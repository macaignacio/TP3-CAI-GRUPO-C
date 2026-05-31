using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal static class HojaDeRutaOmnibusAlmacen
    {
        public static List<HojaDeRutaOmnibusEntidad> hojasderutaomnibus = new();

        static HojaDeRutaOmnibusAlmacen()
        {
            if (File.Exists(@"datos\hojasderutaomnibus.json"))
            {
                string json = File.ReadAllText(@"datos\hojasderutaomnibus.json");
                hojasderutaomnibus = JsonSerializer.Deserialize<List<HojaDeRutaOmnibusEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hojasderutaomnibus);
            File.WriteAllText(@"datos\hojasderutaomnibus.json", json);
        }
    }
}
