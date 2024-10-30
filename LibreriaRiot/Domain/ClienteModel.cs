using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Models;
using Domain;

namespace Domain
{
    internal class ClienteModel
    {
        DatosCliente DatosCliente = new DatosCliente();

        public bool AgregarNuevoCliente(string telefono, string domicilio, DateTime fechaRegistro, string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento)
        {
            return DatosCliente.AgregarCliente(nombre, apellido, dni, fechaNacimiento, telefono, mail, domicilio, fechaRegistro);
        }

        public List<ClienteConInformacion> MostrarClientes()
        {
            return DatosCliente.ObtenerClientes();
        }

        public ClienteConInformacion? ImportarCliente(int id)
        {
            return DatosCliente.TraerClientesId(id);
        }

        public bool ActualizacionClient(int clientId, string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento, string telefono, string domicilio, string baja)
        {
            return DatosCliente.ActualizarCliente(clientId, nombre, apellido, dni, mail, fechaNacimiento, telefono, domicilio, baja);
        }

        public bool IsValidDni(string dni)
        {
            return DatosCliente.ExisteDNI(dni);
        }

        public bool IsValidCorreo(string mail)
        {
            return DatosCliente.ExisteMail(mail);
        }


        public bool IsValidEdad(DateTime fechaNacimiento)
        {
            return DatosCliente.CumpleCondicionesFechaNacimiento(fechaNacimiento);
        }

    }
}
