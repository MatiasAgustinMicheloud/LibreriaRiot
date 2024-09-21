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
            /**Administrador.VerEmpleados verEmpleados = new Administrador.VerEmpleados();
            verEmpleados.Show();
            this.Hide();*/

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

        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}
