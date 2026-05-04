using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TP3_CAI_GRUPO_C.ImposicionXTel
{
    internal class ImposicionXTelModelo
    {
        public (Cliente? cliente, string error) ValidarCliente(string cuitTexto)
        {
            if (string.IsNullOrWhiteSpace(cuitTexto))
                return (null, "El campo CUIT no puede estar vacío.");

            if (cuitTexto.Length != 11 || !long.TryParse(cuitTexto, out long cuit))
                return (null, "CUIT inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");

            var cliente = Clientes.FirstOrDefault(c => c.Cuit == cuit);

            if (cliente == null)
                return (null, "Cliente no encontrado.");

            return (cliente, "");
        }

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

        //Datos de Pruebareturn new List<Cliente>

        public List<Cliente> Clientes { get; } = new List<Cliente>
        {
            new Cliente {
                Cuit = 30205869953,
                RazonSocial = "EnvasesArg",
            },
            new Cliente {
                Cuit = 30725648921,
                RazonSocial = "RepuestosCorSA",
            },
            new Cliente {
                Cuit = 20314567891,
                RazonSocial = "TecnologiaHoy",
            }
        };

        //Cargo Localidades en el ComboBox cuando selecciona provincia CABA
        public string[] LocalidadesCABA { get; } = [
        "Palermo",
        "Recoleta",
        "Belgrano",
        "Caballito",
        "Almagro",
        "Villa Crespo",
        "Flores",
        "Barracas",
        "La Boca",
        "San Telmo", ];

        public string[] ObtenerLocalidadesPorProvincia(string provincia)
        {
            if (provincia == "Ciudad Autónoma de Buenos Aires")
            {
                return LocalidadesCABA;
            }

            return new string[0]; // vacío para otras provincias
        }

        public bool ValidarCodigoPostal(string cp)
        {
            if (string.IsNullOrWhiteSpace(cp))
                return false;

            if (!int.TryParse(cp, out _))
                return false;

            if (cp.Length != 4)
                return false;

            return true;
        }

        public bool ValidarDireccion(string direccion)
        {
            return !string.IsNullOrWhiteSpace(direccion);
        }

        public List<Sucursal> ObtenerSucursalesPorProvincia(string provincia)
        {
            if (provincia == "Ciudad Autónoma de Buenos Aires")
            {
                return new List<Sucursal>
        {
            new Sucursal { Codigo = "001", Direccion = "Av. Santa Fe 1234", Horarios = "L a V 9-18", Tipo = "Agencia" },
            new Sucursal { Codigo = "002", Direccion = "Av. Corrientes 567", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
            new Sucursal { Codigo = "003", Direccion = "Av. Cabildo 890", Horarios = "L a S 10-19", Tipo = "Agencia" },
            new Sucursal { Codigo = "004", Direccion = "Av. Rivadavia 2222", Horarios = "L a V 9-17", Tipo = "Centro de Distribución" },
            new Sucursal { Codigo = "005", Direccion = "Av. Callao 1500", Horarios = "L a V 9-18", Tipo = "Agencia" },
            new Sucursal { Codigo = "006", Direccion = "Av. San Juan 3000", Horarios = "L a V 8-16", Tipo = "Centro de Distribución" }
        };
            }

            return new List<Sucursal>();
        }
        

    }
}
