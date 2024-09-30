using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibreriaRiot.Principal.lobi.Gerente
{
    public partial class Estadisticas : Form
    {

        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;

        public Estadisticas(LobiPrincipal lobi)
        {
            InitializeComponent();
            this.instanciaLobi = lobi;
            cbEstadisticas.SelectedIndex = 0;
        }

        private void cbEstadisticas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grafico = cbEstadisticas.SelectedIndex;

            switch (grafico)
            {
                case 0:
                    //Mejores vendedores. Grafico de barras
                    esconderGraficos();
                    chrMejoresEmpleados.Visible = true;

                    break;
                case 1:
                    //Ver salarios. Grafico de barras
                    esconderGraficos();
                    chrSalarios.Visible = true;
                    break;
                case 2:
                    //Libros mas vendidos(top 10). Grafico de pie
                    esconderGraficos();
                    chrLibros.Visible = true;

                    break;
                case 3:
                    //Ver finanzas(gastos, ganancias y profit. Grafico de area)
                    esconderGraficos();
                    chrFinanzas.Visible = true;
                    break;
                default:

                    break;
            }
        }

        private void esconderGraficos()
        {
            chrMejoresEmpleados.Visible = false;
            chrSalarios.Visible = false;
            chrLibros.Visible = false;
            chrFinanzas.Visible = false;
        }

    }
}
