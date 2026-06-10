using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.FacturarCliente
{
    internal class FacturarClienteModelo
    {
        private const string PrefijoFactura = "A-0001-";

        public List<Servicio> ServiciosCargados { get; } = new List<Servicio>();

        public decimal TotalCalculado { get; private set; }

        public (Cliente? cliente, string error) ValidarCliente(long cuit)
        {
            if (cuit < 10_000_000_000 || cuit > 99_999_999_999)
                return (null, "El CUIT debe tener 11 dígitos");

            var cliente = ClienteAlmacen.clientes.FirstOrDefault(c => c.Cuit == cuit);

            if (cliente == null)
                return (null, "Cliente no encontrado");

            return (MapearCliente(cliente), "");
        }

        public List<Cliente> Clientes => ClienteAlmacen.clientes
            .Select(MapearCliente)
            .ToList();

        public List<Servicio> ObtenerFacturasPorCliente(string cliente)
        {
            var clienteEntidad = ClienteAlmacen.clientes
                .FirstOrDefault(c => c.RazonSocial == cliente);

            if (clienteEntidad == null)
                return [];

            return ObtenerGuiasPendientesDelMes(clienteEntidad.Cuit)
                .Select(MapearServicio)
                .OrderBy(s => s.Fecha)
                .ToList();
        }

        public void CargarServiciosFacturados(string cliente)
        {
            var servicios = ObtenerFacturasPorCliente(cliente);
            var resultado = CalcularFacturacion(new FacturacionCliente
            {
                Servicios = servicios
            });

            ServiciosCargados.Clear();
            ServiciosCargados.AddRange(resultado.facturas);
            TotalCalculado = resultado.total;
        }

        public void LimpiarServiciosCargados()
        {
            ServiciosCargados.Clear();
            TotalCalculado = 0;
        }

        public (List<Servicio> facturas, decimal total) CalcularFacturacion(
            FacturacionCliente facturacion)
        {
            decimal total = 0;
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

            var numerosSeleccionados = facturacion.Servicios
                .Select(s => s.NumeroGuia)
                .ToHashSet();

            var guiasVigentes = ObtenerGuiasPendientesDelMes(facturacion.CuitCliente)
                .Where(g => numerosSeleccionados.Contains(g.NumeroGuia))
                .ToList();

            if (guiasVigentes.Count != numerosSeleccionados.Count)
            {
                return new ResultadoFactura
                {
                    Valido = false,
                    Error = "Una o más guías ya fueron facturadas o no pertenecen al período actual."
                };
            }

            var serviciosVigentes = guiasVigentes
                .Select(MapearServicio)
                .OrderBy(s => s.Fecha)
                .ToList();

            var resultadoFacturacion = CalcularFacturacion(new FacturacionCliente
            {
                CuitCliente = facturacion.CuitCliente,
                RazonSocial = resultadoCliente.cliente.RazonSocial,
                Servicios = serviciosVigentes
            });

            var fechaEmision = DateTime.Now;
            var numeroFactura = GenerarNumeroFactura();
            var facturaEntidad = new FacturaEntidad
            {
                NumeroFactura = numeroFactura,
                CuitCliente = facturacion.CuitCliente,
                FechaEmision = fechaEmision,
                Total = resultadoFacturacion.total,
                Vencimiento = fechaEmision.AddDays(10),
                Guias = resultadoFacturacion.facturas
                    .Select(s => s.NumeroGuia)
                    .ToList()
            };

            FacturaAlmacen.facturas.Add(facturaEntidad);
            FacturaAlmacen.Guardar();

            CuentaCorrienteClienteAlmacen.ctaCteCliente.Add(
                CrearMovimientoCuentaCorriente(facturaEntidad));
            CuentaCorrienteClienteAlmacen.Guardar();

            var factura = new Factura
            {
                NumeroFactura = numeroFactura,
                CuitCliente = facturacion.CuitCliente,
                RazonSocial = resultadoCliente.cliente.RazonSocial,
                FechaEmision = fechaEmision,
                Servicios = resultadoFacturacion.facturas,
                Total = resultadoFacturacion.total
            };

            return new ResultadoFactura
            {
                Valido = true,
                Factura = factura
            };
        }

        private static List<GuiaEntidad> ObtenerGuiasPendientesDelMes(long cuitCliente)
        {
            var hoy = DateTime.Now;
            var guiasFacturadas = FacturaAlmacen.facturas
                .SelectMany(f => f.Guias ?? [])
                .ToHashSet();

            return GuiaAlmacen.guias
                .Where(g => g.CuitCliente == cuitCliente)
                .Where(g => g.EstadoActual == EstadoEnum.Entregado)
                .Where(g => !guiasFacturadas.Contains(g.NumeroGuia))
                .Where(g =>
                {
                    var fechaEntrega = ObtenerFechaEntrega(g);
                    return fechaEntrega.HasValue
                        && fechaEntrega.Value.Year == hoy.Year
                        && fechaEntrega.Value.Month == hoy.Month;
                })
                .ToList();
        }

        private static Servicio MapearServicio(GuiaEntidad guia)
        {
            return new Servicio
            {
                Fecha = ObtenerFechaEntrega(guia)!.Value,
                Descripcion = ObtenerDescripcion(guia.MetodoEntrega),
                NumeroGuia = guia.NumeroGuia,
                Monto = guia.Importe,
                Subtotal = 0
            };
        }

        private static DateTime? ObtenerFechaEntrega(GuiaEntidad guia)
        {
            return guia.Historial?
                .Where(m => m.Estado == EstadoEnum.Entregado)
                .OrderByDescending(m => m.UltimaActualizacion)
                .Select(m => (DateTime?)m.UltimaActualizacion)
                .FirstOrDefault();
        }

        private static string ObtenerDescripcion(MetodoEntregaEnum metodoEntrega)
        {
            return metodoEntrega switch
            {
                MetodoEntregaEnum.ADomicilio => "Entrega de encomienda a domicilio",
                MetodoEntregaEnum.CentroDeDistribucion => "Entrega de encomienda en CD",
                MetodoEntregaEnum.Agencia => "Entrega de encomienda en Agencia",
                _ => "Entrega de encomienda"
            };
        }

        private static CuentaCorrienteClienteEntidad CrearMovimientoCuentaCorriente(
            FacturaEntidad factura)
        {
            var saldoAnterior = CuentaCorrienteClienteAlmacen.ctaCteCliente
                .Where(m => m.Cuit == factura.CuitCliente)
                .Sum(m => m.Debe - m.Haber);

            return new CuentaCorrienteClienteEntidad
            {
                Cuit = factura.CuitCliente,
                TipoComprobante = "Factura",
                Fecha = factura.FechaEmision,
                Comprobante = factura.NumeroFactura,
                Debe = factura.Total,
                Haber = 0,
                Saldo = saldoAnterior + factura.Total
            };
        }

        private static Cliente MapearCliente(ClienteEntidad cliente)
        {
            return new Cliente
            {
                Cuit = cliente.Cuit,
                RazonSocial = cliente.RazonSocial
            };
        }

        private static string GenerarNumeroFactura()
        {
            var numerosFacturas = FacturaAlmacen.facturas
                .Select(f => f.NumeroFactura)
                .Concat(CuentaCorrienteClienteAlmacen.ctaCteCliente
                    .Where(m => m.TipoComprobante.Equals(
                        "Factura",
                        StringComparison.OrdinalIgnoreCase))
                    .Select(m => m.Comprobante));

            var ultimoNumero = numerosFacturas
                .Where(n => !string.IsNullOrWhiteSpace(n) && n.StartsWith(PrefijoFactura))
                .Select(n => int.TryParse(n[PrefijoFactura.Length..], out var numero)
                    ? numero
                    : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"{PrefijoFactura}{ultimoNumero + 1:00000000}";
        }
    }
}
