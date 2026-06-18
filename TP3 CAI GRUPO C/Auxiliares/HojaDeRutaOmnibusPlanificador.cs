using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.Auxiliares
{
    internal static class HojaDeRutaOmnibusPlanificador
    {
        public static (HojaDeRutaOmnibusEntidad? hojaDeRuta, bool esNueva, string error) ObtenerHojaDeRutaDisponible(
            GuiaEntidad guia,
            string codigoNuevaHojaDeRuta)
        {
            var capacidadGuia = CalcularCapacidadEnS(guia);
            var hojaExistente = BuscarHojaDeRutaDisponible(guia, capacidadGuia);

            if (hojaExistente != null)
            {
                if (!hojaExistente.Guias.Contains(guia.NumeroGuia))
                    hojaExistente.Guias.Add(guia.NumeroGuia);

                return (hojaExistente, false, "");
            }

            var servicio = ObtenerServicioConCobertura(guia.CentroDistribucionOrigen, guia.CentroDistribucionDestino, capacidadGuia);

            if (servicio == null)
                return (null, false, "No hay servicios de omnibus futuros con cobertura y disponibilidad entre el centro de distribucion origen y destino.");

            return (new HojaDeRutaOmnibusEntidad
            {
                Codigo = codigoNuevaHojaDeRuta,
                IdentificadorServicio = servicio.IdentificadorServicio,
                CentroDistribucionOrigen = guia.CentroDistribucionOrigen,
                CentroDistribucionDestino = guia.CentroDistribucionDestino,
                Estado = EstadoHDROmnibusEnum.Asignada,
                Guias = new List<string> { guia.NumeroGuia }
            }, true, "");
        }

        private static HojaDeRutaOmnibusEntidad? BuscarHojaDeRutaDisponible(GuiaEntidad guia, long capacidadGuia)
        {
            return HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus
                .Where(h =>
                    h.CentroDistribucionOrigen == guia.CentroDistribucionOrigen &&
                    h.CentroDistribucionDestino == guia.CentroDistribucionDestino &&
                    h.Estado == EstadoHDROmnibusEnum.Asignada)
                .Select(h => new
                {
                    HojaDeRuta = h,
                    Servicio = ServicioOmnibusAlmacen.servicios.FirstOrDefault(s => s.IdentificadorServicio == h.IdentificadorServicio)
                })
                .Where(x => x.Servicio != null)
                .Where(x => TieneParadasEnOrdenFuturas(x.Servicio!, guia.CentroDistribucionOrigen, guia.CentroDistribucionDestino))
                .Where(x => TieneDisponibilidad(x.HojaDeRuta, x.Servicio!, guia, capacidadGuia))
                .OrderBy(x => ObtenerFechaHoraParada(x.Servicio!, guia.CentroDistribucionOrigen))
                .Select(x => x.HojaDeRuta)
                .FirstOrDefault();
        }

        private static ServicioOmnibusEntidad? ObtenerServicioConCobertura(
            string centroDistribucionOrigen,
            string centroDistribucionDestino,
            long capacidadGuia)
        {
            return ServicioOmnibusAlmacen.servicios
                .Where(s => ObtenerEmpresa(s) != null)
                .Where(s => TieneParadasEnOrdenFuturas(s, centroDistribucionOrigen, centroDistribucionDestino))
                .Where(s => ObtenerEmpresa(s)!.capacidadAlmacenamientoEnS >= capacidadGuia)
                .OrderBy(s => ObtenerFechaHoraParada(s, centroDistribucionOrigen))
                .FirstOrDefault();
        }

        private static bool TieneDisponibilidad(
            HojaDeRutaOmnibusEntidad hojaDeRuta,
            ServicioOmnibusEntidad servicio,
            GuiaEntidad guia,
            long capacidadGuia)
        {
            var empresa = ObtenerEmpresa(servicio);

            if (empresa == null)
                return false;

            var capacidadUsada = hojaDeRuta.Guias
                .Where(numeroGuia => numeroGuia != guia.NumeroGuia)
                .Select(numeroGuia => GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia))
                .Where(g => g != null)
                .Sum(g => CalcularCapacidadEnS(g!));

            return capacidadUsada + capacidadGuia <= empresa.capacidadAlmacenamientoEnS;
        }

        private static EmpresaOmnibusEntidad? ObtenerEmpresa(ServicioOmnibusEntidad servicio)
        {
            return EmpresaOmnibusAlmacen.empresasOmnibus
                .FirstOrDefault(e => e.cuitEmpresaOmnibus == servicio.CuitEmpresaOmnibus);
        }

        private static bool TieneParadasEnOrdenFuturas(
            ServicioOmnibusEntidad servicio,
            string centroDistribucionOrigen,
            string centroDistribucionDestino)
        {
            var paradaOrigen = ObtenerFechaHoraParada(servicio, centroDistribucionOrigen);
            var paradaDestino = ObtenerFechaHoraParada(servicio, centroDistribucionDestino);

            return paradaOrigen != null &&
                   paradaDestino != null &&
                   paradaOrigen > Program.AhoraSistema() &&
                   paradaOrigen < paradaDestino;
        }

        private static DateTime? ObtenerFechaHoraParada(ServicioOmnibusEntidad servicio, string centroDistribucion)
        {
            return servicio.Parada
                .Where(p => p.CentroDistribucionParada == centroDistribucion)
                .Select(p => (DateTime?)p.FechaHoraParada)
                .FirstOrDefault();
        }

        private static long CalcularCapacidadEnS(GuiaEntidad guia)
        {
            return guia.CajasS +
                   guia.CajasM * 2L +
                   guia.CajasL * 4L +
                   guia.CajasXL * 8L;
        }
    }
}
