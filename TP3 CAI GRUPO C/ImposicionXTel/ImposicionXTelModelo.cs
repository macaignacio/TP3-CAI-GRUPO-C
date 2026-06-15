using System;
using System.Collections.Generic;
using System.Linq;
using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.ImposicionXTel
{
    internal class ImposicionXTelModelo
    {        
        public string[] MetodosEntrega => Enum.GetValues<MetodoEntregaEnum>()

            .Select(ObtenerDescripcionMetodoEntrega)
            .ToArray();

        public string[] Provincias =>
            ProvinciaAlmacen.provincias.Select(p => p.Nombre).ToArray();

        public (Cliente? cliente, string error) ValidarCliente(long cuit)
        {
            if (cuit < 10_000_000_000 || cuit > 99_999_999_999)
                return (null, "CUIT inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");

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
                return (false, "DNI inválido. Se debe ingresar un número de entre 7 a 8 dígitos.");

            return (true, "");
        }

        public ResultadoImposicion GenerarImposicion(Imposicion imposicion)
        {
            var resultadoCliente = ValidarCliente(imposicion.CuitCliente);
            if (resultadoCliente.cliente == null)
                return new ResultadoImposicion { Valido = false, Error = resultadoCliente.error };

            if (string.IsNullOrWhiteSpace(imposicion.NombreDestinatario))
                return new ResultadoImposicion { Valido = false, Error = "El Nombre y Apellido de Destinatario no puede estar vacío." };

            var resultadoDNI = ValidarDNI(imposicion.DniDestinatario);
            if (!resultadoDNI.valido)
                return new ResultadoImposicion { Valido = false, Error = resultadoDNI.error };

            if (!Provincias.Contains(imposicion.ProvinciaRetiro))
                return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una provincia de retiro." };

            if (!ObtenerLocalidadesPorProvincia(imposicion.ProvinciaRetiro).Contains(imposicion.LocalidadRetiro))
                return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una localidad de retiro válida." };

            if (!ValidarCodigoPostal(imposicion.CodigoPostalRetiro))
                return new ResultadoImposicion { Valido = false, Error = "El código postal de retiro debe ser un número de 4 dígitos." };

            var centroDistribucionRetiro = ObtenerCentroDistribucionPorLocalidadYCodigoPostal(
                imposicion.LocalidadRetiro,
                imposicion.CodigoPostalRetiro);

            if (centroDistribucionRetiro == null)
                return new ResultadoImposicion { Valido = false, Error = "El codigo postal de retiro no corresponde a la localidad seleccionada o no tiene centro de distribucion asignado." };

            if (!ValidarDireccion(imposicion.DireccionRetiro))
                return new ResultadoImposicion { Valido = false, Error = "La dirección de retiro no puede estar vacía." };

            if (!MetodosEntrega.Contains(imposicion.MetodoEntrega))
                return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar un método de entrega." };

            var metodoEntrega = ObtenerMetodoEntrega(imposicion.MetodoEntrega);

            if (metodoEntrega == MetodoEntregaEnum.ADomicilio)
            {
                if (!Provincias.Contains(imposicion.ProvinciaEnvio))
                    return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una provincia de entrega." };

                if (!ObtenerLocalidadesPorProvincia(imposicion.ProvinciaEnvio).Contains(imposicion.LocalidadEnvio))
                    return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar una localidad de entrega válida." };

                if (!ValidarCodigoPostal(imposicion.CodigoPostalEnvio))
                    return new ResultadoImposicion { Valido = false, Error = "El código postal de entrega debe ser un número de 4 dígitos." };

                if (ObtenerCentroDistribucionPorLocalidadYCodigoPostal(imposicion.LocalidadEnvio, imposicion.CodigoPostalEnvio) == null)
                    return new ResultadoImposicion { Valido = false, Error = "El codigo postal de entrega no corresponde a la localidad seleccionada o no tiene centro de distribucion asignado." };

                if (!ValidarDireccion(imposicion.DireccionEnvio))
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

            var centroDistribucionOrigen = ObtenerCentroDistribucionOrigen();
            if (centroDistribucionOrigen == null)
                return new ResultadoImposicion { Valido = false, Error = "Debe seleccionar un centro de distribucion actual valido." };

            if (centroDistribucionRetiro.Codigo != centroDistribucionOrigen.Codigo)
                return new ResultadoImposicion { Valido = false, Error = "El centro de distribucion actual no corresponde a la localidad y codigo postal de retiro." };

            var guia = GenerarGuía(imposicion);
            var resultadoHojaDeRuta = GenerarHojaDeRutaRetiro(guia);

            if (resultadoHojaDeRuta.hojaDeRuta == null)
                return new ResultadoImposicion { Valido = false, Error = resultadoHojaDeRuta.error };

            GuiaAlmacen.guias.Add(guia);
            HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Add(resultadoHojaDeRuta.hojaDeRuta);

            GuiaAlmacen.Guardar();
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

        private GuiaEntidad GenerarGuía(Imposicion imposicion)
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
                    imposicion.LocalidadEnvio,
                    imposicion.CodigoPostalEnvio);
                cdDestinoCodigo = cdDestino?.Codigo ?? "";
                direccionEntrega = imposicion.DireccionEnvio;
                cpEntrega = imposicion.CodigoPostalEnvio;
            }
            else if (metodoEntrega == MetodoEntregaEnum.CentroDeDistribucion)
            {
                cdDestinoCodigo = imposicion.SucursalSeleccionada!.Codigo;
                cdEntregaCodigo = imposicion.SucursalSeleccionada.Codigo;
                direccionEntrega = imposicion.SucursalSeleccionada.Direccion;
                cpEntrega = 0;
                cdDestino = CentroDistribucionAlmacen.cd
                    .FirstOrDefault(c => c.Codigo == cdDestinoCodigo);
            }
            else // Agencia
            {
                var agencia = AgenciaAlmacen.agencia
                    .FirstOrDefault(a => a.Codigo == imposicion.SucursalSeleccionada!.Codigo);
                cdDestinoCodigo = agencia?.CentroDistribucion ?? "";
                agenciaEntregaCodigo = imposicion.SucursalSeleccionada!.Codigo;
                direccionEntrega = imposicion.SucursalSeleccionada.Direccion;
                cpEntrega = 0;
                cdDestino = CentroDistribucionAlmacen.cd
                    .FirstOrDefault(c => c.Codigo == cdDestinoCodigo);
            }

            var importe = CalcularImporte(imposicion, cdOrigen!, cdDestino!, metodoEntrega);

            return new GuiaEntidad
            {
                NumeroGuia = numeroGuia,
                FechaCreacion = ahora,
                CuitCliente = imposicion.CuitCliente,
                Importe = importe,
                EstadoActual = EstadoEnum.ImpuestaTelefonicamente,

                CentroDistribucionOrigen = cdOrigen.Codigo,
                CentroDistribucionDestino = cdDestinoCodigo,

                MetodoEntrega = metodoEntrega,
                AgenciaEntregaCodigo = agenciaEntregaCodigo,
                CentroDistribucionEntregaCodigo = cdEntregaCodigo,
                DireccionEntrega = direccionEntrega,
                CodPostalEntrega = cpEntrega,

                MetodoRetiro = MetodoRetiroEnum.EnDomicilio,
                AgenciaRetiroCodigo = "",
                CentroDistribucionRetiroCodigo = cdOrigen.Codigo,
                DireccionRetiro = imposicion.DireccionRetiro,
                CodPostalRetiro = imposicion.CodigoPostalRetiro,

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
                        Estado = EstadoEnum.ImpuestaTelefonicamente,
                        UltimaActualizacion = ahora,
                        Ubicacion = imposicion.DireccionRetiro
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

        private static (HojaDeRutaFleteroEntidad? hojaDeRuta, string error) GenerarHojaDeRutaRetiro(GuiaEntidad guia)
        {
            if (!PuedeGenerarHojaDeRutaFletero(guia.EstadoActual))
                return (null, "La guía no está en un estado válido para generar una hoja de ruta de fletero.");

            var centroDistribucion = CentroDistribucionAlmacen.cd
                .FirstOrDefault(c => c.Codigo == guia.CentroDistribucionRetiroCodigo);

            if (centroDistribucion == null)
                return (null, "No se encontró el centro de distribución de origen para asignar el retiro.");

            var fletero = ObtenerFleteroConMenorCarga(centroDistribucion);

            if (fletero == null)
                return (null, "No hay fleteros con cobertura para el centro de distribución de origen.");

            return (new HojaDeRutaFleteroEntidad
            {
                Codigo = GenerarCodigoHojaDeRutaRetiro(),
                CentroDistribucion = centroDistribucion.Codigo,
                CuitCuilFletero = fletero.CuitCuilFletero,
                TipoHDR = TipoHDRFleteroEnum.Retiro,
                Estado = EstadoHDRFleteroEnum.Asignada,
                Guias = new List<string> { guia.NumeroGuia }
            }, "");
        }

        private static bool PuedeGenerarHojaDeRutaFletero(EstadoEnum estado)
        {
            return estado == EstadoEnum.ImpuestaTelefonicamente ||
                   estado == EstadoEnum.ImpuestaEnAgencia ||
                   estado == EstadoEnum.EnCDDestino;
        }

        private static FleteroEntidad? ObtenerFleteroConMenorCarga(CentroDistribucionEntidad centroDistribucion)
        {
            var fleterosConCobertura = FleteroAlmacen.fleteros
                .Where(f => centroDistribucion.Fleteros.Contains(f.CuitCuilFletero))
                .ToList();

            if (fleterosConCobertura.Count == 0)
                return null;

            return fleterosConCobertura
                .OrderBy(f => ContarHojasDeRutaRetiroAsignadas(centroDistribucion.Codigo, f.CuitCuilFletero))
                .ThenBy(f => centroDistribucion.Fleteros.IndexOf(f.CuitCuilFletero))
                .First();
        }

        private static int ContarHojasDeRutaRetiroAsignadas(string codigoCentroDistribucion, long cuitCuilFletero)
        {
            return HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Count(h =>
                h.CentroDistribucion == codigoCentroDistribucion &&
                h.CuitCuilFletero == cuitCuilFletero &&
                h.TipoHDR == TipoHDRFleteroEnum.Retiro &&
                h.Estado == EstadoHDRFleteroEnum.Asignada);
        }

        private static string GenerarCodigoHojaDeRutaRetiro()
        {
            var periodo = DateTime.Now.ToString("yyyyMM");
            var prefijo = $"HDR-RET-{periodo}-";

            var ultimoNumero = HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros
                .Where(h => h.Codigo.StartsWith(prefijo))
                .Select(h => int.TryParse(h.Codigo.Substring(prefijo.Length), out var numero) ? numero : 0)
                .DefaultIfEmpty(0)
                .Max();

            return $"{prefijo}{ultimoNumero + 1:0000}";
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

            importe += ObtenerPrecioExtra("RetiroDomicilio");

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

        private static CentroDistribucionEntidad? ObtenerCentroDistribucionOrigen()
        {
            return CentroDistribucionAlmacen.cd.FirstOrDefault(c => c.Codigo == Program.CDActual);
        }


    }
}
