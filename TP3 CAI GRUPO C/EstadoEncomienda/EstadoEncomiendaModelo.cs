using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.Almacenes;

namespace TP3_CAI_GRUPO_C.EstadoEncomienda
{

    internal class EstadoEncomiendaModelo
    {
        public List<Guia> Guias { get; } = new List<Guia>();

        public EstadoEncomiendaModelo()
        {
            CargarGuias();
        }

        private void CargarGuias()
        {
            Guias.Clear();

            foreach (var guiaEntidad in GuiaAlmacen.guias)
            {
                Guias.Add(new Guia
                {
                    NumeroGuia = guiaEntidad.NumeroGuia,
                    Historial = ObtenerHistorial(guiaEntidad)
                });
            }
        }

        private List<Movimiento> ObtenerHistorial(GuiaEntidad guiaEntidad)
        {
            return (guiaEntidad.Historial ?? new List<MovimientoGuia>())
                .OrderBy(movimiento => movimiento.UltimaActualizacion)
                .Select(movimiento => new Movimiento
                {
                    Estado = ObtenerNombreEstado(movimiento.Estado),
                    UltimaActualizacion = movimiento.UltimaActualizacion.ToString("dd/MM/yyyy HH:mm"),
                    Ubicacion = movimiento.Ubicacion
                })
                .ToList();
        }

        private string ObtenerNombreEstado(EstadoEnum estado)
        {
            return estado switch
            {
                EstadoEnum.ImpuestaTelefonicamente => "Impuesta telefonicamente",
                EstadoEnum.ImpuestaEnAgencia => "Impuesta en Agencia",
                EstadoEnum.ImpuestaEnCD => "Impuesta en CD",
                EstadoEnum.RetiroDomicilioEnCurso => "Retiro a domicilio en curso",
                EstadoEnum.RetiroAgenciaEnCurso => "Retiro en Agencia en curso",
                EstadoEnum.PendienteAdmision => "Pendiente de admision",
                EstadoEnum.AdmitidaEnCD => "Admitida en CD",
                EstadoEnum.EnTransitoACDDestino => "En transito a CD destino",
                EstadoEnum.EnCDDestino => "Recibido en CD destino",
                EstadoEnum.ListaParaEntregarPorCD => "Listo para retirar por CD",
                EstadoEnum.EnTransitoEntregaDomicilio => "En transito para entrega a domicilio",
                EstadoEnum.EnTransitoAAgenciaDestino => "En transito a Agencia destino",
                EstadoEnum.ListaParaEntregarPorAgencia => "Listo para retirar por Agencia",
                EstadoEnum.Entregado => "Entregado",
                _ => ""
            };
        }

        public (Guia? guia, string error) ValidarYBuscarGuia(string numeroGuia)
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
