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
using Common.Models;
using Domain;
using System.Net;
using LibreriaRiot.Domain;
using LibreriaRiot.Common.Models;

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
            string titulo = txtTitulo.Text;
            string editorial = cbEditorial.Text;
            string autor = cbAutor.Text;
            string descripcion = txtDescripcion.Text;
            string categoria = cbCategoria.Text;
            string precio = txtPrecio.Text;
            string stock = txtStock.Text;
            string imagen = pbPortada.Text;

            ProductoModel productoModel = new ProductoModel();

            // Ocultar todas las etiquetas de error al iniciar la validación
            lbErrorMenssage1.Visible = false;
            lbErrorMenssage2.Visible = false;
            lbErrorMenssage3.Visible = false;
            lbErrorMenssage4.Visible = false;
            lbErrorMenssage5.Visible = false;
            lbErrorMenssage6.Visible = false;
            lbErrorMenssage7.Visible = false;
            lbErrorMenssage8.Visible = false;


            if (string.IsNullOrWhiteSpace(titulo))
            {
                msgError("Debe ingresar un Titulo", lbErrorMenssage1);
            }
            else if (cbEditorial.SelectedIndex == 0 || cbEditorial.SelectedItem.ToString() == "")
            {

                msgError("Por favor, selecciona una Editorial", lbErrorMenssage2);

            }
            else if (cbAutor.SelectedIndex == 0 || cbAutor.SelectedItem.ToString() == "")
            {

                msgError("Por favor, selecciona un Autor", lbErrorMenssage3);

            }
            else if (string.IsNullOrWhiteSpace(descripcion))
            {

                msgError("Debe ingresar una Descripcion", lbErrorMenssage4);
            }
            else if (cbCategoria.SelectedIndex == 0 || cbCategoria.SelectedItem.ToString() == "")
            {
                msgError("Por favor, selecciona una Categoria.", lbErrorMenssage5);

            }
            else if (!float.TryParse(precio, out float precioN))
            {

                msgError("Debe ingresar el Precio Numerico", lbErrorMenssage6);

            }
            else if (!int.TryParse(stock, out int stockN))
            {

                msgError("Debe ingresar el Stock Numerico", lbErrorMenssage7);

            }
            else if (string.IsNullOrEmpty(imagenName))
            {
                msgError("Ingrese una imagen", lbErrorMenssage8);
            }
            else
            {
                // Mostrar mensaje de confirmación
                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea registrar este producto?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Llama al método AgregarNuevoProducto con los valores convertidos
                    int idEditorial = productoModel.ObtenerIdEditorial(editorial);
                    int idAutor = productoModel.ObtenerIdAutor(autor);
                    int idCategoria = productoModel.ObtenerIdCategoria(categoria);

                    bool productoAgregado = productoModel.AgregarNuevoProducto(titulo, descripcion, precio, stock, imagenName!, idCategoria, idEditorial, idAutor);

                    if (productoAgregado)
                    {
                        // Copia la imagen a la carpeta de destino
                        File.Copy(fileActualPath!, fileSavePath!);

                        MessageBox.Show("Libro agregado exitosamente: " + titulo, "Libro Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema al agregar el libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

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

        private void opcionesCategoria()
        {
            ProductoModel productoModel = new ProductoModel();
            var categorias = productoModel.ObtenerCategorias();

            // Agrega el mensaje predeterminado al comienzo de la lista
            categorias.Insert(0, "Seleccione Categoría");

            // Asigna la lista de categorías como DataSource del ComboBox
            cbCategoria.DataSource = categorias;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cbCategoria.SelectedIndex = 0;
        }

        private void opcionesEditorial()
        {
            ProductoModel productoModel = new ProductoModel();
            var editorial = productoModel.ObtenerEditoriales();

            editorial.Insert(0, "Seleccione Editorial");

            cbEditorial.DataSource = editorial;

            cbEditorial.SelectedIndex = 0;
        }

        private void opcionesAutores()
        {
            ProductoModel productoModel = new ProductoModel();
            var autor = productoModel.ObtenerAutores();

            autor.Insert(0, "Seleccione Autor");

            cbAutor.DataSource = autor;

            cbAutor.SelectedIndex = 0;
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

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            opcionesCategoria();
            opcionesEditorial();
            opcionesAutores();
        }
    }
}
