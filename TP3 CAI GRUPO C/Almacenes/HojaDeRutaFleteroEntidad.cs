using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.EstadoEncomienda;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class HojaDeRutaFleteroEntidad
    {   //datos cabecera
        public string Codigo { get; set; }
        public string CentroDistribucion { get; set; }
        public long CuitCuilFletero { get; set; }
        public TipoHDRFleteroEnum TipoHDR { get; set; }
        public EstadoHDRFleteroEnum Estado { get; set; }
        public List<NumeroGuia> Guias { get; set; } 
    }
}
