﻿using FontAwesome.Sharp;
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
using LibreriaRiot.Principal.lobi.Administrador;
using LibreriaRiot.Principal.lobi.Vendedor;
using Common.Cache;
using Domain;

namespace LibreriaRiot.Principal.lobi
{
    public partial class LobiPrincipal : Form
    {

        private Form currentChildForm;
        private IconButton currentBtn;
        private Panel leftBoderBtn;

        public LobiPrincipal()
        {
            InitializeComponent();
            leftBoderBtn = new Panel();
            leftBoderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBoderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.MinimumSize = new Size(1200, 700);
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

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            Lhora.Text = DateTime.Now.ToLongTimeString();
            Lfecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy").ToUpper();
        }

        private void LobiPrincipal_Load(object sender, EventArgs e)
        {
            string carpetaDestino = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Principal/lobi/imagenes/");
            carpetaDestino = Path.GetFullPath(carpetaDestino);
            pictureBox2.Image = Image.FromFile(carpetaDestino + "lobi.gif");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            if (UserLoginCache.TipoPerfil == 1)
            {
                iconEstadistica.Visible = true;
                iconRespaldo.Visible = true;
            }
            else if (UserLoginCache.TipoPerfil == 2)
            {
                iconProducto.Visible = true;
                iconUsuarios.Visible = true;
                iconHistorialVentas.Visible = true;
            }
            else
            {
                iconCatalogo.Visible = true;
                iconMisVentas.Visible = true;
            }
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            DialogResult salida = MessageBox.Show("Estas seguro que desea salir", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (salida == DialogResult.OK)
            {
                // Cerrar el lobi actual
                this.Close();

                // Abrir el formulario de login
            }
        }

        private void iconProducto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Administrador.AgregarProducto(this));
        }

        private void iconUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Administrador.AgregarEmpleado(this));
        }

        internal void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitleCurrentForm.Text = childForm.Text;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(58, 52, 91);
            public static Color color2 = Color.FromArgb(170, 139, 86);
            public static Color color3 = Color.FromArgb(0, 129, 138);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(176, 166, 232);
            public static Color color6 = Color.FromArgb(144, 197, 203);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(64, 64, 64);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBoderBtn.BackColor = color;
                leftBoderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBoderBtn.Visible = true;
                leftBoderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = SystemColors.ControlDarkDark;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBoderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            lbTitleCurrentForm.Text = "Inicio";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
        }

        private void iconHistorialVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Administrador.HistorialVentas(this));

        }

        private void iconEstadistica_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Gerente.Estadisticas(this));
        }

        private void iconRespaldo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Gerente.BaseDatos(this));
        }

        private void iconCargarCliente_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender, RGBColors.color2);
            //OpenChildForm(new Vendedor.VerClientes(this));
        }

        private void iconMisVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Vendedor.MisVentas(this));
        }

        private void iconCatalogo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Vendedor.Catalogo(this));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Crear una instancia de UserModel
            UsuarioModel userModel = new UsuarioModel();

            // Obtén el nombre del rol desde la capa de dominio
            int tipoPerfil = UserLoginCache.TipoPerfil; // Quita los paréntesis

            string? roleName = userModel.GetRolName(tipoPerfil); // Llama al método en la instancia de UserModel

            // Asigna el nombre del rol al lbRol.Text
            lbRol.Text = roleName;

            // Resto del código para mostrar otros datos de usuario
            lbNApe.Text = UserLoginCache.Nombre + " " + UserLoginCache.Apellido;
        }
    }
}
