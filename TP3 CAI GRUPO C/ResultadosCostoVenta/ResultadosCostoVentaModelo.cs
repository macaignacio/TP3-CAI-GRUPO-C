using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.ResultadosCostoVenta
{
    internal class ResultadosCostoVentaModelo
    {
        private Dictionary<DateTime, List<Resultado>> ResultadosPorPeriodo { get; } = new()
        {
            {
                new DateTime(2026, 3, 1),
                [
                    new Resultado { EmpresaOmnibus = "Flecha Bus", Ventas = 185000, Costos = 122000, Utilidad = 63000 },
                    new Resultado { EmpresaOmnibus = "Chevallier", Ventas = 148000, Costos = 97000, Utilidad = 51000 },
                    new Resultado { EmpresaOmnibus = "Andesmar", Ventas = 162000, Costos = 108000, Utilidad = 54000 },
                ]
            },
            {
                new DateTime(2026, 4, 1),
                [
                    new Resultado { EmpresaOmnibus = "Flecha Bus", Ventas = 210000, Costos = 139000, Utilidad = 71000 },
                    new Resultado { EmpresaOmnibus = "Chevallier", Ventas = 176000, Costos = 116000, Utilidad = 60000 },
                    new Resultado { EmpresaOmnibus = "Andesmar", Ventas = 194000, Costos = 128000, Utilidad = 66000 },
                ]
            },
            {
                new DateTime(2026, 5, 1),
                [
                    new Resultado { EmpresaOmnibus = "Flecha Bus", Ventas = 236000, Costos = 151000, Utilidad = 85000 },
                    new Resultado { EmpresaOmnibus = "Chevallier", Ventas = 189000, Costos = 124000, Utilidad = 65000 },
                    new Resultado { EmpresaOmnibus = "Andesmar", Ventas = 218000, Costos = 143000, Utilidad = 75000 },
                ]
            },
        };

        public List<Resultado> ObtenerResultadosPorPeriodo(DateTime periodo)
        {
            var periodoNormalizado = new DateTime(periodo.Year, periodo.Month, 1);

            return ResultadosPorPeriodo.TryGetValue(periodoNormalizado, out var resultados)
                ? resultados
                : [];
        }
    }
}
