using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.Almacenes;
using TP3_CAI_GRUPO_C.Auxiliares;

namespace TP3_CAI_GRUPO_C.RecepcionEncomiendasCD
{
    internal class RecepcionEncomiendasCDModelo
    {
        public string CodigoCDActual => Program.CDActual;

        public List<EmpresaOmnibusEntidad> Empresas =>
            EmpresaOmnibusAlmacen.empresasOmnibus;

        public (bool valido, string error) ValidarBusqueda(
            string empresa,
            DateTime fechaSalida)
        {
            if (string.IsNullOrWhiteSpace(empresa))
                return (false, "Debe seleccionar una empresa de ómnibus.");

            if (string.IsNullOrWhiteSpace(CodigoCDActual))
                return (false, "Debe seleccionar un centro de distribución actual.");

            if (!Empresas.Any(e => e.nombre == empresa))
                return (false, "Debe seleccionar una empresa de ómnibus válida.");

            if (!EsFechaRecepcionPermitida(fechaSalida))
                return (false, "Solo se pueden buscar paradas de llegada del dia actual o con hasta 12 horas de demora.");

            return (true, "");
        }

        public List<HojaDeRuta> BuscarHojasDeRuta(
            string empresa,
            DateTime fechaSalida)
        {
            var resultado = new List<HojaDeRuta>();

            var empresaSeleccionada =
                EmpresaOmnibusAlmacen.empresasOmnibus
                .FirstOrDefault(e => e.nombre == empresa);

            if (empresaSeleccionada == null)
                return resultado;

            var serviciosEmpresa =
                ServicioOmnibusAlmacen.servicios
                .Where(s =>
                    s.CuitEmpresaOmnibus ==
                    empresaSeleccionada.cuitEmpresaOmnibus)
                .ToList();

            foreach (var servicio in serviciosEmpresa)
            {
                var hdrs =
                    HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus
                    .Where(h =>
                        h.IdentificadorServicio ==
                        servicio.IdentificadorServicio
                        &&
                        h.CentroDistribucionDestino == CodigoCDActual
                        &&
                        h.Estado ==
                        EstadoHDROmnibusEnum.EnTransitoCDDestino)
                    .ToList();

                foreach (var hdr in hdrs)
                {
                    var fechaHoraDestino = ObtenerFechaHoraParada(
                        servicio,
                        hdr.CentroDistribucionDestino);

                    if (fechaHoraDestino == null)
                        continue;

                    if (!EsParadaRecepcionPermitida(fechaHoraDestino.Value))
                        continue;

                    resultado.Add(new HojaDeRuta
                    {
                        NroOrden = hdr.IdentificadorServicio,
                        Codigo = hdr.Codigo,
                        Estado = hdr.Estado.ToString(),
                        EmpresaOmnibus = empresaSeleccionada.nombre,
                        FechaSalida = fechaHoraDestino.Value,
                        Destino = hdr.CentroDistribucionDestino
                    });
                }
            }

            return resultado;
        }

        private static DateTime? ObtenerFechaHoraParada(
            ServicioOmnibusEntidad servicio,
            string centroDistribucion)
        {
            return servicio.Parada
                .Where(p => p.CentroDistribucionParada == centroDistribucion)
                .Select(p => (DateTime?)p.FechaHoraParada)
                .FirstOrDefault();
        }

        private static bool EsFechaRecepcionPermitida(DateTime busqueda)
        {
            var diferencia = Program.AhoraSistema() - busqueda;

            return busqueda.Date == Program.HoySistema() ||
                   (diferencia >= TimeSpan.Zero && diferencia <= TimeSpan.FromHours(12));
        }

        private static bool EsParadaRecepcionPermitida(DateTime parada)
        {
            var diferencia = Program.AhoraSistema() - parada;

            return parada.Date == Program.HoySistema() ||
                   (diferencia >= TimeSpan.Zero && diferencia <= TimeSpan.FromHours(12));
        }

        public (bool valido, string error) ValidarConfirmacion(
            List<HojaDeRuta> hojas)
        {
            if (hojas.Count == 0)
            {
                return (
                    false,
                    "No hay Hojas de Ruta cargadas para confirmar la recepción."
                );
            }

            return (true, "");
        }

