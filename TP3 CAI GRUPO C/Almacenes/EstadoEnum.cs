using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    public enum EstadoEnum
    {
        ImpuestaTelefonicamente,
        ImpuestaEnAgencia,
        ImpuestaEnCD,
        RetiroDomicilioEnCurso,
        RetiroAgenciaEnCurso,
        AdmitidaEnCD,
        EnTransitoACDDestino,
        EnCDDestino,
        ListaParaEntregarPorCD,
        EnTransitoEntregaDomicilio,
        EnTransitoAAgenciaDestino,
        ListaParaEntregarPorAgencia,
        Entregado
    }
}
