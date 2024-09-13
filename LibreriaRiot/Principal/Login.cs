using LibreriaRiot.Principal.lobi;
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
        private UserType currentUserType;
        public Login()
        {
            InitializeComponent();
        }

        /*private bool ValidacionDatos()
        {
           
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
         }**/

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconEye_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            iconEye.Visible = !string.IsNullOrEmpty(txtPassword.Text);
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {

                msgError("El campo 'Usuario' es obligatorio.");
                txtUsuario.Focus();

            }
            else
            {

                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                if (!Regex.IsMatch(txtUsuario.Text, emailPattern))
                {
                    msgError("El formato del email es inválido.");

                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        msgError("El campo 'Contraseña' es obligatorio.");
                        txtPassword.Focus();

                    }
                    else
                    {
                        if (txtUsuario.Text == "admin@gmail.com" && txtPassword.Text == "Admin1")
                        {
                            currentUserType = UserType.Admin;
                            Lobi menu = new Lobi(currentUserType);
                            menu.Show();

                            this.Hide();
                        }
                        else if (txtUsuario.Text == "vendedor@gmail.com" && txtPassword.Text == "Vendedor1")
                        {
                            currentUserType = UserType.Vendedor;
                            Lobi menu = new Lobi(currentUserType);
                            menu.Show();

                            this.Hide();
                        }
                        else if (txtUsuario.Text == "gerente@gmail.com" && txtPassword.Text == "Gerente1")
                        {
                            currentUserType = UserType.Gerente;
                            Lobi menu = new Lobi(currentUserType);
                            menu.Show();

                            this.Hide();
                        }
                        else
                        {
                            msgError("Usuario o contraseña incorrecta");
                            txtPassword.Focus();
                        }



                    }
                }

            }



        }

        private void msgError(string msg)
        {
            lbErrorMenssage.Text = "        " + msg;
            lbErrorMenssage.Visible = true;
        }

    }
}
