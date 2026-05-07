using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Entrega
{
    internal class Encomienda
    {
        public long NumeroGuia { get; set; }
        public EstadoEncomienda Estado { get; set; }
        public Destinatario Destinatario { get; set; } = new Destinatario();
        public Cliente ClienteAsociado { get; set; } = new Cliente();
    }
}