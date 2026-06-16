using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.GestionFleterosAsignacion
{
    internal class GestionFleterosAsignacionModelo
    {
        public List<Fletero> Fleteros => CargarFleteros();

        private static List<Fletero> CargarFleteros()
        {
            return FleteroAlmacen.fleteros
                .Select(fletero => new Fletero
                {
                    CuitCuil = fletero.CuitCuilFletero,
                    NombreCompleto = fletero.NombreCompleto,
                    HojasDeRuta = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                        .Where(hoja => hoja.CuitCuilFletero == fletero.CuitCuilFletero
                            && hoja.Estado == EstadoHDRFleteroEnum.Asignada)
                        .SelectMany(hoja => hoja.Guias.Select(numeroGuia =>
                        {
                            var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                            return new HojaDeRuta
                            {
                                Codigo = hoja.Codigo,
                                NumeroGuia = numeroGuia,
                                EstadoEncomienda = ObtenerEstadoPendiente(hoja.TipoHDR, guia)
                            };
                        }))
                        .Where(hoja =>
                        {
                            var hojaEntidad = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                                .First(h => h.Codigo == hoja.Codigo);
                            var guia = GuiaAlmacen.guias
                                .FirstOrDefault(g => g.NumeroGuia == hoja.NumeroGuia);

                            return GuiaPuedeAsignarseAFletero(
                                hojaEntidad.TipoHDR,
                                guia);
                        })
                        .ToList()
                })
                .ToList();
        }

        private static string ObtenerEstadoPendiente(TipoHDRFleteroEnum tipoHDR, GuiaEntidad? guia)
        {
            if (guia != null)
            {
                return ObtenerDescripcionEstado(guia.EstadoActual);
            }

            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
            {
                return ObtenerDescripcionEstado(EstadoEnum.ImpuestaTelefonicamente);
            }

            return ObtenerDescripcionEstado(EstadoEnum.EnCDDestino);
        }

        private static bool GuiaPuedeAsignarseAFletero(
            TipoHDRFleteroEnum tipoHDR,
            GuiaEntidad? guia)
        {
            if (guia == null)
            {
                return false;
            }

            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
            {
                return guia.EstadoActual == EstadoEnum.ImpuestaTelefonicamente ||
                       guia.EstadoActual == EstadoEnum.ImpuestaEnAgencia ||
                       guia.EstadoActual == EstadoEnum.DevolucionIniciada;
            }

            if (guia.EstadoActual == EstadoEnum.EnCDDestino &&
                (guia.MetodoEntrega == MetodoEntregaEnum.ADomicilio ||
                 guia.MetodoEntrega == MetodoEntregaEnum.Agencia))
                return true;

            if (guia.EstadoActual == EstadoEnum.PendienteSegundoIntentoEntrega &&
                guia.MetodoEntrega == MetodoEntregaEnum.ADomicilio)
                return true;

            if (guia.EstadoActual == EstadoEnum.EnCDOrigenPorDevolucion)
                return true;

            return false;
        }

        public (Fletero? fletero, string error) BuscarFletero(long cuitCuil)
        {
            if (cuitCuil < 10_000_000_000 || cuitCuil > 99_999_999_999)
            {
                return (null, "CUIT/CUIL invalido. Se debe ingresar un numero de 11 digitos sin guiones ni comas.");
            }

            var fletero = Fleteros.FirstOrDefault(f => f.CuitCuil == cuitCuil);

            if (fletero == null)
            {
                return (null, "Fletero no encontrado.");
            }

            return (fletero, "");
        }

        public ResultadoAsignacion ConfirmarAsignacion(long cuitCuil)
        {
            var resultadoFletero = BuscarFletero(cuitCuil);

            if (resultadoFletero.fletero == null)
            {
                return new ResultadoAsignacion { Valido = false, Error = resultadoFletero.error };
            }

            if (resultadoFletero.fletero.HojasDeRuta.Count == 0)
            {
                return new ResultadoAsignacion { Valido = false, Error = "El fletero no tiene hojas de ruta pendientes." };
            }

            var asignaciones = new List<(HojaDeRuta hoja, HojaDeRutaFleteroEntidad hojaEntidad, GuiaEntidad guia)>();

            foreach (var hojaDeRuta in resultadoFletero.fletero.HojasDeRuta)
            {
                var hojaEntidad = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                    .FirstOrDefault(h =>
                        h.Codigo == hojaDeRuta.Codigo &&
                        h.CuitCuilFletero == cuitCuil &&
                        h.Estado == EstadoHDRFleteroEnum.Asignada &&
                        h.Guias.Contains(hojaDeRuta.NumeroGuia));

                if (hojaEntidad == null)
                {
                    return new ResultadoAsignacion
                    {
                        Valido = false,
                        Error = $"La hoja de ruta {hojaDeRuta.Codigo} ya no está disponible para asignar."
                    };
                }

                var guia = GuiaAlmacen.guias
                    .FirstOrDefault(g => g.NumeroGuia == hojaDeRuta.NumeroGuia);

                if (guia == null)
                {
                    return new ResultadoAsignacion
                    {
                        Valido = false,
                        Error = $"La guía {hojaDeRuta.NumeroGuia} no fue encontrada."
                    };
                }

                if (!GuiaPuedeAsignarseAFletero(hojaEntidad.TipoHDR, guia))
                {
                    return new ResultadoAsignacion
                    {
                        Valido = false,
                        Error = $"La guía {guia.NumeroGuia} ya no está en un estado válido para la hoja de ruta {hojaEntidad.Codigo}."
                    };
                }

                asignaciones.Add((hojaDeRuta, hojaEntidad, guia));
            }

            foreach (var asignacion in asignaciones)
            {
                var estadoActualizado = ObtenerEstadoActualizado(
                    asignacion.hojaEntidad.TipoHDR,
                    asignacion.guia);

                asignacion.guia.EstadoActual = estadoActualizado;
                asignacion.guia.Historial ??= new List<MovimientoGuia>();
                asignacion.guia.Historial.Add(new MovimientoGuia
                {
                    Estado = estadoActualizado,
                    UltimaActualizacion = DateTime.Now,
                    Ubicacion = ObtenerUbicacionMovimiento(
                        asignacion.hojaEntidad.TipoHDR,
                        asignacion.guia)
                });

                asignacion.hoja.EstadoEncomienda = ObtenerDescripcionEstado(estadoActualizado);
            }

            GuiaAlmacen.Guardar();

            return new ResultadoAsignacion
            {
                Valido = true,
                HojasActualizadas = resultadoFletero.fletero.HojasDeRuta
            };
        }

        private static EstadoEnum ObtenerEstadoActualizado(
            TipoHDRFleteroEnum tipoHDR,
            GuiaEntidad guia)
        {
            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
            {
                return guia.EstadoActual switch
                {
                    EstadoEnum.ImpuestaTelefonicamente => EstadoEnum.RetiroDomicilioEnCurso,
                    EstadoEnum.ImpuestaEnAgencia => EstadoEnum.RetiroAgenciaEnCurso,
                    EstadoEnum.DevolucionIniciada => EstadoEnum.RetiroDevolucionAgenciaEnCurso,
                    _ => guia.EstadoActual
                };
            }

            if (guia.EstadoActual == EstadoEnum.PendienteSegundoIntentoEntrega)
                return EstadoEnum.EnTransitoSegundoIntentoEntrega;

            if (guia.EstadoActual == EstadoEnum.EnCDOrigenPorDevolucion)
            {
                return guia.MetodoRetiro switch
                {
                    MetodoRetiroEnum.EnDomicilio => EstadoEnum.EnTransitoDomicilioRemitente,
                    MetodoRetiroEnum.Agencia => EstadoEnum.EnTransitoAgenciaOrigen,
                    _ => guia.EstadoActual
                };
            }

            return guia.MetodoEntrega switch
            {
                MetodoEntregaEnum.ADomicilio => EstadoEnum.EnTransitoEntregaDomicilio,
                MetodoEntregaEnum.Agencia => EstadoEnum.EnTransitoAAgenciaDestino,
                _ => guia.EstadoActual
            };
        }

        private static string ObtenerDescripcionEstado(EstadoEnum estado)
        {
            return estado switch
            {
                EstadoEnum.ImpuestaTelefonicamente => "Impuesta Telefónicamente",
                EstadoEnum.ImpuestaEnAgencia => "Impuesta en Agencia",
                EstadoEnum.ImpuestaEnCD => "Impuesta en CD",
                EstadoEnum.RetiroDomicilioEnCurso => "Retiro a Domicilio en Curso",
                EstadoEnum.RetiroAgenciaEnCurso => "Retiro en Agencia en Curso",
                EstadoEnum.AdmitidaEnCD => "Admitida en CD",
                EstadoEnum.EnTransitoACDDestino => "En Tránsito a CD Destino",
                EstadoEnum.EnCDDestino => "En CD Destino",
                EstadoEnum.ListaParaEntregarPorCD => "Lista para Entregar por CD",
                EstadoEnum.EnTransitoEntregaDomicilio => "En Tránsito a Domicilio",
                EstadoEnum.EnTransitoAAgenciaDestino => "En Tránsito a Agencia Destino",
                EstadoEnum.ListaParaEntregarPorAgencia => "Lista para Entregar por Agencia",
                EstadoEnum.Entregado => "Entregado",
                _ => estado.ToString()
            };
        }

        private static string ObtenerUbicacionMovimiento(
            TipoHDRFleteroEnum tipoHDR,
            GuiaEntidad guia)
        {
            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
            {
                return $"En transito a {ObtenerDestinoRetiro(guia)}";
            }

            return $"En transito a {ObtenerDestinoEntrega(guia)}";
        }

        private static string ObtenerDestinoRetiro(GuiaEntidad guia)
        {
            if (guia.MetodoRetiro == MetodoRetiroEnum.EnDomicilio)
            {
                return guia.DireccionRetiro;
            }

            if (guia.MetodoRetiro == MetodoRetiroEnum.Agencia)
            {
                return AgenciaAlmacen.agencia.FirstOrDefault(a => a.Codigo == guia.AgenciaRetiroCodigo)?.Nombre
                    ?? guia.AgenciaRetiroCodigo;
            }

            return CentroDistribucionAlmacen.cd.FirstOrDefault(cd => cd.Codigo == guia.CentroDistribucionRetiroCodigo)?.Nombre
                ?? guia.CentroDistribucionRetiroCodigo;
        }

        private static string ObtenerDestinoEntrega(GuiaEntidad guia)
        {
            if (guia.MetodoEntrega == MetodoEntregaEnum.ADomicilio)
            {
                return guia.DireccionEntrega;
            }

            if (guia.MetodoEntrega == MetodoEntregaEnum.Agencia)
            {
                return AgenciaAlmacen.agencia.FirstOrDefault(a => a.Codigo == guia.AgenciaEntregaCodigo)?.Nombre
                    ?? guia.AgenciaEntregaCodigo;
            }

            return CentroDistribucionAlmacen.cd.FirstOrDefault(cd => cd.Codigo == guia.CentroDistribucionEntregaCodigo)?.Nombre
                ?? guia.CentroDistribucionEntregaCodigo;
        }
    }
}
