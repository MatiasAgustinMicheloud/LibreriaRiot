﻿using System;
using System.Data.SqlClient;

namespace DataAccess
{

    public abstract class ConnectionToSql 
    {
        //Atributos de la Conexion
        private readonly string connectionString;
        protected SqlConnection sqlConnection;

        //Entras la informacion necesaria de tu servidor y instancias una para la conexion
        public ConnectionToSql()
        {
            connectionString = "Server = DESKTOP-GP6CS2R\\SQLEXPRESS;Database=bd_LibreriaRiot;Integrated Security=true;";
            sqlConnection = new SqlConnection(connectionString);
        }

        //es para crear una cadena de conexion
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}