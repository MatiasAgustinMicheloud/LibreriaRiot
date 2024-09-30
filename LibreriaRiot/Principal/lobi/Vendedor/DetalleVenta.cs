using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaRiot.Principal.lobi.Vendedor
{
    public partial class DetalleVenta : Form
    {
        private LobiPrincipal instanciaLobi;
        public DetalleVenta(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void msgError(string msg, Label label)
        {
            label.Text = "        " + msg;
            label.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string FormaPago = cbMetodoPago.Text;
            string TipoPago = cbTipoFactura.Text;

            lbErrorMenssage1.Visible = false;
            lbErrorMenssage2.Visible = false;

            bool error = false;

            if (cbMetodoPago.SelectedIndex == -1 || cbMetodoPago.SelectedItem.ToString() == "")
            {

                msgError("Por favor, selecciona una Forma de Pago", lbErrorMenssage1);
                error = true;
            }
            else if (cbTipoFactura.SelectedIndex == -1 || cbTipoFactura.SelectedItem.ToString() == "")
            {

                msgError("Por favor, seleccione un tipo de factura", lbErrorMenssage2);
                error = true;
            }

            if (!error)
            {
                DialogResult confirmResult = MessageBox.Show("¿Desea confirmar la venta?", "Confirmar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    MessageBox.Show("Pago confirmado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    instanciaLobi.OpenChildForm(new Vendedor.DetalleFactura(instanciaLobi));
                }


            }


        }

        private void LimpiarCampos()
        {

            cbMetodoPago.SelectedIndex = -1;
            cbTipoFactura.SelectedIndex = -1;

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Vendedor.RealizarVenta(instanciaLobi));
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Vendedor.CargarCliente(instanciaLobi));
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Vendedor.VerClientes(instanciaLobi));
        }


    }
}
