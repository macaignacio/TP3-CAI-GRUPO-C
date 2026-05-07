using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.EstadoEncomienda
{
    public class Guia
    {
        public long NumeroGuia { get; set; }
        public List<Movimiento> Historial { get; set; } = new List<Movimiento>();
    }
}
