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

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string cuit = txtCUIT.Text;
            string mail = txtEmail.Text;
            string domicilio = txtDomicilio.Text;
            DateTime nacimiento = dtFechaNac.Value;
            string telefono = txtTelefono.Text;
            string baja = checkBoxSi.Checked ? "SI" : "NO";

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(cuit) || string.IsNullOrWhiteSpace(domicilio) || string.IsNullOrWhiteSpace(telefono))
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

            if (nacimiento == DateTime.Now || nacimiento < DateTime.Now)
            {
                msgError("Debe seleccionar una fecha de nacimiento válida (en el pasado)");
            }

        }

        private void txtCUIT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
