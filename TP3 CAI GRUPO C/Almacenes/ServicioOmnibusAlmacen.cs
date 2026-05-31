using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal static class ServicioOmnibusAlmacen
    {
        public static List<ServicioOmnibusEntidad> servicios = new();

        static ServicioOmnibusAlmacen()
        {
            if (File.Exists(@"datos\ServiciosOmnibus.json"))
            {
                string json = File.ReadAllText(@"datos\ServiciosOmnibus.json");
                servicios = JsonSerializer.Deserialize<List<ServicioOmnibusEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(servicios);
            File.WriteAllText(@"datos\ServiciosOmnibus.json", json);
        }
    }
}
