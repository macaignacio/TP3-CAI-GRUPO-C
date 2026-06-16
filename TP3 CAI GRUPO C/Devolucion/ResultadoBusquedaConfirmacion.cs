using System.Collections.Generic;

namespace TP3_CAI_GRUPO_C.Devolucion
{
    internal class ResultadoBusquedaConfirmacion
    {
        public bool Valido { get; set; }
        public string Error { get; set; } = "";
        public Cliente? Cliente { get; set; }
        public List<GuiaDevolucionConfirmar> Guias { get; set; } = new();
    }
}
