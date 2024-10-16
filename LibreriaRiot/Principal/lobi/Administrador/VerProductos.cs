using Common.Models;
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

namespace LibreriaRiot.Principal.lobi.Administrador
{
    public partial class VerProductos : Form
    {
        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
        private string? fileSavePath;
        private string? fileActualPath;
        private string? imagenName;
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
            int idEditorial = cbEditorial.SelectedIndex;
            int idAutor = cbAutor.SelectedIndex;
            string nuevaDescripcion = txtDescripcion.Text;
            int idCategoria = cbCategoria.SelectedIndex;
            string precio = txtPrecio.Text;
            string stock = txtStock.Text;
            string nuevoEstado = checkBoxSi.Checked ? "SI" : "NO";



            lbErrorMenssage.Visible = false;

            // Indicador de error
            bool error = false;

            // Validaciones
            if (string.IsNullOrWhiteSpace(nuevoTitulo))
            {
                msgError("Debe ingresar un Titulo");
                error = true;
            }
            else if (nuevoTitulo.Any(char.IsDigit))
            {
                msgError("El Titulo no puede contener números");
                error = true;
            }
            else if (cbEditorial.SelectedIndex == -1 || cbEditorial.SelectedItem.ToString() == "")
            {
                msgError("Por favor, selecciona una Editorial.");
                error = true;
            }
            else if (cbAutor.SelectedIndex == -1 || cbAutor.SelectedItem.ToString() == "")
            {
                msgError("Por favor, selecciona un Autor.");
                error = true;
            }
            else if (string.IsNullOrWhiteSpace(nuevaDescripcion))
            {
                msgError("Debe ingresar una descripcion");
                error = true;
            }
            else if (nuevaDescripcion.Any(char.IsDigit))
            {
                msgError("El campo descripcion no puede contener números");
                error = true;
            }
            else if (cbCategoria.SelectedIndex == -1 || cbCategoria.SelectedItem.ToString() == "")
            {
                msgError("Por favor, selecciona una Categoria.");
                error = true;
            }
            else if (string.IsNullOrWhiteSpace(precio))
            {
                msgError("Debe ingresar un precio.");
                error = true;
            }
            else if (!int.TryParse(precio, out int precioN))
            {
                msgError("EL precio tiene que ser numérico");
                error = true;
            }
            else if (string.IsNullOrWhiteSpace(stock))
            {
                msgError("Debe ingresar un Stock.");
                error = true;
            }
            else if (!int.TryParse(stock, out int stockN))
            {
                msgError("EL Stock tiene que ser numérico");
                error = true;
            }
            else if (string.IsNullOrEmpty(imagenName))
            {
                msgError("Ingrese una imagen");
                error = true;
            }

            // Si no hay errores, mostrar el mensaje de éxito
            if (!error)
            {
                MessageBox.Show("Libro modificado exitosamente: " + nuevoTitulo,
                    "Modificar libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AlmacenDatos.ListaDatos;
            dataGridView1.Columns["Portada"].Width = 100;

            if (dataGridView1.Columns["Portada"] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)dataGridView1.Columns["Portada"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }

        }

        private void checkBoxSi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSi.Checked)
            {
                checkBoxNo.Checked = false; // Desmarca el otro CheckBox
            }
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNo.Checked)
            {
                checkBoxSi.Checked = false; // Desmarca el otro CheckBox
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            cbEditorial.SelectedIndex = -1;
            txtDescripcion.Clear();
            cbAutor.SelectedIndex = -1;
            txtPrecio.Clear();
            txtStock.Clear();
            pbPortada.Image = null;
            cbCategoria.SelectedIndex = -1;
            txtTitulo.Focus();
        }

        private void btAgregarImagen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile = new()
            {
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Multiselect = false,
                Title = "Seleccione una Imagen",
            };

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imagenName = Guid.NewGuid().ToString() + ".png" + ".jpg" + ".jpeg";
                    string actualName = openFile.SafeFileName;
                    fileSavePath = Path.Combine("..", "..", "..", "Principal/lobi/imagenes", imagenName);
                    string selectedImagePath = openFile.FileName;
                    fileActualPath = selectedImagePath;

                    // Intenta cargar la imagen desde el archivo
                    pbPortada.Image = Image.FromFile(fileActualPath);


                }
                catch (Exception ex)
                {
                    // Manejar la excepción aquí, puedes mostrar un mensaje de error
                    MessageBox.Show("No se pudo agregar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
