namespace TP3_CAI_GRUPO_C.Admision
{
    internal class Guia
    {
        public long NumeroGuia { get; set; }
        public string EstadoActual { get; set; } = "";
        public DateTime FechaHoraAlta { get; set; }
        public long CuitCliente { get; set; }
        public int CantidadCajaS { get; set; }
        public int CantidadCajaM { get; set; }
        public int CantidadCajaL { get; set; }
        public int CantidadCajaXL { get; set; }
    }
}
