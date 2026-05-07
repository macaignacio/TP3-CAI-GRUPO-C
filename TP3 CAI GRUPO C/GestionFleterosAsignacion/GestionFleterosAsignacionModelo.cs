namespace TP3_CAI_GRUPO_C.GestionFleterosAsignacion
{
    internal class GestionFleterosAsignacionModelo
    {
        private const string EstadoImposicionTelefonica = "Imposición hecha telefónicamente";
        private const string EstadoImposicionAgencia = "Imposición hecha por agencia";
        private const string EstadoRecibidoCDDestino = "Recibido en CD destino";
        private const string EstadoListoDistribucionLocal = "Listo para distribución local";
        private const string EstadoPendienteRetiroFletero = "Pendiente de retiro por fletero";
        private const string EstadoEnCaminoDestinatario = "En camino hacia el destinatario";

        public List<Fletero> Fleteros { get; } = new List<Fletero>
        {
            new Fletero
            {
                CuitCuil = 20345678901,
                NombreCompleto = "Martin Alvarez",
                HojasDeRuta =
                [
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0001", NumeroGuia = 20260506101010101, EstadoEncomienda = EstadoImposicionTelefonica },
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0002", NumeroGuia = 20260506101010202, EstadoEncomienda = EstadoImposicionAgencia },
                    new HojaDeRuta { Codigo = "HDR-DIS-202605-0001", NumeroGuia = 20260506101010303, EstadoEncomienda = EstadoRecibidoCDDestino },
                ]
            },
            new Fletero
            {
                CuitCuil = 20345678902,
                NombreCompleto = "Luciana Torres",
                HojasDeRuta =
                [
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0003", NumeroGuia = 20260506101510101, EstadoEncomienda = EstadoImposicionAgencia },
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0004", NumeroGuia = 20260506101510202, EstadoEncomienda = EstadoImposicionAgencia },
                    new HojaDeRuta { Codigo = "HDR-DIS-202605-0002", NumeroGuia = 20260506101510303, EstadoEncomienda = EstadoListoDistribucionLocal },
                ]
            },
            new Fletero
            {
                CuitCuil = 20345678903,
                NombreCompleto = "Carlos Benitez",
                HojasDeRuta =
                [
                    new HojaDeRuta { Codigo = "HDR-DIS-202605-0003", NumeroGuia = 20260506102010101, EstadoEncomienda = EstadoRecibidoCDDestino },
                    new HojaDeRuta { Codigo = "HDR-DIS-202605-0004", NumeroGuia = 20260506102010202, EstadoEncomienda = EstadoListoDistribucionLocal },
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0005", NumeroGuia = 20260506102010303, EstadoEncomienda = EstadoImposicionTelefonica },
                ]
            },
            new Fletero
            {
                CuitCuil = 20345678904,
                NombreCompleto = "Sofia Romero",
                HojasDeRuta =
                [
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0006", NumeroGuia = 20260506102510101, EstadoEncomienda = EstadoImposicionTelefonica },
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0007", NumeroGuia = 20260506102510202, EstadoEncomienda = EstadoImposicionTelefonica },
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0008", NumeroGuia = 20260506102510303, EstadoEncomienda = EstadoImposicionTelefonica },
                ]
            },
            new Fletero
            {
                CuitCuil = 20345678905,
                NombreCompleto = "Diego Fernandez",
                HojasDeRuta =
                [
                    new HojaDeRuta { Codigo = "HDR-DIS-202605-0005", NumeroGuia = 20260506103010101, EstadoEncomienda = EstadoRecibidoCDDestino },
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0009", NumeroGuia = 20260506103010202, EstadoEncomienda = EstadoImposicionAgencia },
                    new HojaDeRuta { Codigo = "HDR-DIS-202605-0006", NumeroGuia = 20260506103010303, EstadoEncomienda = EstadoListoDistribucionLocal },
                ]
            },
            new Fletero
            {
                CuitCuil = 20345678906,
                NombreCompleto = "Valeria Castro",
                HojasDeRuta =
                [
                    new HojaDeRuta { Codigo = "HDR-RET-202605-0010", NumeroGuia = 20260506103510101, EstadoEncomienda = EstadoImposicionAgencia },
                    new HojaDeRuta { Codigo = "HDR-DIS-202605-0007", NumeroGuia = 20260506103510202, EstadoEncomienda = EstadoRecibidoCDDestino },
                    new HojaDeRuta { Codigo = "HDR-DIS-202605-0008", NumeroGuia = 20260506103510303, EstadoEncomienda = EstadoListoDistribucionLocal },
                ]
            },
        };

        public (Fletero? fletero, string error) BuscarFletero(long cuitCuil)
        {
            if (cuitCuil < 10_000_000_000 || cuitCuil > 99_999_999_999)
                return (null, "CUIT/CUIL inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");

            var fletero = Fleteros.FirstOrDefault(f => f.CuitCuil == cuitCuil);

            if (fletero == null)
                return (null, "Fletero no encontrado.");

            return (fletero, "");
        }

        public ResultadoAsignacion ConfirmarAsignacion(long cuitCuil)
        {
            var resultadoFletero = BuscarFletero(cuitCuil);

            if (resultadoFletero.fletero == null)
                return new ResultadoAsignacion { Valido = false, Error = resultadoFletero.error };

            if (resultadoFletero.fletero.HojasDeRuta.Count == 0)
                return new ResultadoAsignacion { Valido = false, Error = "El fletero no tiene hojas de ruta pendientes." };

            foreach (var hojaDeRuta in resultadoFletero.fletero.HojasDeRuta)
            {
                hojaDeRuta.EstadoEncomienda = ObtenerEstadoActualizado(hojaDeRuta.EstadoEncomienda);
            }

            return new ResultadoAsignacion
            {
                Valido = true,
                HojasActualizadas = resultadoFletero.fletero.HojasDeRuta
            };
        }

        private string ObtenerEstadoActualizado(string estadoActual)
        {
            if (estadoActual == EstadoImposicionTelefonica || estadoActual == EstadoImposicionAgencia)
                return EstadoPendienteRetiroFletero;

            if (estadoActual == EstadoRecibidoCDDestino || estadoActual == EstadoListoDistribucionLocal)
                return EstadoEnCaminoDestinatario;

            return estadoActual;
        }
    }
}
