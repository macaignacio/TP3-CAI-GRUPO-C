using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class ProvinciaEntidad
    {
        public int IdProvincia { get; set; }

        public string Nombre { get; set; }

        public List<int> Localidades { get; set; }
    }
}
