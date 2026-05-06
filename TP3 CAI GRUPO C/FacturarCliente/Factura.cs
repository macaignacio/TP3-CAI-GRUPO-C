using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    internal class Factura
    {
        public DateTime Fecha { get; set; }
        
        public required string Descripcion { get; set; }

        public int NumeroGuia { get; set; }

        public int Monto { get; set; }

        public int Subtotal { get; set; }

    }
}
