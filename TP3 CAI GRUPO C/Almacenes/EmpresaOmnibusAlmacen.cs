using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class EmpresaOmnibusAlmacen
    {
        public static List<EmpresaOmnibusEntidad> empresasOmnibus = new();

        static EmpresaOmnibusAlmacen()
        {
            if (File.Exists(@"datos\EmpresaOmnibus.json"))
            {
                string json = File.ReadAllText(@"datos\EmpresaOmnibus.json");
                empresasOmnibus = JsonSerializer.Deserialize<List<EmpresaOmnibusEntidad>>(json);
            }
        }

      
        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(empresasOmnibus);
            File.WriteAllText(@"datos\EmpresaOmnibus.json", json);
        }
    }
}
