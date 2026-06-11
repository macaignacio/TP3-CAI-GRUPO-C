using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.ConsultaCtaCteCliente
{
    internal class ConsultaCtaCteClienteModelo
    {
        public (Cliente? cliente, string error) ValidarCliente(long cuit)
        {
            if (cuit < 10_000_000_000 || cuit > 99_999_999_999)
                return (null, "CUIT invalido. Se debe ingresar un numero de 11 digitos sin guiones ni comas.");

            var cliente = ClienteAlmacen.clientes.FirstOrDefault(c => c.Cuit == cuit);

            if (cliente == null)
                return (null, "Cliente no encontrado.");

            return (MapearCliente(cliente), "");
        }

        public List<CtaCorriente> ObtenerCuentaCorrientePorCliente(long cuitCliente, DateTime periodo)
        {
            return CuentaCorrienteClienteAlmacen.ctaCteCliente
                .Where(m => m.Cuit == cuitCliente)
                .Where(m => m.Fecha.Year == periodo.Year && m.Fecha.Month == periodo.Month)
                .OrderBy(m => m.Fecha)
                .ThenBy(m => m.Comprobante)
                .Select(MapearMovimiento)
                .ToList();
        }

        private static Cliente MapearCliente(ClienteEntidad cliente)
        {
            return new Cliente
            {
                Cuit = cliente.Cuit,
                RazonSocial = cliente.RazonSocial
            };
        }

        private static CtaCorriente MapearMovimiento(CuentaCorrienteClienteEntidad movimiento)
        {
            return new CtaCorriente
            {
                Tipo = movimiento.TipoComprobante,
                Fecha = movimiento.Fecha,
                Vencimiento = CalcularVencimiento(movimiento),
                Comprobante = movimiento.Comprobante,
                Debe = movimiento.Debe,
                Haber = movimiento.Haber,
                Saldo = movimiento.Saldo
            };
        }

        private static DateTime CalcularVencimiento(CuentaCorrienteClienteEntidad movimiento)
        {
            if (movimiento.TipoComprobante.Equals("Factura", StringComparison.OrdinalIgnoreCase))
            {
                var factura = FacturaAlmacen.facturas
                    .FirstOrDefault(f => f.NumeroFactura == movimiento.Comprobante);

                return factura?.Vencimiento ?? movimiento.Fecha.AddDays(30);
            }

            return movimiento.Fecha;
        }
    }
}
