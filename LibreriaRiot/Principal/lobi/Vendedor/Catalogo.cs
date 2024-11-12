using Common.Models;
using Domain;
using Common.Cache;
using FontAwesome.Sharp;
using LibreriaRiot.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaRiot.Principal.lobi.Vendedor
{
    public partial class Catalogo : Form
    {
        private LobiPrincipal instanciaLobi;
        private ProductoModel productModel = new ProductoModel();
        public List<BotonesLibros> listaDeBotones = new List<BotonesLibros>();
        private List<BotonesLibros>? listaBotonesResguardo;
        private List<BotonesLibros>? todosLosLibros;
        private int contador;
        public Catalogo(LobiPrincipal lobi)
        {
            InitializeComponent();
            LlenarProductos();
            this.instanciaLobi = lobi;

            contador = 0;

            if (Carrito.contador != null)
            {
                contador = (int)Carrito.contador;
                lbContador.Text = Carrito.contador.ToString();
            }

            foreach (BotonesLibros btn in listaDeBotones)
            {
                btn.añadirEvento += añadirEvento!;
            }
        }


        private void añadirEvento(object sender, EventArgs e)
        {
            BotonesLibros btn = (BotonesLibros)sender;
            Libro libro = productModel.ObtenerLibroId(btn.idLibro);

            Carrito.AgregarLibro(libro);

            lbContador.Text = Carrito.contador.ToString();
        }

        private void LlenarProductos()
        {
            productModel.LlenarCatalogo(flowLayoutPanel, this);
            listaBotonesResguardo = listaDeBotones;
            todosLosLibros = listaBotonesResguardo.ToList();
        }

        private void btnVerCarrito_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Vendedor.RealizarVenta(this, instanciaLobi));
        }

        private void opcionesCategorias()
        {
            ProductoModel productModel = new();
            var categorias = productModel.ObtenerCategorias();

            categorias.Insert(0, "Categorias");

            cBBuscadorGenero.DataSource = categorias;
            cBBuscadorGenero.SelectedIndex = 0;
        }

        private void MostrarTodosLosLibros()
        {
            flowLayoutPanel.Controls.Clear();

            foreach (var libro in todosLosLibros!)
            {
                flowLayoutPanel.Controls.Add(libro);
            }
        }

        private void FiltrarProductosCategoria()
        {
            string textoBusquedaCategoria = cBBuscadorGenero.Text;

            if (textoBusquedaCategoria.Equals("Categorias", StringComparison.OrdinalIgnoreCase))
            {
                MostrarTodosLosLibros();
            }
            else
            {
                var librosFiltrados = todosLosLibros!
                    .Where(libro => libro.Categorias.Equals(textoBusquedaCategoria, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                flowLayoutPanel.Controls.Clear();

                foreach (var libro in librosFiltrados)
                {
                    flowLayoutPanel.Controls.Add(libro);
                }
            }
        }

        private void cBBuscadorPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarProductosCategoria();
        }

        private void BusquedaProductos()
        {
            string textoBusquedaTitulo = txtBuscadorNombre.Text.ToLower();
            if (string.IsNullOrEmpty(textoBusquedaTitulo))
            {
                foreach (var libro in listaBotonesResguardo!)
                {
                    flowLayoutPanel.Controls.Add(libro);
                }
                return;
            }
            var librosFiltrados = flowLayoutPanel.Controls.OfType<BotonesLibros>()
                .Where(libro => string.IsNullOrEmpty(textoBusquedaTitulo) || libro.tituloLibro.ToLower().Contains(textoBusquedaTitulo))
                .ToList();

            flowLayoutPanel.Controls.Clear();

            foreach (var libro in librosFiltrados)
            {
                flowLayoutPanel.Controls.Add(libro);
            }
        }

        private void txtBuscadorNombre_TextChanged(object sender, EventArgs e)
        {
            BusquedaProductos();
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            opcionesCategorias();
        }

        public void LoadLabelContador()
        {
            lbContador.Text = Carrito.contador.ToString();
        }
    }
}
