using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class ClienteAlmacen
    {
        public static List<ClienteEntidad> clientes = new();

        static ClienteAlmacen()
        {
            if (File.Exists(@"datos\Clientes.json"))
            {
                string json = File.ReadAllText(@"datos\Clientes.json");
                clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(clientes);
            File.WriteAllText(@"datos\Clientes.json", json);
        }

    }
}
