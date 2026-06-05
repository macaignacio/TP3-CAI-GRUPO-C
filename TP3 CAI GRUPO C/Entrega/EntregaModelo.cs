using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.Entrega
{
    internal class EntregaModelo
    {
        public List<Destinatario> Destinatarios { get; } = new List<Destinatario>();

        public List<Encomienda> Encomiendas { get; } = new List<Encomienda>();

        public EntregaModelo()
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            Encomiendas.Clear();
            Destinatarios.Clear();

            foreach (var guia in GuiaAlmacen.guias)
            {
                var estado = ObtenerEstadoEntrega(guia.EstadoActual);

                if (estado == null)
                    continue;

                var destinatario = new Destinatario
                {
                    NombreApellido = guia.NombreApellidoDestinatario,
                    Dni = guia.DniDestinatario
                };

                Encomiendas.Add(new Encomienda
                {
                    NumeroGuia = guia.NumeroGuia,
                    Estado = estado.Value,
                    Destinatario = destinatario,
                    ClienteAsociado = ObtenerClienteAsociado(guia.CuitCliente)
                });
            }

            Destinatarios.AddRange(Encomiendas
                .Select(e => e.Destinatario)
                .GroupBy(d => d.Dni)
                .Select(g => g.First()));
        }

        private Cliente ObtenerClienteAsociado(long cuit)
        {
            var cliente = ClienteAlmacen.clientes.FirstOrDefault(c => c.Cuit == cuit);

            return new Cliente
            {
                Cuit = cuit,
                RazonSocial = cliente?.RazonSocial ?? ""
            };
        }

        private EstadoEncomienda? ObtenerEstadoEntrega(EstadoEnum estado)
        {
            return estado switch
            {
                EstadoEnum.EnCDDestino => EstadoEncomienda.RecibidoCDDestino,
                EstadoEnum.ListaParaEntregarPorCD => EstadoEncomienda.ListoParaRetirarPorCD,
                EstadoEnum.ListaParaEntregarPorAgencia => EstadoEncomienda.ListoParaRetirarPorAgencia,
                EstadoEnum.Entregado => EstadoEncomienda.Entregado,
                _ => null
            };
        }

        public (bool valido, string error) ValidarIngresoDNI(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return (false, "Debe ingresar un DNI.");

            if (!dni.All(char.IsDigit))
                return (false, "Debe ingresar un valor numerico.");

            if (dni.Length < 7 || dni.Length > 8)
                return (false, "Debe ingresar un valor numerico de 7 a 8 digitos. Por ejemplo: 42830416");

            return (true, "");
        }

        public (bool valido, string error) ValidarDNI(int dni)
        {
            if (dni < 1_000_000 || dni > 99_999_999)
                return (false, "Debe ingresar un valor numerico de 7 a 8 digitos. Por ejemplo: 42830416");

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
            var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.DniDestinatario == dni && g.NumeroGuia == numeroGuia);

            if (guia != null)
            {
                guia.EstadoActual = EstadoEnum.Entregado;
                guia.Historial ??= new List<MovimientoGuia>();
                guia.Historial.Add(new MovimientoGuia
                {
                    Estado = EstadoEnum.Entregado,
                    UltimaActualizacion = DateTime.Now,
                    Ubicacion = guia.DireccionEntrega
                });
                GuiaAlmacen.Guardar();
            }

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

