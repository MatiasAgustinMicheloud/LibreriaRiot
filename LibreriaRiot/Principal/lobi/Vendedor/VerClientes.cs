using Common.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaRiot.Principal.lobi.Vendedor
{
    public partial class VerClientes : Form
    {
        private LobiPrincipal instanciaLobi;
        ClienteModel ClienteModel = new ClienteModel();
        private bool edicionRealizada = false;
        private ClienteConInformacion? clienteSeleccionado;
        private int idClienteSeleccionado = -1;
        public VerClientes(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }


        private void msgError(string msg)
        {
            lbErrorMenssage.Text = "        " + msg;
            lbErrorMenssage.Visible = true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void LimpiarCamposModificar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDomicilio.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            dtFechaNac.Value = DateTime.Now;
            checkBoxSi.Checked = false;
            checkBoxNo.Checked = false;
            lbErrorMenssage.Text = "";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            edicionRealizada = false;
            if (idClienteSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un Cliente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            DateTime fechaNacimiento = dtFechaNac.Value; // Se obtiene el valor de la fecha seleccionada
            string mail = txtEmail.Text;
            string domicilio = txtDomicilio.Text;
            string telefonoN = txtTelefono.Text;
            string baja = checkBoxSi.Checked ? "SI" : "NO";



            // Ocultar todas las etiquetas de error al iniciar la validación
            lbErrorMenssage.Visible = false;



            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre))
            {
                msgError("Debe ingresar un nombre");

            }
            else if (nombre.Any(char.IsDigit))
            {
                msgError("El nombre no puede contener números");

            }
            else if (string.IsNullOrWhiteSpace(apellido))
            {
                msgError("Debe ingresar un apellido");

            }
            else if (apellido.Any(char.IsDigit))
            {
                msgError("El apellido no puede contener números");

            }
            else if (string.IsNullOrWhiteSpace(dni))
            {
                msgError("Debe ingresar DNI");

            }
            else if (!int.TryParse(dni, out int DNI))
            {
                msgError("El DNI tiene que ser numérico");

            }
            else if (string.IsNullOrWhiteSpace(domicilio))
            {
                msgError("Debe ingresar un domicilio");

            }
            else if (string.IsNullOrWhiteSpace(telefonoN))
            {
                msgError("Debe ingresar un teléfono.");

            }
            else if (!int.TryParse(telefonoN, out int telefono))
            {
                msgError("EL telefono tiene que ser numérico");

            }
            else if (string.IsNullOrWhiteSpace(mail))
            {
                msgError("Debe ingresar un correo electrónico");

            }
            else if (!IsValidEmail(mail))
            {
                msgError("El correo electrónico no es válido");

            }
            else if (fechaNacimiento == DateTime.Now || fechaNacimiento > DateTime.Now)
            {
                msgError("Debe seleccionar una fecha válida");

            }

            bool cambiosRealizados = !string.Equals(nombre, clienteSeleccionado?.PersonaNombre, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(apellido, clienteSeleccionado?.PersonaApellido, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(dni, clienteSeleccionado?.PersonaDNI, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(mail, clienteSeleccionado?.PersonaMail) ||
                                    !string.Equals(telefonoN, clienteSeleccionado?.PersonaTelefono, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(domicilio, clienteSeleccionado?.Domicilio, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(baja, clienteSeleccionado?.PersonaBaja, StringComparison.OrdinalIgnoreCase) ||
                                    !DateTime.Equals(fechaNacimiento, clienteSeleccionado?.PersonaFechaNacimiento);
            if (!cambiosRealizados)
            {
                LimpiarCamposModificar();
                MessageBox.Show("Usted no realizó cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de realizar estas modificaciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool exitoCliente = ClienteModel.ActualizacionClient(
                    clienteSeleccionado!.IdCliente,
                    nombre,
                    apellido,
                    dni,
                    mail,
                    fechaNacimiento,
                    telefonoN,
                    domicilio,
                    baja
                );

                if (exitoCliente)
                {
                    MessageBox.Show("El cliente" + apellido + " " + nombre + " " + "se ha actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposModificar();
                    VerClientes_Load(sender, e);

                }
                else
                {

                    msgError("Ha ocurrido un error.");
                }
            }
            else
            {
                msgError("No se realizaron cambios al Cliente.");
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Vendedor.CargarCliente(instanciaLobi));
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Vendedor.DetalleVenta(instanciaLobi));
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

            }
        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!edicionRealizada && e.RowIndex >= 0)
            {
                edicionRealizada = true;
                DialogResult confirmResult = MessageBox.Show("Usted esta por realizar una Edición.En caso de que no lo desee vacie Los campos", "Informe de edición", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (confirmResult == DialogResult.OK)
                {
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    checkBoxSi.Enabled = true;
                    checkBoxNo.Enabled = true;
                    txtDNI.Enabled = true;
                    txtEmail.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtDomicilio.Enabled = true;
                    dtFechaNac.Enabled = true;
                    btnLimpiar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnElegir.Enabled = true;

                    DataGridViewRow row = dataGridCliente.Rows[e.RowIndex];

                    clienteSeleccionado = (ClienteConInformacion)row.DataBoundItem;
                    idClienteSeleccionado = clienteSeleccionado.IdCliente;

                    txtNombre.Text = clienteSeleccionado.PersonaNombre;
                    txtApellido.Text = clienteSeleccionado.PersonaApellido;
                    txtDNI.Text = clienteSeleccionado.PersonaDNI;
                    txtEmail.Text = clienteSeleccionado.PersonaMail;
                    txtTelefono.Text = clienteSeleccionado.PersonaTelefono;
                    txtDomicilio.Text = clienteSeleccionado.Domicilio;
                    dtFechaNac.Value = clienteSeleccionado.PersonaFechaNacimiento;

                    if (clienteSeleccionado.PersonaBaja == "SI")
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
            }


        }

        private void VerClientes_Load(object sender, EventArgs e)
        {
            List<ClienteConInformacion> clientes = ClienteModel.MostrarClientes().ToList();
            dataGridCliente.DataSource = clientes;
            dataGridCliente.Columns["IdCliente"].HeaderText = "ID";
            dataGridCliente.Columns["PersonaNombre"].HeaderText = "Nombre";
            dataGridCliente.Columns["PersonaApellido"].HeaderText = "Apellido";
            dataGridCliente.Columns["PersonaDNI"].HeaderText = "D.N.I";
            dataGridCliente.Columns["PersonaMail"].HeaderText = "Correo";
            dataGridCliente.Columns["PersonaFechaNacimiento"].HeaderText = "F.Nacimiento";
            dataGridCliente.Columns["FechaRegistro"].HeaderText = "F.Registro";
            dataGridCliente.Columns["PersonaBaja"].HeaderText = "Baja";
            dataGridCliente.Columns["Id_Persona"].Visible = false;
            dtFechaNac.CustomFormat = "dd/MM/yyyy";
            dtFechaNac.Format = DateTimePickerFormat.Custom;
            dataGridCliente.RowPrePaint += DataGridClientes_RowPrePaint!;

        }

        private void DataGridClientes_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridCliente.Rows[e.RowIndex];

            string? valorBaja = row.Cells["PersonaBaja"].Value.ToString();

            if (valorBaja == "SI")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 140, 140);
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            else
            {
                row.DefaultCellStyle.BackColor = SystemColors.Window;
                row.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                string texto = txtNombre.Text;
                string textoFormateado = char.ToUpper(texto[0]) + texto.Substring(1).ToLower();

                txtNombre.Text = textoFormateado;
                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtApellido.Text))
            {
                string texto = txtApellido.Text;
                string textoFormateado = char.ToUpper(texto[0]) + texto.Substring(1).ToLower();

                txtApellido.Text = textoFormateado;
                txtApellido.SelectionStart = txtApellido.Text.Length;
            }
        }

        private void FiltrarClientes()
        {
            string textoBusquedaNombre = txtBuscadorNombre.Text.ToLower();
            string textoBusquedaApellido = txtBuscadorApellido.Text.ToLower();
            string textoBusquedaDNI = txtBuscadorDNI.Text.ToLower();

            List<ClienteConInformacion> clientesFiltrados;

            clientesFiltrados = ClienteModel.MostrarClientes()
                .Where(cliente =>
                         (string.IsNullOrEmpty(textoBusquedaNombre) || cliente.PersonaNombre?.ToLower()?.Contains(textoBusquedaNombre) == true) &&
                         (string.IsNullOrEmpty(textoBusquedaApellido) || cliente.PersonaApellido?.ToLower()?.Contains(textoBusquedaApellido) == true) &&
                         (string.IsNullOrEmpty(textoBusquedaDNI) || cliente.PersonaDNI?.ToLower()?.Contains(textoBusquedaDNI) == true))
                     .ToList();


            dataGridCliente.DataSource = clientesFiltrados;
        }

        private void txtBuscadorNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void txtBuscadorApellido_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }

        private void txtBuscadorDNI_TextChanged(object sender, EventArgs e)
        {
            FiltrarClientes();
        }
    }

}
