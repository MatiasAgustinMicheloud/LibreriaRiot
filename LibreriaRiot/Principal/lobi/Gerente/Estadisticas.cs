﻿using System;
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
            List<Tuple<string, float>> clientesDestacados = statistics.ClientesDestacados();
            chart1.Series.Clear();

            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;  // Cambiado a gráfico de puntos (redondos)
            series.Name = "Destacados";

            foreach (var cliente in clientesDestacados)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.YValues = new double[] { cliente.Item2 };
                dataPoint.AxisLabel = cliente.Item1;
                dataPoint.LegendText = cliente.Item1;
                series.Points.Add(dataPoint);
                dataPoint.LabelAngle = -90;
            }

            chart1.Series.Add(series);

            chart1.Titles.Add("Clientes Destacados").Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Century Gothic", 8, FontStyle.Regular);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Century Gothic", 8, FontStyle.Regular);
            chart1.ChartAreas[0].AxisX.Title = "Clientes";
            chart1.ChartAreas[0].AxisY.Title = "Total-Ventas";
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
