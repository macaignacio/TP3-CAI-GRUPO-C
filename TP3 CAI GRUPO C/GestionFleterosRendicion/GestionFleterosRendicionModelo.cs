using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.GestionFleterosRendicion
{
    internal class GestionFleterosRendicionModelo
    {
       

        public (Fletero? fletero, string error) BuscarFletero(long cuitCuil)
        {
            if (cuitCuil < 10_000_000_000 || cuitCuil > 99_999_999_999)
                return (null, "CUIT/CUIL inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");

            var fleteroEntidad = FleteroAlmacen.fleteros.FirstOrDefault(f => f.CuitCuilFletero == cuitCuil);

            if (fleteroEntidad == null)
                return (null, "Fletero no encontrado.");

            var fletero = new Fletero
            {
                CuitCuil = fleteroEntidad.CuitCuilFletero,
                NombreCompleto = fleteroEntidad.NombreCompleto,
                HojasDeRuta = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                    .Where(hoja => hoja.CuitCuilFletero == fleteroEntidad.CuitCuilFletero
                        && hoja.Estado == EstadoHDRFleteroEnum.Asignada)
                    .SelectMany(hoja => hoja.Guias
                        .Select(numeroGuia => new
                        {
                            hoja.Codigo,
                            NumeroGuia = numeroGuia,
                            Guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia)
                        })
                        .Where(item => item.Guia != null && PuedeRendirse(item.Guia.EstadoActual))
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
                return (null, "El fletero no tiene hojas de ruta asignadas pendientes de rendicion.");

            return (fletero, "");
        }

        public ResultadoRendicion ConfirmarRendicion(long cuitCuil, List<string> codigosCumplidos)
        {
            var resultadoFletero = BuscarFletero(cuitCuil);

            if (resultadoFletero.fletero == null)
                return new ResultadoRendicion { Valido = false, Error = resultadoFletero.error };

            

            var hojasDeRutaCumplidas = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                .Where(hoja => hoja.CuitCuilFletero == cuitCuil
                    && hoja.Estado == EstadoHDRFleteroEnum.Asignada
                    && codigosCumplidos.Contains(hoja.Codigo))
                .ToList();

            foreach (var hojaDeRutaFletero in hojasDeRutaCumplidas)
            {
                hojaDeRutaFletero.Estado = EstadoHDRFleteroEnum.Cumplida;

                foreach (var numeroGuia in hojaDeRutaFletero.Guias)
                {
                    var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                    if (guia == null)
                        continue;

                    ActualizarEstadoGuiaRendida(guia);
                }
            }

            foreach (var hojaDeRuta in resultadoFletero.fletero.HojasDeRuta)
            {
                if (codigosCumplidos.Contains(hojaDeRuta.Codigo))
                {
                    var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == hojaDeRuta.NumeroGuia);
                    hojaDeRuta.EstadoEncomienda = guia?.EstadoActual.ToString() ?? "";
                }
            }

            var directorio = new DirectoryInfo(AppContext.BaseDirectory);

            while (directorio != null && !Directory.Exists(Path.Combine(directorio.FullName, "datos")))
            {
                directorio = directorio.Parent;
            }

            if (directorio != null)
                Directory.SetCurrentDirectory(directorio.FullName);

            HojaDeRutaFleteroAlmacen.Guardar();
            GuiaAlmacen.Guardar();

            return new ResultadoRendicion
            {
                Valido = true,
                HojasActualizadas = resultadoFletero.fletero.HojasDeRuta
            };
        }

        private static void ActualizarEstadoGuiaRendida(GuiaEntidad guia)
        {
            var estadoActualizado = ObtenerEstadoActualizadoPorRendicion(guia.EstadoActual);

            if (estadoActualizado == guia.EstadoActual)
                return;

            guia.EstadoActual = estadoActualizado;
            guia.Historial ??= new List<MovimientoGuia>();
            guia.Historial.Add(new MovimientoGuia
            {
                Estado = estadoActualizado,
                UltimaActualizacion = DateTime.Now,
                Ubicacion = ObtenerUbicacionGuia(guia, estadoActualizado)
            });
        }

        private static EstadoEnum ObtenerEstadoActualizadoPorRendicion(EstadoEnum estado)
        {
            return estado switch
            {
                EstadoEnum.RetiroAgenciaEnCurso => EstadoEnum.PendienteAdmision,
                EstadoEnum.RetiroDomicilioEnCurso => EstadoEnum.PendienteAdmision,
                EstadoEnum.EnTransitoEntregaDomicilio => EstadoEnum.Entregado,
                EstadoEnum.EnTransitoAAgenciaDestino => EstadoEnum.ListaParaEntregarPorAgencia,
                _ => estado
            };
        }

        private static string ObtenerUbicacionGuia(GuiaEntidad guia, EstadoEnum estado)
        {
            if (estado == EstadoEnum.Entregado && !string.IsNullOrWhiteSpace(guia.DireccionEntrega))
                return guia.DireccionEntrega;

            if (estado == EstadoEnum.PendienteAdmision && !string.IsNullOrWhiteSpace(guia.CentroDistribucionRetiroCodigo))
                return guia.CentroDistribucionRetiroCodigo;

            if (estado == EstadoEnum.ListaParaEntregarPorAgencia && !string.IsNullOrWhiteSpace(guia.AgenciaEntregaCodigo))
                return guia.AgenciaEntregaCodigo;

            return Program.CDActual;
        }

        private static bool PuedeRendirse(EstadoEnum estado)
        {
            return estado == EstadoEnum.RetiroAgenciaEnCurso ||
                   estado == EstadoEnum.RetiroDomicilioEnCurso ||
                   estado == EstadoEnum.EnTransitoEntregaDomicilio ||
                   estado == EstadoEnum.EnTransitoAAgenciaDestino;
        }

    }
}
