﻿using FontAwesome.Sharp;
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

        public Catalogo(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void btnVerCarrito_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Vendedor.RealizarVenta(instanciaLobi));

        }
    }
}
