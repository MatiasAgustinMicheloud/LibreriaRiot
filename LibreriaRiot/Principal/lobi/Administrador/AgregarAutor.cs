using LibreriaRiot.Common.Models;
using LibreriaRiot.Domain;
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
    public partial class AgregarAutor : Form
    {
        private LobiPrincipal instanciaLobi;
        private int idAutorSeleccionado = -1;
        private bool edicionRealizada = false;
        Autor? AutorSeleccionada;
        private ProductoModel productoModel = new ProductoModel();
        private List<string> autores = new List<string>();


        public AgregarAutor(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            instanciaLobi.OpenChildForm(new Administrador.AgregarProducto(instanciaLobi));
        }

        private void msgError(string msg, Label label)
        {
            label.Text = "        " + msg;
            label.Visible = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtAutor.Text.Trim();

            lblErrorAgregar.Visible = false;

            if (string.IsNullOrEmpty(nombre))
            {
                msgError("No deje campos vacios!", lblErrorAgregar);
            }
            else
            {
                DialogResult confirmResult = MessageBox.Show("¿Desea registrar el autor " + nombre + "?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    List<string> editoriales = productoModel.ObtenerAutores();
                    bool yaExiste = false;

                    foreach (string autor in autores)
                    {
                        if (autor.Equals(nombre))
                        {
                            yaExiste = true;
                            break;
                        }
                    }

                    if (!yaExiste)
                    {
                        bool autorAgregado = productoModel.AgregarAutor(nombre);

                        if (autorAgregado)
                        {
                            txtAutor.Text = "";
                            MessageBox.Show(nombre + " fue registrado con exito!");
                            instanciaLobi.OpenChildForm(new Administrador.AgregarAutor(instanciaLobi)); //Actualiza el fomulario pare ver la nueva ed en el datagrid

                        }
                        else
                        {
                            msgError("Error! No se pudo registrar", lblErrorAgregar);
                        }

                    }
                    else
                    {
                        txtAutor.Text = "";
                        msgError("Error! La editorial ya existe", lblErrorAgregar);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            edicionRealizada = false;

            if (idAutorSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un registro para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreNuevo = txtModificarAutor.Text;

            lblErrorModificar.Visible = false;

            if (string.IsNullOrEmpty(nombreNuevo))
            {
                msgError("No deje campos vacios!", lblErrorModificar);
            }
            else
            {
                bool cambiosRealizados = !string.Equals(nombreNuevo, AutorSeleccionada?.Nombre, StringComparison.OrdinalIgnoreCase);

                if (!cambiosRealizados)
                {
                    txtModificarAutor.Text = "";
                    MessageBox.Show("Usted no realizó cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de realizar la modificacion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool exitoAutor = productoModel.ActualizarAutor(AutorSeleccionada!.Id_Autor, nombreNuevo);

                    if (exitoAutor)
                    {
                        MessageBox.Show("Registro actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtModificarAutor.Text = "";
                        AgregarAutor_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al actualizar el registro. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se realizaron cambios en el registro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void AgregarAutor_Load(object sender, EventArgs e)
        {
            List<Autor> autores = productoModel.ObtenerTipoAutor();

            dataGridAutores.DataSource = autores;

            dataGridAutores.Columns["Nombre"].HeaderText = "Nombre Autor";
            dataGridAutores.Columns["Id_Autor"].HeaderText = "ID Autor";
            dataGridAutores.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!edicionRealizada && e.RowIndex >= 0)
            {
                edicionRealizada = true;
                txtModificarAutor.Enabled = true;

                DataGridViewRow row = dataGridAutores.Rows[e.RowIndex];

                // Verificar que DataBoundItem no sea null y sea del tipo Editorial
                if (row.DataBoundItem is Autor autor)
                {
                    AutorSeleccionada = autor;
                    txtModificarAutor.Text = AutorSeleccionada.Nombre;
                    idAutorSeleccionado = AutorSeleccionada.Id_Autor;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el objeto Autor de la fila seleccionada.");
                }
            }
            else
            {
                edicionRealizada = false;
            }
        }


    }
}
