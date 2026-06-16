using TP3_CAI_GRUPO_C.Almacenes;
using TP3_CAI_GRUPO_C.Auxiliares;

namespace TP3_CAI_GRUPO_C.GestionFleterosRendicion
{
    internal class GestionFleterosRendicionModelo
    {
        public (Fletero? fletero, string error) BuscarFletero(long cuitCuil)
        {
            if (cuitCuil < 10_000_000_000 || cuitCuil > 99_999_999_999)
            {
                return (null, "CUIT/CUIL inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");
            }

            var fleteroEntidad = FleteroAlmacen.fleteros.FirstOrDefault(f => f.CuitCuilFletero == cuitCuil);

            if (fleteroEntidad == null)
            {
                return (null, "Fletero no encontrado.");
            }

            var fletero = new Fletero
            {
                CuitCuil = fleteroEntidad.CuitCuilFletero,
                NombreCompleto = fleteroEntidad.NombreCompleto,
                HojasDeRuta = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                    .Where(hoja => hoja.CuitCuilFletero == fleteroEntidad.CuitCuilFletero
                        && hoja.Estado == EstadoHDRFleteroEnum.Asignada
                        && HojaPuedeRendirse(hoja))
                    .SelectMany(hoja => hoja.Guias
                        .Select(numeroGuia => new
                        {
                            hoja.Codigo,
                            NumeroGuia = numeroGuia,
                            Guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia)
                        })
                        .Where(item => item.Guia != null)
                        .Select(item =>
                    {
                        return new HojaDeRuta
                        {
                            Codigo = item.Codigo,
                            NumeroGuia = item.NumeroGuia,
                            EstadoEncomienda = item.Guia!.EstadoActual.ToString()
                        };
                    }))
                    .ToList()
            };

            if (fletero.HojasDeRuta.Count == 0)
            {
                return (null, "El fletero no tiene hojas de ruta asignadas pendientes de rendicion.");
            }

            return (fletero, "");
        }

        public ResultadoRendicion ConfirmarRendicionCumplida(long cuitCuil, List<string> codigosCumplidos)
        {
            return ProcesarRendicion(cuitCuil, codigosCumplidos, cumplida: true);
        }

        public ResultadoRendicion ConfirmarRendicionNoCumplida(long cuitCuil, List<string> codigosNoCumplidas)
        {
            return ProcesarRendicion(cuitCuil, codigosNoCumplidas, cumplida: false);
        }

        private ResultadoRendicion ProcesarRendicion(long cuitCuil, List<string> codigos, bool cumplida)
        {
            var resultadoFletero = BuscarFletero(cuitCuil);

            if (resultadoFletero.fletero == null)
            {
                return new ResultadoRendicion { Valido = false, Error = resultadoFletero.error };
            }

            if (codigos.Count == 0)
            {
                return new ResultadoRendicion { Valido = false, Error = "Debe seleccionar al menos una hoja de ruta." };
            }

            var hojasDeRuta = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                .Where(hoja => hoja.CuitCuilFletero == cuitCuil
                    && hoja.Estado == EstadoHDRFleteroEnum.Asignada
                    && codigos.Contains(hoja.Codigo))
                .ToList();

            if (hojasDeRuta.Count != codigos.Distinct().Count())
            {
                return new ResultadoRendicion
                {
                    Valido = false,
                    Error = "Una o más hojas de ruta ya no están disponibles para rendir."
                };
            }

            foreach (var hojaDeRuta in hojasDeRuta)
            {
                if (!HojaPuedeRendirse(hojaDeRuta))
                {
                    return new ResultadoRendicion
                    {
                        Valido = false,
                        Error = $"La hoja de ruta {hojaDeRuta.Codigo} contiene guías que no están listas para rendir."
                    };
                }

                if (!cumplida && !HojaPuedeMarcarseNoCumplida(hojaDeRuta))
                {
                    return new ResultadoRendicion
                    {
                        Valido = false,
                        Error = $"La hoja de ruta {hojaDeRuta.Codigo} no admite ser marcada como no cumplida."
                    };
                }
            }

            foreach (var hojaDeRuta in hojasDeRuta)
            {
                var importeCargo = CalcularImporteCargoFletero(hojaDeRuta, cumplida);

                hojaDeRuta.Estado = cumplida
                    ? EstadoHDRFleteroEnum.Cumplida
                    : EstadoHDRFleteroEnum.NoCumplida;

                foreach (var numeroGuia in hojaDeRuta.Guias)
                {
                    var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                    if (guia == null) continue;

                    if (cumplida)
                    {
                        ProcesarGuiaCumplida(hojaDeRuta, guia);
                    }
                    else
                    {
                        ProcesarGuiaNoCumplida(hojaDeRuta, guia);
                    }
                }

                if (importeCargo > 0)
                    GenerarMovimientoCuentaCorrienteFletero(hojaDeRuta, importeCargo);
            }

            foreach (var hojaDeRuta in resultadoFletero.fletero.HojasDeRuta)
            {
                if (codigos.Contains(hojaDeRuta.Codigo))
                {
                    var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == hojaDeRuta.NumeroGuia);
                    hojaDeRuta.EstadoEncomienda = guia?.EstadoActual.ToString() ?? "";
                }
            }

