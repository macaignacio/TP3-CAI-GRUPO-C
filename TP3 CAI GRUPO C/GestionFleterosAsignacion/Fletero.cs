namespace TP3_CAI_GRUPO_C.GestionFleterosAsignacion
{
    internal class Fletero
    {
        public long CuitCuil { get; set; }
        public string NombreCompleto { get; set; } = "";
        public List<HojaDeRuta> HojasDeRuta { get; set; } = new List<HojaDeRuta>();
    }
}
