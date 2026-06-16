using TP3_CAI_GRUPO_C.Almacenes;
using TP3_CAI_GRUPO_C.Auxiliares;

namespace TP3_CAI_GRUPO_C.ImposiciónXCD
{
    internal class ImposicionXCDModelo
    {
        public string CodigoCDActual => Program.CDActual;

        public string[] Provincias =>
            ProvinciaAlmacen.provincias.Select(p => p.Nombre).ToArray();

        public string[] MetodosEntrega => Enum.GetValues<MetodoEntregaEnum>()
            .Select(ObtenerDescripcionMetodoEntrega)
            .ToArray();

        public (Cliente? cliente, string error) ValidarCliente(long cuit)
        {
            if (cuit < 10_000_000_000 || cuit > 99_999_999_999)
                return (null, "CUIT inválido. Se debe ingresar un número de 11 dígitos sin guiones ni comas.");

            var entidad = ClienteAlmacen.clientes.FirstOrDefault(c => c.Cuit == cuit);

            if (entidad == null)
                return (null, "Cliente no encontrado.");

            return (new Cliente { Cuit = entidad.Cuit, RazonSocial = entidad.RazonSocial }, "");
        }

        public string[] ObtenerLocalidadesPorProvincia(string provincia)
        {
            var entidad = ProvinciaAlmacen.provincias.FirstOrDefault(p => p.Nombre == provincia);

            if (entidad == null)
                return [];

            return LocalidadAlmacen.localidades
                .Where(l => entidad.Localidades.Contains(l.IDLocalidad))
                .Select(l => l.Descripcion)
                .ToArray();
        }

        public List<Sucursal> ObtenerSucursalesPorLocalidad(string localidad, string metodoEntrega)
        {
            var entidad = LocalidadAlmacen.localidades.FirstOrDefault(l => l.Descripcion == localidad);

            if (entidad == null)
                return [];

            var metodo = ObtenerMetodoEntrega(metodoEntrega);

            if (metodo == MetodoEntregaEnum.ADomicilio)
                return [];

            var centros = CentroDistribucionAlmacen.cd
                .Where(c => c.IdLocalidad == entidad.IDLocalidad)
                .ToList();

            var codigosCentros = centros.Select(c => c.Codigo).ToHashSet();

            var sucursalesCentros = centros.Select(c => new Sucursal
            {
                Codigo = c.Codigo,
                Direccion = c.Direccion,
                Horarios = c.Horarios,
                Tipo = ObtenerDescripcionMetodoEntrega(MetodoEntregaEnum.CentroDeDistribucion)
            });

            var sucursalesAgencias = AgenciaAlmacen.agencia
                .Where(a => codigosCentros.Contains(a.CentroDistribucion))
                .Select(a => new Sucursal
                {
                    Codigo = a.Codigo,
                    Direccion = a.Direccion,
                    Horarios = a.Horarios,
                    Tipo = ObtenerDescripcionMetodoEntrega(MetodoEntregaEnum.Agencia)
                });

            var sucursales = metodo == MetodoEntregaEnum.CentroDeDistribucion
                ? sucursalesCentros
                : sucursalesAgencias;

            return sucursales
                .OrderBy(s => s.Codigo)
                .ToList();
        }

        public bool ValidarCodigoPostal(int cp)
        {
            return cp >= 1000 && cp <= 9999;
        }

        public bool ValidarDireccion(string direccion)
        {
            return !string.IsNullOrWhiteSpace(direccion);
        }

        public (bool valido, string error) ValidarCajas(int s, int m, int l, int xl)
        {
            if (s < 0 || m < 0 || l < 0 || xl < 0)
                return (false, "Las cantidades de cajas no pueden ser negativas.");

            long totalCajas = s + m + l + xl;

            if (totalCajas == 0)
                return (false, "Debe ingresar al menos una caja.");

            long capacidadUsada = (s * 1L) + (m * 2L) + (l * 4L) + (xl * 8L);
            long capacidadMaxima = 20 * 8;

            if (capacidadUsada > capacidadMaxima)
                return (false, "La cantidad de cajas supera el máximo permitido.");

            return (true, "");
        }

        public (bool valido, string error) ValidarDNI(int dni)
        {
            if (dni < 1_000_000 || dni > 99_999_999)
                return (false, "DNI inválido. Se debe ingresar un número de entre 7 a 8 dí­gitos.");

            return (true, "");
        }

