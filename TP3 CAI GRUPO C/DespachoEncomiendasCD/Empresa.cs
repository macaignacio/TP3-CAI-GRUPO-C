using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.DespachoEncomiendasCD
{
    internal class Empresa
    {
        public string Nombre { get; set; } = "";
        public int CapacidadAlmacenamiento { get; set; }
        public string[] HorariosSalida { get; set; } = [];
    }
}
