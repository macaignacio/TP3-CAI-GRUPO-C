using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.RecepcionEncomiendasCD
{
    internal class HojaDeRuta
    {
        public long NumeroGuia { get; set; }
        public string NroOrden { get; set; } = "";
        public string Codigo { get; set; } = "";
        public string Estado { get; set; } = "";
        public string EmpresaOmnibus { get; set; } = "";
        public DateTime FechaSalida { get; set; }
        public string Destino { get; set; } = "";
    }
}
