using System;
using System.Collections.Generic;
using System.Text;
using TP3_CAI_GRUPO_C.EstadoEncomienda;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    internal class GuiaEntidad
    {   //datos cabecera
        public long CuitCliente { get; set; }      
        public string NumeroGuia { get; set; }
        public DateTime FechaCreacion { get; set; }
        public decimal  Importe { get; set; }
        public EstadoEnum EstadoActual { get; set; }

        //datos troncal
        public string CentroDistribucionOrigen { get; set; }
        public string CentroDistribucionDestino { get; set; }
       
        //datos destino
        public MetodoEntregaEnum MetodoEntrega { get; set; }
        public string AgenciaEntregaCodigo { get; set; }
        public string CentroDistribucionEntregaCodigo { get; set; }
        public string DireccionEntrega { get; set; }
        public int CodPostalEntrega { get; set; }

        //datos origen 
        public MetodoRetiroEnum MetodoRetiro { get; set; }
        public string AgenciaRetiroCodigo { get; set; }
        public string CentroDistribucionRetiroCodigo { get; set; }
        public string DireccionRetiro { get; set; }
        public int CodPostalRetiro { get; set; }

        //datos entrega
        public int DniDestinatario { get; set; }
        public string NombreApellidoDestinatario { get; set; }

        //datos encomienda
        public int CajasS { get; set; }
        public int CajasM { get; set; }
        public int CajasL { get; set; }
        public int CajasXL { get; set; }

        //movimientos
        public List<MovimientoGuia> Historial { get; set; }

        //datos devolucion
        public string CentroDistribucionOrigenDevolucion { get; set; }
        public string CentroDistribucionDestinoDevolucion { get; set; }
        public string AgenciaDevolucionCodigo { get; set; }
        public string DireccionDevolucion { get; set; }
        public int CodPostalDevolucion { get; set; }
    }
}
