using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class CuentaCorrienteClienteAlmacen
    {
        public static List<CuentaCorrienteClienteEntidad> ctaCteCliente = new();

        static CuentaCorrienteClienteAlmacen()
        {
            if (File.Exists(@"datos\CtaCteCliente.json"))
            {
                string json = File.ReadAllText(@"datos\CtaCteCliente.json");
                ctaCteCliente = JsonSerializer.Deserialize<List<CuentaCorrienteClienteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(ctaCteCliente);
            File.WriteAllText(@"datos\CtaCteCliente.json", json);
        }
    }
}
