using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class PreciosExtrasAlmacen
    {
        public static List<PreciosExtrasEntidad> PreciosExtras = new();
        static PreciosExtrasAlmacen()
        {
            if (File.Exists(@"datos\PreciosExtras.json"))
            {
                string json = File.ReadAllText(@"datos\PreciosExtras.json");
                PreciosExtras = JsonSerializer.Deserialize<List<PreciosExtrasEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(PreciosExtras);
            File.WriteAllText(@"datos\PreciosExtras.json", json);
        }
    }
}