        public ResultadoImposicion GenerarImposicion(Imposicion imposicion)
        {
            imposicion.TipoImposicion = "CD";
            imposicion.CodigoCDOrigen = CodigoCDActual;

            var resultadoCliente = ValidarCliente(imposicion.CuitCliente);
            if (resultadoCliente.cliente == null)
                return new ResultadoImposicion { Valido = false, Error = resultadoCliente.error };

            if (ObtenerCentroDistribucionOrigen() == null)
                return new ResultadoImposicion { Valido = false, Error = "No se encontró el centro de distribución de origen." };

            if (string.IsNullOrWhiteSpace(imposicion.NombreDestinatario))
                return new ResultadoImposicion { Valido = false, Error = "El Nombre y Apellido de Destinatario no puede estar vacío." };

            var resultadoDNI = ValidarDNI(imposicion.DniDestinatario);
            if (!resultadoDNI.valido)
                return new ResultadoImposicion { Valido = false, Error = resultadoDNI.error };

            if (!MetodosEntrega.Contains(imposicion.MetodoEntrega))
                return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar un método de entrega." };

            var metodoEntrega = ObtenerMetodoEntrega(imposicion.MetodoEntrega);

            if (metodoEntrega == MetodoEntregaEnum.ADomicilio)
            {
                if (!Provincias.Contains(imposicion.ProvinciaDomicilio))
                    return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una provincia de entrega." };

                if (!ObtenerLocalidadesPorProvincia(imposicion.ProvinciaDomicilio).Contains(imposicion.LocalidadDomicilio))
                    return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una localidad de entrega válida." };

                if (!ValidarCodigoPostal(imposicion.CodigoPostalDomicilio))
                    return new ResultadoImposicion { Valido = false, Error = "El código postal de entrega debe ser un número de 4 dí­gitos." };

                if (ObtenerCentroDistribucionPorLocalidadYCodigoPostal(imposicion.LocalidadDomicilio, imposicion.CodigoPostalDomicilio) == null)
                    return new ResultadoImposicion { Valido = false, Error = "El código postal de entrega no corresponde a la localidad seleccionada o no tiene centro de distribución asignado." };

                if (!ValidarDireccion(imposicion.DireccionDomicilio))
                    return new ResultadoImposicion { Valido = false, Error = "La dirección de entrega no puede estar vacía." };
            }
            else
            {
                if (!Provincias.Contains(imposicion.ProvinciaSucursal))
                    return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una provincia de sucursal." };

                if (!ObtenerLocalidadesPorProvincia(imposicion.ProvinciaSucursal).Contains(imposicion.LocalidadSucursal))
                    return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una localidad de sucursal válida." };

                if (imposicion.SucursalSeleccionada == null)
                    return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una sucursal." };

                var sucursalValida = ObtenerSucursalesPorLocalidad(imposicion.LocalidadSucursal, imposicion.MetodoEntrega)
                    .Any(s => s.Codigo == imposicion.SucursalSeleccionada.Codigo);

                if (!sucursalValida)
                    return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una sucursal válida para la localidad elegida." };
            }

            var resultadoCajas = ValidarCajas(
                imposicion.CantidadCajaS,
                imposicion.CantidadCajaM,
                imposicion.CantidadCajaL,
                imposicion.CantidadCajaXL);

            if (!resultadoCajas.valido)
                return new ResultadoImposicion { Valido = false, Error = resultadoCajas.error };

            var guia = GenerarGuia(imposicion);
            var resultadoHojaDeRuta = PlanificarHojaDeRutaPosterior(guia);

            if (!resultadoHojaDeRuta.valido)
                return new ResultadoImposicion { Valido = false, Error = resultadoHojaDeRuta.error };

            GuiaAlmacen.guias.Add(guia);

            if (resultadoHojaDeRuta.hojaDeRutaOmnibusNueva)
                HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus.Add(resultadoHojaDeRuta.hojaDeRutaOmnibus!);

            if (resultadoHojaDeRuta.hojaDeRutaFleteroNueva)
                HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Add(resultadoHojaDeRuta.hojaDeRutaFletero!);

            GuiaAlmacen.Guardar();
            HojaDeRutaOmnibusAlmacen.Guardar();
            HojaDeRutaFleteroAlmacen.Guardar();

            return new ResultadoImposicion
            {
                Valido = true,
                Guía = new Guía
                {
                    NumeroGuia = guia.NumeroGuia,
                    EstadoActual = guia.EstadoActual.ToString(),
                    FechaHoraAlta = guia.FechaCreacion
                }
            };
        }

