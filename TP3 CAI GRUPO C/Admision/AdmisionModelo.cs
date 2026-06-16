using TP3_CAI_GRUPO_C.Almacenes;
using TP3_CAI_GRUPO_C.Auxiliares;

namespace TP3_CAI_GRUPO_C.Admision
{
    internal class AdmisionModelo
    {
        public ResultadoAdmision BuscarGuia(string numeroGuia)
        {
            var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

            if (guia == null)
                return new ResultadoAdmision { Valido = false, Error = "Guia no encontrada." };

            if (!PuedeAdmitirse(guia.EstadoActual))
                return new ResultadoAdmision { Valido = false, Error = "La guía no se encuentra en un estado válido para ser admitida." };

            var cliente = ClienteAlmacen.clientes.FirstOrDefault(c => c.Cuit == guia.CuitCliente);

            if (cliente == null)
                return new ResultadoAdmision { Valido = false, Error = "Cliente asociado a la guia no encontrado." };

            return new ResultadoAdmision
            {
                Valido = true,
                Guia = MapearGuia(guia)
            };
        }

        public ResultadoAdmision ConfirmarAdmision(string numeroGuia, int cantidadCajaS, int cantidadCajaM, int cantidadCajaL, int cantidadCajaXL)
        {
            var guia = GuiaAlmacen.guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

            if (guia == null)
                return new ResultadoAdmision { Valido = false, Error = "Guia no encontrada." };

            if (!PuedeAdmitirse(guia.EstadoActual))
                return new ResultadoAdmision { Valido = false, Error = "La guía no se encuentra en un estado válido para ser admitida." };

            var resultadoCajas = ValidarCajas(cantidadCajaS, cantidadCajaM, cantidadCajaL, cantidadCajaXL);

            if (!resultadoCajas.valido)
                return new ResultadoAdmision { Valido = false, Error = resultadoCajas.error };

            var cdOrigen = CentroDistribucionAlmacen.cd.FirstOrDefault(c => c.Codigo == Program.CDActual);
            var cdDestino = CentroDistribucionAlmacen.cd.FirstOrDefault(c => c.Codigo == guia.CentroDistribucionDestino);

            if (cdOrigen == null)
                return new ResultadoAdmision { Valido = false, Error = "Debe seleccionar un centro de distribucion actual valido." };

            if (cdDestino == null)
                return new ResultadoAdmision { Valido = false, Error = "No se encontro el centro de distribucion de destino de la guia." };

            var cajasModificadas =
                guia.CajasS != cantidadCajaS ||
                guia.CajasM != cantidadCajaM ||
                guia.CajasL != cantidadCajaL ||
                guia.CajasXL != cantidadCajaXL;
            var centroDistribucionOrigenModificado =
                guia.CentroDistribucionOrigen != cdOrigen.Codigo;

            var guiaParaPlanificar = new GuiaEntidad
            {
                NumeroGuia = guia.NumeroGuia,
                CentroDistribucionOrigen = cdOrigen.Codigo,
                CentroDistribucionDestino = guia.CentroDistribucionDestino,
                MetodoEntrega = guia.MetodoEntrega,
                AgenciaEntregaCodigo = guia.AgenciaEntregaCodigo,
                CentroDistribucionEntregaCodigo = guia.CentroDistribucionEntregaCodigo,
                DireccionEntrega = guia.DireccionEntrega,
                CodPostalEntrega = guia.CodPostalEntrega,
                CajasS = cantidadCajaS,
                CajasM = cantidadCajaM,
                CajasL = cantidadCajaL,
                CajasXL = cantidadCajaXL
            };

            var resultadoHojaDeRuta = PlanificarHojaDeRutaPosterior(
                guiaParaPlanificar,
                guia.MetodoEntrega);

            if (!resultadoHojaDeRuta.valido)
                return new ResultadoAdmision { Valido = false, Error = resultadoHojaDeRuta.error };

            guia.CajasS = cantidadCajaS;
            guia.CajasM = cantidadCajaM;
            guia.CajasL = cantidadCajaL;
            guia.CajasXL = cantidadCajaXL;
            guia.CentroDistribucionOrigen = cdOrigen.Codigo;

            if (cajasModificadas || centroDistribucionOrigenModificado)
                guia.Importe = CalcularImporte(guia, cdOrigen, cdDestino);

            guia.EstadoActual = resultadoHojaDeRuta.estadoGuia;
            guia.Historial ??= new List<MovimientoGuia>();
            guia.Historial.Add(new MovimientoGuia
            {
                Estado = resultadoHojaDeRuta.estadoGuia,
                UltimaActualizacion = DateTime.Now,
                Ubicacion = cdOrigen.Nombre
            });

            if (resultadoHojaDeRuta.hojaDeRutaOmnibusNueva)
                HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus.Add(resultadoHojaDeRuta.hojaDeRutaOmnibus!);

            if (resultadoHojaDeRuta.hojaDeRutaFleteroNueva)
                HojaDeRutaFleteroAlmacen.HojasDeRutaFleteros.Add(resultadoHojaDeRuta.hojaDeRutaFletero!);

            GuiaAlmacen.Guardar();
            HojaDeRutaOmnibusAlmacen.Guardar();
            HojaDeRutaFleteroAlmacen.Guardar();

            return new ResultadoAdmision
            {
                Valido = true,
                Guia = MapearGuia(guia)
            };
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
                return (false, "La cantidad de cajas supera el maximo permitido.");

            return (true, "");
        }

