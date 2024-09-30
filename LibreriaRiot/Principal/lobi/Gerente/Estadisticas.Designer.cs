namespace LibreriaRiot.Principal.lobi.Gerente
{
    partial class Estadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel3 = new Panel();
            chrFinanzas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chrLibros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chrSalarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            cbEstadisticas = new ComboBox();
            chrMejoresEmpleados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            lblEstadisticas = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chrFinanzas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrSalarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrMejoresEmpleados).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 457);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(chrFinanzas);
            panel3.Controls.Add(chrLibros);
            panel3.Controls.Add(chrSalarios);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cbEstadisticas);
            panel3.Controls.Add(chrMejoresEmpleados);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 384);
            panel3.TabIndex = 1;
            // 
            // chrFinanzas
            // 
            chrFinanzas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            chartArea5.Name = "ChartArea1";
            chrFinanzas.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            chrFinanzas.Legends.Add(legend5);
            chrFinanzas.Location = new Point(82, 66);
            chrFinanzas.Name = "chrFinanzas";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series7.Legend = "Legend1";
            series7.Name = "Gastos";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series8.Legend = "Legend1";
            series8.Name = "Ingresos";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Ganancias";
            chrFinanzas.Series.Add(series7);
            chrFinanzas.Series.Add(series8);
            chrFinanzas.Series.Add(series9);
            chrFinanzas.Size = new Size(655, 270);
            chrFinanzas.TabIndex = 51;
            chrFinanzas.Text = "Finanzas";
            chrFinanzas.Visible = false;
            // 
            // chrLibros
            // 
            chrLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            chartArea6.Name = "ChartArea1";
            chrLibros.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            chrLibros.Legends.Add(legend6);
            chrLibros.Location = new Point(82, 66);
            chrLibros.Name = "chrLibros";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.Legend = "Legend1";
            series10.Name = "Series3";
            chrLibros.Series.Add(series10);
            chrLibros.Size = new Size(655, 270);
            chrLibros.TabIndex = 2;
            chrLibros.Text = "Top Libros";
            title2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title2.Name = "Title1";
            title2.Text = "Top 10 Libros mas vendidos";
            chrLibros.Titles.Add(title2);
            chrLibros.Visible = false;
            // 
            // chrSalarios
            // 
            chrSalarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            chartArea7.Name = "ChartArea1";
            chrSalarios.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            chrSalarios.Legends.Add(legend7);
            chrSalarios.Location = new Point(82, 66);
            chrSalarios.Name = "chrSalarios";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Salario";
            chrSalarios.Series.Add(series11);
            chrSalarios.Size = new Size(655, 270);
            chrSalarios.TabIndex = 1;
            chrSalarios.Text = "Salario Empleados";
            chrSalarios.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(82, 16);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar";
            // 
            // cbEstadisticas
            // 
            cbEstadisticas.Anchor = AnchorStyles.Top;
            cbEstadisticas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadisticas.FormattingEnabled = true;
            cbEstadisticas.Items.AddRange(new object[] { "Mejores Vendedores", "Salario Empleados", "Libros mas vendidos", "Finanzas" });
            cbEstadisticas.Location = new Point(186, 18);
            cbEstadisticas.Name = "cbEstadisticas";
            cbEstadisticas.Size = new Size(183, 23);
            cbEstadisticas.TabIndex = 50;
            cbEstadisticas.Tag = "";
            cbEstadisticas.SelectedIndexChanged += cbEstadisticas_SelectedIndexChanged;
            // 
            // chrMejoresEmpleados
            // 
            chrMejoresEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            chartArea8.Name = "ChartArea1";
            chrMejoresEmpleados.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            chrMejoresEmpleados.Legends.Add(legend8);
            chrMejoresEmpleados.Location = new Point(82, 66);
            chrMejoresEmpleados.Name = "chrMejoresEmpleados";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Cantidad de Ventas";
            chrMejoresEmpleados.Series.Add(series12);
            chrMejoresEmpleados.Size = new Size(655, 270);
            chrMejoresEmpleados.TabIndex = 0;
            chrMejoresEmpleados.Text = "Empleados que mas vendieron";
            chrMejoresEmpleados.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(lblEstadisticas);
            panel2.Location = new Point(12, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 70);
            panel2.TabIndex = 0;
            // 
            // lblEstadisticas
            // 
            lblEstadisticas.Anchor = AnchorStyles.Top;
            lblEstadisticas.AutoSize = true;
            lblEstadisticas.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstadisticas.ForeColor = Color.FromArgb(241, 241, 241);
            lblEstadisticas.Location = new Point(315, 18);
            lblEstadisticas.Name = "lblEstadisticas";
            lblEstadisticas.Size = new Size(146, 39);
            lblEstadisticas.TabIndex = 1;
            lblEstadisticas.Text = "Estadísticas";
            lblEstadisticas.TextAlign = ContentAlignment.TopCenter;
            // 
            // Estadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Estadisticas";
            Text = "Estadisticas";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chrFinanzas).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrSalarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrMejoresEmpleados).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblEstadisticas;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrMejoresEmpleados;
        private ComboBox cbEstadisticas;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrSalarios;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrLibros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrFinanzas;
    }
}