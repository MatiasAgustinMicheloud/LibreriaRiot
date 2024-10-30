using Common.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaRiot.Principal.lobi.Vendedor
{
    public partial class CargarCliente : Form
    {
        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
        ClienteModel ClienteModel = new ClienteModel();
        public CargarCliente(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            instanciaLobi.OpenChildForm(new Vendedor.VerClientes(instanciaLobi));
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
            DateTime fechaCarga = dtFechaCarga.Value; // Se obtiene el valor de la fecha seleccionada
            string mail = txtEmail.Text;
            string domicilio = txtDomicilio.Text;
            string telefonoN = txtTelefono.Text;
            DateTime fechaRegistro = DateTime.Now;
            //Para agregar a la base de datos
            UsuarioModel usuarioModel = new UsuarioModel();

            // Ocultar todas las etiquetas de error al iniciar la validación
            lbErrorMenssage1.Visible = false;
            lbErrorMenssage2.Visible = false;
            lbErrorMenssage3.Visible = false;
            lbErrorMenssage4.Visible = false;
            lbErrorMenssage6.Visible = false;
            lbErrorMenssage7.Visible = false;
            lbErrorMenssage8.Visible = false;


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
            else if (string.IsNullOrWhiteSpace(domicilio))
            {
                msgError("Debe ingresar un domicilio", lbErrorMenssage4);
            }
            else if (string.IsNullOrWhiteSpace(telefonoN))
            {
                msgError("Debe ingresar un teléfono.", lbErrorMenssage6);
            }
            else if (!int.TryParse(telefonoN, out int telefono))
            {
                msgError("Este campo tiene que ser numérico", lbErrorMenssage6);
            }
            else if (string.IsNullOrWhiteSpace(mail))
            {
                msgError("Debe ingresar un correo electrónico", lbErrorMenssage7);
            }
            else if (!IsValidEmail(mail))
            {
                msgError("El correo electrónico ingresado no es válido", lbErrorMenssage7);
            }
            else if (fechaCarga > DateTime.Now)
            {
                msgError("Debe seleccionar una fecha de carga válida", lbErrorMenssage8);
            }
            else if (ClienteModel.IsValidDni(dni))
            {
                msgError("El DNI ya está registrado...", lbErrorMenssage3);
            }
            else if (ClienteModel.IsValidCorreo(mail))
            {
                msgError("El Correo ya esta registrado...", lbErrorMenssage7);
            }
            else if (ClienteModel.IsValidEdad(fechaCarga) == false)
            {
                msgError("No cumple con los requisitos de Edad", lbErrorMenssage8);
            }
            else
            {

                DialogResult confirmResult = MessageBox.Show("¿Está seguro que desea registrar este usuario?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    bool clienteAgregado = ClienteModel.AgregarNuevoCliente(telefonoN, domicilio, fechaRegistro, nombre, apellido, dni, mail, fechaCarga);
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
            dtFechaCarga.Value = DateTime.Now;
            txtEmail.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            txtNombre.Focus();
        }

        private void CargarCliente_Load(object sender, EventArgs e)
        {
            dtFechaCarga.CustomFormat = "dd/MM/yyyy";
            dtFechaCarga.Format = DateTimePickerFormat.Custom;
        }
    }
}
