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
                HorariosSalida = ["08:00", "14:00", "20:00"]
            },
            new Empresa
            {
                Nombre = "Chevallier",
                CapacidadAlmacenamiento = 90,
                HorariosSalida = ["07:30", "13:00", "19:30"]
            },
            new Empresa
            {
                Nombre = "Andesmar",
                CapacidadAlmacenamiento = 100,
                HorariosSalida = ["09:00", "15:00", "21:00"]
            },
        ];

        private List<HojaDeRuta> HojasDeRuta { get; } =
        [
            // Flecha Bus - 08:00
            new HojaDeRuta { NumeroGuia = 20260510080001, NroOrden = "ORD-001", Codigo = "HDR-FB-001", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 7, 8, 0, 0), Destino = "Córdoba Capital" },
            new HojaDeRuta { NumeroGuia = 20260510080002, NroOrden = "ORD-002", Codigo = "HDR-FB-002", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 7, 8, 0, 0), Destino = "Villa Carlos Paz" },
            new HojaDeRuta { NumeroGuia = 20260510080003, NroOrden = "ORD-003", Codigo = "HDR-FB-003", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 7, 8, 0, 0), Destino = "Río Cuarto" },
            // Flecha Bus - 14:00
            new HojaDeRuta { NumeroGuia = 20260510140001, NroOrden = "ORD-004", Codigo = "HDR-FB-004", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 7, 14, 0, 0), Destino = "Córdoba Capital" },
            new HojaDeRuta { NumeroGuia = 20260510140002, NroOrden = "ORD-005", Codigo = "HDR-FB-005", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 7, 14, 0, 0), Destino = "Godoy Cruz" },
            new HojaDeRuta { NumeroGuia = 20260510140003, NroOrden = "ORD-006", Codigo = "HDR-FB-006", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 7, 14, 0, 0), Destino = "Guaymallén" },
            // Flecha Bus - 20:00
            new HojaDeRuta { NumeroGuia = 20260510200001, NroOrden = "ORD-007", Codigo = "HDR-FB-007", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 7, 20, 0, 0), Destino = "Córdoba Capital" },
            new HojaDeRuta { NumeroGuia = 20260510200002, NroOrden = "ORD-008", Codigo = "HDR-FB-008", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 7, 20, 0, 0), Destino = "Palermo" },
            new HojaDeRuta { NumeroGuia = 20260510200003, NroOrden = "ORD-009", Codigo = "HDR-FB-009", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Flecha Bus", FechaSalida = new DateTime(2026, 5, 7, 20, 0, 0), Destino = "Belgrano" },

            // Chevallier - 07:30
            new HojaDeRuta { NumeroGuia = 20260512073001, NroOrden = "ORD-010", Codigo = "HDR-CH-001", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 7, 7, 30, 0), Destino = "Ciudad de Mendoza" },
            new HojaDeRuta { NumeroGuia = 20260512073002, NroOrden = "ORD-011", Codigo = "HDR-CH-002", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 7, 7, 30, 0), Destino = "Godoy Cruz" },
            new HojaDeRuta { NumeroGuia = 20260512073003, NroOrden = "ORD-012", Codigo = "HDR-CH-003", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 7, 7, 30, 0), Destino = "Guaymallén" },
            // Chevallier - 13:00
            new HojaDeRuta { NumeroGuia = 20260512130001, NroOrden = "ORD-013", Codigo = "HDR-CH-004", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 7, 13, 0, 0), Destino = "Recoleta" },
            new HojaDeRuta { NumeroGuia = 20260512130002, NroOrden = "ORD-014", Codigo = "HDR-CH-005", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 7, 13, 0, 0), Destino = "Palermo" },
            new HojaDeRuta { NumeroGuia = 20260512130003, NroOrden = "ORD-015", Codigo = "HDR-CH-006", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 7, 13, 0, 0), Destino = "Belgrano" },
            // Chevallier - 19:30
            new HojaDeRuta { NumeroGuia = 20260512193001, NroOrden = "ORD-016", Codigo = "HDR-CH-007", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 7, 19, 30, 0), Destino = "Ciudad de Mendoza" },
            new HojaDeRuta { NumeroGuia = 20260512193002, NroOrden = "ORD-017", Codigo = "HDR-CH-008", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 7, 19, 30, 0), Destino = "Godoy Cruz" },
            new HojaDeRuta { NumeroGuia = 20260512193003, NroOrden = "ORD-018", Codigo = "HDR-CH-009", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Chevallier", FechaSalida = new DateTime(2026, 5, 7, 19, 30, 0), Destino = "Córdoba Capital" },

            // Andesmar - 09:00
            new HojaDeRuta { NumeroGuia = 20260515090001, NroOrden = "ORD-019", Codigo = "HDR-AN-001", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 7, 9, 0, 0), Destino = "Río Cuarto" },
            new HojaDeRuta { NumeroGuia = 20260515090002, NroOrden = "ORD-020", Codigo = "HDR-AN-002", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 7, 9, 0, 0), Destino = "Villa Carlos Paz" },
            new HojaDeRuta { NumeroGuia = 20260515090003, NroOrden = "ORD-021", Codigo = "HDR-AN-003", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 7, 9, 0, 0), Destino = "Guaymallén" },
            // Andesmar - 15:00
            new HojaDeRuta { NumeroGuia = 20260515150001, NroOrden = "ORD-022", Codigo = "HDR-AN-004", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 7, 15, 0, 0), Destino = "Recoleta" },
            new HojaDeRuta { NumeroGuia = 20260515150002, NroOrden = "ORD-023", Codigo = "HDR-AN-005", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 7, 15, 0, 0), Destino = "Belgrano" },
            new HojaDeRuta { NumeroGuia = 20260515150003, NroOrden = "ORD-024", Codigo = "HDR-AN-006", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 7, 15, 0, 0), Destino = "Ciudad de Mendoza" },
            // Andesmar - 21:00
            new HojaDeRuta { NumeroGuia = 20260515210001, NroOrden = "ORD-025", Codigo = "HDR-AN-007", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 7, 21, 0, 0), Destino = "Palermo" },
            new HojaDeRuta { NumeroGuia = 20260515210002, NroOrden = "ORD-026", Codigo = "HDR-AN-008", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 7, 21, 0, 0), Destino = "Córdoba Capital" },
            new HojaDeRuta { NumeroGuia = 20260515210003, NroOrden = "ORD-027", Codigo = "HDR-AN-009", Estado = "En tránsito a CD Destino", EmpresaOmnibus = "Andesmar", FechaSalida = new DateTime(2026, 5, 7, 21, 0, 0), Destino = "Godoy Cruz" },
        ];

        public (bool valido, string error) ValidarBusqueda(string empresa, DateTime fechaSalida)
        {
            if (string.IsNullOrWhiteSpace(empresa))
                return (false, "Debe seleccionar una empresa de ómnibus.");

            if (!Empresas.Any(e => e.Nombre == empresa))
                return (false, "Debe seleccionar una empresa de ómnibus válida.");

            if (fechaSalida > DateTime.Now)
                return (false, "La fecha y hora de llegada no puede ser posterior a la fecha y hora actual.");

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

        public (bool valido, string error) ValidarConfirmacion(HojaDeRuta? hojaSeleccionada)
        {
            if (hojaSeleccionada == null)
                return (false, "Debe seleccionar una Hoja de Ruta para confirmar la recepción.");

            return (true, "");
        }

        public (bool valido, string error) ActualizarEstadoHojaDeRuta(HojaDeRuta hojaDeRuta)
        {
            var hojaEnSistema = HojasDeRuta.FirstOrDefault(h => h.NumeroGuia == hojaDeRuta.NumeroGuia);

            if (hojaEnSistema == null)
                return (false, "Hoja de Ruta no encontrada.");

            hojaEnSistema.Estado = EstadoRecibido;

            return (true, "");
        }
    }
}
