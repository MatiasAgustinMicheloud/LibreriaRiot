﻿using Domain;
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
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            DateTime fechaNacimiento = dtFechaNac.Value; // Se obtiene el valor de la fecha seleccionada
            string mail = txtEmail.Text;
            string domicilio = txtDomicilio.Text;
            string cuit = txtCUIT.Text;
            string telefonoN = txtTelefono.Text;

            // Para agregar a la base de datos
            UsuarioModel usuarioModel = new UsuarioModel();

            // Ocultar todas las etiquetas de error al iniciar la validación
            lbErrorMenssage.Visible = false;

            // Indicador de error
            bool error = false;

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombre))
            {
                msgError("Debe ingresar un nombre");
                error = true;
            }
            else if (nombre.Any(char.IsDigit))
            {
                msgError("El nombre no puede contener números");
                error = true;
            }
            else if (string.IsNullOrWhiteSpace(apellido))
            {
                msgError("Debe ingresar un apellido");
                error = true;
            }
            else if (apellido.Any(char.IsDigit))
            {
                msgError("El apellido no puede contener números");
                error = true;
            }
            else if (string.IsNullOrWhiteSpace(dni))
            {
                msgError("Debe ingresar DNI");
                error = true;
            }
            else if (!int.TryParse(dni, out int DNI))
            {
                msgError("El DNI tiene que ser numérico");
                error = true;
            }
            else if (string.IsNullOrWhiteSpace(domicilio))
            {
                msgError("Debe ingresar un domicilio");
                error = true;
            }
            else if (string.IsNullOrWhiteSpace(cuit))
            {
                msgError("Debe ingresar un CUIT.");
                error = true;
            }
            else if (!int.TryParse(cuit, out int CUIT))
            {
                msgError("EL cuit tiene que ser numérico");
                error = true;
            }
            else if (string.IsNullOrWhiteSpace(telefonoN))
            {
                msgError("Debe ingresar un teléfono.");
                error = true;
            }
            else if (!int.TryParse(telefonoN, out int telefono))
            {
                msgError("EL telefono tiene que ser numérico");
                error = true;
            }
            else if (string.IsNullOrWhiteSpace(mail))
            {
                msgError("Debe ingresar un correo electrónico");
                error = true;
            }
            else if (!IsValidEmail(mail))
            {
                msgError("El correo electrónico no es válido");
                error = true;
            }
            else if (fechaNacimiento == DateTime.Now || fechaNacimiento > DateTime.Now)
            {
                msgError("Debe seleccionar una fecha válida");
                error = true;
            }

            // Si no hay errores, mostrar el mensaje de éxito
            if (!error)
            {
                MessageBox.Show("Usuario modificado exitosamente: " + nombre + " " + apellido,
                    "Cliente modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtDomicilio.Clear();
            txtEmail.Clear();
            txtCUIT.Clear();
            txtTelefono.Clear();
            dtFechaNac.Value = DateTime.Now;
        }
    }

}
