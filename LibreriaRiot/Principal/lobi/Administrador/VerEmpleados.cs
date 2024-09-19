using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaRiot.Principal.lobi.Administrador
{

    public partial class VerEmpleados : Form
    {
        private UserType currentUserType;

        public VerEmpleados()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            currentUserType = UserType.Admin;
            Lobi menu = new Lobi(currentUserType);
            menu.Show();

            this.Hide();
        }
    }
}
