using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal static class HojaDeRutaOmnibusAlmacen
    {
        public static List<HojaDeRutaOmnibusEntidad> HojasDeRutaOmnibus = new();

        static HojaDeRutaOmnibusAlmacen()
        {
            if (File.Exists(@"datos\HojasDeRutaOmnibus.json"))
            {
                string json = File.ReadAllText(@"datos\HojasDeRutaOmnibus.json");
                HojasDeRutaOmnibus = JsonSerializer.Deserialize<List<HojaDeRutaOmnibusEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(HojasDeRutaOmnibus);
            File.WriteAllText(@"datos\HojasDeRutaOmnibus.json", json);
        }
    }
}
