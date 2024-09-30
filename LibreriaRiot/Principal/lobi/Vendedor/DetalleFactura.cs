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
    public partial class DetalleFactura : Form
    {
        private LobiPrincipal instanciaLobi;
        public DetalleFactura(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            instanciaLobi.FormClosed += (s, args) => this.Close();
            instanciaLobi.Show();
        }

    }
}
