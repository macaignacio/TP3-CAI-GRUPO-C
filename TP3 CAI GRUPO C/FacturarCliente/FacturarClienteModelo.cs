using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    internal class FacturarClienteModelo
    {
        private int ProximoNumeroFactura { get; set; } = 2001;

        private List<Factura> FacturasEmitidas { get; } = new List<Factura>();

        public (Cliente? cliente, string error) ValidarCliente(long cuit)
        {
            if (cuit < 10_000_000_000 || cuit > 99_999_999_999)
                return (null, "El CUIT debe tener 11 dígitos");

            var cliente = Clientes.FirstOrDefault(c => c.Cuit == cuit);

            if (cliente == null)
                return (null, "Cliente no encontrado");

            return (cliente, "");
        }

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

        private Dictionary<string, List<Servicio>> FacturasPorCliente { get; } = new()
        {
            {
                "EnvasesArg",
                [
                    new Servicio { Fecha = new DateTime(2024, 12, 2), Descripcion = "Entrega encomienda XL", NumeroGuia = 20241202090000001, Monto = 25000, Subtotal = 25000 },
                    new Servicio { Fecha = new DateTime(2025, 3, 17), Descripcion = "Entrega encomienda M", NumeroGuia = 20250317103000002, Monto = 15000, Subtotal = 40000 },
                    new Servicio { Fecha = new DateTime(2025, 6, 28), Descripcion = "Entrega encomienda S", NumeroGuia = 20250628114500003, Monto = 10000, Subtotal = 50000 },
                ]
            },
            {
                "RepuestosCorSA",
                [
                    new Servicio { Fecha = new DateTime(2023, 1, 14), Descripcion = "Entrega encomienda S", NumeroGuia = 20230114091500004, Monto = 6000, Subtotal = 6000 },
                    new Servicio { Fecha = new DateTime(2024, 10, 10), Descripcion = "Entrega encomienda XL", NumeroGuia = 20241010110000005, Monto = 18000, Subtotal = 24000 },
                    new Servicio { Fecha = new DateTime(2026, 4, 3), Descripcion = "Entrega encomienda L", NumeroGuia = 20260403123000006, Monto = 20000, Subtotal = 44000 },
                ]
            },
            {
                "TecnologiaHoy",
                [
                    new Servicio { Fecha = new DateTime(2025, 7, 12), Descripcion = "Entrega encomienda M", NumeroGuia = 20250712094500007, Monto = 25000, Subtotal = 25000 },
                    new Servicio { Fecha = new DateTime(2025, 11, 30), Descripcion = "Entrega encomienda XL", NumeroGuia = 20251130131500008, Monto = 24000, Subtotal = 49000 },
                    new Servicio { Fecha = new DateTime(2026, 3, 16), Descripcion = "Entrega encomienda L", NumeroGuia = 20260316160000009, Monto = 21000, Subtotal = 70000 },
                ]
            },
        };

        public List<Servicio> ObtenerFacturasPorCliente(string cliente)
        {
            return FacturasPorCliente.TryGetValue(cliente, out var facturas)
                ? facturas
                : [];
        }

        public (List<Servicio> facturas, int total) CalcularFacturacion(FacturacionCliente facturacion)
        {
            int total = 0;
            var facturasCalculadas = new List<Servicio>();

            foreach (var factura in facturacion.Servicios)
            {
                total += factura.Monto;

                facturasCalculadas.Add(new Servicio
                {
                    Fecha = factura.Fecha,
                    Descripcion = factura.Descripcion,
                    NumeroGuia = factura.NumeroGuia,
                    Monto = factura.Monto,
                    Subtotal = total
                });
            }

            return (facturasCalculadas, total);
        }

        public ResultadoFactura EmitirFactura(FacturacionCliente facturacion)
        {
            var resultadoCliente = ValidarCliente(facturacion.CuitCliente);
            if (resultadoCliente.cliente == null)
                return new ResultadoFactura { Valido = false, Error = resultadoCliente.error };

            if (facturacion.Servicios.Count == 0)
                return new ResultadoFactura { Valido = false, Error = "No hay servicios para facturar." };

            var resultadoFacturacion = CalcularFacturacion(facturacion);

            var factura = new Factura
            {
                NumeroFactura = GenerarNumeroFactura(),
                CuitCliente = facturacion.CuitCliente,
                RazonSocial = resultadoCliente.cliente.RazonSocial,
                FechaEmision = DateTime.Now,
                Servicios = resultadoFacturacion.facturas,
                Total = resultadoFacturacion.total
            };

            FacturasEmitidas.Add(factura);

            return new ResultadoFactura
            {
                Valido = true,
                Factura = factura
            };
        }

        private string GenerarNumeroFactura()
        {
            var numeroFactura = $"001-{ProximoNumeroFactura:000000}";
            ProximoNumeroFactura++;

            return numeroFactura;
        }
    }
}
