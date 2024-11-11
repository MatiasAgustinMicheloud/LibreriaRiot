using Common.Models;
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
    public partial class AgregarEditorial : Form
    {
        private LobiPrincipal instanciaLobi;
        private int idEditorialSeleccionado = -1;
        private bool edicionRealizada = false;
        Editorial? editorialSeleccionada;
        private ProductoModel productoModel = new ProductoModel();
        private List<string> editoriales = new List<string>();


        public AgregarEditorial(LobiPrincipal lobi)
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
            string nombre = txtEditorial.Text.Trim();

            lblErrorAgregar.Visible = false;

            if (string.IsNullOrEmpty(nombre))
            {
                msgError("No deje campos vacios!", lblErrorAgregar);
            }
            else
            {
                DialogResult confirmResult = MessageBox.Show("¿Desea registrar la editorial " + nombre + "?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    List<string> editoriales = productoModel.ObtenerEditoriales();
                    bool yaExiste = false;

                    foreach (string editorial in editoriales)
                    {
                        if (editorial.Equals(nombre))
                        {
                            yaExiste = true;
                            break;
                        }
                    }

                    if (!yaExiste)
                    {
                        bool editorialAgregado = productoModel.AgregarEditorial(nombre);

                        if (editorialAgregado)
                        {
                            txtEditorial.Text = "";
                            MessageBox.Show(nombre + " fue registrado con exito!");
                            instanciaLobi.OpenChildForm(new Administrador.AgregarEditorial(instanciaLobi)); //Actualiza el fomulario pare ver la nueva ed en el datagrid

                        }
                        else
                        {
                            msgError("Error! No se pudo registrar", lblErrorAgregar);
                        }

                    }
                    else
                    {
                        txtEditorial.Text = "";
                        msgError("Error! La editorial ya existe", lblErrorAgregar);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            edicionRealizada = false;

            if (idEditorialSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un registro para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreNuevo = txtModificarEditorial.Text;

            lblErrorModificar.Visible = false;

            if (string.IsNullOrEmpty(nombreNuevo))
            {
                msgError("No deje campos vacios!", lblErrorModificar);
            }
            else
            {
                bool cambiosRealizados = !string.Equals(nombreNuevo, editorialSeleccionada?.NombreEditorial, StringComparison.OrdinalIgnoreCase);

                if (!cambiosRealizados)
                {
                    txtModificarEditorial.Text = "";
                    MessageBox.Show("Usted no realizó cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de realizar la modificacion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool exitoEditorial = productoModel.ActualizarEditorial(editorialSeleccionada!.Id_Editorial, nombreNuevo);

                    if (exitoEditorial)
                    {
                        MessageBox.Show("Registro actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtModificarEditorial.Text = "";
                        AgregarEditorial_Load(sender, e);
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

        private void AgregarEditorial_Load(object sender, EventArgs e)
        {
            List<Editorial> editoriales = productoModel.ObtenerTipoEditorial();

            dataGridEditoriales.DataSource = editoriales;

            dataGridEditoriales.Columns["NombreEditorial"].HeaderText = "Nombre Editorial";
            dataGridEditoriales.Columns["Id_Editorial"].HeaderText = "ID Editorial";
            dataGridEditoriales.Columns["NombreEditorial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            //dataGridEditoriales.Columns.Add("columnaTexto", "Nombre Editorial");
            //dataGridEditoriales.Columns["columnaTexto"].DataPropertyName = "NombreEditorial";

            //foreach (string row in editoriales)
            //{
            //    dataGridEditoriales.Rows.Add(row);
            //}
        }


        private void dataGridEditoriales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!edicionRealizada && e.RowIndex >= 0)
            {
                edicionRealizada = true;
                txtModificarEditorial.Enabled = true;

                DataGridViewRow row = dataGridEditoriales.Rows[e.RowIndex];

                // Verificar que DataBoundItem no sea null y sea del tipo Editorial
                if (row.DataBoundItem is Editorial editorial)
                {
                    editorialSeleccionada = editorial;
                    txtModificarEditorial.Text = editorialSeleccionada.NombreEditorial;
                    idEditorialSeleccionado = editorialSeleccionada.Id_Editorial;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el objeto Editorial de la fila seleccionada.");
                }
            }
            else
            {
                edicionRealizada = false;
            }
        }
    }
}
