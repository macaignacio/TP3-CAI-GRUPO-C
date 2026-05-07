using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.EstadoEncomienda
{

    internal class EstadoEncomiendaModelo
    {
        public List<Guia> Guias { get; } = new List<Guia>
        {
            new Guia
            {
                NumeroGuia = 20260506101010101,
                Historial = new List<Movimiento>
                {
                    new Movimiento { Estado = "Imposición", UltimaActualizacion = "06/05/2026 10:00", Ubicacion = "Agencia CABA-PAL-001 - Palermo" }
                }
            },

            new Guia
            {
                NumeroGuia = 20260506101010202,
                Historial = new List<Movimiento>
                {
                    new Movimiento { Estado = "Imposición", UltimaActualizacion = "05/05/2026 09:15", Ubicacion = "Agencia MZA-CIU-001 - Ciudad de Mendoza" },
                    new Movimiento { Estado = "Admitida en CD", UltimaActualizacion = "05/05/2026 18:30", Ubicacion = "CD MZA-CIU-002 - Ciudad de Mendoza" },
                    new Movimiento { Estado = "En viaje", UltimaActualizacion = "06/05/2026 08:00", Ubicacion = "CD MZA-CIU-002 - Ciudad de Mendoza" }
                }
            },

            new Guia
            {
                NumeroGuia = 20260506101010303,
                Historial = new List<Movimiento>
                {
                    new Movimiento { Estado = "Imposición", UltimaActualizacion = "04/05/2026 11:00", Ubicacion = "Agencia COR-RCU-001 - Rio Cuarto" },
                    new Movimiento { Estado = "Admitida en CD", UltimaActualizacion = "04/05/2026 19:00", Ubicacion = "CD COR-RCU-002 - Rio Cuarto" },
                    new Movimiento { Estado = "En viaje", UltimaActualizacion = "05/05/2026 07:30", Ubicacion = "CD COR-RCU-002 - Rio Cuarto" },
                    new Movimiento { Estado = "Recibido en CD destino", UltimaActualizacion = "06/05/2026 14:00", Ubicacion = "CD CABA-BEL-002 - Belgrano" },
                    new Movimiento { Estado = "Encomienda lista para visitar domicilio", UltimaActualizacion = "07/05/2026 08:30", Ubicacion = "CD CABA-BEL-002 - Belgrano" },
                    new Movimiento { Estado = "Entregado", UltimaActualizacion = "07/05/2026 11:15", Ubicacion = "Domicilio Cliente - Belgrano" }
                }
            }
        };

        public (Guia? guia, string error) ValidarYBuscarGuia(long numeroGuia)
        {
            var guiaEncontrada = Guias.FirstOrDefault(g => g.NumeroGuia == numeroGuia);

            if (guiaEncontrada == null)
            {
                return (null, "Guia no encontrada");
            }

            return (guiaEncontrada, "");
        }
    }
}
