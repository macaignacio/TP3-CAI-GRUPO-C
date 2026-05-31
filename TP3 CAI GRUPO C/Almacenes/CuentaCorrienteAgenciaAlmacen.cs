using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal static class CuentaCorrienteAgenciaAlmacen
    {
        public static List<CuentaCorrienteAgenciaEntidad> ctaCteAgencia = new();

        static CuentaCorrienteAgenciaAlmacen()
        {
            if (File.Exists(@"datos\ctacteagencia.json"))
            {
                string json = File.ReadAllText(@"datos\ctacteagencia.json");
                ctaCteAgencia = JsonSerializer.Deserialize<List<CuentaCorrienteAgenciaEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(ctaCteAgencia);
            File.WriteAllText(@"datos\ctacteagencia.json", json);
        }
    }
}
