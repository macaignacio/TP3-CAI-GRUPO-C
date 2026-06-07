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
                    .SelectMany(hoja => hoja.Guias.Select(numeroGuia =>
                    {
                        var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

                        return new HojaDeRuta
                        {
                            Codigo = hoja.Codigo,
                            NumeroGuia = numeroGuia,
                            EstadoEncomienda = guia?.EstadoActual.ToString() ?? ""
                        };
                    }))
                    .ToList()
            };

            if (fletero.HojasDeRuta.Count == 0)
                return (null, "El fletero no tiene hojas de ruta asignadas.");

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
            }

            foreach (var hojaDeRuta in resultadoFletero.fletero.HojasDeRuta)
            {
                if (codigosCumplidos.Contains(hojaDeRuta.Codigo))
                    hojaDeRuta.EstadoEncomienda = EstadoHDRFleteroEnum.Cumplida.ToString();
            }

            var directorio = new DirectoryInfo(AppContext.BaseDirectory);

            while (directorio != null && !Directory.Exists(Path.Combine(directorio.FullName, "datos")))
            {
                directorio = directorio.Parent;
            }

            if (directorio != null)
                Directory.SetCurrentDirectory(directorio.FullName);

            HojaDeRutaFleteroAlmacen.Guardar();

            return new ResultadoRendicion
            {
                Valido = true,
                HojasActualizadas = resultadoFletero.fletero.HojasDeRuta
            };
        }

     

    }
}
