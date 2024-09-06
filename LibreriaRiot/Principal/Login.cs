using LibreriaRiot.Principal.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaRiot.Principal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private bool ValidacionDatos()
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo 'Usuario' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus(); // Focalizar el campo vacío
                return false;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtUsuario.Text, emailPattern))
            {
                MessageBox.Show("El formato del email es inválido.");
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("El campo 'Contraseña' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            else
            {
                if (txtPassword.Text.Length < 3)
                {
                    MessageBox.Show("La contraseña debe tener al menos 3 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                // Verificar que contenga al menos una letra mayúscula, una minúscula y un número
                if (!txtPassword.Text.Any(char.IsUpper) || !txtPassword.Text.Any(char.IsLower) || !txtPassword.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("La contraseña debe contener al menos una letra mayúscula, una minúscula y un número.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ValidacionDatos();

            if (txtUsuario.Text == "admin@gmail.com" && txtPassword.Text == "Admin1")
            {
                MessageBox.Show("Admin");
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
            }
        }
    }
}