        private GuiaEntidad GenerarGuia(Imposicion imposicion)
        {
            var ahora = DateTime.Now;
            var metodoEntrega = ObtenerMetodoEntrega(imposicion.MetodoEntrega);
            var cdOrigen = ObtenerCentroDistribucionOrigen()!;
            var numeroGuia = GenerarNumeroGuia(cdOrigen.Codigo);

            string cdDestinoCodigo;
            string agenciaEntregaCodigo = "";
            string cdEntregaCodigo = "";
            string direccionEntrega;
            int cpEntrega;
            CentroDistribucionEntidad? cdDestino;

            if (metodoEntrega == MetodoEntregaEnum.ADomicilio)
            {
                cdDestino = ObtenerCentroDistribucionPorLocalidadYCodigoPostal(
                    imposicion.LocalidadDomicilio,
                    imposicion.CodigoPostalDomicilio);
                cdDestinoCodigo = cdDestino?.Codigo ?? "";
                direccionEntrega = imposicion.DireccionDomicilio;
                cpEntrega = imposicion.CodigoPostalDomicilio;
            }
            else if (metodoEntrega == MetodoEntregaEnum.CentroDeDistribucion)
            {
                cdDestinoCodigo = imposicion.SucursalSeleccionada!.Codigo;
                cdEntregaCodigo = imposicion.SucursalSeleccionada.Codigo;
                direccionEntrega = imposicion.SucursalSeleccionada.Direccion;
                cdDestino = CentroDistribucionAlmacen.cd.FirstOrDefault(c => c.Codigo == cdDestinoCodigo);
                cpEntrega = cdDestino?.CodPostal.FirstOrDefault() ?? 0;
            }
            else
            {
                var agencia = AgenciaAlmacen.agencia
                    .FirstOrDefault(a => a.Codigo == imposicion.SucursalSeleccionada!.Codigo);
                cdDestinoCodigo = agencia?.CentroDistribucion ?? "";
                agenciaEntregaCodigo = imposicion.SucursalSeleccionada!.Codigo;
                direccionEntrega = imposicion.SucursalSeleccionada.Direccion;
                cdDestino = CentroDistribucionAlmacen.cd.FirstOrDefault(c => c.Codigo == cdDestinoCodigo);
                cpEntrega = cdDestino?.CodPostal.FirstOrDefault() ?? 0;
            }

            var importe = CalcularImporte(imposicion, cdOrigen, cdDestino!, metodoEntrega);

            return new GuiaEntidad
            {
                NumeroGuia = numeroGuia,
                FechaCreacion = ahora,
                CuitCliente = imposicion.CuitCliente,
                Importe = importe,
                EstadoActual = EstadoEnum.AdmitidaEnCD,

                CentroDistribucionOrigen = cdOrigen.Codigo,
                CentroDistribucionDestino = cdDestinoCodigo,

                MetodoEntrega = metodoEntrega,
                AgenciaEntregaCodigo = agenciaEntregaCodigo,
                CentroDistribucionEntregaCodigo = cdEntregaCodigo,
                DireccionEntrega = direccionEntrega,
                CodPostalEntrega = cpEntrega,

                MetodoRetiro = MetodoRetiroEnum.CentroDeDistribución,
                AgenciaRetiroCodigo = "",
                CentroDistribucionRetiroCodigo = cdOrigen.Codigo,
                DireccionRetiro = cdOrigen.Direccion,
                CodPostalRetiro = cdOrigen.CodPostal.FirstOrDefault(),

                DniDestinatario = imposicion.DniDestinatario,
                NombreApellidoDestinatario = imposicion.NombreDestinatario,

                CajasS = imposicion.CantidadCajaS,
                CajasM = imposicion.CantidadCajaM,
                CajasL = imposicion.CantidadCajaL,
                CajasXL = imposicion.CantidadCajaXL,

                Historial = new List<MovimientoGuia>
                {
                    new MovimientoGuia
                    {
                        Estado = EstadoEnum.ImpuestaEnCD,
                        UltimaActualizacion = ahora,
                        Ubicacion = cdOrigen.Nombre
                    },
                    new MovimientoGuia
                    {
                        Estado = EstadoEnum.PendienteAdmision,
                        UltimaActualizacion = ahora,
                        Ubicacion = cdOrigen.Nombre
                    },
                    new MovimientoGuia
                    {
                        Estado = EstadoEnum.AdmitidaEnCD,
                        UltimaActualizacion = ahora,
                        Ubicacion = cdOrigen.Nombre
                    }
                }
            };
        }

