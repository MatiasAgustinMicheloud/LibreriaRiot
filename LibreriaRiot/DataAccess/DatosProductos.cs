﻿using System;
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
using LibreriaRiot.Principal.lobi.Vendedor;
using LibreriaRiot.Common.Models;




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

                    // Verifica si la editorial ya existe
                    command.CommandText = "SELECT COUNT(*) FROM Editorial WHERE NombreEditorial = @NombreEditorial";
                    command.Parameters.AddWithValue("@NombreEditorial", nombreEditorial);

                    int existingCount = Convert.ToInt32(command.ExecuteScalar());

                    // Si ya existe, no se agrega de nuevo
                    if (existingCount > 0)
                    {
                        Console.WriteLine("La editorial ya existe en la base de datos.");
                        return false;
                    }

                    // Si no existe, se agrega
                    command.CommandText = "INSERT INTO Editorial (NombreEditorial) VALUES (@NombreEditorial)";
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

                    // Verifica si el autor ya existe
                    command.CommandText = "SELECT COUNT(*) FROM Autor WHERE Nombre = @Nombre";
                    command.Parameters.AddWithValue("@Nombre", nombreAutor);

                    int existingCount = Convert.ToInt32(command.ExecuteScalar());

                    // Si ya existe, no se agrega de nuevo
                    if (existingCount > 0)
                    {
                        Console.WriteLine("El autor ya existe en la base de datos.");
                        return false;
                    }

                    // Si no existe, se agrega
                    command.CommandText = "INSERT INTO Autor (Nombre) VALUES (@Nombre)";
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

                    // Verifica si la editorial ya existe
                    command.CommandText = "SELECT COUNT(*) FROM Categoria WHERE Nombre = @Nombre";
                    command.Parameters.AddWithValue("@Nombre", nombreCategoria);

                    int existingCount = Convert.ToInt32(command.ExecuteScalar());

                    // Si ya existe, no se agrega de nuevo
                    if (existingCount > 0)
                    {
                        Console.WriteLine("La categoria ya existe en la base de datos.");
                        return false;
                    }

                    command.CommandText = "INSERT INTO Categoria (Nombre) VALUES (@Nombre);";
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
        public int ObtenerIdCategoria(string nameCategoria)
        {
            int categoria = 0;

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id_Categoria FROM Categoria WHERE Nombre = @Nombre";
                    command.Parameters.AddWithValue("@Nombre", nameCategoria);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        categoria = Convert.ToInt32(result);
                    }
                }
            }
            return categoria;
        }


        //Obtener el ID del Autor
        public int ObtenerIdAutor(string nameAutor)
        {
            int autor = 0;
            string nombreAutor = nameAutor != null ? nameAutor : "";

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Id_Autor FROM Autor WHERE Nombre = @Nombre";
                    command.Parameters.AddWithValue("@Nombre", nombreAutor);

                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        autor = Convert.ToInt32(result);
                    }
                }
            }
            return autor;
        }


        //Obtener ID de la Editorial
        public int ObtenerIdEditorial(string nameEditorial)
        {
                int editorialId = 0;

                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT Id_Editorial FROM Editorial WHERE NombreEditorial = @NombreEditorial";
                        command.Parameters.AddWithValue("@NombreEditorial", nameEditorial);

                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            editorialId = Convert.ToInt32(result);
                        }
                    }
                }
            return editorialId;
        }


        //Agregar un libro a la tabla Libro
                      
        public bool AgregarProducto(string titulo, string descripcion, string precio, string Stock, string Imagen, int idCategoria, int idEditorial, int idAutor)
        {
          
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO Libro (NombreProducto, Descripcion, PrecioUnitario, Imagen, Stock, Id_Categoria, Id_Editorial, Id_Autor) VALUES (@Nombre, @Descripcion, @Precio, @Imagen, @Stock, @IdCategoria, @IdEditorial, @IdAutor);";

                    command.Parameters.AddWithValue("@Nombre", titulo);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@Precio", precio);
                    command.Parameters.AddWithValue("@Imagen", Imagen);
                    command.Parameters.AddWithValue("@Stock", Stock);
                    command.Parameters.AddWithValue("@IdCategoria", idCategoria);
                    command.Parameters.AddWithValue("@IdEditorial", idEditorial);
                    command.Parameters.AddWithValue("@IdAutor", idAutor);

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

        public List<string> ObtenerCategorias()
        {
            using (var connection = GetConnection())
            {
                List<string> categorias = new List<string>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT Nombre FROM Categoria";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categorias.Add(reader["Nombre"].ToString());
                        }
                    }
                }

                return categorias;
            }
        }

        public List<string> ObtenerAutores()
        {
            using (var connection = GetConnection())
            {
                List<string> autores = new List<string>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT Nombre FROM Autor";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autores.Add(reader["Nombre"].ToString());
                        }
                    }
                }

                return autores;
            }
        }

        public List<string> ObtenerEditoriales()
        {
            using (var connection = GetConnection())
            {
                List<string> editoriales = new List<string>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT NombreEditorial FROM Editorial";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            editoriales.Add(reader["NombreEditorial"].ToString());
                        }
                    }
                }

                return editoriales;
            }
        }

        public List<Editorial> ObtenerTipoEditorial()
        {
            using (var connection = GetConnection())
            {
                List<Editorial> editoriales = new List<Editorial>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT * FROM Editorial";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Editorial ed = new Editorial();
                            ed.Id_Editorial = reader.GetInt32(0);
                            ed.NombreEditorial = reader.GetString(1);
                            editoriales.Add((ed));
                        }
                    }
                }

                return editoriales;
            }
        }

        public List<Autor> ObtenerTipoAutor()
        {
            using (var connection = GetConnection())
            {
                List<Autor> autores = new List<Autor>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT * FROM Autor";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Autor au = new Autor();
                            au.Id_Autor = reader.GetInt32(0);
                            au.Nombre = reader.GetString(1);
                            autores.Add((au));
                        }
                    }
                }

                return autores;
            }
        }

        public List<Categoria> ObtenerTipoCategoria()
        {
            using (var connection = GetConnection())
            {
                List<Categoria> categorias = new List<Categoria>();
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    string query = "SELECT * FROM Categoria";
                    command.CommandText = query;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categoria ca = new Categoria();
                            ca.Id_Categoria = reader.GetInt32(0);
                            ca.Nombre = reader.GetString(1);
                            categorias.Add((ca));
                        }
                    }
                }

                return categorias;
            }
        }

        public List<Libro> ObtenerProductos()
        {
            List<Libro> productos = new List<Libro>();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT L.*, A.Nombre AS Autor, E.NombreEditorial AS Editorial, C.Nombre AS Categoria " +
                                          "FROM Libro L " +
                                          "INNER JOIN Autor A ON L.Id_Autor = A.Id_Autor " +
                                          "INNER JOIN Editorial E ON L.Id_Editorial = E.Id_Editorial " +
                                          "INNER JOIN Categoria C ON L.Id_Categoria = C.Id_Categoria";

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Libro libro = new Libro();
                            libro.Id_Libro = reader.GetInt32(0);
                            libro.Titulo = reader.GetString(1);
                            libro.Descripcion = reader.GetString(2);
                            libro.Precio = reader.GetDouble(3);
                            libro.Imagen = reader.GetString(4);
                            libro.Stock = reader.GetInt32(5);
                            libro.Baja = reader.GetString(6);
                            libro.Id_Categoria = reader.GetInt32(7);
                            libro.Categoria = reader.GetString(12);
                            libro.Id_Editorial = reader.GetInt32(8);
                            libro.Editorial = reader.GetString(11);
                            libro.Id_Autor = reader.GetInt32(9);
                            libro.Autor = reader.GetString(10);
                            productos.Add(libro);
                        }
                    }
                }
            }

            return productos;
        }


        public Libro ObtenerProductoId(int idLibro)
        {
            Libro producto = new();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "SELECT L.*, A.Nombre AS Autor, E.NombreEditorial AS Editorial, C.Nombre AS Categoria " +
                                          "FROM Libro L " +
                                          "INNER JOIN Autor A ON L.Id_Autor = A.Id_Autor " +
                                          "INNER JOIN Editorial E ON L.Id_Editorial = E.Id_Editorial " +
                                          "INNER JOIN Categoria C ON L.Id_Categoria = C.Id_Categoria " +
                                          "WHERE L.Id_Libro = @ProductId";

                    comando.Parameters.AddWithValue("@ProductId", idLibro);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read()) // Verificar si hay datos para leer
                        {
                            producto.Id_Libro = reader.GetInt32(0);
                            producto.Titulo = reader.GetString(1);
                            producto.Descripcion = reader.GetString(2);
                            producto.Precio = reader.GetDouble(3);
                            producto.Imagen = reader.GetString(4);
                            producto.Stock = reader.GetInt32(5);
                            producto.Baja = reader.GetString(6);
                            producto.Id_Categoria = reader.GetInt32(7);
                            producto.Categoria = reader.GetString(12);
                            producto.Id_Editorial = reader.GetInt32(8);
                            producto.Editorial = reader.GetString(11);
                            producto.Id_Autor = reader.GetInt32(9);
                            producto.Autor = reader.GetString(10);
                        }
                    }
                }
            }

            return producto;
        }


        public bool ActualizarLibro(int idLibro, string titulo, string descripcion, double precio, string imagen, int stock, string baja, int idCategoria, int idAutor, int idEditorial)
        {
            Libro libroEditar = ObtenerProductoId(idLibro);

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Libro SET NombreProducto = @NombreProducto, Descripcion = @Descripcion, PrecioUnitario = @PrecioUnitario, Imagen = @Imagen, Stock = @Stock, Baja = @Baja, Id_Categoria = @Id_Categoria, Id_Editorial = @Id_Editorial, Id_Autor = @Id_Autor WHERE Id_Libro = @Id_Libro";

                    command.Parameters.AddWithValue("@NombreProducto", titulo);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@PrecioUnitario", precio);
                    command.Parameters.AddWithValue("@Imagen", imagen);
                    command.Parameters.AddWithValue("@Stock", stock);
                    command.Parameters.AddWithValue("@Baja", baja);
                    command.Parameters.AddWithValue("@Id_Categoria", idCategoria);
                    command.Parameters.AddWithValue("@Id_Libro", idLibro);
                    command.Parameters.AddWithValue("@Id_Autor", idAutor);
                    command.Parameters.AddWithValue("@Id_Editorial", idEditorial);

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

        public bool ActualizarEditorial(int idEditorial, string nombreNuevo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Editorial SET NombreEditorial = @NombreEditorial WHERE Id_Editorial = @Id_Editorial";

                    command.Parameters.AddWithValue("@NombreEditorial", nombreNuevo);
                    command.Parameters.AddWithValue("@Id_Editorial", idEditorial);

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


        public bool ActualizarAutor(int id, string nombreNuevo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Autor SET Nombre = @Nombre WHERE Id_Autor = @Id";

                    command.Parameters.AddWithValue("@Nombre", nombreNuevo);
                    command.Parameters.AddWithValue("@Id", id);

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

        public bool ActualizarCategoria(int id, string nombreNuevo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Categoria SET Nombre = @Nombre WHERE Id_Categoria = @Id";

                    command.Parameters.AddWithValue("@Nombre", nombreNuevo);
                    command.Parameters.AddWithValue("@Id", id);

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

        public void LlenarBotones(FlowLayoutPanel Contenedor, Catalogo catalog)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Libro WHERE baja = 'NO' AND stock > 0";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Id_Libro = Convert.ToInt32(reader[0]);
                            Libro libro = ObtenerProductoId(Id_Libro);

                            BotonesLibros btn = new BotonesLibros();
                            btn.idLibro = libro.Id_Libro;
                            btn.tituloLibro = libro.Titulo!;
                            btn.descripcionLibro = libro.Descripcion!;
                            btn.precioLibro = "$" + libro.Precio.ToString("N2");
                            btn.stockLibro = "Stock " + libro.Stock.ToString();
                            btn.Autor = libro.Autor!;
                            btn.Editoriales = libro.Editorial!;
                            btn.Categorias = libro.Categoria!;

                            // Cargar la imagen desde el archivo y establecerla en el botón
                            string libroPath = Path.Combine("..", "..", "..", "Principal/lobi/imagenes", libro.Imagen!);
                            if (File.Exists(libroPath))
                            {
                                btn.imagenLibro = Image.FromFile(libroPath);
                            }

                            Contenedor.Controls.Add(btn);
                            catalog.listaDeBotones.Add(btn);
                        }
                    }
                }
            }
        }




    }
}
