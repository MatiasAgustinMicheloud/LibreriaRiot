using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaRiot.Principal;

namespace LibreriaRiot.Principal.lobi
{
    public partial class Lobi : Form
    {
        private UserType userType;
        public Lobi(UserType userType)
        {
            InitializeComponent();
            this.userType = userType;
            ConfigureUI();
        }

        private void btnlobiSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlobiMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnlobiMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void ConfigureUI()
        {
            switch (userType)
            {
                case UserType.Gerente:
                    // Mostrar solo los botones de gerente
                    iconRespaldo.Visible = true;
                    iconEstadistica.Visible = true;
                    iconUsuarios.Visible = true;
                    lbRol.Text = "Gerente";
                    lbNApe.Text = "Matias Micheloud";
                    break;

                case UserType.Admin:
                    // Mostrar solo los botones de administrador
                    iconProducto.Visible = true;
                    iconUsuarios.Visible = true;
                    iconHistorialVentas.Visible = true;
                    lbRol.Text = "administrador";
                    lbNApe.Text = "Lautaro Belucci";
                    break;

                case UserType.Vendedor:
                    // Mostrar solo los botones de vendedor
                    iconCatalogo.Visible = true;
                    iconMisVentas.Visible = true;
                    iconRealizarVenta.Visible = true;
                    iconCargarCliente.Visible = true;
                    lbRol.Text = "Vendedor";
                    lbNApe.Text = "Dylan Fernandez";
                    break;
            }
        }

        private void horaFecha_Tick_1(object sender, EventArgs e)
        {
            Lhora.Text = DateTime.Now.ToLongTimeString();
            Lfecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy").ToUpper();
        }

        private void Lobi_Load(object sender, EventArgs e)
        {
            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Principal/lobi/imagenes/");
            carpetaDestino = Path.GetFullPath(carpetaDestino);
            pictureBox2.Image = Image.FromFile(carpetaDestino + "lobi.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            DialogResult salida = MessageBox.Show("Estas seguro que desea salir", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (salida == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
