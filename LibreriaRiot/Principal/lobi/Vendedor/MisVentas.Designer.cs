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
            txtBuscadorDNI = new TextBox();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            factura = new DataGridViewLinkColumn();
            label6 = new Label();
            txtBuscadorApellido = new TextBox();
            label11 = new Label();
            txtBuscadorNombre = new TextBox();
            label10 = new Label();
            panel2 = new Panel();
            lblMisVentas = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel3.Controls.Add(txtBuscadorDNI);
            panel3.Controls.Add(dataGridView1);
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
            // txtBuscadorDNI
            // 
            txtBuscadorDNI.Anchor = AnchorStyles.Top;
            txtBuscadorDNI.Location = new Point(437, 11);
            txtBuscadorDNI.Name = "txtBuscadorDNI";
            txtBuscadorDNI.Size = new Size(114, 23);
            txtBuscadorDNI.TabIndex = 45;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, cliente, total, factura });
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(775, 332);
            dataGridView1.TabIndex = 0;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // cliente
            // 
            cliente.HeaderText = "Cliente";
            cliente.Name = "cliente";
            // 
            // total
            // 
            total.HeaderText = "Total";
            total.Name = "total";
            // 
            // factura
            // 
            factura.HeaderText = "Factura";
            factura.Name = "factura";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(395, 18);
            label6.Name = "label6";
            label6.Size = new Size(37, 16);
            label6.TabIndex = 44;
            label6.Text = "DNI:";
            // 
            // txtBuscadorApellido
            // 
            txtBuscadorApellido.Anchor = AnchorStyles.Top;
            txtBuscadorApellido.Location = new Point(275, 10);
            txtBuscadorApellido.Name = "txtBuscadorApellido";
            txtBuscadorApellido.Size = new Size(114, 23);
            txtBuscadorApellido.TabIndex = 42;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(200, 18);
            label11.Name = "label11";
            label11.Size = new Size(69, 16);
            label11.TabIndex = 43;
            label11.Text = "Apellido:";
            // 
            // txtBuscadorNombre
            // 
            txtBuscadorNombre.Anchor = AnchorStyles.Top;
            txtBuscadorNombre.Location = new Point(84, 11);
            txtBuscadorNombre.Name = "txtBuscadorNombre";
            txtBuscadorNombre.Size = new Size(114, 23);
            txtBuscadorNombre.TabIndex = 40;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(12, 17);
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
            lblMisVentas.Location = new Point(310, 18);
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
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label lblMisVentas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn total;
        private DataGridViewLinkColumn factura;
        private TextBox txtBuscadorDNI;
        private Label label6;
        private TextBox txtBuscadorApellido;
        private Label label11;
        private TextBox txtBuscadorNombre;
        private Label label10;
    }
}