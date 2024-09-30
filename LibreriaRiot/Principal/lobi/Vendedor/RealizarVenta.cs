using Common.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaRiot.Principal.lobi.Vendedor
{
    public partial class RealizarVenta : Form
    {
        private LobiPrincipal instanciaLobi;
        public RealizarVenta(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea vaciar el carrito?", "Vaciar Carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                //Vaciar carrito
                MessageBox.Show("Vaciar carrito");
            }
        }
        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea realizar la venta?", "Realizar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                //Ir a formulario detalles venta
                instanciaLobi.OpenChildForm(new Vendedor.DetalleVenta(instanciaLobi));
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            instanciaLobi.OpenChildForm(new Vendedor.Catalogo(instanciaLobi));
        }
    }
}
