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
        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
        public VerEmpleados(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            /**  currentUserType = UserType.Admin;
              Lobi menu = new Lobi(currentUserType);
              menu.Show();

              this.Hide();*/
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
            string baja = checkBoxSi.Checked ? "SI" : "NO";

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
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$";

            if (!Regex.IsMatch(mail, emailPattern))
            {
                msgError("Por favor, ingresa una dirección de correo electrónico válida.");
                return;
            }
        }

        private void VerEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
