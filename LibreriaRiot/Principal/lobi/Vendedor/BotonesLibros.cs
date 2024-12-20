﻿using System;
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
    public partial class BotonesLibros : UserControl
    {
        private int id = 0;
        public BotonesLibros()
        {
            InitializeComponent();
            btAñadir.Click += delegate { añadirEvento?.Invoke(this, EventArgs.Empty); };
        }

        public int idLibro
        {
            get { return id; }
            set { id = value; }
        }

        public string descripcionLibro
        {
            get { return rtbDescripcionCatalogo.Text; }
            set { rtbDescripcionCatalogo.Text = value; }
        }

        public Image imagenLibro
        {
            get { return pbImagenCatalogo.Image; }
            set { pbImagenCatalogo.Image = value; }
        }

        public string tituloLibro
        {
            get { return lbTituloCatalog.Text; }
            set { lbTituloCatalog.Text = value; }
        }

        public string precioLibro
        {
            get { return lbPrecioCatalogo.Text; }
            set { lbPrecioCatalogo.Text = value; }
        }

        public string Autor
        {
            get; set;
        }

        public string Editoriales
        {
            get; set;
        }

        public string Categorias
        {
            get; set;
        }

        public string stockLibro
        {
            get { return lbStockCatalogo.Text; }
            set { lbStockCatalogo.Text = value; }
        }

        public event EventHandler? añadirEvento;

    }
}
