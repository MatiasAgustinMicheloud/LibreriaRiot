using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dos librerias importadas
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using Common.Models;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;


namespace DataAccess
{
    public class DatosCliente : ConnectionToSql
    {
        public bool AgregarPersona(string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento, string telefono)
        {
            if (fechaNacimiento == DateTime.MinValue)
            {
                return false;
            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Persona (Nombre, Apellido, DNI, Mail, FechaNacimiento,Telefono) VALUES (@Nombre, @Apellido, @DNI, @Mail, @FechaNacimiento,@Telefono);";

                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Telefono", telefono);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public Persona ObtenerPersonaPorDNI(string dni)
        {
            Persona persona = null; // Inicializa como null

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id_Persona, Nombre, Apellido, DNI, Mail, FechaNacimiento,Telefono " +
                                          "FROM Persona " +
                                          "WHERE DNI = @DNI;";
                    command.Parameters.AddWithValue("@DNI", dni);

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Si encuentra un registro
                            {
                                // Si se encontró una persona con el DNI especificado, crea un objeto Persona y asigna sus propiedades.
                                persona = new Persona
                                {
                                    Id_Persona = reader.GetInt32(reader.GetOrdinal("Id_Persona")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                                    DNI = reader.GetString(reader.GetOrdinal("DNI")),
                                    Mail = reader.GetString(reader.GetOrdinal("Mail")),
                                    FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                                    Telefono = reader.GetString(reader.GetOrdinal("Telefono"))
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }

            return persona; // Devuelve null si no se encontró la persona
        }

        public bool AgregarCliente(string nombre, string apellido, string dni, DateTime fechaNacimiento, string telefono, string mail, string domicilio, DateTime fechaRegistro)
        {
            // Primero, intenta agregar la persona
            bool personaAgregada = AgregarPersona(nombre, apellido, dni, mail, fechaNacimiento, telefono);

            if (!personaAgregada)
            {
                // Si no se pudo agregar la persona, retorna false
                return false;
            }

            // Obtén la persona que acabas de agregar
            Persona persona = ObtenerPersonaPorDNI(dni); // Implementa este método en tu capa intermedia para buscar por DNI

            // Verifica si se encontró la persona
            if (persona != null)
            {
                // Si la persona existe, puedes continuar con la inserción del usuario
                int personaId = persona.Id_Persona;

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Cliente (Domicilio,FechaRegistro,Id_Persona) VALUES (@Domicilio, @FechaRegistro, @Id_Persona);";

                        command.Parameters.AddWithValue("@Domicilio", domicilio);
                        command.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);
                        command.Parameters.AddWithValue("@Id_Persona", personaId);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            return rowsAffected > 0;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                            return false;
                        }
                    }
                }
            }
            else
            {
                // La persona no existe, por lo que no se puede agregar el usuario
                return false;
            }
        }

        public List<ClienteConInformacion> ObtenerClientes()
        {
            List<ClienteConInformacion> clientes = new List<ClienteConInformacion>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT c.Id_Cliente,c.Domicilio,c.FechaRegistro, 
                                        p.Nombre AS PersonaNombre, p.Apellido AS PersonaApellido, 
                                        p.DNI AS PersonaDNI, p.Mail AS PersonaMail, 
                                        p.FechaNacimiento AS PersonaFechaNacimiento, p.Telefono AS PersonaTelefono, p.Baja AS PersonaBaja
                                        FROM Cliente c
                                        INNER JOIN Persona p ON c.Id_Persona = p.Id_Persona";

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ClienteConInformacion cliente = new ClienteConInformacion
                                {
                                    IdCliente = reader.GetInt32(reader.GetOrdinal("Id_Cliente")),
                                    PersonaApellido = reader["PersonaApellido"].ToString(),
                                    PersonaNombre = reader["PersonaNombre"].ToString(),
                                    PersonaDNI = reader["PersonaDNI"].ToString(),
                                    PersonaMail = reader["PersonaMail"].ToString(),
                                    PersonaFechaNacimiento = (DateTime)reader["PersonaFechaNacimiento"],
                                    PersonaTelefono = reader["PersonaTelefono"].ToString(),
                                    Domicilio = reader["Domicilio"].ToString(),
                                    FechaRegistro = (DateTime)reader["FechaRegistro"],
                                    PersonaBaja = reader["PersonaBaja"].ToString()
                                };

                                clientes.Add(cliente);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }

            return clientes;
        }

