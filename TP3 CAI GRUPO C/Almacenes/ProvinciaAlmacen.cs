using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
        internal static class ProvinciaAlmacen
        {
            public static List<ProvinciaEntidad> provincias = new();

            static ProvinciaAlmacen()
            {
                if (File.Exists(@"datos\provincias.json"))
                {
                    string json = File.ReadAllText(@"datos\provincias.json");
                    provincias = JsonSerializer.Deserialize<List<ProvinciaEntidad>>(json);
                }
            }

            public static void Guardar()
            {
                string json = JsonSerializer.Serialize(provincias);
                File.WriteAllText(@"datos\provincias.json", json);
            }
        }
    }
