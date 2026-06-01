using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class PreciosBultosAlmacen
    {
        public static List<PreciosBultosEntidad> PreciosBultos = new();

        static PreciosBultosAlmacen()
        {
            if (File.Exists(@"datos\PreciosBultos.json"))
            {
                string json = File.ReadAllText(@"datos\PreciosBultos.json");

                PreciosBultos = JsonSerializer.Deserialize<List<PreciosBultosEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(PreciosBultos);
            File.WriteAllText(@"datos\PreciosBultos.json", json);
        }
    }
}
