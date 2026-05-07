using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    internal class FacturacionCliente
    {
        public long CuitCliente { get; set; }

        public string RazonSocial { get; set; } = "";

        public required List<Servicio> Servicios { get; set; }
    }
}
