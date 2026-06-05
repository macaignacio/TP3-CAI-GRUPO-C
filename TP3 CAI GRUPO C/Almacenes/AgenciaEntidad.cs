using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class AgenciaEntidad
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CentroDistribucion { get; set; }
        public string Direccion { get; set; }
        public string Horarios { get; set; }
        public decimal ComisionS {  get; set; }
        public decimal ComisionM { get; set; }
        public decimal ComisionL { get; set; }
        public decimal ComisionXL { get; set; }
    }
}
