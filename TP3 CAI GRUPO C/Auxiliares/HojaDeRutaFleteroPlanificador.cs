using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.Auxiliares
{
    internal static class HojaDeRutaFleteroPlanificador
    {
        public static bool ExisteHojaDeRutaRetiroDisponible(GuiaEntidad guia)
        {
            return BuscarHojaDeRutaDisponible(guia, TipoHDRFleteroEnum.Retiro) != null;
        }

        public static bool ExisteHojaDeRutaEntregaDisponible(GuiaEntidad guia)
        {
            return BuscarHojaDeRutaDisponible(guia, TipoHDRFleteroEnum.Entrega) != null;
        }

        public static (HojaDeRutaFleteroEntidad? hojaDeRuta, bool esNueva) ObtenerHojaDeRutaRetiroDisponible(
            GuiaEntidad guia,
            string nuevoCodigo)
        {
            return ObtenerHojaDeRutaDisponible(guia, TipoHDRFleteroEnum.Retiro, nuevoCodigo);
        }

        public static (HojaDeRutaFleteroEntidad? hojaDeRuta, bool esNueva) ObtenerHojaDeRutaEntregaDisponible(
            GuiaEntidad guia,
            string nuevoCodigo)
        {
            return ObtenerHojaDeRutaDisponible(guia, TipoHDRFleteroEnum.Entrega, nuevoCodigo);
        }

        private static (HojaDeRutaFleteroEntidad? hojaDeRuta, bool esNueva) ObtenerHojaDeRutaDisponible(
            GuiaEntidad guia,
            TipoHDRFleteroEnum tipoHDR,
            string nuevoCodigo)
        {
            var hojaExistente = BuscarHojaDeRutaDisponible(guia, tipoHDR);

            if (hojaExistente != null)
            {
                hojaExistente.Guias.Add(guia.NumeroGuia);
                return (hojaExistente, false);
            }

            var centroDistribucion = ObtenerCentroDistribucion(guia, tipoHDR);
            if (centroDistribucion == null)
                return (null, false);

            var fletero = ObtenerFleteroConMenorCarga(centroDistribucion, tipoHDR);
            if (fletero == null)
                return (null, false);

            return (new HojaDeRutaFleteroEntidad
            {
                Codigo = nuevoCodigo,
                CentroDistribucion = centroDistribucion.Codigo,
                CuitCuilFletero = fletero.CuitCuilFletero,
                TipoHDR = tipoHDR,
                Estado = EstadoHDRFleteroEnum.Asignada,
                Guias = new List<string> { guia.NumeroGuia }
            }, true);
        }

        private static HojaDeRutaFleteroEntidad? BuscarHojaDeRutaDisponible(
            GuiaEntidad guia,
            TipoHDRFleteroEnum tipoHDR)
        {
            var centroDistribucion = ObtenerCentroDistribucion(guia, tipoHDR);
            if (centroDistribucion == null)
                return null;

            var clave = ObtenerClavePuntoVisitado(guia, tipoHDR);

            return HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                .Where(h =>
                    h.CentroDistribucion == centroDistribucion.Codigo &&
                    h.TipoHDR == tipoHDR &&
                    h.Estado == EstadoHDRFleteroEnum.Asignada &&
                    !h.Guias.Contains(guia.NumeroGuia))
                .FirstOrDefault(h => h.Guias
                    .Select(numero => GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numero))
                    .Any(g => g != null && ObtenerClavePuntoVisitado(g, tipoHDR) == clave));
        }

        private static CentroDistribucionEntidad? ObtenerCentroDistribucion(
            GuiaEntidad guia,
            TipoHDRFleteroEnum tipoHDR)
        {
            var codigo = tipoHDR == TipoHDRFleteroEnum.Retiro
                ? ObtenerCodigoCentroDistribucionRetiro(guia)
                : ObtenerCodigoCentroDistribucionEntrega(guia);

            return CentroDistribucionAlmacen.cd.FirstOrDefault(c => c.Codigo == codigo);
        }

        private static string ObtenerCodigoCentroDistribucionRetiro(GuiaEntidad guia)
        {
            if (!string.IsNullOrWhiteSpace(guia.CentroDistribucionOrigenDevolucion))
                return guia.CentroDistribucionOrigenDevolucion;

            if (!string.IsNullOrWhiteSpace(guia.CentroDistribucionRetiroCodigo))
                return guia.CentroDistribucionRetiroCodigo;

            return guia.CentroDistribucionOrigen;
        }

        private static string ObtenerCodigoCentroDistribucionEntrega(GuiaEntidad guia)
        {
            if (EsEntregaDevolucion(guia) &&
                !string.IsNullOrWhiteSpace(guia.CentroDistribucionDestinoDevolucion))
                return guia.CentroDistribucionDestinoDevolucion;

            if (!string.IsNullOrWhiteSpace(guia.CentroDistribucionEntregaCodigo))
                return guia.CentroDistribucionEntregaCodigo;

            return guia.CentroDistribucionDestino;
        }

        private static string ObtenerClavePuntoVisitado(GuiaEntidad guia, TipoHDRFleteroEnum tipoHDR)
        {
            return tipoHDR == TipoHDRFleteroEnum.Retiro
                ? ObtenerClaveRetiro(guia)
                : ObtenerClaveEntrega(guia);
        }

        private static string ObtenerClaveRetiro(GuiaEntidad guia)
        {
            if (!string.IsNullOrWhiteSpace(guia.CentroDistribucionOrigenDevolucion) &&
                !string.IsNullOrWhiteSpace(guia.AgenciaEntregaCodigo))
                return $"DEV-AG|{Normalizar(guia.AgenciaEntregaCodigo)}";

            return guia.MetodoRetiro switch
            {
                MetodoRetiroEnum.EnDomicilio => $"DOM|{Normalizar(guia.DireccionRetiro)}|{guia.CodPostalRetiro}",
                MetodoRetiroEnum.Agencia => $"AG|{Normalizar(guia.AgenciaRetiroCodigo)}",
                _ => $"CD|{Normalizar(guia.CentroDistribucionRetiroCodigo)}"
            };
        }

        private static string ObtenerClaveEntrega(GuiaEntidad guia)
        {
            if (EsEntregaDevolucion(guia))
            {
                return guia.MetodoRetiro switch
                {
                    MetodoRetiroEnum.EnDomicilio => $"DEV-DOM|{Normalizar(guia.DireccionDevolucion)}|{guia.CodPostalDevolucion}",
                    MetodoRetiroEnum.Agencia => $"DEV-AG|{Normalizar(guia.AgenciaDevolucionCodigo)}",
                    _ => $"DEV-CD|{Normalizar(guia.CentroDistribucionDestinoDevolucion)}"
                };
            }

            return guia.MetodoEntrega switch
            {
                MetodoEntregaEnum.ADomicilio => $"DOM|{Normalizar(guia.DireccionEntrega)}|{guia.CodPostalEntrega}",
                MetodoEntregaEnum.Agencia => $"AG|{Normalizar(guia.AgenciaEntregaCodigo)}",
                _ => $"CD|{Normalizar(guia.CentroDistribucionEntregaCodigo)}"
            };
        }

        private static bool EsEntregaDevolucion(GuiaEntidad guia)
        {
            return guia.EstadoActual == EstadoEnum.EnCDOrigenPorDevolucion ||
                   (guia.EstadoActual == EstadoEnum.EnTransitoDevolucionAOrigen &&
                    !string.IsNullOrWhiteSpace(guia.CentroDistribucionDestinoDevolucion));
        }

        private static FleteroEntidad? ObtenerFleteroConMenorCarga(
            CentroDistribucionEntidad centroDistribucion,
            TipoHDRFleteroEnum tipoHDR)
        {
            var fleterosConCobertura = FleteroAlmacen.fleteros
                .Where(f => centroDistribucion.Fleteros.Contains(f.CuitCuilFletero))
                .ToList();

            if (fleterosConCobertura.Count == 0)
                return null;

            return fleterosConCobertura
                .OrderBy(f => ContarHojasDeRutaAsignadas(centroDistribucion.Codigo, f.CuitCuilFletero, tipoHDR))
                .ThenBy(f => centroDistribucion.Fleteros.IndexOf(f.CuitCuilFletero))
                .First();
        }

        private static int ContarHojasDeRutaAsignadas(
            string codigoCentroDistribucion,
            long cuitCuilFletero,
            TipoHDRFleteroEnum tipoHDR)
        {
            return HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Count(h =>
                h.CentroDistribucion == codigoCentroDistribucion &&
                h.CuitCuilFletero == cuitCuilFletero &&
                h.TipoHDR == tipoHDR &&
                h.Estado == EstadoHDRFleteroEnum.Asignada);
        }

        private static string Normalizar(string valor)
        {
            return (valor ?? "").Trim().ToUpperInvariant();
        }
    }
}
