using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class CentroDistribucionEntidad
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public int IdLocalidad { get; set; }

        public List<int> CodPostal { get; set; }
        public List<long> Fleteros { get; set; }

    }
}
