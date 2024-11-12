using Common.Models;
using Domain;
using LibreriaRiot.Common.Models;
using Microsoft.VisualBasic.ApplicationServices;
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


namespace LibreriaRiot.Principal.lobi.Administrador
{

    public partial class VerEmpleados : Form
    {
        private UsuarioModel userModel = new UsuarioModel();
        private UserType currentUserType;
        private bool edicionRealizada = false;
        private LobiPrincipal instanciaLobi;
        private int idUsuarioSeleccionado = -1;
        UsuarioConInformacion? usuarioSeleccionado;


        public VerEmpleados(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
           
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            instanciaLobi.OpenChildForm(new Administrador.AgregarEmpleado(instanciaLobi));
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
        private void iconButton2_Click(object sender, EventArgs e)
        {

            edicionRealizada = false;
            if (idUsuarioSeleccionado == -1)
            {
                MessageBox.Show("Por favor, seleccione un Cliente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string mail = txtEmail.Text;
            string usuario = txtUsuario.Text;
            DateTime nacimiento = dtFechaNac.Value;
            string telefono = txtTelefono.Text;
            string baja = checkBoxSi.Checked ? "SI" : "NO";
            //int idTipoPerfil = cbRol.SelectedIndex;
            String tipoPerfil = cbRol.Text;
            UsuarioModel usuarioModel = new UsuarioModel();
            int idTipoPerfil = usuarioModel.ObtenerIdTipoPerfil(tipoPerfil);


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
            else if (string.IsNullOrWhiteSpace(telefono))
            {
                msgError("Debe ingresar un teléfono.");
            }
            else if (!int.TryParse(telefono, out int telefonoN))
            {
                msgError("EL telefono tiene que ser numérico");
            }
            else if (string.IsNullOrWhiteSpace(usuario))
            {
                msgError("Debe ingresar un usuario");
            }
            else if (string.IsNullOrWhiteSpace(mail))
            {
                msgError("Debe ingresar un correo electrónico");
            }
            else if (!IsValidEmail(mail))
            {
                msgError("El correo electrónico no es válido");
            }
            else if (idTipoPerfil == 0)
            {
                msgError("Por favor, selecciona un rol.");
            }
            else if (string.IsNullOrWhiteSpace(dni))
            {
                msgError("Debe ingresar DNI");
            }
            else if (!int.TryParse(dni, out int DNI))
            {
                msgError("El DNI tiene que ser numérico");
            }
            else if (nacimiento == DateTime.Now || nacimiento > DateTime.Now)
            {
                msgError("Debe seleccionar una fecha válida");
            }


            bool cambiosRealizados = !string.Equals(nombre, usuarioSeleccionado?.PersonaNombre, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(apellido, usuarioSeleccionado?.PersonaApellido, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(dni, usuarioSeleccionado?.PersonaDNI, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(mail, usuarioSeleccionado?.PersonaMail) ||
                                    !string.Equals(telefono, usuarioSeleccionado?.PersonaTelefono, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(usuario, usuarioSeleccionado?.UserNombre, StringComparison.OrdinalIgnoreCase) ||
                                    !string.Equals(baja, usuarioSeleccionado?.PersonaBaja, StringComparison.OrdinalIgnoreCase) ||
                                    !DateTime.Equals(nacimiento, usuarioSeleccionado?.PersonaFechaNacimiento);
            if (!cambiosRealizados)
            {
                LimpiarCamposModificar();
                MessageBox.Show("Usted no realizó cambios.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult confirmacion = MessageBox.Show("¿Está seguro de realizar estas modificaciones?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {

                bool actualizado = userModel.ActualizacionEmpleado(usuarioSeleccionado!.Id, nombre, apellido, dni, mail, usuario, nacimiento, telefono, idTipoPerfil, baja);

                if (actualizado)
                {
                    MessageBox.Show("El cliente  " + apellido + " " + nombre + " " + "se ha actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCamposModificar();
                    VerEmpleados_Load(sender, e);

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


        private void LimpiarCamposModificar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtTelefono.Text = "";
            dtFechaNac.Value = DateTime.Now;
            checkBoxSi.Checked = false;
            checkBoxNo.Checked = false;
            cbRol.SelectedIndex = 0;
        }

        private void DataGridUsuarios_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // Obtén la fila actual
            DataGridViewRow row = dataGridUsuarios.Rows[e.RowIndex];

            // Verifica el valor de la columna "Baja" (asegúrate de que el nombre de la columna sea correcto)
            string? valorBaja = row.Cells["PersonaBaja"].Value.ToString();

            // Define el color de fondo deseado para las filas con "Baja" en "SI"
            if (valorBaja == "SI")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 140, 140);
                row.DefaultCellStyle.ForeColor = Color.Black; // Opcional: establecer el color de texto en blanco para mayor visibilidad
            }
            else
            {
                // Restablece el color de fondo y texto para las demás filas (opcional)
                row.DefaultCellStyle.BackColor = SystemColors.Window;
                row.DefaultCellStyle.ForeColor = SystemColors.ControlText;
            }
        }

        private void opcionesPerfilesBuscador()
        {
            UsuarioModel userModel = new();
            var roles = userModel.ObtenerPerfiles();

            // Agrega el mensaje predeterminado al comienzo de la lista
            roles.Insert(0, "Seleccione Perfil");

            // Asigna la lista de categorías como DataSource del ComboBox
            cBBuscadorPerfil.DataSource = roles;

            // Establece el índice seleccionado por defecto en 0 para mostrar el mensaje predeterminado
            cBBuscadorPerfil.SelectedIndex = 0;
        }

        private void opcionesPerfiles()
        {
            UsuarioModel userModel = new();
            var roles = userModel.ObtenerPerfiles();

            roles.Insert(0, "Seleccione Perfil");

            cbRol.DataSource = roles;

            cbRol.SelectedIndex = 0;
        }

        private void FiltrarUsuarios()
        {
            string textoBusquedaNombre = txtBuscadorNombre.Text.ToLower();
            string textoBusquedaApellido = txtBuscadorApellido.Text.ToLower();
            string? perfilSeleccionado = cBBuscadorPerfil.SelectedItem as string;

            List<UsuarioConInformacion> usuariosFiltrados = userModel.MostrarUsers()
                .Where(usuario =>
                    (string.IsNullOrEmpty(textoBusquedaNombre) || usuario?.PersonaNombre?.ToLower()?.Contains(textoBusquedaNombre) == true) &&
                    (string.IsNullOrEmpty(textoBusquedaApellido) || usuario?.PersonaApellido?.ToLower()?.Contains(textoBusquedaApellido) == true) &&
                    (perfilSeleccionado == "Seleccione Perfil" || usuario?.PerfilNombre == perfilSeleccionado))
                .ToList();

            dataGridUsuarios.DataSource = usuariosFiltrados;
        }

        private void VerEmpleados_Load(object sender, EventArgs e)
        {
            opcionesPerfilesBuscador();
            opcionesPerfiles();

            List<UsuarioConInformacion> usuarios = userModel.MostrarUsers();
            dataGridUsuarios.DataSource = usuarios;

            // Configura los nombres de las columnas personalizados
            dataGridUsuarios.Columns["Id"].HeaderText = "ID";
            dataGridUsuarios.Columns["UserNombre"].HeaderText = "Usuario";
            dataGridUsuarios.Columns["PerfilNombre"].HeaderText = "Perfil";
            dataGridUsuarios.Columns["PersonaNombre"].HeaderText = "Nombre";
            dataGridUsuarios.Columns["PersonaApellido"].HeaderText = "Apellido";
            dataGridUsuarios.Columns["PersonaTelefono"].HeaderText = "Telefono";
            dataGridUsuarios.Columns["PersonaDNI"].HeaderText = "Documento";
            dataGridUsuarios.Columns["PersonaMail"].HeaderText = "Correo Electronico";
            dataGridUsuarios.Columns["PersonaFechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dataGridUsuarios.Columns["PersonaBaja"].HeaderText = "Baja"; // Si tienes la columna PersonaBaja

            // Otras configuraciones que puedas necesitar
            dataGridUsuarios.Columns["TipoPerfil"].Visible = false;
            dataGridUsuarios.Columns["Id_Persona"].Visible = false;
            
            dataGridUsuarios.RowPrePaint += DataGridUsuarios_RowPrePaint!;

        }

        private void txtBuscadorNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void txtBuscadorApellido_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void cBBuscadorPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void desactivarBotones()
        {

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtUsuario.Enabled = false;
            txtEmail.Enabled = false;
            cbRol.Enabled = false;
            checkBoxSi.Enabled = false;
            checkBoxNo.Enabled = false;
            iconButton2.Enabled = false;
            btnLimpiar.Enabled = false;
            dtFechaNac.Enabled = false;
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
                    dtFechaNac.Enabled = true;
                    btnLimpiar.Enabled = true;
                    cbRol.Enabled = true;

                    DataGridViewRow row = dataGridUsuarios.Rows[e.RowIndex];

                    usuarioSeleccionado = (UsuarioConInformacion)row.DataBoundItem;

                    idUsuarioSeleccionado = usuarioSeleccionado.Id;
                    txtNombre.Text = usuarioSeleccionado.PersonaNombre;
                    txtApellido.Text = usuarioSeleccionado.PersonaApellido;
                    txtDNI.Text = usuarioSeleccionado.PersonaDNI;
                    txtEmail.Text = usuarioSeleccionado.PersonaMail;
                    txtUsuario.Text = usuarioSeleccionado.UserNombre;
                    txtTelefono.Text = usuarioSeleccionado.PersonaTelefono;
                    dtFechaNac.Value = usuarioSeleccionado.PersonaFechaNacimiento;
                    cbRol.Text = usuarioSeleccionado.PerfilNombre;


                    if (usuarioSeleccionado.PersonaBaja == "SI")
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("Esta por realizar la limpieza de los campos. ¿Seguro?.", "Limpieza", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (limpiar == DialogResult.OK)
            {
                LimpiarCamposModificar();
                edicionRealizada = false;
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

    }
}
