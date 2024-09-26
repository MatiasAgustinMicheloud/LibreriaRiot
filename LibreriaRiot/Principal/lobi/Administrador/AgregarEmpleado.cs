using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Domain;
using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaRiot.Principal.lobi.Administrador
{
    public partial class AgregarEmpleado : Form
    {
        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
        public AgregarEmpleado(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Administrador.VerEmpleados(instanciaLobi));
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            DateTime fechaNacimiento = dtFechaNac.Value;
            string mail = txtEmail.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;
            string telefonoN = txtTelefono.Text;
            string tipoPerfil = cbRol.Text;
            UsuarioModel usuarioModel = new UsuarioModel();
            int idTipoPerfil = usuarioModel.ObtenerIdTipoPerfil(tipoPerfil);


            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni)
                || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena) || string.IsNullOrWhiteSpace(mail))
            {
                msgError("Debe completar todos los campos");
            }
            else if (fechaNacimiento == DateTime.MinValue) // Validación del DateTime
            {
                msgError("Debe seleccionar una fecha de nacimiento válida");
            }
            else if (cbRol.SelectedIndex == -1 || cbRol.SelectedItem.ToString() == "")
            {
                msgError("Por favor, selecciona un rol.");
            }
            else if (!IsValidEmail(mail)) // Validación del correo electrónico
            {
                msgError("El correo electrónico ingresado no es válido");

            }
            else if (!int.TryParse(telefonoN, out int telefono) || !int.TryParse(dni, out int DNI))
            {
                msgError("Ingrese valores válidos en los campos numéricos (Telefono, DNI)");
            }
            else if (idTipoPerfil == 0)
            {
                msgError("Debe seleccionar un tipo de usuario");
            }
            else if (!IsValidEmail(mail)) // Validación del correo electrónico
            {
                msgError("El correo electrónico ingresado no es válido");
            }
            else if (usuarioModel.IsValidDni(dni))
            {
                msgError("El DNI ya está registrado...");
            }
            else if (usuarioModel.IsValidCorreo(mail))
            {
                msgError("El Correo ya esta registrado...");
            }
            else if (usuarioModel.IsValidNombreUsuario(usuario))
            {
                msgError("El Nombre de Usuario ya esta registrado...");
            }
            else if (usuarioModel.IsValidEdad(fechaNacimiento) == false)
            {
                msgError("No cumple con los requisitos de Edad");
            }
            else
            {
                msgError(idTipoPerfil.ToString());

                // Mostrar mensaje de confirmación
                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea registrar este usuario?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {    
                    bool usuarioAgregado = usuarioModel.AgregarNuevoUsuario(usuario, contrasena, idTipoPerfil, nombre, apellido, dni, mail, fechaNacimiento, telefonoN);
                    MessageBox.Show("Usuario agregado exitosamente: " + nombre + " " + apellido, "Empleado Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }

        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            dtFechaNac.Value = DateTime.Now;
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            cbRol.SelectedIndex = -1;
            lbErrorMenssage.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            // Configura el formato personalizado para el DateTimePicker
            dtFechaNac.CustomFormat = "dd/MM/yyyy";
            // Asegúrate de que la propiedad Format esté establecida en Custom
            dtFechaNac.Format = DateTimePickerFormat.Custom;
            opcionesPerfiles();
        }

        private void opcionesPerfiles()
        {
            UsuarioModel userModel = new();
            var roles = userModel.ObtenerPerfiles();

            roles.Insert(0, "Seleccione Perfil");

            cbRol.DataSource = roles;

            cbRol.SelectedIndex = 0;
        }
    }
}
