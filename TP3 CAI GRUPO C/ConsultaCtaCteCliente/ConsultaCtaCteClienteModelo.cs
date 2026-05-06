using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.ConsultaCtaCteCliente
{
    internal class ConsultaCtaCteClienteModelo
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


        //Datos de Pruebareturn new List<Cliente>
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

        private Dictionary<string, List<CtaCorriente>> CuentasCorrientesPorCliente { get; } = new()
        {
            {
                "EnvasesArg",
                [
                    new CtaCorriente {
                        Tipo = "Factura",
                        Fecha = new DateTime(2024, 12, 2),
                        Vencimiento = new DateTime(2025, 1, 1),
                        Comprobante = "A-0001-00001527",
                        Debe = 25000,
                        Haber = 0,
                        Saldo = 25000
                    },
                    new CtaCorriente {
                        Tipo = "Recibo",
                        Fecha = new DateTime(2024, 12, 20),
                        Vencimiento = new DateTime(2024, 12, 20),
                        Comprobante = "1527",
                        Debe = 0,
                        Haber = 15000,
                        Saldo = 10000
                    },
                    new CtaCorriente {
                        Tipo = "Factura",
                        Fecha = new DateTime(2025, 3, 17),
                        Vencimiento = new DateTime(2025, 4, 16),
                        Comprobante = "A-0001-00001529",
                        Debe = 15000,
                        Haber = 0,
                        Saldo = 25000
                    },
                    new CtaCorriente {
                        Tipo = "Factura",
                        Fecha = new DateTime(2025, 6, 28),
                        Vencimiento = new DateTime(2025, 7, 28),
                        Comprobante = "A-0002-00057727",
                        Debe = 10000,
                        Haber = 0,
                        Saldo = 35000
                    }
                ]
            },
            {
                "RepuestosCorSA",
                [
                    new CtaCorriente {
                        Tipo = "Factura",
                        Fecha = new DateTime(2023, 1, 14),
                        Vencimiento = new DateTime(2023, 2, 13),
                        Comprobante = "A-0001-00002001",
                        Debe = 6000,
                        Haber = 0,
                        Saldo = 6000
                    },
                    new CtaCorriente {
                        Tipo = "Recibo",
                        Fecha = new DateTime(2023, 1, 30),
                        Vencimiento = new DateTime(2023, 1, 30),
                        Comprobante = "2001",
                        Debe = 0,
                        Haber = 6000,
                        Saldo = 0
                    },
                    new CtaCorriente {
                        Tipo = "Factura",
                        Fecha = new DateTime(2024, 10, 10),
                        Vencimiento = new DateTime(2024, 11, 9),
                        Comprobante = "A-0003-00001728",
                        Debe = 18000,
                        Haber = 0,
                        Saldo = 18000
                    },
                    new CtaCorriente {
                        Tipo = "Factura",
                        Fecha = new DateTime(2026, 4, 3),
                        Vencimiento = new DateTime(2026, 5, 3),
                        Comprobante = "A-0004-00001729",
                        Debe = 20000,
                        Haber = 0,
                        Saldo = 38000
                    }
                ]
            },
            {
                "TecnologiaHoy",
                [
                    new CtaCorriente {
                        Tipo = "Factura",
                        Fecha = new DateTime(2025, 7, 12),
                        Vencimiento = new DateTime(2025, 8, 11),
                        Comprobante = "A-0001-00003001",
                        Debe = 25000,
                        Haber = 0,
                        Saldo = 25000
                    },
                    new CtaCorriente {
                        Tipo = "Recibo",
                        Fecha = new DateTime(2025, 8, 5),
                        Vencimiento = new DateTime(2025, 8, 5),
                        Comprobante = "3001",
                        Debe = 0,
                        Haber = 10000,
                        Saldo = 15000
                    },
                    new CtaCorriente {
                        Tipo = "Factura",
                        Fecha = new DateTime(2025, 11, 30),
                        Vencimiento = new DateTime(2025, 12, 30),
                        Comprobante = "A-0002-00003002",
                        Debe = 24000,
                        Haber = 0,
                        Saldo = 39000
                    },
                    new CtaCorriente {
                        Tipo = "Factura",
                        Fecha = new DateTime(2026, 3, 16),
                        Vencimiento = new DateTime(2026, 4, 15),
                        Comprobante = "A-0003-00003003",
                        Debe = 21000,
                        Haber = 0,
                        Saldo = 60000
                    }
                ]
            },
        };

        public List<CtaCorriente> ObtenerCuentaCorrientePorCliente(string cliente, DateTime periodo)
        {
            if (!CuentasCorrientesPorCliente.TryGetValue(cliente, out var movimientos))
                return [];

            return movimientos
                .Where(m => m.Fecha.Year == periodo.Year && m.Fecha.Month == periodo.Month)
                .ToList();
        }
    }
}