        public (bool valido, string error)
            ActualizarEstadoHojasDeRuta(List<HojaDeRuta> hojas)
        {
            var hojasEnSistema = new List<HojaDeRutaOmnibusEntidad>();

            foreach (var hoja in hojas)
            {
                var hojaEnSistema =
                    HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus
                    .FirstOrDefault(h => h.Codigo == hoja.Codigo);

                if (hojaEnSistema == null)
                {
                    return (
                        false,
                        $"Hoja de Ruta {hoja.Codigo} no encontrada."
                    );
                }

                if (hojaEnSistema.Estado != EstadoHDROmnibusEnum.EnTransitoCDDestino)
                {
                    return (
                        false,
                        $"La Hoja de Ruta {hoja.Codigo} ya no está en tránsito."
                    );
                }

                if (hojaEnSistema.CentroDistribucionDestino != CodigoCDActual)
                {
                    return (
                        false,
                        $"La Hoja de Ruta {hoja.Codigo} no tiene como destino el centro de distribución actual."
                    );
                }

                foreach (var numeroGuia in hojaEnSistema.Guias)
                {
                    var guia = GuiaAlmacen.guias
                        .FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                    if (guia == null)
                    {
                        return (
                            false,
                            $"Guía {numeroGuia} no encontrada."
                        );
                    }

                    if (guia.EstadoActual != EstadoEnum.EnTransitoACDDestino &&
                        guia.EstadoActual != EstadoEnum.EnTransitoDevolucionAOrigen)
                    {
                        return (
                            false,
                            $"La Guía {numeroGuia} no está en tránsito al centro de distribución destino."
                        );
                    }

                    var esDevolucion = guia.EstadoActual == EstadoEnum.EnTransitoDevolucionAOrigen;
                    var origenGuia = esDevolucion
                        ? guia.CentroDistribucionOrigenDevolucion
                        : guia.CentroDistribucionOrigen;
                    var destinoGuia = esDevolucion
                        ? guia.CentroDistribucionDestinoDevolucion
                        : guia.CentroDistribucionDestino;

                    if (origenGuia != hojaEnSistema.CentroDistribucionOrigen ||
                        destinoGuia != hojaEnSistema.CentroDistribucionDestino)
                    {
                        return (
                            false,
                            $"La Guía {numeroGuia} no coincide con el origen y destino de la Hoja de Ruta {hoja.Codigo}."
                        );
                    }

                    if (!esDevolucion && RequiereDistribucionFletero(guia) &&
                        ExisteHojaDeRutaDistribucion(guia.NumeroGuia))
                    {
                        return (
                            false,
                            $"La Guía {numeroGuia} ya tiene una hoja de ruta de distribución."
                        );
                    }

                    if (!esDevolucion && RequiereDistribucionFletero(guia) &&
                        !HojaDeRutaFleteroPlanificador.ExisteHojaDeRutaEntregaDisponible(guia) &&
                        ObtenerFleteroConMenorCarga(hojaEnSistema.CentroDistribucionDestino) == null)
                    {
                        return (
                            false,
                            $"No hay fleteros con cobertura para distribuir la Guía {numeroGuia}."
                        );
                    }

                    if (esDevolucion && RequiereFleteroDevolucion(guia) &&
                        !HojaDeRutaFleteroPlanificador.ExisteHojaDeRutaEntregaDisponible(guia) &&
                        ObtenerFleteroConMenorCarga(hojaEnSistema.CentroDistribucionDestino) == null)
                    {
                        return (
                            false,
                            $"No hay fleteros con cobertura para distribuir la devolución de la Guía {numeroGuia}."
                        );
                    }
                }

                hojasEnSistema.Add(hojaEnSistema);
            }

            foreach (var hoja in hojas)
            {
                var hojaEnSistema = hojasEnSistema
                    .First(h => h.Codigo == hoja.Codigo);

                hojaEnSistema.Estado =
                    EstadoHDROmnibusEnum.Cumplida;

                hoja.Estado = EstadoHDROmnibusEnum.Cumplida.ToString();

                var ubicacion = CentroDistribucionAlmacen.cd
                    .FirstOrDefault(c => c.Codigo == hojaEnSistema.CentroDistribucionDestino)
                    ?.Nombre ?? hojaEnSistema.CentroDistribucionDestino;

                foreach (var numeroGuia in hojaEnSistema.Guias)
                {
                    var guia = GuiaAlmacen.guias
                        .First(g => g.NumeroGuia == numeroGuia);

                    var ahora = DateTime.Now;
                    var esDevolucion = guia.EstadoActual == EstadoEnum.EnTransitoDevolucionAOrigen;

                    if (esDevolucion)
                    {
                        guia.EstadoActual = EstadoEnum.EnCDOrigenPorDevolucion;
                        guia.Historial ??= new List<MovimientoGuia>();
                        guia.Historial.Add(new MovimientoGuia
                        {
                            Estado = EstadoEnum.EnCDOrigenPorDevolucion,
                            UltimaActualizacion = ahora,
                            Ubicacion = ubicacion
                        });

                        if (RequiereFleteroDevolucion(guia))
                        {
                            var resultadoHojaDeRuta = HojaDeRutaFleteroPlanificador.ObtenerHojaDeRutaEntregaDisponible(
                                guia,
                                GenerarCodigoHojaDeRutaDistribucion());

                            if (resultadoHojaDeRuta.esNueva)
                                HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Add(resultadoHojaDeRuta.hojaDeRuta!);
                        }
                        else if (guia.MetodoRetiro == MetodoRetiroEnum.CentroDeDistribución)
                        {
                            guia.EstadoActual = EstadoEnum.DisponibleParaRetiroEnCDOrigen;
                            guia.Historial.Add(new MovimientoGuia
                            {
                                Estado = EstadoEnum.DisponibleParaRetiroEnCDOrigen,
                                UltimaActualizacion = ahora,
                                Ubicacion = ubicacion
                            });
                        }

                        continue;
                    }

                    guia.EstadoActual = EstadoEnum.EnCDDestino;
                    guia.Historial ??= new List<MovimientoGuia>();
                    guia.Historial.Add(new MovimientoGuia
                    {
                        Estado = EstadoEnum.EnCDDestino,
                        UltimaActualizacion = ahora,
                        Ubicacion = ubicacion
                    });

                    if (RequiereDistribucionFletero(guia))
                    {
                        var resultadoHojaDeRuta = HojaDeRutaFleteroPlanificador.ObtenerHojaDeRutaEntregaDisponible(
                            guia,
                            GenerarCodigoHojaDeRutaDistribucion());

                        if (resultadoHojaDeRuta.esNueva)
                            HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Add(resultadoHojaDeRuta.hojaDeRuta!);
                    }
                    else if (guia.MetodoEntrega ==
                             MetodoEntregaEnum.CentroDeDistribucion)
                    {
                        guia.EstadoActual =
                            EstadoEnum.ListaParaEntregarPorCD;
                        guia.Historial.Add(new MovimientoGuia
                        {
                            Estado = EstadoEnum.ListaParaEntregarPorCD,
                            UltimaActualizacion = ahora,
                            Ubicacion = ubicacion
                        });
                    }
                }
            }

            HojaDeRutaOmnibusAlmacen.Guardar();
            GuiaAlmacen.Guardar();
            HojaDeRutaFleteroAlmacen.Guardar();

            return (true, "");
        }

