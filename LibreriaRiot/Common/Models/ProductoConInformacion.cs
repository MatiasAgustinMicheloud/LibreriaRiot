using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaRiot.Common.Models
{
    internal class ProductoConInformacion
    {
        public int Id { get; set; }
        public string? ProductoNombre { get; set; }
        public string? ProductoDescripcion { get; set; }
        public float ProductoPrecioUnitario { get; set; }
        public string? ProductoImagen { get; set; }
        public int ProductoStock { get; set; }
        public string? ProductoBaja { get; set; }
        public string? ProductoNombreCategoria { get; set; }
        public string? ProductoNombreEditorial { get; set; }
        public string? ProductoNombreAutor { get; set; }
        public int Id_Producto { get; set; }
    }
}
