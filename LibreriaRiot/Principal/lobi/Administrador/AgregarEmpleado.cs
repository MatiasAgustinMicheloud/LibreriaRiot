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
    public partial class AgregarEmpleado : Form
    {
        private UserType currentUserType;

        public AgregarEmpleado()
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

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            Administrador.VerEmpleados verEmpleados = new Administrador.VerEmpleados();
            verEmpleados.Show();
            this.Hide();
        }
    }
}
