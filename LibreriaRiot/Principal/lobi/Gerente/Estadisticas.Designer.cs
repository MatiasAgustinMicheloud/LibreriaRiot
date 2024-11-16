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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel3 = new Panel();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            cbEstadisticas = new ComboBox();
            chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            lblEstadisticas = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart3).BeginInit();
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
            panel3.Controls.Add(chart2);
            panel3.Controls.Add(chart1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cbEstadisticas);
            panel3.Controls.Add(chart3);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 384);
            panel3.TabIndex = 1;
            // 
            // chart2
            // 
            chart2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            chart2.BorderlineColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(82, 66);
            chart2.Name = "chart2";
            series1.BackSecondaryColor = Color.White;
            series1.BorderColor = Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Red;
            series1.LabelForeColor = Color.LightGray;
            series1.Legend = "Legend1";
            series1.Name = " ";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ingresos";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Ganancias";
            chart2.Series.Add(series1);
            chart2.Series.Add(series2);
            chart2.Series.Add(series3);
            chart2.Size = new Size(655, 270);
            chart2.TabIndex = 51;
            chart2.Text = "Finanzas";
            chart2.Visible = false;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(82, 66);
            chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Series3";
            chart1.Series.Add(series4);
            chart1.Size = new Size(655, 270);
            chart1.TabIndex = 2;
            chart1.Text = "Top Libros";
            title1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            title1.Name = "Title1";
            chart1.Titles.Add(title1);
            chart1.Visible = false;
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
            cbEstadisticas.Items.AddRange(new object[] { "Libros mas vendidos", "Mejores Clientes", "Mejores Vendedores" });
            cbEstadisticas.Location = new Point(186, 18);
            cbEstadisticas.Name = "cbEstadisticas";
            cbEstadisticas.Size = new Size(183, 23);
            cbEstadisticas.TabIndex = 50;
            cbEstadisticas.Tag = "";
            cbEstadisticas.SelectedIndexChanged += cbEstadisticas_SelectedIndexChanged;
            // 
            // chart3
            // 
            chart3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            chartArea3.Name = "ChartArea1";
            chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart3.Legends.Add(legend3);
            chart3.Location = new Point(82, 66);
            chart3.Name = "chart3";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Cantidad de Ventas";
            chart3.Series.Add(series5);
            chart3.Size = new Size(655, 270);
            chart3.TabIndex = 0;
            chart3.Text = "Empleados que mas vendieron";
            chart3.Visible = false;
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
            Load += Estadisticas_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblEstadisticas;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private ComboBox cbEstadisticas;
        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}