using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class CuentaCorrienteClienteEntidad
    {
        public long Cuit { get; set; }
        public string TipoComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public string Comprobante { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Saldo { get; set; }
    }
}