        private static bool RequiereDistribucionFletero(GuiaEntidad guia)
        {
            return guia.MetodoEntrega == MetodoEntregaEnum.ADomicilio ||
                   guia.MetodoEntrega == MetodoEntregaEnum.Agencia;
        }

        private static bool RequiereFleteroDevolucion(GuiaEntidad guia)
        {
            return guia.MetodoRetiro == MetodoRetiroEnum.EnDomicilio ||
                   guia.MetodoRetiro == MetodoRetiroEnum.Agencia;
        }

        private static HojaDeRutaFleteroEntidad GenerarHojaDeRutaDistribucionDevolucion(GuiaEntidad guia)
        {
            var fletero = ObtenerFleteroConMenorCarga(
                guia.CentroDistribucionDestinoDevolucion)!;

            return new HojaDeRutaFleteroEntidad
            {
                Codigo = GenerarCodigoHojaDeRutaDistribucion(),
                CentroDistribucion = guia.CentroDistribucionDestinoDevolucion,
                CuitCuilFletero = fletero.CuitCuilFletero,
                TipoHDR = TipoHDRFleteroEnum.Entrega,
                Estado = EstadoHDRFleteroEnum.Asignada,
                Guias = new List<string> { guia.NumeroGuia }
            };
        }

        private static bool ExisteHojaDeRutaDistribucion(string numeroGuia)
        {
            return HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Any(h =>
                h.TipoHDR == TipoHDRFleteroEnum.Entrega &&
                h.Guias.Contains(numeroGuia));
        }

        private static HojaDeRutaFleteroEntidad GenerarHojaDeRutaDistribucion(
            GuiaEntidad guia)
        {
            var fletero = ObtenerFleteroConMenorCarga(
                guia.CentroDistribucionDestino)!;

            return new HojaDeRutaFleteroEntidad
            {
                Codigo = GenerarCodigoHojaDeRutaDistribucion(),
                CentroDistribucion = guia.CentroDistribucionDestino,
                CuitCuilFletero = fletero.CuitCuilFletero,
                TipoHDR = TipoHDRFleteroEnum.Entrega,
                Estado = EstadoHDRFleteroEnum.Asignada,
                Guias = new List<string> { guia.NumeroGuia }
            };
        }

        private static FleteroEntidad? ObtenerFleteroConMenorCarga(
            string codigoCentroDistribucion)
        {
            var centroDistribucion = CentroDistribucionAlmacen.cd
                .FirstOrDefault(c => c.Codigo == codigoCentroDistribucion);

            if (centroDistribucion == null)
                return null;

            var fleterosConCobertura = FleteroAlmacen.fleteros
                .Where(f =>
                    centroDistribucion.Fleteros.Contains(f.CuitCuilFletero))
                .ToList();

            if (fleterosConCobertura.Count == 0)
                return null;

            return fleterosConCobertura
                .OrderBy(f => ContarHojasDeRutaDistribucionAsignadas(
                    centroDistribucion.Codigo,
                    f.CuitCuilFletero))
                .ThenBy(f =>
                    centroDistribucion.Fleteros.IndexOf(f.CuitCuilFletero))
                .First();
        }

        private static int ContarHojasDeRutaDistribucionAsignadas(
            string codigoCentroDistribucion,
            long cuitCuilFletero)
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
                .Select(h => int.TryParse(
                    h.Codigo.Substring(prefijo.Length),
                    out var numero)
                    ? numero
                    : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"{prefijo}{ultimoNumero + 1:0000}";
        }
    }
}
