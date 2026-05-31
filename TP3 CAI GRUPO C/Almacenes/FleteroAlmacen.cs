using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class FleteroAlmacen
    {public static List<FleteroEntidad> fleteros = new();

        static FleteroAlmacen()
        {
            if (File.Exists(@"datos\Fleteros.json"))
            {
                string json = File.ReadAllText(@"datos\Fleteros.json");
                fleteros = JsonSerializer.Deserialize<List<FleteroEntidad>>(json);
            }

        }

        public static void Guardar()

        {
            string json = JsonSerializer.Serialize(fleteros);
            File.WriteAllText(@"datos\Fleteros.json", json);
        }

    }
}

