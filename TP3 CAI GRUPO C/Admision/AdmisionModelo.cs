namespace TP3_CAI_GRUPO_C.Admision
{
    internal class AdmisionModelo
    {
        private const string EstadoImpuesta = "Impuesta";
        private const string EstadoAdmitida = "Admitida";

        public List<Cliente> Clientes { get; } = new List<Cliente>
        {
            new Cliente {
                Cuit = 30205869953,
                RazonSocial = "EnvasesArg",
            },
            new Cliente {
                Cuit = 30725648921,
                RazonSocial = "RepuestosCorSA",
            },
            new Cliente {
                Cuit = 20314567891,
                RazonSocial = "TecnologiaHoy",
            }
        };

        public List<Guia> Guias { get; } = new List<Guia>
        {
            new Guia
            {
                NumeroGuia = 20260506143015987,
                EstadoActual = EstadoImpuesta,
                FechaHoraAlta = new DateTime(2026, 5, 6, 14, 30, 15),
                CuitCliente = 30205869953,
                CantidadCajaS = 4,
                CantidadCajaM = 0,
                CantidadCajaL = 0,
                CantidadCajaXL = 0
            },
            new Guia
            {
                NumeroGuia = 20260506151245821,
                EstadoActual = EstadoImpuesta,
                FechaHoraAlta = new DateTime(2026, 5, 6, 15, 12, 45),
                CuitCliente = 30725648921,
                CantidadCajaS = 2,
                CantidadCajaM = 3,
                CantidadCajaL = 1,
                CantidadCajaXL = 0
            },
            new Guia
            {
                NumeroGuia = 20260506164530734,
                EstadoActual = EstadoImpuesta,
                FechaHoraAlta = new DateTime(2026, 5, 6, 16, 45, 30),
                CuitCliente = 20314567891,
                CantidadCajaS = 1,
                CantidadCajaM = 2,
                CantidadCajaL = 0,
                CantidadCajaXL = 1
            }
        };

        public ResultadoAdmision BuscarGuia(long numeroGuia)
        {
            var guia = Guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

            if (guia == null)
                return new ResultadoAdmision { Valido = false, Error = "Guía no encontrada." };

            if (guia.EstadoActual != EstadoImpuesta)
                return new ResultadoAdmision { Valido = false, Error = "La guía no se encuentra en estado Impuesta." };

            var cliente = Clientes.FirstOrDefault(c => c.Cuit == guia.CuitCliente);

            if (cliente == null)
                return new ResultadoAdmision { Valido = false, Error = "Cliente asociado a la guía no encontrado." };

            return new ResultadoAdmision
            {
                Valido = true,
                Guia = guia
            };
        }

        public ResultadoAdmision ConfirmarAdmision(long numeroGuia, int cantidadCajaS, int cantidadCajaM, int cantidadCajaL, int cantidadCajaXL)
        {
            var resultadoGuia = BuscarGuia(numeroGuia);

            if (!resultadoGuia.Valido || resultadoGuia.Guia == null)
                return resultadoGuia;

            var resultadoCajas = ValidarCajas(cantidadCajaS, cantidadCajaM, cantidadCajaL, cantidadCajaXL);

            if (!resultadoCajas.valido)
                return new ResultadoAdmision { Valido = false, Error = resultadoCajas.error };

            resultadoGuia.Guia.CantidadCajaS = cantidadCajaS;
            resultadoGuia.Guia.CantidadCajaM = cantidadCajaM;
            resultadoGuia.Guia.CantidadCajaL = cantidadCajaL;
            resultadoGuia.Guia.CantidadCajaXL = cantidadCajaXL;
            resultadoGuia.Guia.EstadoActual = EstadoAdmitida;

            return new ResultadoAdmision
            {
                Valido = true,
                Guia = resultadoGuia.Guia
            };
        }

        public (bool valido, string error) ValidarCajas(int s, int m, int l, int xl)
        {
            if (s < 0 || m < 0 || l < 0 || xl < 0)
                return (false, "Las cantidades de cajas no pueden ser negativas.");

            long totalCajas = s + m + l + xl;

            if (totalCajas == 0)
                return (false, "Debe ingresar al menos una caja.");

            long capacidadUsada = (s * 1) + (m * 2) + (l * 4) + (xl * 8);
            long capacidadMaxima = 20 * 8;

            if (capacidadUsada > capacidadMaxima)
                return (false, "La cantidad de cajas supera el máximo permitido.");

            return (true, "");
        }
    }
}
