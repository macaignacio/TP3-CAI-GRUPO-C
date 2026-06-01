using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class FacturaEntidad
    {   //datos cabecera
        public string NumeroFactura { get; set; }
        public long CuitCliente { get; set; }
        public DateTime FechaEmision { get; set; }
        public int Total { get; set; }
        public DateTime Vencimiento { get; set; }


        //movimientos
        public List<long> Guias { get; set; }

    }

}

