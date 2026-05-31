using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal static class HojaDeRutaFleteroAlmacen
    {
        public static List<HojaDeRutaFleteroEntidad> HojasDeRutaFleteros = new();

        static HojaDeRutaFleteroAlmacen()
        {
            if (File.Exists(@"datos\HojasDeRutaFleteros.json"))
            {
                string json = File.ReadAllText(@"datos\HojasDeRutaFleteros.json");
                HojasDeRutaFleteros = JsonSerializer.Deserialize<List<HojaDeRutaFleteroEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(HojasDeRutaFleteros);
            File.WriteAllText(@"datos\hojasderutafleteros.json", json);
        }
    }
}
