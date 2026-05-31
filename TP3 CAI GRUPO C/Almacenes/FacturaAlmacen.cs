using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using TP3_CAI_GRUPO_C.FacturarCliente;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class FacturaAlmacen
    {public static List<FacturaEntidad> facturas = new();

        static FacturaAlmacen()
        {
            if (File.Exists(@"datos\Facturas.json"))
            {
                string json = File.ReadAllText(@"datos\Facturas.json");
                facturas = JsonSerializer.Deserialize<List<FacturaEntidad>>(json);
            }

        }

        public static void Guardar()

        {
            string json = JsonSerializer.Serialize(facturas);
            File.WriteAllText(@"datos\Facturas.json", json);
        }

    }
}
