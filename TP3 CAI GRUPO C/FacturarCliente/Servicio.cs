using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    internal class Servicio
    {
        public DateTime Fecha { get; set; }
        
        public required string Descripcion { get; set; }

        public long NumeroGuia { get; set; }

        public decimal Monto { get; set; }

        public decimal Subtotal { get; set; }

    }
}
