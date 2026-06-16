using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class CuentaCorrienteAgenciaEntidad
    {
        public string CodigoAgencia { get; set; }
        public DateTime Fecha { get; set; }
        public string NumeroGuia { get; set; }
        public string Comprobante { get; set; }
        public TipoMovimientoCtaCteEnum TipoMovimiento { get; set; }
        public string Concepto { get; set; }
        public decimal Importe { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Saldo { get; set; }
        public bool Pagado { get; set; }
    }
}
