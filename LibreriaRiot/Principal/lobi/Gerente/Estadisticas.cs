using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Common.Models;
using Domain;
using Google.Protobuf.WellKnownTypes;

namespace LibreriaRiot.Principal.lobi.Gerente
{
    public partial class Estadisticas : Form
    {

        private UserType currentUserType;
        private LobiPrincipal instanciaLobi;
        private StaticsModel statistics = new();

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
                    //Libros Mas Vendidos. Grafico de barras
                    esconderGraficos();
                    chart3.Visible = true;
                    break;
                case 1:
                    //mejores clientes. Grafico de pie
                    esconderGraficos();
                    chart1.Visible = true;
                    break;
                case 2:
                    //mejores vendedores
                    esconderGraficos();
                    chart2.Visible = true;
                    break;
                default:

                    break;
            }
        }

        private void esconderGraficos()
        {
            chart3.Visible = false;
            chart1.Visible = false;
            chart2.Visible = false;
        }

        private void estadisticasClientes()
        {
            List<Tuple<string, float>> clientesDestacados = statistics.ClientesDestacados();
            chart1.Series.Clear();

            Series series = new Series();
            series.ChartType = SeriesChartType.Column;  // Cambiado a gráfico de puntos (redondos)
            series.IsVisibleInLegend = false;
            int abscisa = 1;

            Color[] colores = new Color[]
            {
                Color.Blue, Color.Green, Color.Red
            };

            int colorIndex = 0;

            foreach (var cliente in clientesDestacados)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.YValues = new double[] { cliente.Item2 };
                dataPoint.AxisLabel = cliente.Item1;
                dataPoint.XValue = abscisa;
                dataPoint.LegendText = cliente.Item1;
                series.Points.Add(dataPoint);
                dataPoint.LabelAngle = -90;
                dataPoint.IsValueShownAsLabel = true;
                dataPoint.Color = colores[colorIndex];

                abscisa++;
                colorIndex++;
            }

            chart1.Series.Add(series);

            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.Titles.Add("Clientes Destacados").Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 8, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 8, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.Title = "Clientes";
            chart1.ChartAreas[0].AxisY.Title = "Monto Total";
            chart1.Invalidate();
        }

        private void estadisticasVendedores()
        {
            List<Tuple<string, float>> empleadosDestacados = statistics.EmpleadosDestacados();
            chart2.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            int abscisa = 1;
            series.IsVisibleInLegend = false;

            Color[] colores = new Color[]
            {
                Color.Blue, Color.Green, Color.Red
            };

            int colorIndex = 0;

            foreach (Tuple<string, float> empleado in empleadosDestacados)
            {
                DataPoint dataPoint = new DataPoint
                {
                    YValues = new double[] { empleado.Item2 },
                    IsValueShownAsLabel = true,
                    XValue = abscisa,
                    AxisLabel = empleado.Item1,
                    LabelAngle = -90,
                    Color = colores[colorIndex]
                };
                series.Points.Add(dataPoint);

                abscisa++;
                colorIndex++;
            }
            chart2.Series.Add(series);

            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Transparent;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart2.Titles.Add("Vendedores Destacados").Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart2.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 9, FontStyle.Regular);
            chart2.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 9, FontStyle.Regular);
            chart2.ChartAreas[0].AxisX.Title = "Vendedores";
            chart2.ChartAreas[0].AxisY.Title = "Monto Total Ventas";
            chart2.Invalidate();
        }

        public void estadisticasLibros()
        {
            List<Ventas> librosMasVendidos = statistics.MostrarCantidadLibros();

            chart3.Series.Clear();
            chart3.Series.Add("Libros Más Vendidos");
            chart3.Series["Libros Más Vendidos"].ChartType = SeriesChartType.Pie;

            foreach (Ventas libroMasVendido in librosMasVendidos)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueY(libroMasVendido.Cantidad);
                dataPoint.LegendText = libroMasVendido.Titulo;
                dataPoint.Label = libroMasVendido.Cantidad.ToString();
                dataPoint.LabelForeColor = Color.White;
                dataPoint.Font = new Font("Century Gothic", 14, FontStyle.Italic);
                chart3.Series["Libros Más Vendidos"].Points.Add(dataPoint);
            }

            chart3.Titles.Add("Libros Más Vendidos").Font = new Font("Century Gothic", 15, FontStyle.Bold);
            chart3.Invalidate();
        }
        private void Estadisticas_Load(object sender, EventArgs e)
        {
            estadisticasClientes();
            estadisticasVendedores();
            estadisticasLibros();
        }
    }
}
