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
                return (null, "El fletero no tiene hojas de ruta asignadas pendientes de rendicion.");

            return (fletero, "");
        }

        public ResultadoRendicion ConfirmarRendicion(long cuitCuil, List<string> codigosCumplidos)
        {
            var resultadoFletero = BuscarFletero(cuitCuil);

            if (resultadoFletero.fletero == null)
                return new ResultadoRendicion { Valido = false, Error = resultadoFletero.error };

            if (codigosCumplidos.Count == 0)
                return new ResultadoRendicion { Valido = false, Error = "Debe seleccionar al menos una hoja de ruta." };

            var hojasDeRutaCumplidas = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                .Where(hoja => hoja.CuitCuilFletero == cuitCuil
                    && hoja.Estado == EstadoHDRFleteroEnum.Asignada
                    && codigosCumplidos.Contains(hoja.Codigo))
                .ToList();

            if (hojasDeRutaCumplidas.Count != codigosCumplidos.Distinct().Count())
            {
                return new ResultadoRendicion
                {
                    Valido = false,
                    Error = "Una o más hojas de ruta ya no están disponibles para rendir."
                };
            }

            foreach (var hojaDeRutaFletero in hojasDeRutaCumplidas)
            {
                if (!HojaPuedeRendirse(hojaDeRutaFletero))
                {
                    return new ResultadoRendicion
                    {
                        Valido = false,
                        Error = $"La hoja de ruta {hojaDeRutaFletero.Codigo} contiene guías que no están listas para rendir."
                    };
                }
            }

            foreach (var hojaDeRutaFletero in hojasDeRutaCumplidas)
            {
                hojaDeRutaFletero.Estado = EstadoHDRFleteroEnum.Cumplida;

                foreach (var numeroGuia in hojaDeRutaFletero.Guias)
                {
                    var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                    ActualizarEstadoGuiaRendida(
                        hojaDeRutaFletero,
                        guia!);
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

        private static bool HojaPuedeRendirse(
            HojaDeRutaFleteroEntidad hojaDeRuta)
        {
            if (hojaDeRuta.Guias.Count == 0)
                return false;

            return hojaDeRuta.Guias.All(numeroGuia =>
            {
                var guia = GuiaAlmacen.guias
                    .FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                return guia != null &&
                       PuedeRendirse(hojaDeRuta.TipoHDR, guia.EstadoActual);
            });
        }

        private static void ActualizarEstadoGuiaRendida(
            HojaDeRutaFleteroEntidad hojaDeRuta,
            GuiaEntidad guia)
        {
            var estadoAnterior = guia.EstadoActual;
            var estadoActualizado = ObtenerEstadoActualizadoPorRendicion(
                hojaDeRuta.TipoHDR,
                estadoAnterior);

            guia.EstadoActual = estadoActualizado;
            guia.Historial ??= new List<MovimientoGuia>();
            guia.Historial.Add(new MovimientoGuia
            {
                Estado = estadoActualizado,
                UltimaActualizacion = DateTime.Now,
                Ubicacion = ObtenerUbicacionGuia(
                    hojaDeRuta,
                    guia,
                    estadoAnterior)
            });
        }

        private static EstadoEnum ObtenerEstadoActualizadoPorRendicion(
            TipoHDRFleteroEnum tipoHDR,
            EstadoEnum estado)
        {
            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
            {
                return estado switch
                {
                    EstadoEnum.RetiroAgenciaEnCurso => EstadoEnum.PendienteAdmision,
                    EstadoEnum.RetiroDomicilioEnCurso => EstadoEnum.PendienteAdmision,
                    _ => estado
                };
            }

            return estado switch
            {
                EstadoEnum.EnTransitoEntregaDomicilio => EstadoEnum.Entregado,
                EstadoEnum.EnTransitoAAgenciaDestino => EstadoEnum.ListaParaEntregarPorAgencia,
                _ => estado
            };
        }

        private static string ObtenerUbicacionGuia(
            HojaDeRutaFleteroEntidad hojaDeRuta,
            GuiaEntidad guia,
            EstadoEnum estadoAnterior)
        {
            if (hojaDeRuta.TipoHDR == TipoHDRFleteroEnum.Retiro)
                return ObtenerNombreCentroDistribucion(hojaDeRuta.CentroDistribucion);

            if (estadoAnterior == EstadoEnum.EnTransitoEntregaDomicilio)
                return ObtenerDestinoDomicilio(guia);

            return ObtenerNombreAgencia(guia.AgenciaEntregaCodigo);
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

        private static bool PuedeRendirse(
            TipoHDRFleteroEnum tipoHDR,
            EstadoEnum estado)
        {
            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
            {
                return estado == EstadoEnum.RetiroAgenciaEnCurso ||
                       estado == EstadoEnum.RetiroDomicilioEnCurso;
            }

            return estado == EstadoEnum.EnTransitoEntregaDomicilio ||
                   estado == EstadoEnum.EnTransitoAAgenciaDestino;
        }

    }
}
