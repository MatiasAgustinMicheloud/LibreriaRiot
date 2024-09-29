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
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            factura = new DataGridViewLinkColumn();
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
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 384);
            panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, cliente, total, factura });
            dataGridView1.Location = new Point(119, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(534, 329);
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
    }
}