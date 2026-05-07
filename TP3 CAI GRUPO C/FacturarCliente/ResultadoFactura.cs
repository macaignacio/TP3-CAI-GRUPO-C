namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    internal class ResultadoFactura
    {
        public bool Valido { get; set; }

        public string Error { get; set; } = "";

        public Factura? Factura { get; set; }
    }
}
