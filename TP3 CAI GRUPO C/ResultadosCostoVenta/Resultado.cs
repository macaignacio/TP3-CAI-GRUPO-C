using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.ResultadosCostoVenta
{
    internal class Resultado
    {
        public string EmpresaOmnibus { get; set; } = "";
        public decimal Ventas { get; set; }
        public decimal Costos { get; set; }
        public decimal Utilidad { get; set; }
    }
}
