namespace TP3_CAI_GRUPO_C.GestionFleterosAsignacion
{
    internal class ResultadoAsignacion
    {
        public bool Valido { get; set; }
        public string Error { get; set; } = "";
        public List<HojaDeRuta> HojasActualizadas { get; set; } = new List<HojaDeRuta>();
    }
}
