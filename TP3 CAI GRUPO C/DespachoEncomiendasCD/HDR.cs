using System;

namespace TP3_CAI_GRUPO_C.DespachoEncomiendasCD
{
    internal class HojaDeRuta
    {
        public string NroOrden { get; set; } = "";
        public string Codigo { get; set; } = "";
        public string Estado { get; set; } = "";
        public string EmpresaOmnibus { get; set; } = "";
        public DateTime FechaSalida { get; set; }
        public string Destino { get; set; } = "";
    }
}
