using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TP3_CAI_GRUPO_C.ImposicionXTel
{
    internal class ImposicionXTelModelo
    {
        private const string MetodoEntregaDomicilio = "A Domicilio";

        public (Cliente? cliente, string error) ValidarCliente(long cuit)
        {
            if (cuit < 10_000_000_000 || cuit > 99_999_999_999)
                return (null, "CUIT inválido. Se debe ingresar un número de 11 digitos sin guiones ni comas.");

            var cliente = Clientes.FirstOrDefault(c => c.Cuit == cuit);

            if (cliente == null)
                return (null, "Cliente no encontrado.");

            return (cliente, "");
        }

        //Cargo Provincias en el ComboBox Provincias
        public string[] Provincias { get; } = [
         "Ciudad Autónoma de Buenos Aires",
         "Mendoza",
         "Cordoba",
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

        private Dictionary<string, string[]> LocalidadesPorProvincia { get; } = new()
        {
            {
                "Ciudad Autónoma de Buenos Aires",
                ["Palermo", "Recoleta", "Belgrano"]
            },
            {
                "Mendoza",
                ["Ciudad de Mendoza", "Godoy Cruz", "Guaymallen"]
            },
            {
                "Cordoba",
                ["Cordoba Capital", "Villa Carlos Paz", "Rio Cuarto"]
            }
        };

        private Dictionary<string, List<Sucursal>> SucursalesPorLocalidad { get; } = new()
        {
            {
                "Palermo",
                [
                    new Sucursal { Codigo = "CABA-PAL-001", Direccion = "Av. Santa Fe 3250", Horarios = "L a V 9-18", Tipo = "Agencia" },
                    new Sucursal { Codigo = "CABA-PAL-002", Direccion = "Av. Scalabrini Ortiz 1600", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
                    new Sucursal { Codigo = "CABA-PAL-003", Direccion = "Honduras 4900", Horarios = "L a S 10-19", Tipo = "Agencia" },
                ]
            },
            {
                "Recoleta",
                [
                    new Sucursal { Codigo = "CABA-REC-001", Direccion = "Av. Callao 1500", Horarios = "L a V 9-18", Tipo = "Agencia" },
                    new Sucursal { Codigo = "CABA-REC-002", Direccion = "Av. Pueyrredon 1900", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
                    new Sucursal { Codigo = "CABA-REC-003", Direccion = "Juncal 2100", Horarios = "L a S 10-19", Tipo = "Agencia" },
                ]
            },
            {
                "Belgrano",
                [
                    new Sucursal { Codigo = "CABA-BEL-001", Direccion = "Av. Cabildo 890", Horarios = "L a V 9-18", Tipo = "Agencia" },
                    new Sucursal { Codigo = "CABA-BEL-002", Direccion = "Juramento 2400", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
                    new Sucursal { Codigo = "CABA-BEL-003", Direccion = "Mendoza 1800", Horarios = "L a S 10-19", Tipo = "Agencia" },
                ]
            },
            {
                "Ciudad de Mendoza",
                [
                    new Sucursal { Codigo = "MZA-CIU-001", Direccion = "Av. San Martin 1150", Horarios = "L a V 9-18", Tipo = "Agencia" },
                    new Sucursal { Codigo = "MZA-CIU-002", Direccion = "Colon 420", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
                    new Sucursal { Codigo = "MZA-CIU-003", Direccion = "Las Heras 780", Horarios = "L a S 10-19", Tipo = "Agencia" },
                ]
            },
            {
                "Godoy Cruz",
                [
                    new Sucursal { Codigo = "MZA-GOD-001", Direccion = "San Martin Sur 850", Horarios = "L a V 9-18", Tipo = "Agencia" },
                    new Sucursal { Codigo = "MZA-GOD-002", Direccion = "Perito Moreno 620", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
                    new Sucursal { Codigo = "MZA-GOD-003", Direccion = "Beltran 1450", Horarios = "L a S 10-19", Tipo = "Agencia" },
                ]
            },
            {
                "Guaymallen",
                [
                    new Sucursal { Codigo = "MZA-GUA-001", Direccion = "Bandera de los Andes 5100", Horarios = "L a V 9-18", Tipo = "Agencia" },
                    new Sucursal { Codigo = "MZA-GUA-002", Direccion = "Av. Mitre 700", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
                    new Sucursal { Codigo = "MZA-GUA-003", Direccion = "Libertad 230", Horarios = "L a S 10-19", Tipo = "Agencia" },
                ]
            },
            {
                "Cordoba Capital",
                [
                    new Sucursal { Codigo = "COR-CAP-001", Direccion = "Av. Colon 950", Horarios = "L a V 9-18", Tipo = "Agencia" },
                    new Sucursal { Codigo = "COR-CAP-002", Direccion = "Bv. San Juan 430", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
                    new Sucursal { Codigo = "COR-CAP-003", Direccion = "Independencia 620", Horarios = "L a S 10-19", Tipo = "Agencia" },
                ]
            },
            {
                "Villa Carlos Paz",
                [
                    new Sucursal { Codigo = "COR-VCP-001", Direccion = "Av. San Martin 1200", Horarios = "L a V 9-18", Tipo = "Agencia" },
                    new Sucursal { Codigo = "COR-VCP-002", Direccion = "9 de Julio 450", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
                    new Sucursal { Codigo = "COR-VCP-003", Direccion = "General Paz 300", Horarios = "L a S 10-19", Tipo = "Agencia" },
                ]
            },
            {
                "Rio Cuarto",
                [
                    new Sucursal { Codigo = "COR-RCU-001", Direccion = "Sobremonte 760", Horarios = "L a V 9-18", Tipo = "Agencia" },
                    new Sucursal { Codigo = "COR-RCU-002", Direccion = "Constitucion 550", Horarios = "L a V 8-17", Tipo = "Centro de Distribución" },
                    new Sucursal { Codigo = "COR-RCU-003", Direccion = "Av. Italia 980", Horarios = "L a S 10-19", Tipo = "Agencia" },
                ]
            },
        };

        public string[] ObtenerLocalidadesPorProvincia(string provincia)
        {
            return LocalidadesPorProvincia.TryGetValue(provincia, out var localidades)
                ? localidades
                : [];
        }

        public bool ValidarCodigoPostal(int cp)
        {
            return cp >= 1000 && cp <= 9999;
        }

        public bool ValidarDireccion(string direccion)
        {
            return !string.IsNullOrWhiteSpace(direccion);
        }

        public List<Sucursal> ObtenerSucursalesPorLocalidad(string localidad)
        {
            return SucursalesPorLocalidad.TryGetValue(localidad, out var sucursales)
                ? sucursales
                : [];
        }

        public (bool valido, string error) ValidarCajas(int s, int m, int l, int xl)
        {
            // Negativos
            if (s < 0 || m < 0 || l < 0 || xl < 0)
            {
                return (false, "Las cantidades de cajas no pueden ser negativas.");
            }

            // Al menos una caja
            long totalCajas = s + m + l + xl;

            if (totalCajas == 0)
            {
                return (false, "Debe ingresar al menos una caja.");
            }

            // Capacidad
            long capacidadUsada = (s * 1) + (m * 2) + (l * 4) + (xl * 8);
            long capacidadMaxima = 20 * 8;

            if (capacidadUsada > capacidadMaxima)
            {
                return (false, "La cantidad de cajas supera el máximo permitido.");
            }

            return (true, "");
        }

        public (bool valido, string error) ValidarDNI(int dni)
        {
            if (dni < 1_000_000 || dni > 99_999_999)
                return (false, "DNI inválido. Se debe ingresar un número de entre 7 a 8 dígitos.");

            return (true, "");
        }

        public (bool valido, string error) GenerarImposicion(Imposicion imposicion)
        {
            var resultadoCliente = ValidarCliente(imposicion.CuitCliente);
            if (resultadoCliente.cliente == null)
                return (false, resultadoCliente.error);

            if (string.IsNullOrWhiteSpace(imposicion.NombreDestinatario))
                return (false, "El Nombre y Apellido de Destinatario no puede estar vacío.");

            var resultadoDNI = ValidarDNI(imposicion.DniDestinatario);
            if (!resultadoDNI.valido)
                return resultadoDNI;

            if (!Provincias.Contains(imposicion.ProvinciaRetiro))
                return (false, "Debe seleccionar una provincia de retiro.");

            if (!ObtenerLocalidadesPorProvincia(imposicion.ProvinciaRetiro).Contains(imposicion.LocalidadRetiro))
                return (false, "Debe seleccionar una localidad de retiro válida.");

            if (!ValidarCodigoPostal(imposicion.CodigoPostalRetiro))
                return (false, "El código postal de retiro debe ser un número de 4 dígitos.");

            if (!ValidarDireccion(imposicion.DireccionRetiro))
                return (false, "La dirección de retiro no puede estar vacía.");

            if (!MetodosEntrega.Contains(imposicion.MetodoEntrega))
                return (false, "Debe seleccionar un método de entrega.");

            if (imposicion.MetodoEntrega == MetodoEntregaDomicilio)
            {
                if (!Provincias.Contains(imposicion.ProvinciaEnvio))
                    return (false, "Debe seleccionar una provincia de entrega.");

                if (!ObtenerLocalidadesPorProvincia(imposicion.ProvinciaEnvio).Contains(imposicion.LocalidadEnvio))
                    return (false, "Debe seleccionar una localidad de entrega válida.");

                if (!ValidarCodigoPostal(imposicion.CodigoPostalEnvio))
                    return (false, "El código postal de entrega debe ser un número de 4 dígitos.");

                if (!ValidarDireccion(imposicion.DireccionEnvio))
                    return (false, "La dirección de entrega no puede estar vacía.");
            }
            else
            {
                if (!Provincias.Contains(imposicion.ProvinciaSucursal))
                    return (false, "Debe seleccionar una provincia de sucursal.");

                if (!ObtenerLocalidadesPorProvincia(imposicion.ProvinciaSucursal).Contains(imposicion.LocalidadSucursal))
                    return (false, "Debe seleccionar una localidad de sucursal válida.");

                if (imposicion.SucursalSeleccionada == null)
                    return (false, "Debe seleccionar una sucursal.");

                var sucursalValida = ObtenerSucursalesPorLocalidad(imposicion.LocalidadSucursal)
                    .Any(s => s.Codigo == imposicion.SucursalSeleccionada.Codigo);

                if (!sucursalValida)
                    return (false, "Debe seleccionar una sucursal válida para la localidad elegida.");
            }

            var resultadoCajas = ValidarCajas(
                imposicion.CantidadCajaS,
                imposicion.CantidadCajaM,
                imposicion.CantidadCajaL,
                imposicion.CantidadCajaXL);

            if (!resultadoCajas.valido)
                return resultadoCajas;

            return (true, "");
        }
    }
}
