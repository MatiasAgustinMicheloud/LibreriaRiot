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
    public partial class HistorialVentas : Form
    {
        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
    
        public HistorialVentas(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