        private static (
            bool valido,
            string error,
            EstadoEnum estadoGuia,
            HojaDeRutaOmnibusEntidad? hojaDeRutaOmnibus,
            bool hojaDeRutaOmnibusNueva,
            HojaDeRutaFleteroEntidad? hojaDeRutaFletero,
            bool hojaDeRutaFleteroNueva) PlanificarHojaDeRutaPosterior(
                GuiaEntidad guia,
                MetodoEntregaEnum metodoEntrega)
        {
            if (guia.CentroDistribucionOrigen != guia.CentroDistribucionDestino)
            {
                var resultadoOmnibus = HojaDeRutaOmnibusPlanificador.ObtenerHojaDeRutaDisponible(
                    guia,
                    GenerarCodigoHojaDeRutaOmnibus());

                return (
                    resultadoOmnibus.hojaDeRuta != null,
                    resultadoOmnibus.error,
                    EstadoEnum.AdmitidaEnCD,
                    resultadoOmnibus.hojaDeRuta,
                    resultadoOmnibus.esNueva,
                    null,
                    false);
            }

            if (metodoEntrega == MetodoEntregaEnum.CentroDeDistribucion)
                return (true, "", EstadoEnum.ListaParaEntregarPorCD, null, false, null, false);

            guia.EstadoActual = EstadoEnum.EnCDDestino;
            var resultadoFletero = HojaDeRutaFleteroPlanificador.ObtenerHojaDeRutaEntregaDisponible(
                guia,
                GenerarCodigoHojaDeRutaDistribucion());

            return (
                resultadoFletero.hojaDeRuta != null,
                resultadoFletero.hojaDeRuta == null ? "No hay fleteros con cobertura para el centro de distribucion destino." : "",
                EstadoEnum.EnCDDestino,
                null,
                false,
                resultadoFletero.hojaDeRuta,
                resultadoFletero.esNueva);
        }

        private static bool PuedeAdmitirse(EstadoEnum estado)
        {
            return estado == EstadoEnum.ImpuestaEnCD ||
                   estado == EstadoEnum.PendienteAdmision;
        }

        private static Guia MapearGuia(GuiaEntidad guia)
        {
            return new Guia
            {
                NumeroGuia = guia.NumeroGuia,
                EstadoActual = guia.EstadoActual.ToString(),
                FechaHoraAlta = guia.FechaCreacion,
                CuitCliente = guia.CuitCliente,
                CantidadCajaS = guia.CajasS,
                CantidadCajaM = guia.CajasM,
                CantidadCajaL = guia.CajasL,
                CantidadCajaXL = guia.CajasXL
            };
        }

        private static decimal CalcularImporte(GuiaEntidad guia, CentroDistribucionEntidad cdOrigen, CentroDistribucionEntidad cdDestino)
        {
            var importe = 0m;

            importe += guia.CajasS * ObtenerPrecioBulto("S", cdOrigen.IdLocalidad, cdDestino.IdLocalidad);
            importe += guia.CajasM * ObtenerPrecioBulto("M", cdOrigen.IdLocalidad, cdDestino.IdLocalidad);
            importe += guia.CajasL * ObtenerPrecioBulto("L", cdOrigen.IdLocalidad, cdDestino.IdLocalidad);
            importe += guia.CajasXL * ObtenerPrecioBulto("XL", cdOrigen.IdLocalidad, cdDestino.IdLocalidad);

            if (guia.MetodoRetiro == MetodoRetiroEnum.EnDomicilio)
                importe += ObtenerPrecioExtra("RetiroDomicilio");

            if (guia.MetodoEntrega == MetodoEntregaEnum.ADomicilio)
                importe += ObtenerPrecioExtra("EntregaDomicilio");
            else if (guia.MetodoEntrega == MetodoEntregaEnum.Agencia)
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
    }
}
