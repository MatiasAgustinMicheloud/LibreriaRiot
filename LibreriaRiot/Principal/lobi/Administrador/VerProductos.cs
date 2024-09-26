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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            desactivarBotones();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AlmacenDatos.ListaDatos;
            dataGridView1.Columns["Portada"].Width = 100;

            if (dataGridView1.Columns["Portada"] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)dataGridView1.Columns["Portada"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

        }

        private void desactivarBotones()
        {

            txtTitulo.Enabled = false;
            txtEditorial.Enabled = false;
            txtPrecio.Enabled = false;
            txtAutor.Enabled = false;
            txtStock.Enabled = false;
            txtDescripcion.Enabled = false;
            pbPortada.Enabled = false;
            cbCategoria.Enabled = false;
            checkBoxSi.Enabled = false;
            checkBoxNo.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;
        }
    }
}
