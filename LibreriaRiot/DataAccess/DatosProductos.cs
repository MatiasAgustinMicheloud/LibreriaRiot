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
using Common.Models;



//Clase para los datos del usuario
namespace DataAccess
{
    internal class DatosProductos : ConnectionToSql
    {

        //Agregar una editorial nueva a la tabla Editorial
        public bool AgregarEditorial(string nombreEditorial)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Editorial (NombreEditorial) VALUES (@NombreEditorial);";

                    command.Parameters.AddWithValue("@NombreEditorial", nombreEditorial);

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

        //Agregar un autor nuevo a la tabla Autor
        public bool AgregarAutor(string nombreAutor)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Editorial (Nombre) VALUES (@Nombre);";

                    command.Parameters.AddWithValue("@Nombre", nombreAutor);

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

        //Agregar una categoria nueva a la tabla Categoria
        public bool AgregarCategoria(string nombreCategoria)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Editorial (Nombre) VALUES (@NombreCategoria);";

                    command.Parameters.AddWithValue("@NombreCategoria", nombreCategoria);

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


        //Obtener ID de la Categoria
        public int ObtenerIdCategoria(string categoria)
        {
            int Idcategoria = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id_Categoria" + "FROM Categoria" + "WHERE Nombre = @Categoria;";

                    command.Parameters.AddWithValue("@Categoria", categoria);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        Idcategoria = Convert.ToInt32(result);
                    }
                }
            }

            return Idcategoria;
        }


        //Obtener el ID del Autor
        public int ObtenerIdAutor(string autor)
        {
            int IdAutor = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id_Autor" + "FROM Autor" + "WHERE Nombre = @Autor;";

                    command.Parameters.AddWithValue("@Autor", autor);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        IdAutor = Convert.ToInt32(result);
                    }
                }
            }

            return IdAutor;
        }


        //Obtener ID de la Editorial
        public int ObtenerIdEditorial(string editorial)
        {
            int IdEditorial = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id_Editorial" + "FROM Editorial" + "WHERE NombreEditorial = @Editorial;";

                    command.Parameters.AddWithValue("@Editorial", editorial);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        IdEditorial = Convert.ToInt32(result);
                    }
                }
            }

            return IdEditorial;
        }


        //Agregar un libro a la tabla Libro
       /** public bool AgregarProducto(string titulo, string editorial, string autor, string descripcion, string categoria, string PrecioUnitario, string Stock, string Imagen)
        {
            bool editorialAgregada = AgregarEditorial(editorial);
            bool AutorAgregado = AgregarAutor(autor);
            bool categoriaAgregado = AgregarCategoria(categoria);

            if (!editorialAgregada && !AutorAgregado && !categoriaAgregado)
            {
                return false;
            }

            int idCategoria = ObtenerIdCategoria(categoria);
            int idEditorial = ObtenerIdEditorial(editorial);
            int idAutor = ObtenerIdAutor(autor);

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Libro (NombreProducto, Descripcion, PrecioUnitario, Imagen, Stock, Id_Categoria, Id_Editorial, Id_Autor) VALUES (@Nombre, @Descripcion, @Precio, @Imagen, @Stock, @IdCategoria, @IdEditorial, @IdAutor);";

                    command.Parameters.AddWithValue("@Nombre", titulo);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Precio", PrecioUnitario);
                    command.Parameters.AddWithValue("@Imagen", Imagen);
                    command.Parameters.AddWithValue("@Stock", Stock);
                    command.Parameters.AddWithValue("@IdCategoria", 1);
                    command.Parameters.AddWithValue("@IdEditorial", 1);
                    command.Parameters.AddWithValue("@IdAutor", 1);

                }

            }

        }*/
    }

}
