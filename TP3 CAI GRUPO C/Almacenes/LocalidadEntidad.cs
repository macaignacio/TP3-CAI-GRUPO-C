using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class LocalidadEntidad
    {
        public int IDLocalidad { get; set; }
        public string Descripcion { get; set; }
        public List<int> CodigosPostales { get; set; }
    }
}
