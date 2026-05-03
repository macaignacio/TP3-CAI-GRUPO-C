using System;
using System.Collections.Generic;
using System.Text;

namespace TP3_CAI_GRUPO_C.ImposicionXTel
{
    internal class ImposicionXTelModelo
    {
      /*  public List<Cliente> ValidarCliente(long cuit)

        {

        }*/
       
        //Cargo Provincias en el ComboBox Provincias
       public string[] Provincias { get; } = [
     "Buenos Aires",

     "Catamarca",

     "Chaco",

     "Chubut",

     "Córdoba",

     "Ciudad Autónoma de Buenos Aires",

     "Corrientes",

     "Entre Ríos",

     "Formosa",

     "Jujuy",

     "La Pampa",

     "La Rioja",

     "Mendoza",

     "Misiones",

     "Neuquén",

     "Río Negro",

     "Salta",

     "San Juan",

     "San Luis",

     "Santa Cruz",

     "Santa Fe",

     "Santiago del Estero",

     "Tierra del Fuego",

     "Tucumán",


     ];

    //Agregar las opciones tamaños a Combobox Metodos de Entrega
    public string[] MetodosEntrega { get; } = [

     "A Domicilio",

     "Centro de Distribución",

     "Agencia",

     ];

    }
}
