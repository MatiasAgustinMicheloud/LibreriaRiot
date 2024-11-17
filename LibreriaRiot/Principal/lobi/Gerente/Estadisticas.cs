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

        private void chrFinanzas_Click(object sender, EventArgs e)
        {

        }

        private void estadisticasClientes()
        {
            // Obtener los datos de los clientes destacados
            List<Tuple<int, string, float>> clientesDestacados = statistics.ClientesDestacados();
            chart1.Series.Clear();

            // Verifica si hay datos para mostrar
            if (clientesDestacados.Count == 0)
            {
                MessageBox.Show("No hay datos disponibles para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear una nueva serie para el gráfico
            Series series = new Series
            {
                ChartType = SeriesChartType.Column,
                Name = "Clientes Destacados",
                IsValueShownAsLabel = true, // Mostrar los valores sobre las barras
                BorderWidth = 2 // Aumentar el grosor de los bordes de las barras
            };

            // Asignar colores a las barras
            Color[] colores = { Color.Blue, Color.Red, Color.Green, Color.Orange, Color.Purple };

            // Añadir los puntos al gráfico
            int colorIndex = 0;
            foreach (var cliente in clientesDestacados)
            {
                string nombreCompleto = cliente.Item2; // Nombre del cliente
                float totalVentas = cliente.Item3;     // Total de ventas

                // Crear un nuevo punto de datos
                int puntoIndex = series.Points.AddY(totalVentas);
                series.Points[puntoIndex].AxisLabel = nombreCompleto; // Asignar etiqueta al eje X
                series.Points[puntoIndex].Label = $"${totalVentas:N2}"; // Mostrar valor en la barra
                series.Points[puntoIndex].Color = colores[colorIndex % colores.Length]; // Asignar color

                colorIndex++; // Avanzar al siguiente color
            }

            // Añadir la serie al gráfico
            chart1.Series.Add(series);

            // Configurar el área del gráfico
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // Rotar etiquetas para mejor lectura
            chart1.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Century Gothic", 8, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.Title = "Clientes";
            chart1.ChartAreas[0].AxisY.Title = "Total Ventas ($)";
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 10, FontStyle.Bold);

            // Configurar el título del gráfico
            chart1.Titles.Clear();
            chart1.Titles.Add("Clientes Destacados");
            chart1.Titles[0].Font = new Font("Century Gothic", 12, FontStyle.Bold);

            // Refrescar para mostrar cambios
            chart1.Invalidate();
        }

        private void estadisticasVendedores()
        {
            List<Tuple<string, float>> empleadosDestacados = statistics.EmpleadosDestacados();
            chart2.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Doughnut;
            series.Name = "Destacados";

            foreach (var empleado in empleadosDestacados)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.YValues = new double[] { empleado.Item2 };

                dataPoint.AxisLabel = empleado.Item1;

                series.Points.Add(dataPoint);
                dataPoint.LabelAngle = -90;
            }
            chart2.Series.Add(series);

            chart2.Titles.Add("Vendedores Destacados").Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart2.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 9, FontStyle.Regular);
            chart2.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 9, FontStyle.Regular);
            chart2.ChartAreas[0].AxisX.Title = "Vendedores";
            chart2.ChartAreas[0].AxisY.Title = "Total-Ventas";
            chart2.Invalidate();
        }

        public void estadisticasLibros()
        {
            List<Ventas> librosMasVendidos = statistics.MostrarCantidadLibros();

            chart3.Series.Clear();
            chart3.Series.Add("Libros Más Vendidos");
            chart3.Series["Libros Más Vendidos"].ChartType = SeriesChartType.Doughnut;

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
