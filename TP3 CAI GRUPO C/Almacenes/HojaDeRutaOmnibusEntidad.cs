using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.EstadoEncomienda;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class HojaDeRutaOmnibusEntidad
    {   
        public string Codigo { get; set; }
        public string IdentificadorServicio { get; set; }
        public string CentroDistribucionOrigen { get; set; }

        public string CentroDistribucionDestino { get; set; }

        public EstadoHDROmnibusEnum Estado { get; set; }
        public List<NumeroGuia> Guias { get; set; } 
    }
}
