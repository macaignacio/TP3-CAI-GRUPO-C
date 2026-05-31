using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class AgenciaAlmacen
    {
        public static List<AgenciaEntidad> agencia = new();

        static AgenciaAlmacen()
        {
            if (File.Exists(@"datos\Agencias.json"))
            {
                string json = File.ReadAllText(@"datos\Agencias.json");
                agencia = JsonSerializer.Deserialize<List<AgenciaEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(agencia);
            File.WriteAllText(@"datos\Agencias.json", json);
        }
    }
}