            HojaDeRutaFleteroAlmacen.Guardar();
            GuiaAlmacen.Guardar();
            CuentaCorrienteFleteroAlmacen.Guardar();
            CuentaCorrienteClienteAlmacen.Guardar();
            HojaDeRutaOmnibusAlmacen.Guardar();

            return new ResultadoRendicion
            {
                Valido = true,
                HojasActualizadas = resultadoFletero.fletero.HojasDeRuta
            };
        }

        private static void ProcesarGuiaCumplida(HojaDeRutaFleteroEntidad hojaDeRuta, GuiaEntidad guia)
        {
            var estadoAnterior = guia.EstadoActual;
            var estadoActualizado = ObtenerEstadoActualizadoPorRendicionCumplida(
                hojaDeRuta.TipoHDR,
                estadoAnterior);

            guia.EstadoActual = estadoActualizado;
            guia.Historial ??= new List<MovimientoGuia>();
            guia.Historial.Add(new MovimientoGuia
            {
                Estado = estadoActualizado,
                UltimaActualizacion = DateTime.Now,
                Ubicacion = ObtenerUbicacionGuiaCumplida(
                    hojaDeRuta,
                    guia,
                    estadoAnterior)
            });

            if (estadoActualizado == EstadoEnum.DevueltaAlRemitente)
                GenerarMovimientoCuentaCorrienteClienteDevolucion(guia);
        }

        private static void ProcesarGuiaNoCumplida(HojaDeRutaFleteroEntidad hojaDeRuta, GuiaEntidad guia)
        {
            var ahora = DateTime.Now;
            var estadoAnterior = guia.EstadoActual;

            if (estadoAnterior == EstadoEnum.EnTransitoEntregaDomicilio)
            {
                guia.EstadoActual = EstadoEnum.PendienteSegundoIntentoEntrega;
                guia.Historial ??= new List<MovimientoGuia>();
                guia.Historial.Add(new MovimientoGuia
                {
                    Estado = EstadoEnum.PendienteSegundoIntentoEntrega,
                    UltimaActualizacion = ahora,
                    Ubicacion = ObtenerNombreCentroDistribucionDestino(guia)
                });

                GenerarHojaDeRutaSegundoIntento(guia);
                return;
            }

            if (estadoAnterior == EstadoEnum.EnTransitoSegundoIntentoEntrega)
            {
                CompletarDatosDevolucion(guia);

                guia.Historial ??= new List<MovimientoGuia>();
                guia.EstadoActual = EstadoEnum.DevolucionIniciada;
                guia.Historial.Add(new MovimientoGuia
                {
                    Estado = EstadoEnum.DevolucionIniciada,
                    UltimaActualizacion = ahora,
                    Ubicacion = ObtenerNombreCentroDistribucionDestino(guia)
                });

                guia.EstadoActual = EstadoEnum.ListaParaDespachoDevolucion;
                guia.Historial.Add(new MovimientoGuia
                {
                    Estado = EstadoEnum.ListaParaDespachoDevolucion,
                    UltimaActualizacion = ahora,
                    Ubicacion = ObtenerNombreCentroDistribucionDestino(guia)
                });

                GenerarHojaDeRutaOmnibusDevolucion(guia);
            }
        }

        private static bool HojaPuedeRendirse(HojaDeRutaFleteroEntidad hojaDeRuta)
        {
            if (hojaDeRuta.Guias.Count == 0)
            {
                return false;
            }

            return hojaDeRuta.Guias.All(numeroGuia =>
            {
                var guia = GuiaAlmacen.guias
                    .FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                return guia != null && PuedeRendirse(hojaDeRuta.TipoHDR, guia.EstadoActual);
            });
        }

        private static bool HojaPuedeMarcarseNoCumplida(HojaDeRutaFleteroEntidad hojaDeRuta)
        {
            if (hojaDeRuta.TipoHDR != TipoHDRFleteroEnum.Entrega)
                return false;

            return hojaDeRuta.Guias.All(numeroGuia =>
            {
                var guia = GuiaAlmacen.guias
                    .FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                return guia != null &&
                    (guia.EstadoActual == EstadoEnum.EnTransitoEntregaDomicilio ||
                     guia.EstadoActual == EstadoEnum.EnTransitoSegundoIntentoEntrega);
            });
        }

        private static bool PuedeRendirse(TipoHDRFleteroEnum tipoHDR, EstadoEnum estado)
        {
            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
            {
                return estado == EstadoEnum.RetiroAgenciaEnCurso ||
                       estado == EstadoEnum.RetiroDomicilioEnCurso ||
                       estado == EstadoEnum.RetiroDevolucionAgenciaEnCurso;
            }

            return estado == EstadoEnum.EnTransitoEntregaDomicilio ||
                   estado == EstadoEnum.EnTransitoAAgenciaDestino ||
                   estado == EstadoEnum.EnTransitoSegundoIntentoEntrega ||
                   estado == EstadoEnum.EnTransitoDomicilioRemitente ||
                   estado == EstadoEnum.EnTransitoAgenciaOrigen;
        }

        private static EstadoEnum ObtenerEstadoActualizadoPorRendicionCumplida(TipoHDRFleteroEnum tipoHDR, EstadoEnum estado)
        {
            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
            {
                return estado switch
                {
                    EstadoEnum.RetiroAgenciaEnCurso => EstadoEnum.PendienteAdmision,
                    EstadoEnum.RetiroDomicilioEnCurso => EstadoEnum.PendienteAdmision,
                    EstadoEnum.RetiroDevolucionAgenciaEnCurso => EstadoEnum.ListaParaDespachoDevolucion,
                    _ => estado
                };
            }

            return estado switch
            {
                EstadoEnum.EnTransitoEntregaDomicilio => EstadoEnum.Entregado,
                EstadoEnum.EnTransitoAAgenciaDestino => EstadoEnum.ListaParaEntregarPorAgencia,
                EstadoEnum.EnTransitoSegundoIntentoEntrega => EstadoEnum.Entregado,
                EstadoEnum.EnTransitoDomicilioRemitente => EstadoEnum.DevueltaAlRemitente,
                EstadoEnum.EnTransitoAgenciaOrigen => EstadoEnum.DisponibleParaRetiroEnAgenciaOrigen,
                _ => estado
            };
        }

        private static string ObtenerUbicacionGuiaCumplida(
            HojaDeRutaFleteroEntidad hojaDeRuta,
            GuiaEntidad guia,
            EstadoEnum estadoAnterior)
        {
            if (hojaDeRuta.TipoHDR == TipoHDRFleteroEnum.Retiro)
            {
                if (estadoAnterior == EstadoEnum.RetiroDevolucionAgenciaEnCurso)
                    return ObtenerNombreCentroDistribucion(guia.CentroDistribucionOrigenDevolucion);

                return ObtenerNombreCentroDistribucion(hojaDeRuta.CentroDistribucion);
            }

            if (estadoAnterior == EstadoEnum.EnTransitoEntregaDomicilio ||
                estadoAnterior == EstadoEnum.EnTransitoSegundoIntentoEntrega)
            {
                return ObtenerDestinoDomicilio(guia);
            }

            if (estadoAnterior == EstadoEnum.EnTransitoDomicilioRemitente)
            {
                return !string.IsNullOrWhiteSpace(guia.DireccionDevolucion)
                    ? $"domicilio {guia.DireccionDevolucion}"
                    : "domicilio remitente";
            }

            if (estadoAnterior == EstadoEnum.EnTransitoAgenciaOrigen)
            {
                return ObtenerNombreAgencia(guia.AgenciaDevolucionCodigo);
            }

            return ObtenerNombreAgencia(guia.AgenciaEntregaCodigo);
        }

        private static string ObtenerDestinoDomicilio(GuiaEntidad guia)
        {
            if (!string.IsNullOrWhiteSpace(guia.DireccionEntrega))
            {
                return $"domicilio {guia.DireccionEntrega}";
            }

            return "domicilio";
        }

        private static string ObtenerNombreAgencia(string codigoAgencia)
        {
            if (string.IsNullOrWhiteSpace(codigoAgencia))
                return "";

            var agencia = AgenciaAlmacen.agencia.FirstOrDefault(a => a.Codigo == codigoAgencia);
            return agencia?.Nombre ?? codigoAgencia;
        }

        private static string ObtenerNombreCentroDistribucion(string codigoCentroDistribucion)
        {
            if (string.IsNullOrWhiteSpace(codigoCentroDistribucion))
                return "";

            var centroDistribucion = CentroDistribucionAlmacen.cd.FirstOrDefault(c => c.Codigo == codigoCentroDistribucion);
            return centroDistribucion?.Nombre ?? codigoCentroDistribucion;
        }

        private static string ObtenerNombreCentroDistribucionDestino(GuiaEntidad guia)
        {
            var codigo = !string.IsNullOrWhiteSpace(guia.CentroDistribucionEntregaCodigo)
                ? guia.CentroDistribucionEntregaCodigo
                : guia.CentroDistribucionDestino;
            return ObtenerNombreCentroDistribucion(codigo);
        }

        private static decimal CalcularImporteCargoFletero(HojaDeRutaFleteroEntidad hojaDeRuta, bool cumplida)
        {
            var importe = 0m;

            foreach (var numeroGuia in hojaDeRuta.Guias)
            {
                var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);
                if (guia == null) continue;

                var (precioBase, aplica) = DeterminarPrecioYAplicabilidad(hojaDeRuta.TipoHDR, guia);
                if (!aplica) continue;

                var porcentaje = DeterminarPorcentaje(guia.EstadoActual, cumplida);
                importe += precioBase * porcentaje;
            }

            return importe;
        }

        private static (decimal precio, bool aplica) DeterminarPrecioYAplicabilidad(TipoHDRFleteroEnum tipoHDR, GuiaEntidad guia)
        {
            if (guia.EstadoActual == EstadoEnum.EnTransitoAgenciaOrigen ||
                guia.EstadoActual == EstadoEnum.RetiroDevolucionAgenciaEnCurso)
                return (0m, false);

            if (guia.EstadoActual == EstadoEnum.EnTransitoDomicilioRemitente)
                return (ObtenerPrecioExtra("EntregaDomicilio"), true);

            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
                return (ObtenerPrecioExtra("RetiroDomicilio"), guia.MetodoRetiro == MetodoRetiroEnum.EnDomicilio);

            return (ObtenerPrecioExtra("EntregaDomicilio"), guia.MetodoEntrega == MetodoEntregaEnum.ADomicilio);
        }

        private static decimal DeterminarPorcentaje(EstadoEnum estado, bool cumplida)
        {
            if (estado == EstadoEnum.EnTransitoSegundoIntentoEntrega)
                return 0.5m;

            if (!cumplida && estado == EstadoEnum.EnTransitoEntregaDomicilio)
                return 0.5m;

            return 1m;
        }

        private static decimal ObtenerPrecioExtra(string tipo)
        {
            return PreciosExtrasAlmacen.PreciosExtras
                .First(e => e.Tipo == tipo)
                .Precio;
        }

        private static void GenerarMovimientoCuentaCorrienteFletero(HojaDeRutaFleteroEntidad hojaDeRuta, decimal importe)
        {
            var saldoAnterior = ObtenerSaldoCuentaCorrienteFletero(hojaDeRuta.CuitCuilFletero);
            var concepto = hojaDeRuta.TipoHDR == TipoHDRFleteroEnum.Retiro
                ? "Servicio de retiro a domicilio"
                : "Servicio de entrega a domicilio";

            var movimiento = new CuentaCorrienteFleteroEntidad
            {
                CuitCuilFletero = hojaDeRuta.CuitCuilFletero,
                Fecha = DateTime.Now,
                CodigoHDR = hojaDeRuta.Codigo,
                Comprobante = "",
                TipoMovimiento = TipoMovimientoCtaCteEnum.Cargo,
                Concepto = concepto,
                Importe = importe,
                Debe = importe,
                Haber = 0,
                Saldo = saldoAnterior + importe,
                Pagado = false
            };

            CuentaCorrienteFleteroAlmacen.ctaCteFletero.Add(movimiento);
        }

        private static decimal ObtenerSaldoCuentaCorrienteFletero(long cuitCuilFletero)
        {
            return CuentaCorrienteFleteroAlmacen.ctaCteFletero
                .Where(c => c.CuitCuilFletero == cuitCuilFletero)
                .OrderBy(c => c.Fecha)
                .LastOrDefault()
                ?.Saldo ?? 0;
        }

        private static void GenerarMovimientoCuentaCorrienteClienteDevolucion(GuiaEntidad guia)
        {
            var importe = guia.Importe;
            var saldoAnterior = ObtenerSaldoCuentaCorrienteCliente(guia.CuitCliente);

            var movimiento = new CuentaCorrienteClienteEntidad
            {
                Cuit = guia.CuitCliente,
                TipoComprobante = "Devolucion",
                Fecha = DateTime.Now,
                Comprobante = guia.NumeroGuia,
                Debe = importe,
                Haber = 0,
                Saldo = saldoAnterior + importe
            };

            CuentaCorrienteClienteAlmacen.ctaCteCliente.Add(movimiento);
        }

        private static decimal ObtenerSaldoCuentaCorrienteCliente(long cuit)
        {
            return CuentaCorrienteClienteAlmacen.ctaCteCliente
                .Where(c => c.Cuit == cuit)
                .OrderBy(c => c.Fecha)
                .LastOrDefault()
                ?.Saldo ?? 0;
        }

        private static void CompletarDatosDevolucion(GuiaEntidad guia)
        {
            var cdActual = !string.IsNullOrWhiteSpace(guia.CentroDistribucionEntregaCodigo)
                ? guia.CentroDistribucionEntregaCodigo
                : guia.CentroDistribucionDestino;

            guia.CentroDistribucionOrigenDevolucion = cdActual;
            guia.CentroDistribucionDestinoDevolucion = guia.CentroDistribucionOrigen;
            guia.AgenciaDevolucionCodigo = guia.MetodoRetiro == MetodoRetiroEnum.Agencia
                ? guia.AgenciaRetiroCodigo
                : "";
            guia.DireccionDevolucion = guia.DireccionRetiro;
            guia.CodPostalDevolucion = guia.CodPostalRetiro;
        }

        private static void GenerarHojaDeRutaSegundoIntento(GuiaEntidad guia)
        {
            var resultadoHojaDeRuta = HojaDeRutaFleteroPlanificador.ObtenerHojaDeRutaEntregaDisponible(
                guia,
                GenerarCodigoHojaDeRutaDistribucion());

            if (resultadoHojaDeRuta.esNueva)
                HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Add(resultadoHojaDeRuta.hojaDeRuta!);
        }

        private static void GenerarHojaDeRutaOmnibusDevolucion(GuiaEntidad guia)
        {
            var cdOrigen = CentroDistribucionAlmacen.cd
                .FirstOrDefault(c => c.Codigo == guia.CentroDistribucionOrigenDevolucion);
            var cdDestino = CentroDistribucionAlmacen.cd
                .FirstOrDefault(c => c.Codigo == guia.CentroDistribucionDestinoDevolucion);

            if (cdOrigen == null || cdDestino == null || cdOrigen.Codigo == cdDestino.Codigo)
                return;

            var servicio = ObtenerServicioConCobertura(cdOrigen.Codigo, cdDestino.Codigo);
            if (servicio == null) return;

            var hdr = new HojaDeRutaOmnibusEntidad
            {
                Codigo = GenerarCodigoHojaDeRutaOmnibus(),
                IdentificadorServicio = servicio.IdentificadorServicio,
                CentroDistribucionOrigen = cdOrigen.Codigo,
                CentroDistribucionDestino = cdDestino.Codigo,
                Estado = EstadoHDROmnibusEnum.Asignada,
                Guias = new List<string> { guia.NumeroGuia }
            };

            HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus.Add(hdr);
        }

        private static string ObtenerCodigoCentroDistribucionDestino(GuiaEntidad guia)
        {
            return !string.IsNullOrWhiteSpace(guia.CentroDistribucionEntregaCodigo)
                ? guia.CentroDistribucionEntregaCodigo
                : guia.CentroDistribucionDestino;
        }

        private static FleteroEntidad? ObtenerFleteroConMenorCargaEntrega(CentroDistribucionEntidad centroDistribucion)
        {
            var fleterosConCobertura = FleteroAlmacen.fleteros
                .Where(f => centroDistribucion.Fleteros.Contains(f.CuitCuilFletero))
                .ToList();

            if (fleterosConCobertura.Count == 0) return null;

            return fleterosConCobertura
                .OrderBy(f => ContarHDREntregaAsignadas(centroDistribucion.Codigo, f.CuitCuilFletero))
                .ThenBy(f => centroDistribucion.Fleteros.IndexOf(f.CuitCuilFletero))
                .First();
        }

        private static int ContarHDREntregaAsignadas(string codigoCentroDistribucion, long cuitCuilFletero)
        {
            return HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Count(h =>
                h.CentroDistribucion == codigoCentroDistribucion &&
                h.CuitCuilFletero == cuitCuilFletero &&
                h.TipoHDR == TipoHDRFleteroEnum.Entrega &&
                h.Estado == EstadoHDRFleteroEnum.Asignada);
        }

        private static string GenerarCodigoHojaDeRutaDistribucion()
        {
            var periodo = DateTime.Now.ToString("yyyyMM");
            var prefijo = $"HDR-DIS-{periodo}-";

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
