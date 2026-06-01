using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class PreciosBultosEntidad
    {
        public string TamañoCaja { get; set; }
        public int IdLocalidadOrigen { get; set; }
        public int IdLocalidadDestino { get; set; }
        public decimal Precio { get; set; }
    }
}
