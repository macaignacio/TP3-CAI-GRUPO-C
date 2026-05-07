//using TP3_CAI_GRUPO_C.Entrega;
//using TP3_CAI_GRUPO_C.ImposiciónXCD;
//using TP3_CAI_GRUPO_C.ConsultaCtaCteCliente; 
//using TP3_CAI_GRUPO_C.ResultadosCostoVenta;
using TP3_CAI_GRUPO_C.GestionFleterosRendicion;

namespace TP3_CAI_GRUPO_C
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GestionFleterosRendicionForm());
        }
    }
}