        private static string GenerarNumeroGuia(string codigoOrigen)
        {
            var prefijo = $"{codigoOrigen}-";

            var ultimoNumero = GuiaAlmacen.guias
                .Where(g => g.NumeroGuia.StartsWith(prefijo))
                .Select(g =>
                {
                    var secuencial = g.NumeroGuia[prefijo.Length..];
                    return int.TryParse(secuencial, out var numero) ? numero : 0;
                })
                .DefaultIfEmpty(0)
                .Max();

            return $"{prefijo}{ultimoNumero + 1:00000000}";
        }

        private static (
            bool valido,
            string error,
            HojaDeRutaOmnibusEntidad? hojaDeRutaOmnibus,
            bool hojaDeRutaOmnibusNueva,
            HojaDeRutaFleteroEntidad? hojaDeRutaFletero,
            bool hojaDeRutaFleteroNueva) PlanificarHojaDeRutaPosterior(GuiaEntidad guia)
        {
            if (guia.CentroDistribucionOrigen != guia.CentroDistribucionDestino)
            {
                var resultadoOmnibus = GenerarHojaDeRutaOmnibus(guia);
                return (
                    resultadoOmnibus.hojaDeRuta != null,
                    resultadoOmnibus.error,
                    resultadoOmnibus.hojaDeRuta,
                    resultadoOmnibus.esNueva,
                    null,
                    false);
            }

            if (guia.MetodoEntrega == MetodoEntregaEnum.CentroDeDistribucion)
            {
                ActualizarEstado(guia, EstadoEnum.ListaParaEntregarPorCD, guia.CentroDistribucionDestino);
                return (true, "", null, false, null, false);
            }

            ActualizarEstado(guia, EstadoEnum.EnCDDestino, guia.CentroDistribucionDestino);

            var resultadoFletero = HojaDeRutaFleteroPlanificador.ObtenerHojaDeRutaEntregaDisponible(
                guia,
                GenerarCodigoHojaDeRutaDistribucion());

            return (
                resultadoFletero.hojaDeRuta != null,
                resultadoFletero.hojaDeRuta == null ? "No hay fleteros con cobertura para el centro de distribucion destino." : "",
                null,
                false,
                resultadoFletero.hojaDeRuta,
                resultadoFletero.esNueva);
        }

        private static void ActualizarEstado(GuiaEntidad guia, EstadoEnum estado, string codigoCentroDistribucion)
        {
            var ubicacion = CentroDistribucionAlmacen.cd
                .FirstOrDefault(c => c.Codigo == codigoCentroDistribucion)
                ?.Nombre ?? codigoCentroDistribucion;

            guia.EstadoActual = estado;
            guia.Historial ??= new List<MovimientoGuia>();
            guia.Historial.Add(new MovimientoGuia
            {
                Estado = estado,
                UltimaActualizacion = DateTime.Now,
                Ubicacion = ubicacion
            });
        }

        private static (HojaDeRutaOmnibusEntidad? hojaDeRuta, bool esNueva, string error) GenerarHojaDeRutaOmnibus(GuiaEntidad guia)
        {
            if (guia.EstadoActual != EstadoEnum.AdmitidaEnCD)
                return (null, false, "La guía no está en un estado válido para generar una hoja de ruta de ómnibus.");

            if (guia.CentroDistribucionOrigen == guia.CentroDistribucionDestino)
                return (null, false, "No corresponde generar hoja de ruta de ómnibus porque el origen y el destino son el mismo centro de distribución.");

            return HojaDeRutaOmnibusPlanificador.ObtenerHojaDeRutaDisponible(
                guia,
                GenerarCodigoHojaDeRutaOmnibus());
        }

