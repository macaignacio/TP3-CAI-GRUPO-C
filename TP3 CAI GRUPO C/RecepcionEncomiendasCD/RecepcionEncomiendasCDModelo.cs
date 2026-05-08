using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.RecepcionEncomiendasCD
{
    internal class RecepcionEncomiendasCDModelo
    {
        private const string EstadoRecibido = "Recibido en CD Destino";

        public int CodigoCDActual { get; } = 3001;

        public List<Empresa> Empresas { get; } =
        [
            new Empresa
            {
                Nombre = "Flecha Bus",
                CapacidadAlmacenamiento = 120,
                HorariosSalida = ["20:00", "22:00", "23:00"]
            },
            new Empresa
            {
                Nombre = "Chevallier",
                CapacidadAlmacenamiento = 90,
                HorariosSalida = ["21:30", "22:30", "23:30"]
            },
            new Empresa
            {
                Nombre = "Andesmar",
                CapacidadAlmacenamiento = 100,
                HorariosSalida = ["19:00", "20:00", "21:00"]
            },
        ];

        private List<HojaDeRuta> HojasDeRuta { get; } =
        [
            // Flecha Bus - 20:00 - ORD-001
            new HojaDeRuta { NroOrden = "ORD-001", Codigo = "HDR-FB-202605-0001", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 10, 20, 0, 0), Destino = "Córdoba Capital" },
            new HojaDeRuta { NroOrden = "ORD-001", Codigo = "HDR-FB-202605-0002", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 10, 20, 0, 0), Destino = "Villa Carlos Paz" },
            new HojaDeRuta { NroOrden = "ORD-001", Codigo = "HDR-FB-202605-0003", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 10, 20, 0, 0), Destino = "Río Cuarto" },
            // Flecha Bus - 22:00 - ORD-002
            new HojaDeRuta { NroOrden = "ORD-002", Codigo = "HDR-FB-202605-0004", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 10, 22, 0, 0), Destino = "Córdoba Capital" },
            new HojaDeRuta { NroOrden = "ORD-002", Codigo = "HDR-FB-202605-0005", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 10, 22, 0, 0), Destino = "Godoy Cruz" },
            new HojaDeRuta { NroOrden = "ORD-002", Codigo = "HDR-FB-202605-0006", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 10, 22, 0, 0), Destino = "Guaymallén" },
            // Flecha Bus - 23:00 - ORD-003
            new HojaDeRuta { NroOrden = "ORD-003", Codigo = "HDR-FB-202605-0007", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 10, 23, 0, 0), Destino = "Córdoba Capital" },
            new HojaDeRuta { NroOrden = "ORD-003", Codigo = "HDR-FB-202605-0008", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 10, 23, 0, 0), Destino = "Palermo" },
            new HojaDeRuta { NroOrden = "ORD-003", Codigo = "HDR-FB-202605-0009", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 10, 23, 0, 0), Destino = "Belgrano" },
 
            // Chevallier - 21:30 - ORD-004
            new HojaDeRuta { NroOrden = "ORD-004", Codigo = "HDR-CH-202605-0001", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 12, 21, 30, 0), Destino = "Ciudad de Mendoza" },
            new HojaDeRuta { NroOrden = "ORD-004", Codigo = "HDR-CH-202605-0002", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 12, 21, 30, 0), Destino = "Godoy Cruz" },
            new HojaDeRuta { NroOrden = "ORD-004", Codigo = "HDR-CH-202605-0003", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 12, 21, 30, 0), Destino = "Guaymallén" },
            // Chevallier - 22:30 - ORD-005
            new HojaDeRuta { NroOrden = "ORD-005", Codigo = "HDR-CH-202605-0004", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 12, 22, 30, 0), Destino = "Recoleta" },
            new HojaDeRuta { NroOrden = "ORD-005", Codigo = "HDR-CH-202605-0005", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 12, 22, 30, 0), Destino = "Palermo" },
            new HojaDeRuta { NroOrden = "ORD-005", Codigo = "HDR-CH-202605-0006", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 12, 22, 30, 0), Destino = "Belgrano" },
            // Chevallier - 23:30 - ORD-006
            new HojaDeRuta { NroOrden = "ORD-006", Codigo = "HDR-CH-202605-0007", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 12, 23, 30, 0), Destino = "Ciudad de Mendoza" },
            new HojaDeRuta { NroOrden = "ORD-006", Codigo = "HDR-CH-202605-0008", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 12, 23, 30, 0), Destino = "Godoy Cruz" },
            new HojaDeRuta { NroOrden = "ORD-006", Codigo = "HDR-CH-202605-0009", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 12, 23, 30, 0), Destino = "Córdoba Capital" },
 
            // Andesmar - 19:00 - ORD-007
            new HojaDeRuta { NroOrden = "ORD-007", Codigo = "HDR-AN-202605-0001", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 15, 19, 0, 0), Destino = "Río Cuarto" },
            new HojaDeRuta { NroOrden = "ORD-007", Codigo = "HDR-AN-202605-0002", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 15, 19, 0, 0), Destino = "Villa Carlos Paz" },
            new HojaDeRuta { NroOrden = "ORD-007", Codigo = "HDR-AN-202605-0003", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 15, 19, 0, 0), Destino = "Guaymallén" },
            // Andesmar - 20:00 - ORD-008
            new HojaDeRuta { NroOrden = "ORD-008", Codigo = "HDR-AN-202605-0004", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 15, 20, 0, 0), Destino = "Recoleta" },
            new HojaDeRuta { NroOrden = "ORD-008", Codigo = "HDR-AN-202605-0005", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 15, 20, 0, 0), Destino = "Belgrano" },
            new HojaDeRuta { NroOrden = "ORD-008", Codigo = "HDR-AN-202605-0006", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 15, 20, 0, 0), Destino = "Ciudad de Mendoza" },
            // Andesmar - 21:00 - ORD-009
            new HojaDeRuta { NroOrden = "ORD-009", Codigo = "HDR-AN-202605-0007", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 15, 21, 0, 0), Destino = "Palermo" },
            new HojaDeRuta { NroOrden = "ORD-009", Codigo = "HDR-AN-202605-0008", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 15, 21, 0, 0), Destino = "Córdoba Capital" },
            new HojaDeRuta { NroOrden = "ORD-009", Codigo = "HDR-AN-202605-0009", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 15, 21, 0, 0), Destino = "Godoy Cruz" },
        ];

        public (bool valido, string error) ValidarBusqueda(string empresa, DateTime fechaSalida)
        {
            if (string.IsNullOrWhiteSpace(empresa))
                return (false, "Debe seleccionar una empresa de ómnibus.");

            if (!Empresas.Any(e => e.Nombre == empresa))
                return (false, "Debe seleccionar una empresa de ómnibus válida.");

            if (fechaSalida > DateTime.Now)
                return (false, "La fecha y hora de salida no puede ser posterior a la fecha y hora actual.");

            return (true, "");
        }

        public List<HojaDeRuta> BuscarHojasDeRuta(string empresa, DateTime fechaSalida)
        {
            return HojasDeRuta
                .Where(h =>
                    h.EmpresaOmnibus == empresa &&
                    h.FechaSalida.Date == fechaSalida.Date &&
                    h.FechaSalida.Hour == fechaSalida.Hour &&
                    h.FechaSalida.Minute == fechaSalida.Minute)
                .ToList();
        }

        public (bool valido, string error) ValidarConfirmacion(List<HojaDeRuta> hojas)
        {
            if (hojas.Count == 0)
                return (false, "No hay Hojas de Ruta cargadas para confirmar la recepción.");

            return (true, "");
        }

        public (bool valido, string error) ActualizarEstadoHojasDeRuta(List<HojaDeRuta> hojas)
        {
            foreach (var hojaDeRuta in hojas)
            {
                var hojaEnSistema = HojasDeRuta.FirstOrDefault(h => h.Codigo == hojaDeRuta.Codigo);

                if (hojaEnSistema == null)
                    return (false, $"Hoja de Ruta {hojaDeRuta.Codigo} no encontrada.");

                hojaEnSistema.Estado = EstadoRecibido;
            }

            return (true, "");
        }
    }
}