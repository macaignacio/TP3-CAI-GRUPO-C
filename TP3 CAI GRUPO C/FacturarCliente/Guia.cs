using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    internal class Guia
    {
        public int Cuit { get; set; }

        public int NumeroGuia { get; set; }

        public required string Estado { get; set; }
    }
}
