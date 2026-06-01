using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class EmpresaOmnibusEntidad
    {
        public string nombre { get; set; }

        public long cuitEmpresaOmnibus { get; set; }

        public List<string> serviciosOmnibus { get; set; }

        public List<string> resultados { get; set; }

        public decimal precioFijo { get; set; }

        public int capacidadAlmacenamientoEnS { get; set; }
    }
}
