using System;
using System.Collections.Generic;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    internal class Factura
    {
        public string NumeroFactura { get; set; } = "";

        public long CuitCliente { get; set; }

        public string RazonSocial { get; set; } = "";

        public DateTime FechaEmision { get; set; }

        public List<Servicio> Servicios { get; set; } = new List<Servicio>();

        public decimal Total { get; set; }
    }
}
