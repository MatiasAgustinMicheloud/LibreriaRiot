using Common.Models;
using LibreriaRiot.Domain;
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

        private LobiPrincipal instanciaLobi;
        private ProductoModel productModel = new ProductoModel();
        private List<Libro> libros = new List<Libro>();
        private Libro? libroSeleccionado;
        private int idLibroSeleccionado = -1;
        private string? fileSavePath;
        private string? fileActualPath;
        private string? imagenName;
        private bool edicionRealizada = false;

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
            string? imagenActual = null;
            edicionRealizada = false;


            if (libroSeleccionado != null)
            {
                imagenActual = libroSeleccionado.Imagen;
            }

            if (idLibroSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un libro para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevoTitulo = txtTitulo.Text;
            string nuevaDescripcion = txtDescripcion.Text;
            double nuevoPrecio;
            int nuevoStock;
            string? nuevaEditorial = cbEditorial.SelectedItem as string;
            int idNuevoEditorial = productModel.ObtenerIdEditorial(nuevaEditorial!);
            string? nuevoAutor = cbAutor.SelectedItem as string;
            int idNuevoAutor = productModel.ObtenerIdAutor(nuevoAutor!);
            string? nuevaCategoria = cbCategoria.SelectedItem as string;
            int idNuevaCategoria = productModel.ObtenerIdCategoria(nuevaCategoria!);


            string nuevoEstado = checkBoxSi.Checked ? "SI" : "NO";

            lbErrorMenssage.Visible = false;

            // Validaciones
            if (string.IsNullOrWhiteSpace(nuevoTitulo))
            {
                msgError("Debe ingresar un Titulo");
                return;
            }

            if (nuevoTitulo.Any(char.IsDigit))
            {
                msgError("El Titulo no puede contener números");
                return;
            }

            if (cbEditorial.SelectedIndex == 0 || string.IsNullOrWhiteSpace(cbEditorial.SelectedItem?.ToString()))
            {
                msgError("Por favor, selecciona una Editorial.");
                return;
            }

            if (cbAutor.SelectedIndex == 0 || string.IsNullOrWhiteSpace(cbAutor.SelectedItem?.ToString()))
            {
                msgError("Por favor, selecciona un Autor.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nuevaDescripcion))
            {
                msgError("Debe ingresar una descripcion");
                return;
            }

            if (nuevaDescripcion.Any(char.IsDigit))
            {
                msgError("El campo descripcion no puede contener números");
                return;
            }

            if (cbCategoria.SelectedIndex == 0 || string.IsNullOrWhiteSpace(cbCategoria.SelectedItem?.ToString()))
            {
                msgError("Por favor, selecciona una Categoria.");
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out nuevoPrecio))
            {
                msgError("Debe ingresar un precio válido y numérico.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out nuevoStock))
            {
                msgError("Debe ingresar un Stock válido y numérico.");
                return;
            }

            if (string.IsNullOrEmpty(imagenActual) && string.IsNullOrEmpty(imagenName))
            {
                msgError("Ingrese una imagen.");
                return;
            }

            bool cambiosRealizados = !string.Equals(nuevoTitulo, libroSeleccionado?.Titulo, StringComparison.OrdinalIgnoreCase) ||
                                   !string.Equals(nuevaDescripcion, libroSeleccionado?.Descripcion, StringComparison.OrdinalIgnoreCase) ||
                                   !double.Equals(nuevoPrecio, libroSeleccionado?.Precio) ||
                                   !int.Equals(nuevoStock, libroSeleccionado.Stock) ||
                                   !string.Equals(nuevoEstado, libroSeleccionado.Baja, StringComparison.OrdinalIgnoreCase) ||
                                   idNuevaCategoria != libroSeleccionado.Id_Categoria ||
                                   idNuevoAutor != libroSeleccionado.Id_Autor ||
                                   idNuevoEditorial != libroSeleccionado.Id_Editorial ||
                                   (!string.IsNullOrWhiteSpace(imagenName) && !string.Equals(imagenActual, imagenName, StringComparison.OrdinalIgnoreCase));

            if (!cambiosRealizados)
            {
                LimpiarCamposModificar();
                MessageBox.Show("Usted no realizó cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de realizar estas modificaciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(imagenName) && !string.Equals(imagenActual, imagenName, StringComparison.OrdinalIgnoreCase))
                {
                    libroSeleccionado!.Imagen = imagenName;
                }

                bool exitoLibro = productModel.ActualizarLibro(
                    libroSeleccionado!.Id_Libro,
                    nuevoTitulo,
                    nuevaDescripcion,
                    nuevoPrecio,
                    libroSeleccionado.Imagen!,
                    nuevoStock,
                    nuevoEstado,
                    idNuevaCategoria,
                    idNuevoAutor,
                    idNuevoEditorial
                );

                if (exitoLibro)
                {
                    if (!string.IsNullOrWhiteSpace(imagenName) && !string.Equals(imagenActual, imagenName, StringComparison.OrdinalIgnoreCase))
                    {
                        libroSeleccionado!.Imagen = imagenName;
                        File.Copy(fileActualPath!, fileSavePath!);
                    }
                    imagenName = null;
                    MessageBox.Show("El producto se ha actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposModificar();
                    VerProductos_Load(sender, e);
                }
                else
                {

                    MessageBox.Show("Ha ocurrido un error al actualizar el producto. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("No se realizaron cambios en el producto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LimpiarCamposModificar()
        {
            edicionRealizada = false;
            txtTitulo.Text = "";
            cbAutor.SelectedIndex = 0;
            txtStock.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cbEditorial.SelectedIndex = 0;
            cbCategoria.SelectedIndex = 0;
            checkBoxSi.Checked = false;
            checkBoxNo.Checked = false;
            pbPortada.Image = null;

        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            libros = productModel.MostrarProducts();

            foreach (Libro libro in libros)
            {
                productModel.CargarImagen(libro);
            }

            dataGridProductos.DataSource = libros;

            dataGridProductos.Columns["Id_Categoria"].Visible = false;
            dataGridProductos.Columns["Id_Editorial"].Visible = false;
            dataGridProductos.Columns["Id_Autor"].Visible = false;
            dataGridProductos.Columns["Imagen"].Visible = false;
            dataGridProductos.Columns["Titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridProductos.Columns["Baja"].DisplayIndex = dataGridProductos.Columns.Count - 1;

            dataGridProductos.Columns["ImagenPortada"].DisplayIndex = dataGridProductos.Columns.Count - 2;
            dataGridProductos.Columns["ImagenPortada"].Visible = true;
            dataGridProductos.Columns["ImagenPortada"].HeaderText = "Portada";
            dataGridProductos.Columns["ImagenPortada"].Width = 100;
            dataGridProductos.RowTemplate.Height = 70;
            if (dataGridProductos.Columns["ImagenPortada"] is DataGridViewImageColumn)
            {
                ((DataGridViewImageColumn)dataGridProductos.Columns["ImagenPortada"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            opcionesCategoria();
            opcionesAutores();
            opcionesEditorial();
            BuscadorCategoria();
            BuscadorAutores();
            dataGridProductos.RowPrePaint += DataGridProductos_RowPrePaint!;

        }

        private void DataGridProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridProductos.Rows[e.RowIndex];

            string? valorBaja = row.Cells["Baja"].Value.ToString();

            if (valorBaja == "SI")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(243, 106, 106);
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                row.DefaultCellStyle.BackColor = SystemColors.Window;
                row.DefaultCellStyle.ForeColor = SystemColors.ControlText;
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
            DialogResult limpiar = MessageBox.Show("Esta por realizar la limpieza de los campos. ¿Seguro?.", "Limpieza", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (limpiar == DialogResult.OK)
            {
                LimpiarCamposModificar();
                edicionRealizada = false;
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!edicionRealizada && e.RowIndex >= 0)
            {
                edicionRealizada = true;

                DialogResult confirmResult = MessageBox.Show("¿Desea Realizar una Modificacion al Libro?", "Informe de edición", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (confirmResult == DialogResult.OK)
                {
                    txtTitulo.Enabled = true;
                    txtDescripcion.Enabled = true;
                    checkBoxSi.Enabled = true;
                    checkBoxNo.Enabled = true;
                    cbCategoria.Enabled = true;
                    cbAutor.Enabled = true;
                    cbEditorial.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtStock.Enabled = true;
                    btAgregarImagen.Enabled = true;
                    btnGuardar.Enabled = true;
                    btnLimpiar.Enabled = true;

                    DataGridViewRow row = dataGridProductos.Rows[e.RowIndex];

                    libroSeleccionado = (Libro)row.DataBoundItem;
                    idLibroSeleccionado = libroSeleccionado.Id_Libro;
                    txtTitulo.Text = libroSeleccionado.Titulo;
                    cbEditorial.Text = libroSeleccionado.Editorial;
                    cbAutor.Text = libroSeleccionado.Autor;
                    cbCategoria.Text = libroSeleccionado.Categoria;
                    txtPrecio.Text = libroSeleccionado.Precio.ToString();
                    txtStock.Text = libroSeleccionado.Stock.ToString();
                    txtDescripcion.Text = libroSeleccionado.Descripcion;
                    pbPortada.Image = libroSeleccionado.ImagenPortada;

                    if (libroSeleccionado.Baja == "SI")
                    {
                        checkBoxSi.Checked = true;
                        checkBoxNo.Checked = false;
                    }
                    else
                    {
                        checkBoxSi.Checked = false;
                        checkBoxNo.Checked = true;
                    }

                }
                else
                {
                    edicionRealizada = false;
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


        private void BuscadorCategoria()
        {
            ProductoModel productoModel = new ProductoModel();
            var categorias = productoModel.ObtenerCategorias();

            // Agrega el mensaje predeterminado al comienzo de la lista
            categorias.Insert(0, "Seleccione Categoría");

            // Asigna la lista de categorías como DataSource del ComboBox
            cbBuscadorCategoria.DataSource = categorias;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cbBuscadorCategoria.SelectedIndex = 0;
        }

        private void BuscadorAutores()
        {
            ProductoModel productoModel = new ProductoModel();
            var autor = productoModel.ObtenerAutores();

            autor.Insert(0, "Seleccione Autor");

            cbBuscadorAutor.DataSource = autor;

            cbBuscadorAutor.SelectedIndex = 0;
        }

    }
}
