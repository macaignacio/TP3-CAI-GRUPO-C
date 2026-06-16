using System;
using System.Collections.Generic;
using System.Linq;
using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.Devolucion
{
    internal class GestionDevolucionModelo
    {
        private const decimal ComisionAgencia = 2000m;
        private const int DiasMinimosParaDevolucion = 15;

        public ResultadoBusquedaConfirmacion BuscarParaConfirmar(long cuit)
        {
            if (cuit < 10_000_000_000 || cuit > 99_999_999_999)
                return new ResultadoBusquedaConfirmacion { Valido = false, Error = "CUIT inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas." };

            var clienteEntidad = ClienteAlmacen.clientes.FirstOrDefault(c => c.Cuit == cuit);

            if (clienteEntidad == null)
                return new ResultadoBusquedaConfirmacion { Valido = false, Error = "Cliente no encontrado." };

            var guias = GuiaAlmacen.guias
                .Where(g => g.CuitCliente == cuit)
                .Where(g => g.EstadoActual == EstadoEnum.DisponibleParaRetiroEnAgenciaOrigen ||
                            g.EstadoActual == EstadoEnum.DisponibleParaRetiroEnCDOrigen)
                .Where(EstaEnContextoActual)
                .Select(MapearGuiaConfirmar)
                .ToList();

            return new ResultadoBusquedaConfirmacion
            {
                Valido = true,
                Cliente = new Cliente { Cuit = clienteEntidad.Cuit, RazonSocial = clienteEntidad.RazonSocial },
                Guias = guias
            };
        }

        public (bool valido, string error) ConfirmarDevolucion(string numeroGuia)
        {
            var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

            if (guia == null)
                return (false, "Guía no encontrada.");

            if (guia.EstadoActual != EstadoEnum.DisponibleParaRetiroEnAgenciaOrigen &&
                guia.EstadoActual != EstadoEnum.DisponibleParaRetiroEnCDOrigen)
                return (false, "La guía no está en un estado válido para confirmar devolución.");

            if (!EstaEnContextoActual(guia))
                return (false, "La guía no se encuentra en el centro de distribución o agencia actual.");

            var retiroAgencia = guia.EstadoActual == EstadoEnum.DisponibleParaRetiroEnAgenciaOrigen;

            guia.EstadoActual = EstadoEnum.DevueltaAlRemitente;
            guia.Historial ??= new List<MovimientoGuia>();
            guia.Historial.Add(new MovimientoGuia
            {
                Estado = EstadoEnum.DevueltaAlRemitente,
                UltimaActualizacion = DateTime.Now,
                Ubicacion = ObtenerUbicacionConfirmacion(guia, retiroAgencia)
            });
            GuiaAlmacen.Guardar();

            if (retiroAgencia)
                GenerarMovimientoCuentaCorrienteAgencia(guia);

            return (true, "");
        }

        public List<GuiaDevolucionIniciar> ObtenerGuiasParaIniciar()
        {
            var hoy = DateTime.Now;

            return GuiaAlmacen.guias
                .Where(g => g.EstadoActual == EstadoEnum.ListaParaEntregarPorCD ||
                            g.EstadoActual == EstadoEnum.ListaParaEntregarPorAgencia)
                .Where(EstaEnContextoActualParaIniciar)
                .Select(g => new
                {
                    Guia = g,
                    FechaArribo = ObtenerFechaIngresoEstado(g, g.EstadoActual)
                })
                .Where(x => x.FechaArribo != null &&
                            (hoy - x.FechaArribo!.Value).TotalDays > DiasMinimosParaDevolucion)
                .Select(x => new GuiaDevolucionIniciar
                {
                    NumeroGuia = x.Guia.NumeroGuia,
                    RazonSocialCliente = ObtenerRazonSocial(x.Guia.CuitCliente),
                    Estado = x.Guia.EstadoActual.ToString(),
                    UbicacionActual = ObtenerUbicacionEntregaActual(x.Guia),
                    FechaArribo = x.FechaArribo!.Value,
                    DiasEnEspera = (int)(hoy - x.FechaArribo!.Value).TotalDays,
                    DestinoDevolucion = ObtenerDestinoDevolucion(x.Guia)
                })
                .ToList();
        }

        public (bool valido, string error) IniciarDevolucion(string numeroGuia)
        {
            var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

            if (guia == null)
                return (false, "Guía no encontrada.");

            if (guia.EstadoActual != EstadoEnum.ListaParaEntregarPorCD &&
                guia.EstadoActual != EstadoEnum.ListaParaEntregarPorAgencia)
                return (false, "La guía no está en un estado válido para iniciar devolución.");

            if (!EstaEnContextoActualParaIniciar(guia))
                return (false, "La guía no se encuentra en el centro de distribución o agencia actual.");

            var fechaArribo = ObtenerFechaIngresoEstado(guia, guia.EstadoActual);
            if (fechaArribo == null || (DateTime.Now - fechaArribo.Value).TotalDays <= DiasMinimosParaDevolucion)
                return (false, "La guía no supera los 15 días de espera requeridos para iniciar la devolución.");

            CompletarDatosDevolucion(guia);

            if (guia.EstadoActual == EstadoEnum.ListaParaEntregarPorAgencia)
            {
                var resultadoHDR = GenerarHojaDeRutaRetiroDevolucion(guia);
                if (resultadoHDR.hojaDeRuta == null)
                    return (false, resultadoHDR.error);

                HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Add(resultadoHDR.hojaDeRuta);

                guia.EstadoActual = EstadoEnum.DevolucionIniciada;
                guia.Historial.Add(new MovimientoGuia
                {
                    Estado = EstadoEnum.DevolucionIniciada,
                    UltimaActualizacion = DateTime.Now,
                    Ubicacion = ObtenerNombreAgencia(guia.AgenciaEntregaCodigo)
                });

                GuiaAlmacen.Guardar();
                HojaDeRutaFleteroAlmacen.Guardar();
                return (true, "");
            }

            var resultadoHDROmnibus = GenerarHojaDeRutaOmnibusDevolucion(guia);
            if (resultadoHDROmnibus.hojaDeRuta == null)
                return (false, resultadoHDROmnibus.error);

            var ahora = DateTime.Now;
            var ubicacionCDActual = ObtenerNombreCentroDistribucion(guia.CentroDistribucionOrigenDevolucion);

            guia.EstadoActual = EstadoEnum.DevolucionIniciada;
            guia.Historial.Add(new MovimientoGuia
            {
                Estado = EstadoEnum.DevolucionIniciada,
                UltimaActualizacion = ahora,
                Ubicacion = ubicacionCDActual
            });

            guia.EstadoActual = EstadoEnum.ListaParaDespachoDevolucion;
            guia.Historial.Add(new MovimientoGuia
            {
                Estado = EstadoEnum.ListaParaDespachoDevolucion,
                UltimaActualizacion = ahora,
                Ubicacion = ubicacionCDActual
            });

            HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus.Add(resultadoHDROmnibus.hojaDeRuta);

            GuiaAlmacen.Guardar();
            HojaDeRutaOmnibusAlmacen.Guardar();
            return (true, "");
        }

        private static bool EstaEnContextoActual(GuiaEntidad guia)
        {
            if (!string.IsNullOrWhiteSpace(Program.AgenciaActual))
            {
                return guia.EstadoActual == EstadoEnum.DisponibleParaRetiroEnAgenciaOrigen &&
                       guia.AgenciaRetiroCodigo == Program.AgenciaActual;
            }

            if (!string.IsNullOrWhiteSpace(Program.CDActual))
            {
                if (guia.EstadoActual == EstadoEnum.DisponibleParaRetiroEnAgenciaOrigen)
                {
                    var agencia = AgenciaAlmacen.agencia
                        .FirstOrDefault(a => a.Codigo == guia.AgenciaRetiroCodigo);
                    return agencia?.CentroDistribucion == Program.CDActual;
                }

                return guia.CentroDistribucionOrigen == Program.CDActual;
            }

            return false;
        }

        private static bool EstaEnContextoActualParaIniciar(GuiaEntidad guia)
        {
            if (!string.IsNullOrWhiteSpace(Program.AgenciaActual))
            {
                return guia.EstadoActual == EstadoEnum.ListaParaEntregarPorAgencia &&
                       guia.AgenciaEntregaCodigo == Program.AgenciaActual;
            }

            if (!string.IsNullOrWhiteSpace(Program.CDActual))
            {
                if (guia.EstadoActual == EstadoEnum.ListaParaEntregarPorAgencia)
                {
                    var agencia = AgenciaAlmacen.agencia
                        .FirstOrDefault(a => a.Codigo == guia.AgenciaEntregaCodigo);
                    return agencia?.CentroDistribucion == Program.CDActual;
                }

                var cdEntrega = !string.IsNullOrWhiteSpace(guia.CentroDistribucionEntregaCodigo)
                    ? guia.CentroDistribucionEntregaCodigo
                    : guia.CentroDistribucionDestino;
                return cdEntrega == Program.CDActual;
            }

            return false;
        }

        private static GuiaDevolucionConfirmar MapearGuiaConfirmar(GuiaEntidad guia)
        {
            var retiroAgencia = guia.EstadoActual == EstadoEnum.DisponibleParaRetiroEnAgenciaOrigen;
            var lugar = retiroAgencia
                ? ObtenerNombreAgencia(guia.AgenciaRetiroCodigo)
                : ObtenerNombreCentroDistribucion(guia.CentroDistribucionOrigen);

            return new GuiaDevolucionConfirmar
            {
                NumeroGuia = guia.NumeroGuia,
                Estado = guia.EstadoActual.ToString(),
                LugarDevolucion = lugar,
                FechaLlegada = ObtenerFechaIngresoEstado(guia, guia.EstadoActual) ?? DateTime.MinValue
            };
        }

        private static void CompletarDatosDevolucion(GuiaEntidad guia)
        {
            string cdOrigenDevolucion;
            if (guia.EstadoActual == EstadoEnum.ListaParaEntregarPorAgencia)
            {
                var agencia = AgenciaAlmacen.agencia
                    .FirstOrDefault(a => a.Codigo == guia.AgenciaEntregaCodigo);
                cdOrigenDevolucion = agencia?.CentroDistribucion ?? "";
            }
            else
            {
                cdOrigenDevolucion = !string.IsNullOrWhiteSpace(guia.CentroDistribucionEntregaCodigo)
                    ? guia.CentroDistribucionEntregaCodigo
                    : guia.CentroDistribucionDestino;
            }

            guia.CentroDistribucionOrigenDevolucion = cdOrigenDevolucion;
            guia.CentroDistribucionDestinoDevolucion = guia.CentroDistribucionOrigen;
            guia.AgenciaDevolucionCodigo = guia.MetodoRetiro == MetodoRetiroEnum.Agencia
                ? guia.AgenciaRetiroCodigo
                : "";
            guia.DireccionDevolucion = guia.DireccionRetiro;
            guia.CodPostalDevolucion = guia.CodPostalRetiro;
        }

        private static (HojaDeRutaFleteroEntidad? hojaDeRuta, string error) GenerarHojaDeRutaRetiroDevolucion(GuiaEntidad guia)
        {
            var centroDistribucion = CentroDistribucionAlmacen.cd
                .FirstOrDefault(c => c.Codigo == guia.CentroDistribucionOrigenDevolucion);

            if (centroDistribucion == null)
                return (null, "No se encontró el centro de distribución para asignar el retiro de devolución.");

            var fletero = ObtenerFleteroConMenorCarga(centroDistribucion);

            if (fletero == null)
                return (null, "No hay fleteros con cobertura para el centro de distribución.");

            return (new HojaDeRutaFleteroEntidad
            {
                Codigo = GenerarCodigoHojaDeRutaRetiro(),
                CentroDistribucion = centroDistribucion.Codigo,
                CuitCuilFletero = fletero.CuitCuilFletero,
                TipoHDR = TipoHDRFleteroEnum.Retiro,
                Estado = EstadoHDRFleteroEnum.Asignada,
                Guias = new List<string> { guia.NumeroGuia }
            }, "");
        }

        private static (HojaDeRutaOmnibusEntidad? hojaDeRuta, string error) GenerarHojaDeRutaOmnibusDevolucion(GuiaEntidad guia)
        {
            var cdOrigen = CentroDistribucionAlmacen.cd
                .FirstOrDefault(c => c.Codigo == guia.CentroDistribucionOrigenDevolucion);
            var cdDestino = CentroDistribucionAlmacen.cd
                .FirstOrDefault(c => c.Codigo == guia.CentroDistribucionDestinoDevolucion);

            if (cdOrigen == null || cdDestino == null)
                return (null, "No se encontró el centro de distribución de origen o destino para la devolución.");

            if (cdOrigen.Codigo == cdDestino.Codigo)
                return (null, "El centro de distribución de origen y destino de la devolución son el mismo.");

            var servicio = ObtenerServicioConCobertura(cdOrigen.Codigo, cdDestino.Codigo);

            if (servicio == null)
                return (null, "No hay servicios de omnibus con cobertura entre el centro de distribución de origen y destino de la devolución.");

            return (new HojaDeRutaOmnibusEntidad
            {
                Codigo = GenerarCodigoHojaDeRutaOmnibus(),
                IdentificadorServicio = servicio.IdentificadorServicio,
                CentroDistribucionOrigen = cdOrigen.Codigo,
                CentroDistribucionDestino = cdDestino.Codigo,
                Estado = EstadoHDROmnibusEnum.Asignada,
                Guias = new List<string> { guia.NumeroGuia }
            }, "");
        }

        private static void GenerarMovimientoCuentaCorrienteAgencia(GuiaEntidad guia)
        {
            var codigoAgencia = guia.AgenciaRetiroCodigo;
            var saldoAnterior = ObtenerSaldoCuentaCorrienteAgencia(codigoAgencia);

            var movimiento = new CuentaCorrienteAgenciaEntidad
            {
                CodigoAgencia = codigoAgencia,
                Fecha = DateTime.Now,
                NumeroGuia = guia.NumeroGuia,
                Comprobante = "",
                TipoMovimiento = TipoMovimientoCtaCteEnum.Cargo,
                Concepto = "Comision por entrega devolucion",
                Importe = ComisionAgencia,
                Debe = ComisionAgencia,
                Haber = 0,
                Saldo = saldoAnterior + ComisionAgencia,
                Pagado = false
            };

            CuentaCorrienteAgenciaAlmacen.ctaCteAgencia.Add(movimiento);
            CuentaCorrienteAgenciaAlmacen.Guardar();
        }

        private static decimal ObtenerSaldoCuentaCorrienteAgencia(string codigoAgencia)
        {
            return CuentaCorrienteAgenciaAlmacen.ctaCteAgencia
                .Where(c => c.CodigoAgencia == codigoAgencia)
                .OrderBy(c => c.Fecha)
                .LastOrDefault()
                ?.Saldo ?? 0;
        }

        private static DateTime? ObtenerFechaIngresoEstado(GuiaEntidad guia, EstadoEnum estado)
        {
            return guia.Historial?
                .Where(m => m.Estado == estado)
                .OrderByDescending(m => m.UltimaActualizacion)
                .Select(m => (DateTime?)m.UltimaActualizacion)
                .FirstOrDefault();
        }

        private static string ObtenerRazonSocial(long cuit)
        {
            return ClienteAlmacen.clientes
                .FirstOrDefault(c => c.Cuit == cuit)?
                .RazonSocial ?? "";
        }

        private static string ObtenerNombreAgencia(string codigoAgencia)
        {
            if (string.IsNullOrWhiteSpace(codigoAgencia))
                return "";

            return AgenciaAlmacen.agencia
                .FirstOrDefault(a => a.Codigo == codigoAgencia)?
                .Nombre ?? codigoAgencia;
        }

        private static string ObtenerNombreCentroDistribucion(string codigoCentroDistribucion)
        {
            if (string.IsNullOrWhiteSpace(codigoCentroDistribucion))
                return "";

            return CentroDistribucionAlmacen.cd
                .FirstOrDefault(c => c.Codigo == codigoCentroDistribucion)?
                .Nombre ?? codigoCentroDistribucion;
        }

        private static string ObtenerUbicacionConfirmacion(GuiaEntidad guia, bool retiroAgencia)
        {
            return retiroAgencia
                ? ObtenerNombreAgencia(guia.AgenciaRetiroCodigo)
                : ObtenerNombreCentroDistribucion(guia.CentroDistribucionOrigen);
        }

        private static string ObtenerUbicacionEntregaActual(GuiaEntidad guia)
        {
            if (guia.EstadoActual == EstadoEnum.ListaParaEntregarPorAgencia)
                return ObtenerNombreAgencia(guia.AgenciaEntregaCodigo);

            var codigoCD = !string.IsNullOrWhiteSpace(guia.CentroDistribucionEntregaCodigo)
                ? guia.CentroDistribucionEntregaCodigo
                : guia.CentroDistribucionDestino;
            return ObtenerNombreCentroDistribucion(codigoCD);
        }

        private static string ObtenerDestinoDevolucion(GuiaEntidad guia)
        {
            if (guia.MetodoRetiro == MetodoRetiroEnum.Agencia)
                return ObtenerNombreAgencia(guia.AgenciaRetiroCodigo);

            return ObtenerNombreCentroDistribucion(guia.CentroDistribucionOrigen);
        }

        private static FleteroEntidad? ObtenerFleteroConMenorCarga(CentroDistribucionEntidad centroDistribucion)
        {
            var fleterosConCobertura = FleteroAlmacen.fleteros
                .Where(f => centroDistribucion.Fleteros.Contains(f.CuitCuilFletero))
                .ToList();

            if (fleterosConCobertura.Count == 0)
                return null;

            return fleterosConCobertura
                .OrderBy(f => ContarHDRRetiroAsignadas(centroDistribucion.Codigo, f.CuitCuilFletero))
                .ThenBy(f => centroDistribucion.Fleteros.IndexOf(f.CuitCuilFletero))
                .First();
        }

        private static int ContarHDRRetiroAsignadas(string codigoCentroDistribucion, long cuitCuilFletero)
        {
            return HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Count(h =>
                h.CentroDistribucion == codigoCentroDistribucion &&
                h.CuitCuilFletero == cuitCuilFletero &&
                h.TipoHDR == TipoHDRFleteroEnum.Retiro &&
                h.Estado == EstadoHDRFleteroEnum.Asignada);
        }

        private static string GenerarCodigoHojaDeRutaRetiro()
        {
            var periodo = DateTime.Now.ToString("yyyyMM");
            var prefijo = $"HDR-RET-{periodo}-";

            var ultimoNumero = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                .Where(h => h.Codigo.StartsWith(prefijo))
                .Select(h => int.TryParse(h.Codigo.Substring(prefijo.Length), out var numero) ? numero : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"{prefijo}{ultimoNumero + 1:0000}";
        }

        private static string GenerarCodigoHojaDeRutaOmnibus()
        {
            var periodo = DateTime.Now.ToString("yyyyMM");
            var prefijo = $"HDR-OMN-{periodo}-";

            var ultimoNumero = HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus
                .Where(h => h.Codigo.StartsWith(prefijo))
                .Select(h => int.TryParse(h.Codigo.Substring(prefijo.Length), out var numero) ? numero : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"{prefijo}{ultimoNumero + 1:0000}";
        }

        private static ServicioOmnibusEntidad? ObtenerServicioConCobertura(string centroDistribucionOrigen, string centroDistribucionDestino)
        {
            return ServicioOmnibusAlmacen.servicios
                .Where(s => EmpresaOmnibusAlmacen.empresasOmnibus.Any(e => e.cuitEmpresaOmnibus == s.CuitEmpresaOmnibus))
                .Where(s => TieneParadasEnOrden(s, centroDistribucionOrigen, centroDistribucionDestino))
                .OrderBy(s => ObtenerFechaHoraParada(s, centroDistribucionOrigen))
                .FirstOrDefault();
        }

        private static bool TieneParadasEnOrden(ServicioOmnibusEntidad servicio, string centroDistribucionOrigen, string centroDistribucionDestino)
        {
            var paradaOrigen = ObtenerFechaHoraParada(servicio, centroDistribucionOrigen);
            var paradaDestino = ObtenerFechaHoraParada(servicio, centroDistribucionDestino);

            return paradaOrigen != null && paradaDestino != null && paradaOrigen < paradaDestino;
        }

        private static DateTime? ObtenerFechaHoraParada(ServicioOmnibusEntidad servicio, string centroDistribucion)
        {
            return servicio.Parada
                .Where(p => p.CentroDistribucionParada == centroDistribucion)
                .Select(p => (DateTime?)p.FechaHoraParada)
                .FirstOrDefault();
        }
    }
}
