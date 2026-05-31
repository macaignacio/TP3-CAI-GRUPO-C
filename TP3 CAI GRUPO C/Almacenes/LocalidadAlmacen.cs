using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class LocalidadAlmacen
    {
        public static List<LocalidadEntidad> localidades = new();

        static LocalidadAlmacen()
        {
            if (File.Exists(@"datos\Localidades.json"))
            {
                string json = File.ReadAllText(@"datos\Localidades.json");
                localidades = JsonSerializer.Deserialize<List<LocalidadEntidad>>(json);
            }
        }

        public static void Guardar()
        {
            string json = JsonSerializer.Serialize(localidades);
            File.WriteAllText(@"datos\Localidades.json", json);
        }
    }
}
