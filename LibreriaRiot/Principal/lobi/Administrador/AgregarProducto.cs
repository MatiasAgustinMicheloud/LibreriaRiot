using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibreriaRiot.Principal.lobi.Administrador
{
    public partial class AgregarProducto : Form
    {
        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
        private string? fileSavePath;
        private string? fileActualPath;
        private string? imagenName;
        public AgregarProducto(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            /**Administrador.VerProductos modificarProducto = new Administrador.VerProductos();
            modificarProducto.Show();
            this.Hide();*/

            instanciaLobi.OpenChildForm(new Administrador.VerProductos(instanciaLobi));
        }

        private void msgError(string msg)
        {
            lbErrorMenssage.Text = "        " + msg;
            lbErrorMenssage.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProd = txtTitulo.Text;
            string nombreEditorial = txtEditorial.Text;
            string nombreAutor = txtAutor.Text;
            string precioStr = txtPrecio.Text;
            string descripcion = txtDescripcion.Text;
            string stockStr = txtStock.Text;

            if (string.IsNullOrWhiteSpace(nombreProd) || string.IsNullOrWhiteSpace(nombreEditorial) || string.IsNullOrWhiteSpace(nombreAutor) || string.IsNullOrWhiteSpace(precioStr) || string.IsNullOrWhiteSpace(descripcion))
            {
                msgError("Debe completar todos los campos");
            }
            else if (cbCategoria.SelectedIndex == -1 || cbCategoria.SelectedItem.ToString() == "")
            {
                msgError("Por favor, selecciona una Categoria.");
            }
            else if (!float.TryParse(precioStr, out float precio) || !int.TryParse(stockStr, out int stock))
            {
                msgError("Ingrese valores válidos en los campos numéricos (Precio, Stock)");
            }
            else if (string.IsNullOrEmpty(imagenName))
            {
                msgError("Ingrese una imagen");
            }

        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