        private static string GenerarCodigoHojaDeRutaOmnibus()
        {
            var periodo = DateTime.Now.ToString("yyyyMM");
            var prefijo = $"HDR-OMN-{periodo}-";

            var ultimoNumero = HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus
                .Where(h => h.Codigo.StartsWith(prefijo))
                .Select(h => int.TryParse(h.Codigo.Substring(prefijo.Length), out var numero) ? numero : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"{prefijo}{ultimoNumero + 1:0000}";
        }

        private static string GenerarCodigoHojaDeRutaDistribucion()
        {
            var periodo = DateTime.Now.ToString("yyyyMM");
            var prefijo = $"HDR-DIS-{periodo}-";

            var ultimoNumero = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                .Where(h => h.Codigo.StartsWith(prefijo))
                .Select(h => int.TryParse(h.Codigo.Substring(prefijo.Length), out var numero) ? numero : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"{prefijo}{ultimoNumero + 1:0000}";
        }

        private CentroDistribucionEntidad? ObtenerCentroDistribucionOrigen()
        {
            return CentroDistribucionAlmacen.cd.FirstOrDefault(c => c.Codigo == CodigoCDActual);
        }

        private static decimal CalcularImporte(
            Imposicion imposicion,
            CentroDistribucionEntidad cdOrigen,
            CentroDistribucionEntidad cdDestino,
            MetodoEntregaEnum metodoEntrega)
        {
            var importe = 0m;

            importe += imposicion.CantidadCajaS * ObtenerPrecioBulto("S", cdOrigen.IdLocalidad, cdDestino.IdLocalidad);
            importe += imposicion.CantidadCajaM * ObtenerPrecioBulto("M", cdOrigen.IdLocalidad, cdDestino.IdLocalidad);
            importe += imposicion.CantidadCajaL * ObtenerPrecioBulto("L", cdOrigen.IdLocalidad, cdDestino.IdLocalidad);
            importe += imposicion.CantidadCajaXL * ObtenerPrecioBulto("XL", cdOrigen.IdLocalidad, cdDestino.IdLocalidad);

            if (metodoEntrega == MetodoEntregaEnum.ADomicilio)
                importe += ObtenerPrecioExtra("EntregaDomicilio");
            else if (metodoEntrega == MetodoEntregaEnum.Agencia)
                importe += ObtenerPrecioExtra("EntregaAgencia");

            return importe;
        }

        private static decimal ObtenerPrecioBulto(string tamañoCaja, int idLocalidadOrigen, int idLocalidadDestino)
        {
            return PreciosBultosAlmacen.PreciosBultos
                .First(p =>
                    p.TamañoCaja == tamañoCaja &&
                    p.IdLocalidadOrigen == idLocalidadOrigen &&
                    p.IdLocalidadDestino == idLocalidadDestino)
                .Precio;
        }

        private static decimal ObtenerPrecioExtra(string tipo)
        {
            return PreciosExtrasAlmacen.PreciosExtras
                .First(e => e.Tipo == tipo)
                .Precio;
        }

        private static string ObtenerDescripcionMetodoEntrega(MetodoEntregaEnum metodoEntrega)
        {
            return metodoEntrega switch
            {
                MetodoEntregaEnum.ADomicilio => "A Domicilio",
                MetodoEntregaEnum.CentroDeDistribucion => "Centro de Distribución",
                MetodoEntregaEnum.Agencia => "Agencia",
                _ => metodoEntrega.ToString()
            };
        }

        private static MetodoEntregaEnum ObtenerMetodoEntrega(string metodoEntrega)
        {
            return Enum.GetValues<MetodoEntregaEnum>()
                .First(e => ObtenerDescripcionMetodoEntrega(e) == metodoEntrega);
        }

        private static CentroDistribucionEntidad? ObtenerCentroDistribucionPorLocalidadYCodigoPostal(string localidad, int codigoPostal)
        {
            var localidadEntidad = LocalidadAlmacen.localidades
                .FirstOrDefault(l => l.Descripcion == localidad);

            if (localidadEntidad == null || !localidadEntidad.CodigosPostales.Contains(codigoPostal))
                return null;

            return CentroDistribucionAlmacen.cd.FirstOrDefault(c =>
                c.IdLocalidad == localidadEntidad.IDLocalidad &&
                c.CodPostal.Contains(codigoPostal));
        }
    }
}
