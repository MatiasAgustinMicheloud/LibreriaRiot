using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LibreriaRiot.Principal.lobi.Administrador
{
    public partial class Form1 : Form
    {
        private UserType currentUserType;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            Administrador.VerProductos modificarProducto = new Administrador.VerProductos();
            modificarProducto.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            currentUserType = UserType.Admin;
            Lobi menu = new Lobi(currentUserType);
            menu.Show();

            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void msgError(string msg)
        {
            lbErrorMenssage.Text = "        " + msg;
            lbErrorMenssage.Visible = true;
        }


    }
}
