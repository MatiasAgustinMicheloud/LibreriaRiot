using Common.Models;
using DataAccess;
using LibreriaRiot.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaRiot.Domain
{
    class ProductoModel
    {
        DatosProductos productoDatos = new DatosProductos();

        public bool AgregarNuevoProducto(string titulo,string descripcion, string precio, string stock, string imagen,int idCategoria, int idEditorial, int idAutor)
        {
            return productoDatos.AgregarProducto(titulo, descripcion, precio, stock, imagen,idCategoria, idEditorial, idAutor);

        }

        public int ObtenerIdEditorial(string editorial)
        {
            int IdEditorial = productoDatos.ObtenerIdEditorial(editorial);
            return IdEditorial;
        }

        public int ObtenerIdAutor(string autor)
        {
            int IdAutor = productoDatos.ObtenerIdAutor(autor);
            return IdAutor;
        }

        public int ObtenerIdCategoria(string Categoria)
        {
            int IdCategoria = productoDatos.ObtenerIdCategoria(Categoria);
            return IdCategoria;
        }

        public List<string> ObtenerCategorias()
        {
            return productoDatos.ObtenerCategorias();
        }

        public List<string> ObtenerAutores()
        {
            return productoDatos.ObtenerAutores();
        }

        public List<string> ObtenerEditoriales()
        {
            return productoDatos.ObtenerEditoriales();
        }

        public List<Libro> MostrarProducts()
        {
            return productoDatos.ObtenerProductos();
        }

        public void CargarImagen(Libro libro)
        {
            string libroPath = Path.Combine("..", "..", "..", "Principal/lobi/imagenes", libro.Imagen!);

            libro.ImagenPortada = Image.FromFile(libroPath);

        }

        public bool ActualizarLibro(int idLibro, string titulo, string descripcion, double precio, string imagen, int stock, string baja, int idCategoria, int idAuotor, int idEditorial)
        {
            return productoDatos.ActualizarLibro(idLibro, titulo, descripcion, precio, imagen, stock, baja, idCategoria, idAuotor, idEditorial);
        }
    }
}
