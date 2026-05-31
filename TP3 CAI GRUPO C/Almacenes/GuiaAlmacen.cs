using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal static class GuiaAlmacen
    { public static List<GuiaEntidad> guias = new();

        static GuiaAlmacen()
        {
            if(File.Exists(@"datos\guias.json"))
            {
                string json = File.ReadAllText(@"datos\guias.json");
                guias = JsonSerializer.Deserialize<List<GuiaEntidad>>(json);
            }
        }
          
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(guias);
            File.WriteAllText(@"datos\guias.json", json);
        }
    }
}
