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
using Common.Models;
using Domain;

namespace LibreriaRiot.Principal.lobi.Administrador
{

    public partial class VerEmpleados : Form
    {
        private UsuarioModel userModel = new UsuarioModel();
        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
        private int idUsuarioSeleccionado;
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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string mail = txtEmail.Text;
            string usuario = txtUsuario.Text;
            DateTime nacimiento = dtFechaNac.Value;
            string telefono = txtTelefono.Text;
            string baja = checkBoxSi.Checked ? "SI" : "NO";
            int tipoPerfil = cbRol.SelectedIndex;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(usuario) || (checkBoxSi.Checked == false && checkBoxNo.Checked == false))
            {
                msgError("Por favor, completa todos los campos obligatorios");
                return;
            }

            // Verificar si el correo electrónico está vacío
            if (string.IsNullOrWhiteSpace(mail))
            {
                msgError("Por favor, ingresa una dirección de correo electrónico.");
                return;
            }

            // Validar dirección de correo electrónico
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(mail, emailPattern))
            {
                msgError("Por favor, ingresa una dirección de correo electrónico válida.");
                return;
            }

            // Llamar a la función para actualizar el usuario
            bool actualizado = userModel.ActualizacionEmpleado(idUsuarioSeleccionado, nombre, apellido, dni, mail, usuario, nacimiento, telefono, tipoPerfil, baja);

            if (actualizado)
            {
                MessageBox.Show("Usuario actualizado correctamente");
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Hubo un error al actualizar el usuario");
            }
        }

        private void CargarUsuarios()
        {
            var usuarios = userModel.MostrarUsers(); // Asegúrate de que esta función retorne todos los usuarios
            dataGridUsuarios.DataSource = usuarios; // Asigna la lista de usuarios al DataGridView
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

        private void opcionesPerfiles()
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
            List<UsuarioConInformacion> usuarios = userModel.MostrarUsers();
            dataGridUsuarios.DataSource = usuarios;

            // Configura los nombres de las columnas personalizados
            dataGridUsuarios.Columns["Id"].HeaderText = "ID";
            dataGridUsuarios.Columns["UserNombre"].HeaderText = "Usuario";
            dataGridUsuarios.Columns["PerfilNombre"].HeaderText = "Perfil";
            dataGridUsuarios.Columns["PersonaNombre"].HeaderText = "Nombre";
            dataGridUsuarios.Columns["PersonaApellido"].HeaderText = "Apellido";
            dataGridUsuarios.Columns["PersonaDNI"].HeaderText = "Documento";
            dataGridUsuarios.Columns["PersonaMail"].HeaderText = "Correo Electronico";
            dataGridUsuarios.Columns["PersonaFechaNacimiento"].HeaderText = "Fecha de Nacimiento";
            dataGridUsuarios.Columns["PersonaBaja"].HeaderText = "Baja"; // Si tienes la columna PersonaBaja

            // Otras configuraciones que puedas necesitar
            dataGridUsuarios.Columns["TipoPerfil"].Visible = false;
            dataGridUsuarios.Columns["Id_Persona"].Visible = false;
            opcionesPerfiles();
            CargarUsuarios();
            this.dataGridUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellContentClick);


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
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridUsuarios.Rows[e.RowIndex];

                // Guardar el ID del usuario seleccionado
                idUsuarioSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value); // Ajusta el nombre de la columna si es necesario

                // Asignar los valores a los controles correspondientes
                txtNombre.Text = filaSeleccionada.Cells["PersonaNombre"].Value.ToString();
                txtApellido.Text = filaSeleccionada.Cells["PersonaApellido"].Value.ToString();
                txtTelefono.Text = filaSeleccionada.Cells["PersonaTelefono"].Value.ToString();
                txtUsuario.Text = filaSeleccionada.Cells["UserNombre"].Value.ToString();
                txtEmail.Text = filaSeleccionada.Cells["PersonaMail"].Value.ToString();
                cbRol.Text = filaSeleccionada.Cells["PerfilNombre"].Value.ToString();
                txtDNI.Text = filaSeleccionada.Cells["PersonaDNI"].Value.ToString();
                dtFechaNac.Value = Convert.ToDateTime(filaSeleccionada.Cells["PersonaFechaNacimiento"].Value);

                if (filaSeleccionada.Cells["PersonaBaja"].Value != DBNull.Value)
                {
                    string baja = filaSeleccionada.Cells["PersonaBaja"].Value.ToString();

                    // Convertir "SI" o "NO" a booleano
                    if (baja.Equals("SI", StringComparison.OrdinalIgnoreCase))
                    {
                        checkBoxSi.Checked = true;
                        checkBoxNo.Checked = false;
                    }
                    else if (baja.Equals("NO", StringComparison.OrdinalIgnoreCase))
                    {
                        checkBoxSi.Checked = false;
                        checkBoxNo.Checked = true;
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtTelefono.Text = "";

            // Restablecer el valor de DateTimePicker a la fecha actual (o alguna otra fecha predeterminada)
            dtFechaNac.Value = DateTime.Now;

            // Restablecer los CheckBox
            checkBoxSi.Checked = false;
            checkBoxNo.Checked = false;

            // Restablecer el ComboBox
            cbRol.SelectedIndex = -1; // Ningún elemento seleccionado

            // Ocultar los mensajes de error si es necesario

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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