        public ClienteConInformacion? TraerClientesId(int id)
        {
            ClienteConInformacion? cliente = null; // Declarar una variable para almacenar el usuario

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = @"SELECT c.Id_Cliente, p.Nombre AS PersonaNombre, p.Apellido AS PersonaApellido, p.DNI AS PersonaDNI, 
                                           p.Mail AS PersonaMail, p.FechaNacimiento AS PersonaFechaNacimiento,p.Telefono AS PersonaTelefono,
                                           c.Domicilio,c.FechaRegistro, p.Id_Persona, p.Baja AS PersonaBaja 
                                           FROM Cliente c
                                           INNER JOIN Persona p ON c.Id_Persona = p.Id_Persona
                                           WHERE c.Id_Cliente = @Id_Cliente";
                    comando.Parameters.AddWithValue("@Id_Cliente", id);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new ClienteConInformacion(); // Crear una instancia de UsuarioConInformacion
                            cliente.IdCliente = reader.GetInt32(0);
                            cliente.PersonaNombre = reader.GetString(1);
                            cliente.PersonaApellido = reader.GetString(2);
                            cliente.PersonaDNI = reader.GetString(3);
                            cliente.PersonaMail = reader.GetString(4);
                            cliente.PersonaFechaNacimiento = reader.GetDateTime(5);
                            cliente.PersonaTelefono = reader.GetString(6);
                            cliente.Domicilio = reader.GetString(7);
                            cliente.FechaRegistro = reader.GetDateTime(8);
                            cliente.Id_Persona = reader.GetInt32(9);
                            cliente.PersonaBaja = reader.GetString(10);
                        }
                    }
                }
            }
            return cliente;
        }

        public bool ActualizarPersona(int personaId, string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento, string telefono, string baja)
        {
            if (fechaNacimiento == DateTime.MinValue)
            {
                return false; // Fecha de nacimiento no válida
            }

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Persona SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Mail = @Mail, FechaNacimiento = @FechaNacimiento, Telefono = @Telefono, Baja = @Baja WHERE Id_Persona = @Id_Persona;";

                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Mail", mail);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Baja", baja);
                    command.Parameters.AddWithValue("@Id_Persona", personaId);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public Persona? ObtenerPersonaPorIdCliente(int idCliente)
        {
            Persona? persona = null;

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Comprobamos que los nombres de columna coincidan con los de la base de datos
                    command.CommandText = "SELECT p.Id_Persona, p.Nombre, p.Apellido, p.DNI, p.Mail, p.FechaNacimiento, p.Telefono, p.Baja " +
                                          "FROM Persona p " +
                                          "INNER JOIN Cliente c ON p.Id_Persona = c.Id_Persona " +
                                          "WHERE c.Id_Cliente = @IdCliente;";

                    command.Parameters.AddWithValue("@IdCliente", idCliente);

                    try
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Leer datos y asignarlos a la instancia de Persona
                                persona = new Persona
                                {
                                    Id_Persona = reader.GetInt32(reader.GetOrdinal("Id_Persona")),
                                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                    Apellido = reader.GetString(reader.GetOrdinal("Apellido")),
                                    DNI = reader.GetString(reader.GetOrdinal("DNI")),
                                    Mail = reader.GetString(reader.GetOrdinal("Mail")),
                                    FechaNacimiento = reader.GetDateTime(reader.GetOrdinal("FechaNacimiento")),
                                    Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                                    Baja = reader.GetString(reader.GetOrdinal("Baja")) // Agrega Baja aquí si existe en Persona
                                };
                            }
                            else
                            {
                                Console.WriteLine("No se encontró ninguna Persona vinculada con el Id_Cliente proporcionado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                    }
                }
            }

            return persona;
        }

        public bool ActualizarCliente(int clientId, string nombre, string apellido, string dni, string mail, DateTime fechaNacimiento, string telefono, string domicilio, string baja)
        {
            // Obtener los datos de la persona vinculada con el cliente
            Persona persona = ObtenerPersonaPorIdCliente(clientId);
            if (persona != null)
            {
                int personaId = persona.Id_Persona;

                // Actualizar datos de la persona
                bool personaActualizada = ActualizarPersona(personaId, nombre, apellido, dni, mail, fechaNacimiento, telefono, baja);

                if (!personaActualizada)
                {
                    return false;
                }

                // Actualizar el domicilio del cliente
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;

                        // Asegúrate de que el campo a actualizar y el parámetro coinciden con la tabla en la base de datos
                        command.CommandText = "UPDATE Cliente SET Domicilio = @Domicilio WHERE Id_Persona = @Id_Persona";

                        // Agrega los parámetros necesarios
                        command.Parameters.AddWithValue("@Domicilio", domicilio);
                        command.Parameters.AddWithValue("@Id_Persona", personaId); // Se usa `Id_Persona` y no `Id`

                        // Ejecuta la consulta y verifica si se realizaron cambios
                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            else
            {
                return false;
            }
        }


        public bool ExisteDNI(string dni)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Persona WHERE DNI = @DNI;";
                    command.Parameters.AddWithValue("@DNI", dni);

                    try
                    {
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool ExisteMail(string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) FROM Persona WHERE Mail = @Mail;";
                    command.Parameters.AddWithValue("@Mail", mail);

                    try
                    {
                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool CumpleCondicionesFechaNacimiento(DateTime fechaNacimiento)
        {
            int edad = CalcularEdad(fechaNacimiento);
            if (edad >= 10 && edad <= 99)
            {
                return true;
            }

            return false;
        }

        public int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaActual < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;
        }


    }
}
