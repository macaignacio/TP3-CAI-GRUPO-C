using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class CuentaCorrienteFleteroAlmacen
    {
        public static List<CuentaCorrienteFleteroEntidad> ctaCteFletero = new();

        static CuentaCorrienteFleteroAlmacen()
        {
            if (File.Exists(@"datos\CtaCteFletero.json"))
            {
                string json = File.ReadAllText(@"datos\CtaCteFletero.json");
                ctaCteFletero = JsonSerializer.Deserialize<List<CuentaCorrienteFleteroEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(ctaCteFletero);
            File.WriteAllText(@"datos\CtaCteFletero.json", json);
        }
        
    }
}
