using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaRiot.Principal.lobi.Gerente
{
    public partial class BaseDatos : Form
    {
        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
        public BaseDatos(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
        }
    }
}
