using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.ResultadosCostoVenta
{
    internal class ResultadosCostoVentaModelo
    {
        public List<Resultado> ObtenerResultadosPorPeriodo(DateTime periodo)
        {
            var periodoNormalizado = new DateTime(periodo.Year, periodo.Month, 1);

            return EmpresaOmnibusAlmacen.empresasOmnibus
                .Select(empresa => MapearResultado(empresa, periodoNormalizado))
                .Where(resultado => resultado.Ventas > 0 || resultado.Costos > 0)
                .OrderBy(resultado => resultado.EmpresaOmnibus)
                .ToList();
        }

        private static Resultado MapearResultado(EmpresaOmnibusEntidad empresa, DateTime periodo)
        {
            var ventas = CalcularVentas(empresa.cuitEmpresaOmnibus, periodo);
            var costos = CalcularCostos(empresa.cuitEmpresaOmnibus, periodo);

            return new Resultado
            {
                EmpresaOmnibus = empresa.nombre,
                Ventas = ventas,
                Costos = costos,
                Utilidad = ventas - costos
            };
        }

        private static decimal CalcularVentas(long cuitEmpresaOmnibus, DateTime periodo)
        {
            var serviciosEmpresa = ServicioOmnibusAlmacen.servicios
                .Where(s => s.CuitEmpresaOmnibus == cuitEmpresaOmnibus)
                .Where(s => s.Parada != null && s.Parada.Count > 0)
                .Where(s =>
                {
                    var fechaSalida = s.Parada.Min(p => p.FechaHoraParada);
                    return fechaSalida.Year == periodo.Year
                        && fechaSalida.Month == periodo.Month;
                })
                .Select(s => s.IdentificadorServicio)
                .ToHashSet();

            var numerosGuiasEmpresa = HojaDeRutaOmnibusAlmacen.HojasDeRutaOmnibus
                .Where(h => serviciosEmpresa.Contains(h.IdentificadorServicio))
                .SelectMany(h => h.Guias)
                .ToHashSet();

            return GuiaAlmacen.guias
                .Where(g => numerosGuiasEmpresa.Contains(g.NumeroGuia))
                .Sum(g => g.Importe);
        }

        private static decimal CalcularCostos(long cuitEmpresaOmnibus, DateTime periodo)
        {
            return CuentaCorrienteEmpresaOmnibusAlmacen.ctaCteEmpresaOmnibus
                .Where(m => m.CuitEmpresaOmnibus == cuitEmpresaOmnibus)
                .Where(m => m.Fecha.Year == periodo.Year && m.Fecha.Month == periodo.Month)
                .Sum(m => m.Debe);
        }
    }
}
