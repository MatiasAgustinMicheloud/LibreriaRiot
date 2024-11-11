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
    public partial class AgregarCategoria : Form
    {
        private LobiPrincipal instanciaLobi;
        private int idCategoriaSeleccionado = -1;
        private bool edicionRealizada = false;
        Categoria? CategoriaSeleccionada;
        private ProductoModel productoModel = new ProductoModel();
        private List<string> categoria = new List<string>();


        public AgregarCategoria(LobiPrincipal lobi)
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
            string nombre = txtCategoria.Text.Trim();

            lblErrorAgregar.Visible = false;

            if (string.IsNullOrEmpty(nombre))
            {
                msgError("No deje campos vacios!", lblErrorAgregar);
            }
            else
            {
                DialogResult confirmResult = MessageBox.Show("¿Desea registrar la categoria " + nombre + "?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    List<string> categorias = productoModel.ObtenerCategorias();
                    bool yaExiste = false;

                    foreach (string categoria in categorias)
                    {
                        if (categoria.Equals(nombre))
                        {
                            yaExiste = true;
                            break;
                        }
                    }

                    if (!yaExiste)
                    {
                        bool categoriaAgregado = productoModel.AgregarCategoria(nombre);

                        if (categoriaAgregado)
                        {
                            txtCategoria.Text = "";
                            MessageBox.Show(nombre + " fue registrado con exito!");
                            instanciaLobi.OpenChildForm(new Administrador.AgregarCategoria(instanciaLobi)); //Actualiza el fomulario pare ver la nueva ed en el datagrid

                        }
                        else
                        {
                            msgError("Error! No se pudo registrar", lblErrorAgregar);
                        }

                    }
                    else
                    {
                        txtCategoria.Text = "";
                        msgError("Error! La categoria ya existe", lblErrorAgregar);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            edicionRealizada = false;

            if (idCategoriaSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un registro para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreNuevo = txtModificarCategoria.Text;

            lblErrorModificar.Visible = false;

            if (string.IsNullOrEmpty(nombreNuevo))
            {
                msgError("No deje campos vacios!", lblErrorModificar);
            }
            else
            {
                bool cambiosRealizados = !string.Equals(nombreNuevo, CategoriaSeleccionada?.Nombre, StringComparison.OrdinalIgnoreCase);

                if (!cambiosRealizados)
                {
                    txtModificarCategoria.Text = "";
                    MessageBox.Show("Usted no realizó cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de realizar la modificacion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    bool exitoCategoria = productoModel.ActualizarCategoria(CategoriaSeleccionada!.Id_Categoria, nombreNuevo);

                    if (exitoCategoria)
                    {
                        MessageBox.Show("Registro actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtModificarCategoria.Text = "";
                        AgregarCategoria_Load(sender, e);
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

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = productoModel.ObtenerTipoCategoria();

            dataGridCategorias.DataSource = categorias;

            dataGridCategorias.Columns["Nombre"].HeaderText = "Nombre Categoria";
            dataGridCategorias.Columns["Id_Categoria"].HeaderText = "ID Categoria";
            dataGridCategorias.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!edicionRealizada && e.RowIndex >= 0)
            {
                edicionRealizada = true;
                txtModificarCategoria.Enabled = true;

                DataGridViewRow row = dataGridCategorias.Rows[e.RowIndex];

                // Verificar que DataBoundItem no sea null y sea del tipo Editorial
                if (row.DataBoundItem is Categoria categoria)
                {
                    CategoriaSeleccionada = categoria;
                    txtModificarCategoria.Text = CategoriaSeleccionada.Nombre;
                    idCategoriaSeleccionado = CategoriaSeleccionada.Id_Categoria;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el objeto Categoria de la fila seleccionada.");
                }
            }
            else
            {
                edicionRealizada = false;
            }
        }



    }
}
