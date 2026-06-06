using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.DespachoEncomiendasCD
{
    internal class DespachoEncomiendasCDModelo
    {
        public int CodigoCDActual { get; } = 3001;

        public List<EmpresaOmnibusEntidad> Empresas =>
            EmpresaOmnibusAlmacen.empresasOmnibus;

        public (bool valido, string error) ValidarBusqueda(
            string empresa,
            DateTime fechaSalida)
        {
            if (string.IsNullOrWhiteSpace(empresa))
                return (false, "Debe seleccionar una empresa de ómnibus.");

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
                // Primera parada del servicio
                var primeraParada = servicio.Parada
                    .OrderBy(p => p.FechaHoraParada)
                    .FirstOrDefault();

                if (primeraParada == null)
                    continue;

                // Comparar fecha y hora seleccionadas
                if (primeraParada.FechaHoraParada.Year != fechaSalida.Year)
                    continue;

                if (primeraParada.FechaHoraParada.Month != fechaSalida.Month)
                    continue;

                if (primeraParada.FechaHoraParada.Day != fechaSalida.Day)
                    continue;

                if (primeraParada.FechaHoraParada.Hour != fechaSalida.Hour)
                    continue;

                if (primeraParada.FechaHoraParada.Minute != fechaSalida.Minute)
                    continue;

                // Buscar las HDR asociadas al servicio
                var hdrs =
                    HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus
                    .Where(h =>
                        h.IdentificadorServicio ==
                        servicio.IdentificadorServicio
                        &&
                        h.Estado ==
                        EstadoHDROmnibusEnum.Asignada)
                    .ToList();

                foreach (var hdr in hdrs)
                {
                    resultado.Add(new HojaDeRuta
                    {
                        NroOrden = hdr.IdentificadorServicio,
                        Codigo = hdr.Codigo,
                        Estado = hdr.Estado.ToString(),
                        EmpresaOmnibus = empresaSeleccionada.nombre,
                        FechaSalida = primeraParada.FechaHoraParada,
                        Destino = hdr.CentroDistribucionDestino
                    });
                }
            }

            return resultado;
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

                hojaEnSistema.Estado =
                    EstadoHDROmnibusEnum.EnTransito;
            }

            HojaDeRutaOmnibusAlmacen.Guardar();

            return (true, "");
        }
    }
}