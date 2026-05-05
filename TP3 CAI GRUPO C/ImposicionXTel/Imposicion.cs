using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.ImposicionXTel
{
    internal class Imposicion
    {
        public long CuitCliente { get; set; }
        public string NombreDestinatario { get; set; } = "";
        public int DniDestinatario { get; set; }
        public string ProvinciaRetiro { get; set; } = "";
        public string LocalidadRetiro { get; set; } = "";
        public int CodigoPostalRetiro { get; set; }
        public string DireccionRetiro { get; set; } = "";
        public string MetodoEntrega { get; set; } = "";
        public string ProvinciaEnvio { get; set; } = "";
        public string LocalidadEnvio { get; set; } = "";
        public int CodigoPostalEnvio { get; set; }
        public string DireccionEnvio { get; set; } = "";
        public string ProvinciaSucursal { get; set; } = "";
        public string LocalidadSucursal { get; set; } = "";
        public Sucursal? SucursalSeleccionada { get; set; }
        public int CantidadCajaS { get; set; }
        public int CantidadCajaM { get; set; }
        public int CantidadCajaL { get; set; }
        public int CantidadCajaXL { get; set; }
    }
}
