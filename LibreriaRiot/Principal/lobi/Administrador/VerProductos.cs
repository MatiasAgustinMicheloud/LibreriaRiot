using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaRiot.Principal.lobi.Administrador
{
    public partial class VerProductos : Form
    {
        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
        public VerProductos(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            instanciaLobi.OpenChildForm(new Administrador.AgregarProducto(instanciaLobi));
        }

        private void msgError(string msg)
        {
            lbErrorMenssage.Text = "        " + msg;
            lbErrorMenssage.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevoTitulo = txtTitulo.Text;
            string nuevaDescripcion = txtDescripcion.Text;
            string nuevoEstado = checkBoxSi.Checked ? "SI" : "NO";
            string? nuevoAutor = txtAutor.Text;
            string? nuevaEditorial = txtEditorial.Text;

            if (string.IsNullOrWhiteSpace(nuevoTitulo) || string.IsNullOrWhiteSpace(nuevaDescripcion) || string.IsNullOrWhiteSpace(nuevoAutor) || string.IsNullOrWhiteSpace(nuevaEditorial) ||
             (checkBoxSi.Checked == false && checkBoxNo.Checked == false))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
