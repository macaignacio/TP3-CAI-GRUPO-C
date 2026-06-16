using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.DespachoEncomiendasCD
{
    internal class DespachoEncomiendasCDModelo
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

            return (true, "");
        }

        public List<HojaDeRuta> BuscarHojasDeRuta(
            string empresa,
            DateTime fechaSalida)
        {
            var resultado = new List<HojaDeRuta>();

            // Buscar la empresa seleccionada
            var empresaSeleccionada =
                EmpresaOmnibusAlmacen.empresasOmnibus
                .FirstOrDefault(e => e.nombre == empresa);

            if (empresaSeleccionada == null)
                return resultado;

            // Buscar todos los servicios de esa empresa
            var serviciosEmpresa =
                ServicioOmnibusAlmacen.servicios
                .Where(s =>
                    s.CuitEmpresaOmnibus ==
                    empresaSeleccionada.cuitEmpresaOmnibus)
                .ToList();

            foreach (var servicio in serviciosEmpresa)
            {
                // Buscar las HDR asociadas al servicio
                var hdrs =
                    HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus
                    .Where(h =>
                        h.IdentificadorServicio ==
                        servicio.IdentificadorServicio
                        &&
                        h.CentroDistribucionOrigen == CodigoCDActual
                        &&
                        h.Estado ==
                        EstadoHDROmnibusEnum.Asignada)
                    .ToList();

                foreach (var hdr in hdrs)
                {
                    var fechaHoraOrigen = ObtenerFechaHoraParada(
                        servicio,
                        hdr.CentroDistribucionOrigen);

                    var fechaHoraDestino = ObtenerFechaHoraParada(
                        servicio,
                        hdr.CentroDistribucionDestino);

                    if (fechaHoraOrigen == null ||
                        fechaHoraDestino == null ||
                        fechaHoraOrigen >= fechaHoraDestino)
                    {
                        continue;
                    }

                    if (!CoincideFechaHora(fechaHoraOrigen.Value, fechaSalida))
                        continue;

                    resultado.Add(new HojaDeRuta
                    {
                        NroOrden = hdr.IdentificadorServicio,
                        Codigo = hdr.Codigo,
                        Estado = hdr.Estado.ToString(),
                        EmpresaOmnibus = empresaSeleccionada.nombre,
                        FechaSalida = fechaHoraOrigen.Value,
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

        private static bool CoincideFechaHora(DateTime parada, DateTime busqueda)
        {
            return parada.Year == busqueda.Year &&
                   parada.Month == busqueda.Month &&
                   parada.Day == busqueda.Day &&
                   parada.Hour == busqueda.Hour &&
                   parada.Minute == busqueda.Minute;
        }
        
        public (bool valido, string error)
            ValidarConfirmacion(List<HojaDeRuta> hojas)
        {
            if (hojas.Count == 0)
                return (
                    false,
                    "No hay Hojas de Ruta cargadas para confirmar la asignación."
                );

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

                if (hojaEnSistema.Estado != EstadoHDROmnibusEnum.Asignada)
                {
                    return (
                        false,
                        $"La Hoja de Ruta {hoja.Codigo} ya no está asignada."
                    );
                }

                if (hojaEnSistema.CentroDistribucionOrigen != CodigoCDActual)
                {
                    return (
                        false,
                        $"La Hoja de Ruta {hoja.Codigo} no pertenece al centro de distribución actual."
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

                    if (guia.EstadoActual != EstadoEnum.AdmitidaEnCD &&
                        guia.EstadoActual != EstadoEnum.ListaParaDespachoDevolucion)
                    {
                        return (
                            false,
                            $"La Guía {numeroGuia} no está en un estado válido para despacho."
                        );
                    }

                    var origenGuia = guia.EstadoActual == EstadoEnum.ListaParaDespachoDevolucion
                        ? guia.CentroDistribucionOrigenDevolucion
                        : guia.CentroDistribucionOrigen;
                    var destinoGuia = guia.EstadoActual == EstadoEnum.ListaParaDespachoDevolucion
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
                }

                hojasEnSistema.Add(hojaEnSistema);
            }

            foreach (var hoja in hojas)
            {
                var hojaEnSistema = hojasEnSistema
                    .First(h => h.Codigo == hoja.Codigo);

                hojaEnSistema.Estado =
                    EstadoHDROmnibusEnum.EnTransitoCDDestino;

                hoja.Estado = EstadoHDROmnibusEnum.EnTransitoCDDestino.ToString();

                var ubicacion = CentroDistribucionAlmacen.cd
                    .FirstOrDefault(c => c.Codigo == hojaEnSistema.CentroDistribucionOrigen)
                    ?.Nombre ?? hojaEnSistema.CentroDistribucionOrigen;

                foreach (var numeroGuia in hojaEnSistema.Guias)
                {
                    var guia = GuiaAlmacen.guias
                        .First(g => g.NumeroGuia == numeroGuia);

                    var nuevoEstado = guia.EstadoActual == EstadoEnum.ListaParaDespachoDevolucion
                        ? EstadoEnum.EnTransitoDevolucionAOrigen
                        : EstadoEnum.EnTransitoACDDestino;

                    guia.EstadoActual = nuevoEstado;
                    guia.Historial ??= new List<MovimientoGuia>();
                    guia.Historial.Add(new MovimientoGuia
                    {
                        Estado = nuevoEstado,
                        UltimaActualizacion = DateTime.Now,
                        Ubicacion = ubicacion
                    });
                }
            }

            HojaDeRutaOmnibusAlmacen.Guardar();
            GuiaAlmacen.Guardar();

            return (true, "");
        }
    }
}
