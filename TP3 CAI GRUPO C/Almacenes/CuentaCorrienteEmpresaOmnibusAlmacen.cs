using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class CuentaCorrienteEmpresaOmnibusAlmacen
    {
        public static List<CuentaCorrienteEmpresaOmnibusEntidad> ctaCteEmpresaOmnibus = new();

        static CuentaCorrienteEmpresaOmnibusAlmacen()
        {
            if (File.Exists(@"datos\CtaCteEmpresaOmnibus.json"))
            {
                string json = File.ReadAllText(@"datos\CtaCteEmpresaOmnibus.json");
                ctaCteEmpresaOmnibus = JsonSerializer.Deserialize<List<CuentaCorrienteEmpresaOmnibusEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(ctaCteEmpresaOmnibus);
            File.WriteAllText(@"datos\CtaCteEmpresaOmnibus.json", json);
        }

    }
}
