namespace LibreriaRiot.Principal.lobi.Vendedor
{
    partial class MisVentas
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
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridMisVentas = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerHasta = new DateTimePicker();
            dateTimePickerDesde = new DateTimePicker();
            txtBuscadorDNI = new TextBox();
            label6 = new Label();
            txtBuscadorApellido = new TextBox();
            label11 = new Label();
            txtBuscadorNombre = new TextBox();
            label10 = new Label();
            panel2 = new Panel();
            lblMisVentas = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMisVentas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 457);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(dataGridMisVentas);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dateTimePickerHasta);
            panel3.Controls.Add(dateTimePickerDesde);
            panel3.Controls.Add(txtBuscadorDNI);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtBuscadorApellido);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtBuscadorNombre);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 384);
            panel3.TabIndex = 1;
            // 
            // dataGridMisVentas
            // 
            dataGridMisVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridMisVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMisVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMisVentas.Location = new Point(13, 62);
            dataGridMisVentas.Name = "dataGridMisVentas";
            dataGridMisVentas.ReadOnly = true;
            dataGridMisVentas.RowTemplate.Height = 25;
            dataGridMisVentas.Size = new Size(775, 309);
            dataGridMisVentas.TabIndex = 56;
            dataGridMisVentas.CellContentClick += dataGridMisVentas_CellContentClick_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(403, 39);
            label2.Name = "label2";
            label2.Size = new Size(48, 16);
            label2.TabIndex = 55;
            label2.Text = "Hasta";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(225, 40);
            label1.Name = "label1";
            label1.Size = new Size(53, 16);
            label1.TabIndex = 52;
            label1.Text = "Desde";
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Anchor = AnchorStyles.Top;
            dateTimePickerHasta.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerHasta.CalendarForeColor = Color.IndianRed;
            dateTimePickerHasta.CalendarMonthBackground = SystemColors.MenuHighlight;
            dateTimePickerHasta.CalendarTitleBackColor = Color.DarkSlateGray;
            dateTimePickerHasta.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dateTimePickerHasta.CalendarTrailingForeColor = Color.CadetBlue;
            dateTimePickerHasta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerHasta.Location = new Point(453, 35);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(109, 21);
            dateTimePickerHasta.TabIndex = 54;
            dateTimePickerHasta.ValueChanged += dateTimePickerHasta_ValueChanged;
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Anchor = AnchorStyles.Top;
            dateTimePickerDesde.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDesde.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDesde.Location = new Point(278, 35);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(109, 21);
            dateTimePickerDesde.TabIndex = 53;
            dateTimePickerDesde.ValueChanged += dateTimePickerDesde_ValueChanged;
            // 
            // txtBuscadorDNI
            // 
            txtBuscadorDNI.Anchor = AnchorStyles.Top;
            txtBuscadorDNI.Location = new Point(543, 6);
            txtBuscadorDNI.Name = "txtBuscadorDNI";
            txtBuscadorDNI.Size = new Size(114, 23);
            txtBuscadorDNI.TabIndex = 45;
            txtBuscadorDNI.TextChanged += txtBuscadorDNI_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(501, 13);
            label6.Name = "label6";
            label6.Size = new Size(37, 16);
            label6.TabIndex = 44;
            label6.Text = "DNI:";
            // 
            // txtBuscadorApellido
            // 
            txtBuscadorApellido.Anchor = AnchorStyles.Top;
            txtBuscadorApellido.Location = new Point(381, 5);
            txtBuscadorApellido.Name = "txtBuscadorApellido";
            txtBuscadorApellido.Size = new Size(114, 23);
            txtBuscadorApellido.TabIndex = 42;
            txtBuscadorApellido.TextChanged += txtBuscadorApellido_TextChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(306, 13);
            label11.Name = "label11";
            label11.Size = new Size(69, 16);
            label11.TabIndex = 43;
            label11.Text = "Apellido:";
            // 
            // txtBuscadorNombre
            // 
            txtBuscadorNombre.Anchor = AnchorStyles.Top;
            txtBuscadorNombre.Location = new Point(190, 6);
            txtBuscadorNombre.Name = "txtBuscadorNombre";
            txtBuscadorNombre.Size = new Size(114, 23);
            txtBuscadorNombre.TabIndex = 40;
            txtBuscadorNombre.TextChanged += txtBuscadorNombre_TextChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(118, 12);
            label10.Name = "label10";
            label10.Size = new Size(66, 16);
            label10.TabIndex = 41;
            label10.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(lblMisVentas);
            panel2.Location = new Point(12, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 70);
            panel2.TabIndex = 0;
            // 
            // lblMisVentas
            // 
            lblMisVentas.Anchor = AnchorStyles.Top;
            lblMisVentas.AutoSize = true;
            lblMisVentas.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblMisVentas.ForeColor = Color.FromArgb(241, 241, 241);
            lblMisVentas.Location = new Point(328, 28);
            lblMisVentas.Name = "lblMisVentas";
            lblMisVentas.Size = new Size(137, 39);
            lblMisVentas.TabIndex = 1;
            lblMisVentas.Text = "Mis Ventas";
            lblMisVentas.TextAlign = ContentAlignment.TopCenter;
            // 
            // MisVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MisVentas";
            Text = "MisVentas";
            Load += MisVentas_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMisVentas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label lblMisVentas;
        private TextBox txtBuscadorDNI;
        private Label label6;
        private TextBox txtBuscadorApellido;
        private Label label11;
        private TextBox txtBuscadorNombre;
        private Label label10;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePickerHasta;
        private DateTimePicker dateTimePickerDesde;
        private DataGridView dataGridMisVentas;
    }
}