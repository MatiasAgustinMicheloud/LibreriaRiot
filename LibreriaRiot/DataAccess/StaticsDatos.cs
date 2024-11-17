using Common.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaRiot.DataAccess
{
    internal class StaticsDatos : ConnectionToSql
    {
        public List<Tuple<int, string, float>> MejoresClientes()
        {
            List<Tuple<int, string, float>> mejoresClientes = new List<Tuple<int, string, float>>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                SELECT TOP 3 
                    c.Id_Cliente,
                    (p.Nombre + ' ' + p.Apellido) AS NombreCompleto,
                    SUM(vd.SubTotalProducto) AS TotalVentas 
                FROM Cliente c 
                INNER JOIN Persona p ON c.Id_Persona = p.Id_Persona 
                INNER JOIN Venta_Cabecera vc ON c.Id_Cliente = vc.Id_Cliente 
                INNER JOIN Venta_Detalle vd ON vc.Id_VentaCabecera = vd.Id_VentaCabecera 
                WHERE vc.Estado = 'activo'
                GROUP BY c.Id_Cliente, p.Nombre, p.Apellido 
                ORDER BY TotalVentas DESC";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idCliente = Convert.ToInt32(reader["Id_Cliente"]);
                            string nombreCompleto = reader["NombreCompleto"].ToString()!;
                            float totalVentas = Convert.ToSingle(reader["TotalVentas"]);
                            mejoresClientes.Add(new Tuple<int, string, float>(idCliente, nombreCompleto, totalVentas));
                        }
                    }
                }
            }
            return mejoresClientes;
        }

        public List<Tuple<string, float>> ObtenerTresUsuariosMasExitosos()
        {

            List<Tuple<string, float>> usuariosMasExitosos = new List<Tuple<string, float>>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP 3 p.Nombre, p.Apellido, SUM(vc.MontoTotal) AS TotalVentas " +
                                          "FROM Usuario u " +
                                          "INNER JOIN Persona p ON u.Id_Persona = p.Id_Persona " +
                                          "INNER JOIN Venta_Cabecera vc ON u.Id = vc.Id_Usuario " +
                                          "WHERE vc.Estado = 'activo' " +
                                          "GROUP BY p.Nombre, p.Apellido " +
                                          "ORDER BY TotalVentas DESC";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString()!;
                            string apellido = reader["Apellido"].ToString()!;
                            float totalVentas = Convert.ToSingle(reader["TotalVentas"]);
                            string nombreCompleto = $"{nombre} {apellido}";
                            usuariosMasExitosos.Add(new Tuple<string, float>(nombreCompleto, totalVentas));
                        }
                    }
                }
            }

            return usuariosMasExitosos;
        }

        public List<Ventas> ObtenerLibrosMasVendidos(int cantidad)
        {
            List<Ventas> librosMasVendidos = new List<Ventas>();

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TOP " + cantidad + " l.NombreProducto, SUM(vd.Cantidad) AS TotalVendido " +
                                        "FROM Venta_Detalle vd " +
                                        "INNER JOIN Venta_Cabecera vc ON vd.Id_VentaCabecera = vc.Id_VentaCabecera " +
                                        "INNER JOIN Libro l ON vd.Id_Libro = l.Id_Libro " +
                                        "WHERE vc.Estado = 'activo' " +
                                        "GROUP BY l.NombreProducto " +
                                        "ORDER BY TotalVendido DESC";

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ventas libroMasVendido = new Ventas
                            {
                                Titulo = reader["NombreProducto"].ToString(),
                                Cantidad = Convert.ToInt32(reader["TotalVendido"])
                            };
                            librosMasVendidos.Add(libroMasVendido);
                        }
                    }
                }
            }

            return librosMasVendidos;
        }

    }
}
