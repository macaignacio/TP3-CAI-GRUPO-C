using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class ServicioOmnibusEntidad
    {
        public long CuitEmpresaOmnibus { get; set; }

        public string identificadorServicio { get; set; }

        public List<ParadaOmnibus> Parada { get; set; }
    }
}
