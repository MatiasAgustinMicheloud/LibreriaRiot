using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using DataAccess;
using Domain;
using LibreriaRiot.DataAccess;

namespace Domain
{
    internal class StaticsModel
    {
        private StaticsDatos statisticsDatos = new();
        public List<Tuple<int, string, float>> ClientesDestacados()
        {
            // Llama al método MejoresClientes y retorna el resultado directamente.
            return statisticsDatos.MejoresClientes();
        }

        public List<Tuple<string, float>> EmpleadosDestacados()
        {
            return statisticsDatos.ObtenerTresUsuariosMasExitosos();
        }

        public List<Ventas> MostrarCantidadLibros()
        {
            int cantidad = 3;
            return statisticsDatos.ObtenerLibrosMasVendidos(cantidad);
        }

    }
}
