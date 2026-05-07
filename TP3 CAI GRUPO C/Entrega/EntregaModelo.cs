using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Entrega
{
    internal class EntregaModelo
    {
        public List<Destinatario> Destinatarios { get; } = new List<Destinatario>
        {
            new Destinatario { NombreApellido = "Ana Gomez", Dni = 30111222 },
            new Destinatario { NombreApellido = "Bruno Perez", Dni = 28999888 },
            new Destinatario { NombreApellido = "Carla Ruiz", Dni = 33444555 }
        };

        public List<Encomienda> Encomiendas { get; } = new List<Encomienda>
        {
            new Encomienda
            {
                NumeroGuia = 20260506101010101,
                Estado = EstadoEncomienda.RecibidoCDDestino,
                Destinatario = new Destinatario { NombreApellido = "Ana Gomez", Dni = 30111222 },
                ClienteAsociado = new Cliente { Cuit = 30205869953, RazonSocial = "EnvasesArg" }
            },
            new Encomienda
            {
                NumeroGuia = 20260506101010202,
                Estado = EstadoEncomienda.ListoParaRetirarPorCD,
                Destinatario = new Destinatario { NombreApellido = "Ana Gomez", Dni = 30111222 },
                ClienteAsociado = new Cliente { Cuit = 30725648921, RazonSocial = "RepuestosCorSA" }
            },
            new Encomienda
            {
                NumeroGuia = 20260506101010303,
                Estado = EstadoEncomienda.RecibidoCDDestino,
                Destinatario = new Destinatario { NombreApellido = "Bruno Perez", Dni = 28999888 },
                ClienteAsociado = new Cliente { Cuit = 20314567891, RazonSocial = "TecnologiaHoy" }
            },
            new Encomienda
            {
                NumeroGuia = 20260506101510101,
                Estado = EstadoEncomienda.ListoParaRetirarPorAgencia,
                Destinatario = new Destinatario { NombreApellido = "Carla Ruiz", Dni = 33444555 },
                ClienteAsociado = new Cliente { Cuit = 30205869953, RazonSocial = "EnvasesArg" }
            }
        };

        public (bool valido, string error) ValidarIngresoDNI(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return (false, "Debe ingresar un DNI.");

            if (dni.Length < 7 || dni.Length > 8)
                return (false, "Se debe ingresar un numero de entre 7 a 8 digitos.");

            return (true, "");
        }

        public (bool valido, string error) ValidarDNI(int dni)
        {
            if (dni < 1_000_000 || dni > 99_999_999)
                return (false, "Se debe ingresar un numero de entre 7 a 8 digitos.");

            return (true, "");
        }

        public (Destinatario? destinatario, string error) BuscarDestinatario(int dni)
        {
            var resultadoDni = ValidarDNI(dni);
            if (!resultadoDni.valido)
                return (null, resultadoDni.error);

            var destinatario = Destinatarios.FirstOrDefault(d => d.Dni == dni);

            if (destinatario == null)
                return (null, "Destinatario no encontrado.");

            return (destinatario, "");
        }

        public List<Encomienda> ObtenerEncomiendasPorDni(int dni)
        {
            return Encomiendas
                .Where(e => e.Destinatario.Dni == dni)
                .ToList();
        }

        public (bool valido, string error) ConfirmarEntrega(int dni, long numeroGuia)
        {
            var resultadoDni = ValidarDNI(dni);
            if (!resultadoDni.valido)
                return resultadoDni;

            var encomienda = Encomiendas.FirstOrDefault(e => e.Destinatario.Dni == dni && e.NumeroGuia == numeroGuia);

            if (encomienda == null)
                return (false, "Debe indicar una encomienda.");

            if (encomienda.Estado == EstadoEncomienda.Entregado)
                return (false, "La encomienda ya fue entregada.");

            encomienda.Estado = EstadoEncomienda.Entregado;
            return (true, "");
        }

        public string ObtenerNombreEstado(EstadoEncomienda estado)
        {
            return estado switch
            {
                EstadoEncomienda.RecibidoCDDestino => "Recibido en CD destino",
                EstadoEncomienda.ListoParaRetirarPorCD => "Listo para retirar por CD",
                EstadoEncomienda.ListoParaRetirarPorAgencia => "Listo para retirar por Agencia",
                EstadoEncomienda.Entregado => "Entregado",
                _ => ""
            };
        }
    }
}

