using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.GestionFleterosAsignacion
{
    internal class GestionFleterosAsignacionModelo
    {
        public List<Fletero> Fleteros => CargarFleteros();

        private static List<Fletero> CargarFleteros()
        {
            var directorio = new DirectoryInfo(AppContext.BaseDirectory);

            while (directorio != null && !Directory.Exists(Path.Combine(directorio.FullName, "Datos")))
            {
                directorio = directorio.Parent;
            }

            if (directorio != null)
                Directory.SetCurrentDirectory(directorio.FullName);

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
                        .Where(hoja => GuiaPuedeAsignarseAFletero(GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == hoja.NumeroGuia)))
                        .ToList()
                })
                .ToList();
        }

        private static string ObtenerEstadoPendiente(TipoHDRFleteroEnum tipoHDR, GuiaEntidad? guia)
        {
            if (guia != null)
                return guia.EstadoActual.ToString();

            if (tipoHDR == TipoHDRFleteroEnum.Retiro)
                return EstadoEnum.ImpuestaTelefonicamente.ToString();

            return EstadoEnum.EnCDDestino.ToString();
        }

        private static bool GuiaPuedeAsignarseAFletero(GuiaEntidad? guia)
        {
            if (guia == null)
                return false;

            return (int)guia.EstadoActual == 0
                || (int)guia.EstadoActual == 1
                || ((int)guia.EstadoActual == 8 && (int)guia.MetodoEntrega != 1);
        }

        public (Fletero? fletero, string error) BuscarFletero(long cuitCuil)
        {
            if (cuitCuil < 10_000_000_000 || cuitCuil > 99_999_999_999)
                return (null, "CUIT/CUIL invalido. Se debe ingresar un numero de 11 digitos sin guiones ni comas.");

            var fletero = Fleteros.FirstOrDefault(f => f.CuitCuil == cuitCuil);

            if (fletero == null)
                return (null, "Fletero no encontrado.");

            return (fletero, "");
        }

        public ResultadoAsignacion ConfirmarAsignacion(long cuitCuil)
        {
            var resultadoFletero = BuscarFletero(cuitCuil);

            if (resultadoFletero.fletero == null)
                return new ResultadoAsignacion { Valido = false, Error = resultadoFletero.error };

            if (resultadoFletero.fletero.HojasDeRuta.Count == 0)
                return new ResultadoAsignacion { Valido = false, Error = "El fletero no tiene hojas de ruta pendientes." };

            foreach (var hojaDeRuta in resultadoFletero.fletero.HojasDeRuta)
            {
                var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == hojaDeRuta.NumeroGuia);

                if (guia != null)
                {
                    var estadoActualizado = ObtenerEstadoActualizado(guia);

                    if (estadoActualizado != guia.EstadoActual)
                    {
                        guia.EstadoActual = estadoActualizado;
                        guia.Historial ??= new List<MovimientoGuia>();
                        guia.Historial.Add(new MovimientoGuia
                        {
                            Estado = guia.EstadoActual,
                            UltimaActualizacion = DateTime.Now,
                            Ubicacion = ObtenerUbicacionMovimiento(guia)
                        });
                    }

                    hojaDeRuta.EstadoEncomienda = guia.EstadoActual.ToString();
                }
            }

            GuiaAlmacen.Guardar();

            return new ResultadoAsignacion
            {
                Valido = true,
                HojasActualizadas = resultadoFletero.fletero.HojasDeRuta
            };
        }

        private EstadoEnum ObtenerEstadoActualizado(GuiaEntidad guia)
        {
            if ((int)guia.EstadoActual == 0)
                return (EstadoEnum)3;

            if ((int)guia.EstadoActual == 1)
                return (EstadoEnum)4;

            if ((int)guia.EstadoActual == 8
                && (int)guia.MetodoEntrega == 0)
                return (EstadoEnum)10;

            if ((int)guia.EstadoActual == 8
                && (int)guia.MetodoEntrega == 2)
                return (EstadoEnum)11;

            return guia.EstadoActual;
        }

        private string ObtenerUbicacionMovimiento(GuiaEntidad guia)
        {
            if ((int)guia.EstadoActual == 3
                || (int)guia.EstadoActual == 4)
                return $"En transito a {ObtenerDestinoRetiro(guia)}";

            if ((int)guia.EstadoActual == 10
                || (int)guia.EstadoActual == 11)
                return $"En transito a {ObtenerDestinoEntrega(guia)}";

            return $"En transito a {guia.CentroDistribucionDestino}";
        }

        private string ObtenerDestinoRetiro(GuiaEntidad guia)
        {
            if ((int)guia.MetodoRetiro == 2)
                return guia.DireccionRetiro;

            if ((int)guia.MetodoRetiro == 0)
                return AgenciaAlmacen.agencia.FirstOrDefault(a => a.Codigo == guia.AgenciaRetiroCodigo)?.Nombre
                    ?? guia.AgenciaRetiroCodigo;

            return CentroDistribucionAlmacen.cd.FirstOrDefault(cd => cd.Codigo == guia.CentroDistribucionRetiroCodigo)?.Nombre
                ?? guia.CentroDistribucionRetiroCodigo;
        }

        private string ObtenerDestinoEntrega(GuiaEntidad guia)
        {
            if ((int)guia.MetodoEntrega == 0)
                return guia.DireccionEntrega;

            if ((int)guia.MetodoEntrega == 2)
                return AgenciaAlmacen.agencia.FirstOrDefault(a => a.Codigo == guia.AgenciaEntregaCodigo)?.Nombre
                    ?? guia.AgenciaEntregaCodigo;

            return CentroDistribucionAlmacen.cd.FirstOrDefault(cd => cd.Codigo == guia.CentroDistribucionEntregaCodigo)?.Nombre
                ?? guia.CentroDistribucionEntregaCodigo;
        }
    }
}
