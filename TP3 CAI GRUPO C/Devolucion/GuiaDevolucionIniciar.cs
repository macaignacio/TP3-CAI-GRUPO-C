using System;

namespace TP3_CAI_GRUPO_C.Devolucion
{
    internal class GuiaDevolucionIniciar
    {
        public string NumeroGuia { get; set; } = "";
        public string RazonSocialCliente { get; set; } = "";
        public string Estado { get; set; } = "";
        public string UbicacionActual { get; set; } = "";
        public DateTime FechaArribo { get; set; }
        public int DiasEnEspera { get; set; }
        public string DestinoDevolucion { get; set; } = "";
    }
}
