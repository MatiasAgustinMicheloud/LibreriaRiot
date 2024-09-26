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

        private void msgError(string msg, Label label)
        {
            label.Text = "        " + msg;
            label.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProd = txtTitulo.Text;
            string precioStr = txtPrecio.Text;
            string descripcion = txtDescripcion.Text;
            string stockStr = txtStock.Text;

            // Ocultar todas las etiquetas de error al iniciar la validación
            lbErrorMenssage1.Visible = false;
            lbErrorMenssage2.Visible = false;
            lbErrorMenssage3.Visible = false;
            lbErrorMenssage4.Visible = false;
            lbErrorMenssage5.Visible = false;
            lbErrorMenssage6.Visible = false;
            lbErrorMenssage7.Visible = false;
            lbErrorMenssage8.Visible = false;


            if (string.IsNullOrWhiteSpace(nombreProd))
            {
                msgError("Debe ingresar un nombre", lbErrorMenssage1);
            }
            else if (cbEditorial.SelectedIndex == -1 || cbEditorial.SelectedItem.ToString() == "")
            {

                msgError("Por favor, selecciona una Editorial", lbErrorMenssage2);

            }
            else if (cbAutor.SelectedIndex == -1 || cbAutor.SelectedItem.ToString() == "")
            {

                msgError("Por favor, selecciona un Autor", lbErrorMenssage3);

            }
            else if (string.IsNullOrWhiteSpace(descripcion))
            {

                msgError("Debe ingresar una Descripcion", lbErrorMenssage4);
            }
            else if (cbCategoria.SelectedIndex == -1 || cbCategoria.SelectedItem.ToString() == "")
            {
                msgError("Por favor, selecciona una Categoria.", lbErrorMenssage5);

            }
            else if (!float.TryParse(precioStr, out float precio))
            {

                msgError("Debe ingresar el Precio,Numerico", lbErrorMenssage6);

            }
            else if (!int.TryParse(stockStr, out int stock))
            {

                msgError("Debe ingresar el Stock,Numerico", lbErrorMenssage7);

            }
            else if (string.IsNullOrEmpty(imagenName))
            {
                msgError("Ingrese una imagen", lbErrorMenssage8);
            }
            else
            {
                Datos nuevoDato = new Datos()
                {
                    Titulo = nombreProd,
                    Descripcion = descripcion,
                    Editorial = cbEditorial.Text,
                    Autor = cbAutor.Text,
                    Precio = precioStr,
                    Stock = stockStr,
                    Categoria = cbCategoria.Text,
                    Portada = pbPortada.Image
                };

                AlmacenDatos.ListaDatos.Add(nuevoDato);

                MessageBox.Show("libro agregado correctamente", "libro Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
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

                    // Mostrar la ruta del archivo en el TextBox
                    lbPathTittleP.Text = actualName;
                }
                catch (Exception ex)
                {
                    // Manejar la excepción aquí, puedes mostrar un mensaje de error
                    MessageBox.Show("No se pudo agregar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void LimpiarCampos()
        {
            txtTitulo.Text = "";
            cbEditorial.SelectedIndex = -1;
            txtPrecio.Text = "";
            cbAutor.SelectedIndex = -1;
            txtStock.Text = "";
            txtDescripcion.Text = string.Empty;
            pbPortada.Image = null;
            lbPathTittleP.Text = "";
            cbCategoria.SelectedIndex = -1;
            txtTitulo.Focus();
            lbErrorMenssage2.Text = "";
        }

    }
}
