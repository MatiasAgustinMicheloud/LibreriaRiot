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
using static Mysqlx.Datatypes.Scalar.Types;

namespace LibreriaRiot.Principal.lobi.Administrador
{
    public partial class AgregarEmpleado : Form
    {
  
        private LobiPrincipal instanciaLobi;
        public AgregarEmpleado(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        //Boton ver empleados
        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Administrador.VerEmpleados(instanciaLobi));
        }

        private void msgError(string msg, Label label)
        {
            label.Text = "        " + msg;
            label.Visible = true;
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
            DateTime fechaNacimiento = dtFechaNac.Value; // Se obtiene el valor de la fecha seleccionada
            string mail = txtEmail.Text;
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;
            string telefonoN = txtTelefono.Text;
            string tipoPerfil = cbRol.Text;
            UsuarioModel usuarioModel = new UsuarioModel();
            int idTipoPerfil = usuarioModel.ObtenerIdTipoPerfil(tipoPerfil);

            // Ocultar todas las etiquetas de error al iniciar la validación
            lbErrorMenssage1.Visible = false;
            lbErrorMenssage2.Visible = false;
            lbErrorMenssage3.Visible = false;
            lbErrorMenssage4.Visible = false;
            lbErrorMenssage5.Visible = false;
            lbErrorMenssage6.Visible = false;
            lbErrorMenssage7.Visible = false;
            lbErrorMenssage8.Visible = false;
            lbErrorMenssage9.Visible = false;

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre))
            {
                msgError("Debe ingresar un nombre", lbErrorMenssage1);
            }
            else if (nombre.Any(char.IsDigit))
            {
                msgError("El nombre no puede contener números", lbErrorMenssage1);
            }
            else if (string.IsNullOrWhiteSpace(apellido))
            {
                msgError("Debe ingresar un apellido", lbErrorMenssage2);
            }
            else if (apellido.Any(char.IsDigit))
            {
                msgError("El apellido no puede contener números", lbErrorMenssage2);
            }
            else if (string.IsNullOrWhiteSpace(dni))
            {
                msgError("Debe ingresar DNI", lbErrorMenssage3);
            }
            else if (!int.TryParse(dni, out int DNI))
            {
                msgError("Este campo tiene que ser numérico", lbErrorMenssage3);
            }
            else if (fechaNacimiento == DateTime.Now)
            {
                msgError("Debe seleccionar una fecha de nacimiento válida", lbErrorMenssage4);
            }
            else if (string.IsNullOrWhiteSpace(usuario))
            {
                msgError("Debe ingresar un usuario", lbErrorMenssage5);
            }
            else if (idTipoPerfil == 0)
            {
                msgError("Por favor, selecciona un rol.", lbErrorMenssage6);
            }
            else if (string.IsNullOrWhiteSpace(telefonoN))
            {
                msgError("Debe ingresar un teléfono.", lbErrorMenssage7);
            }
            else if (!int.TryParse(telefonoN, out int telefono))
            {
                msgError("Este campo tiene que ser numérico", lbErrorMenssage7);
            }
            else if (string.IsNullOrWhiteSpace(mail))
            {
                msgError("Debe ingresar un correo electrónico", lbErrorMenssage8);
            }
            else if (!IsValidEmail(mail))
            {
                msgError("El correo electrónico ingresado no es válido", lbErrorMenssage8);
            }
            else if (string.IsNullOrWhiteSpace(contrasena))
            {
                msgError("Debe ingresar una contraseña", lbErrorMenssage9);
            }
            else if (usuarioModel.IsValidDni(dni))
            {
                msgError("El DNI ya está registrado...", lbErrorMenssage3);
            }
            else if (usuarioModel.IsValidCorreo(mail))
            {
                msgError("El Correo ya está registrado...", lbErrorMenssage8);
            }
            else if (usuarioModel.IsValidNombreUsuario(usuario))
            {
                msgError("El Nombre de Usuario ya está registrado...", lbErrorMenssage5);
            }
            else if (usuarioModel.IsValidEdad(fechaNacimiento) == false)
            {
                msgError("El usuario debe ser mayor de 17", lbErrorMenssage4);
            }
            else
            {

                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea registrar este usuario?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    bool usuarioAgregado = usuarioModel.AgregarNuevoUsuario(usuario, contrasena, idTipoPerfil, nombre, apellido, dni, mail, fechaNacimiento, telefonoN);
                    MessageBox.Show("Usuario agregado exitosamente: " + nombre + " " + apellido, "Empleado Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }

        }

        // Elimina los campos una vez registrado el Usuario
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            dtFechaNac.Value = DateTime.Now;
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            cbRol.SelectedIndex = 0;
            txtTelefono.Text = "";
            txtNombre.Focus();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
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


        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.D4) // Alt + 64
            {
                // Evitar que se redirija a otro formulario
                e.SuppressKeyPress = true;

                // Agregar el texto @gmail.com
                txtEmail.Text += "@gmail.com";
                // Colocar el cursor al final del texto
                txtEmail.SelectionStart = txtEmail.Text.Length;
            }
        }

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
