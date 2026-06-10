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
            var estadoAnterior = guia.EstadoActual;
            var estadoActualizado = ObtenerEstadoActualizadoPorRendicion(estadoAnterior);

            if (estadoActualizado == estadoAnterior)
                return;

            guia.EstadoActual = estadoActualizado;
            guia.Historial ??= new List<MovimientoGuia>();
            guia.Historial.Add(new MovimientoGuia
            {
                Estado = estadoActualizado,
                UltimaActualizacion = DateTime.Now,
                Ubicacion = ObtenerUbicacionGuia(guia, estadoAnterior)
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

        private static string ObtenerUbicacionGuia(GuiaEntidad guia, EstadoEnum estadoAnterior)
        {
            var destino = ObtenerDestinoFletero(guia, estadoAnterior);

            if (string.IsNullOrWhiteSpace(destino))
                destino = Program.CDActual;

            return $"En transito a {destino}";
        }

        private static string ObtenerDestinoFletero(GuiaEntidad guia, EstadoEnum estadoAnterior)
        {
            return estadoAnterior switch
            {
                EstadoEnum.RetiroAgenciaEnCurso => ObtenerNombreAgencia(guia.AgenciaRetiroCodigo),
                EstadoEnum.RetiroDomicilioEnCurso => ObtenerDestinoRetiroDomicilio(guia),
                EstadoEnum.EnTransitoEntregaDomicilio => ObtenerDestinoDomicilio(guia),
                EstadoEnum.EnTransitoAAgenciaDestino => ObtenerNombreAgencia(guia.AgenciaEntregaCodigo),
                _ => ""
            };
        }

        private static string ObtenerDestinoRetiroDomicilio(GuiaEntidad guia)
        {
            if (!string.IsNullOrWhiteSpace(guia.CentroDistribucionRetiroCodigo))
                return ObtenerNombreCentroDistribucion(guia.CentroDistribucionRetiroCodigo);

            if (!string.IsNullOrWhiteSpace(guia.CentroDistribucionOrigen))
                return ObtenerNombreCentroDistribucion(guia.CentroDistribucionOrigen);

            return guia.DireccionRetiro;
        }

        private static string ObtenerDestinoDomicilio(GuiaEntidad guia)
        {
            if (!string.IsNullOrWhiteSpace(guia.DireccionEntrega))
                return $"domicilio {guia.DireccionEntrega}";

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

        private static bool PuedeRendirse(EstadoEnum estado)
        {
            return estado == EstadoEnum.RetiroAgenciaEnCurso ||
                   estado == EstadoEnum.RetiroDomicilioEnCurso ||
                   estado == EstadoEnum.EnTransitoEntregaDomicilio ||
                   estado == EstadoEnum.EnTransitoAAgenciaDestino;
        }

    }
}
