namespace TP3_CAI_GRUPO_C.ImposiciónXCD
{
    internal class ResultadoImposicion
    {
        public bool Valido { get; set; }
        public string Error { get; set; } = "";
        public Guía? Guía { get; set; }
    }
}
