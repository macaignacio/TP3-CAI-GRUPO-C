using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class CentroDistribucionAlmacen
    {
        public static List<CentroDistribucionEntidad> cd= new();

        static CentroDistribucionAlmacen()
        {
            if (File.Exists(@"datos\CentroDistribucion.json"))
            {
                string json = File.ReadAllText(@"datos\CentroDistribucion.json");
                cd = JsonSerializer.Deserialize<List<CentroDistribucionEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(cd);
            File.WriteAllText(@"datos\CentroDistribucion.json", json);
        }
    }
}
