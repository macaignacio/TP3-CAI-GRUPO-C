namespace TP3_CAI_GRUPO_C.Admision
{
    internal class ResultadoAdmision
    {
        public bool Valido { get; set; }
        public string Error { get; set; } = "";
        public Guia? Guia { get; set; }
    }
}
