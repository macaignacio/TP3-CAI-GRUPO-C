using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.Almacenes
{
    public enum EstadoEnum
    {
        ImpuestaTelefonicamente, //1
        ImpuestaEnAgencia,//2
        ImpuestaEnCD,//3
        RetiroDomicilioEnCurso,//4
        RetiroAgenciaEnCurso,//5
        PendienteAdmision,
        AdmitidaEnCD,//6
        EnTransitoACDDestino,//7
        EnCDDestino,//8
        ListaParaEntregarPorCD,//9
        EnTransitoEntregaDomicilio,//10
        EnTransitoAAgenciaDestino,//11
        ListaParaEntregarPorAgencia,//12
        Entregado//13
    }
}
