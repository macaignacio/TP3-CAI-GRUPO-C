using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.ConsultaCtaCteCliente
{
    internal class CtaCorriente
    {
        public string Tipo { get; set; } = "";
        public DateTime Fecha { get; set; }
        public DateTime Vencimiento { get; set; }
        public string Comprobante { get; set; } = "";
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Saldo { get; set; }
    }
}
