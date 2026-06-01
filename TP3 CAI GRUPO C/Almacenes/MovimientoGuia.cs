using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class MovimientoGuia
    {
        public EstadoEnum Estado {  get; set; }

        public DateTime UltimaActualizacion { get; set; }

        public string Ubicacion { get; set; }

    }
}
