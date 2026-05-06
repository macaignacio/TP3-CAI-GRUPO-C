using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    internal class FacturarClienteModelo
    {
        public (Cliente? cliente, string error) ValidarCliente(long cuit)
        {
            if (cuit < 10_000_000_000 || cuit > 99_999_999_999)
                return (null, "CUIT inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");

            var cliente = Clientes.FirstOrDefault(c => c.Cuit == cuit);

            if (cliente == null)
                return (null, "Cliente no encontrado.");

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

        private Dictionary<string, List<Factura>> FacturasPorCliente { get; } = new()
        {
            {
                "EnvasesArg",
                [
                    new Factura { Fecha = new DateTime(2024, 12, 2), Descripcion = "Entrega encomienda XL", NumeroGuia = 1001, Monto = 25000, Subtotal = 18000 },
                    new Factura { Fecha = new DateTime(2025, 3, 17), Descripcion = "Entrega encomienda M", NumeroGuia = 1002, Monto = 15000, Subtotal = 12000 },
                    new Factura { Fecha = new DateTime(2025, 6, 28), Descripcion = "Entrega encomienda S", NumeroGuia = 1003, Monto = 10000, Subtotal = 8000 },
                ]
            },
            {
                "RepuestosCorSA",
                [
                    new Factura { Fecha = new DateTime(2023, 1, 14), Descripcion = "Entrega encomienda S", NumeroGuia = 2001, Monto = 6000, Subtotal = 5000 },
                    new Factura { Fecha = new DateTime(2024, 10, 10), Descripcion = "Entrega encomienda XL", NumeroGuia = 2002, Monto = 18000, Subtotal = 14000 },
                    new Factura { Fecha = new DateTime(2026, 4, 3), Descripcion = "Entrega encomienda L", NumeroGuia = 2003, Monto = 20000, Subtotal = 15000 },
                ]
            },
            {
                "TecnologiaHoy",
                [
                    new Factura { Fecha = new DateTime(2025, 7, 12), Descripcion = "Entrega encomienda M", NumeroGuia = 3001, Monto = 25000, Subtotal = 18000 },
                    new Factura { Fecha = new DateTime(2025, 11, 30), Descripcion = "Entrega encomienda XL", NumeroGuia = 3002, Monto = 24000, Subtotal = 17500 },
                    new Factura { Fecha = new DateTime(2026, 3, 16), Descripcion = "Entrega encomienda L", NumeroGuia = 3003, Monto = 21000, Subtotal = 16500 },
                ]
            },
        };

        public List<Factura> ObtenerFacturasPorCliente(string cliente)
        {
            return FacturasPorCliente.TryGetValue(cliente, out var facturas)
                ? facturas
                : [];
        }
        /*
        public FacturarClienteModelo Ejemplo()
        {
            //Ejemplo de datos precargados
            clientes[10500900700] = new Cliente
            {
                Fecha = new DateTime(2024, 12, 2),
                Descripcion = "Entrega encomienda XL",
                NumeroGuia = 890,
                Monto = 25000,
                Subtotal = 18000,
            };
        }*/
    }
}
