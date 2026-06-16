using System;

namespace TP3_CAI_GRUPO_C.Devolucion
{
    internal class GuiaDevolucionConfirmar
    {
        public string NumeroGuia { get; set; } = "";
        public string Estado { get; set; } = "";
        public string LugarDevolucion { get; set; } = "";
        public DateTime FechaLlegada { get; set; }
    }
}
