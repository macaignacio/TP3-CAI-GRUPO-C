namespace TP3_CAI_GRUPO_C.ImposicionXAgencia
{
    internal class Imposicion
    {
        public string TipoImposicion { get; set; } = "";
        public string CodigoAgenciaOrigen { get; set; } = "";
        public long CuitCliente { get; set; }
        public string NombreDestinatario { get; set; } = "";
        public int DniDestinatario { get; set; }
        public string MetodoEntrega { get; set; } = "";
        public string ProvinciaDomicilio { get; set; } = "";
        public string LocalidadDomicilio { get; set; } = "";
        public int CodigoPostalDomicilio { get; set; }
        public string DireccionDomicilio { get; set; } = "";
        public string ProvinciaSucursal { get; set; } = "";
        public string LocalidadSucursal { get; set; } = "";
        public Sucursal? SucursalSeleccionada { get; set; }
        public int CantidadCajaS { get; set; }
        public int CantidadCajaM { get; set; }
        public int CantidadCajaL { get; set; }
        public int CantidadCajaXL { get; set; }
    }
}
