using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal static class HojaDeRutaFleteroAlmacen
    {
        public static List<HojaDeRutaFleteroEntidad> hojasderutafleteros = new();

        static HojaDeRutaFleteroAlmacen()
        {
            if (File.Exists(@"datos\hojasderutafleteros.json"))
            {
                string json = File.ReadAllText(@"datos\hojasderutafleteros.json");
                hojasderutafleteros = JsonSerializer.Deserialize<List<HojaDeRutaFleteroEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(hojasderutafleteros);
            File.WriteAllText(@"datos\hojasderutafleteros.json", json);
        }
    }
}
