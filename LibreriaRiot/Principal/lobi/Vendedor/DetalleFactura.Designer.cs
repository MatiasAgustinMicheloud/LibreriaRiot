namespace LibreriaRiot.Principal.lobi.Vendedor
{
    partial class DetalleFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleFactura));
            panel1 = new Panel();
            panel3 = new Panel();
            lbTotal = new Label();
            dataGridFactura = new DataGridView();
            panel4 = new Panel();
            lbFactura = new Label();
            lbPago = new Label();
            lbDNICliente = new Label();
            panel7 = new Panel();
            lbDNIVendedor = new Label();
            lbNombreVendedor = new Label();
            label4 = new Label();
            label1 = new Label();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            lbDatos = new Label();
            lbFechaFactura = new Label();
            lbDireccion = new Label();
            lbTelefono = new Label();
            lbNombreCliente = new Label();
            lbNumeroFactura = new Label();
            lbTittleFactura = new Label();
            dataGridView1 = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            lblMisVentas = new Label();
            printReporte = new PrintPreviewDialog();
            iconImprimir = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFactura).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
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
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lbTotal);
            panel3.Controls.Add(dataGridFactura);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(1406, 741);
            panel3.TabIndex = 1;
            // 
            // lbTotal
            // 
            lbTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.White;
            lbTotal.Location = new Point(627, 356);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(51, 18);
            lbTotal.TabIndex = 55;
            lbTotal.Text = "Total:";
            // 
            // dataGridFactura
            // 
            dataGridFactura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFactura.Location = new Point(34, 201);
            dataGridFactura.Name = "dataGridFactura";
            dataGridFactura.RowTemplate.Height = 25;
            dataGridFactura.Size = new Size(738, 141);
            dataGridFactura.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(lbFactura);
            panel4.Controls.Add(lbPago);
            panel4.Controls.Add(lbDNICliente);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(lbDatos);
            panel4.Controls.Add(lbFechaFactura);
            panel4.Controls.Add(lbDireccion);
            panel4.Controls.Add(lbTelefono);
            panel4.Controls.Add(lbNombreCliente);
            panel4.Controls.Add(lbNumeroFactura);
            panel4.Controls.Add(lbTittleFactura);
            panel4.Location = new Point(34, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(738, 180);
            panel4.TabIndex = 10;
            // 
            // lbFactura
            // 
            lbFactura.AutoSize = true;
            lbFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbFactura.ForeColor = Color.FromArgb(64, 0, 64);
            lbFactura.Location = new Point(220, 3);
            lbFactura.Name = "lbFactura";
            lbFactura.Size = new Size(123, 16);
            lbFactura.TabIndex = 23;
            lbFactura.Text = "Tipo De Factura:";
            // 
            // lbPago
            // 
            lbPago.AutoSize = true;
            lbPago.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbPago.ForeColor = Color.White;
            lbPago.Location = new Point(12, 118);
            lbPago.Name = "lbPago";
            lbPago.Size = new Size(113, 16);
            lbPago.TabIndex = 22;
            lbPago.Text = "Metodo De Pago:";
            // 
            // lbDNICliente
            // 
            lbDNICliente.AutoSize = true;
            lbDNICliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDNICliente.ForeColor = Color.White;
            lbDNICliente.Location = new Point(214, 61);
            lbDNICliente.Name = "lbDNICliente";
            lbDNICliente.Size = new Size(33, 16);
            lbDNICliente.TabIndex = 21;
            lbDNICliente.Text = "DNI:";
            // 
            // panel7
            // 
            panel7.Controls.Add(iconImprimir);
            panel7.Controls.Add(lbDNIVendedor);
            panel7.Controls.Add(lbNombreVendedor);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(iconButton4);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(471, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(267, 180);
            panel7.TabIndex = 20;
            // 
            // lbDNIVendedor
            // 
            lbDNIVendedor.AutoSize = true;
            lbDNIVendedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDNIVendedor.ForeColor = Color.White;
            lbDNIVendedor.Location = new Point(24, 152);
            lbDNIVendedor.Name = "lbDNIVendedor";
            lbDNIVendedor.Size = new Size(33, 16);
            lbDNIVendedor.TabIndex = 23;
            lbDNIVendedor.Text = "DNI:";
            // 
            // lbNombreVendedor
            // 
            lbNombreVendedor.AutoSize = true;
            lbNombreVendedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombreVendedor.ForeColor = Color.White;
            lbNombreVendedor.Location = new Point(24, 118);
            lbNombreVendedor.Name = "lbNombreVendedor";
            lbNombreVendedor.Size = new Size(70, 16);
            lbNombreVendedor.TabIndex = 22;
            lbNombreVendedor.Text = "Vendedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(64, 0, 64);
            label4.Location = new Point(24, 80);
            label4.Name = "label4";
            label4.Size = new Size(129, 18);
            label4.TabIndex = 21;
            label4.Text = "Datos Vendedor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(112, 13);
            label1.Name = "label1";
            label1.Size = new Size(52, 16);
            label1.TabIndex = 21;
            label1.Text = "Volver";
            // 
            // iconButton4
            // 
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 40;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(80, 32);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(52, 45);
            iconButton4.TabIndex = 0;
            iconButton4.TextAlign = ContentAlignment.MiddleRight;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // lbDatos
            // 
            lbDatos.AutoSize = true;
            lbDatos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbDatos.ForeColor = Color.FromArgb(64, 0, 64);
            lbDatos.Location = new Point(12, 32);
            lbDatos.Name = "lbDatos";
            lbDatos.Size = new Size(119, 18);
            lbDatos.TabIndex = 15;
            lbDatos.Text = "Datos Clientes";
            // 
            // lbFechaFactura
            // 
            lbFechaFactura.AutoSize = true;
            lbFechaFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbFechaFactura.ForeColor = Color.FromArgb(64, 0, 64);
            lbFechaFactura.Location = new Point(12, 152);
            lbFechaFactura.Name = "lbFechaFactura";
            lbFechaFactura.Size = new Size(54, 16);
            lbFechaFactura.TabIndex = 14;
            lbFechaFactura.Text = "Fecha:";
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDireccion.ForeColor = Color.White;
            lbDireccion.Location = new Point(214, 87);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(67, 16);
            lbDireccion.TabIndex = 13;
            lbDireccion.Text = "Direccion:";
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbTelefono.ForeColor = Color.White;
            lbTelefono.Location = new Point(12, 87);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(64, 16);
            lbTelefono.TabIndex = 12;
            lbTelefono.Text = "Telefono:";
            // 
            // lbNombreCliente
            // 
            lbNombreCliente.AutoSize = true;
            lbNombreCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombreCliente.ForeColor = Color.White;
            lbNombreCliente.Location = new Point(12, 61);
            lbNombreCliente.Name = "lbNombreCliente";
            lbNombreCliente.Size = new Size(51, 16);
            lbNombreCliente.TabIndex = 11;
            lbNombreCliente.Text = "Cliente:";
            // 
            // lbNumeroFactura
            // 
            lbNumeroFactura.AutoSize = true;
            lbNumeroFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNumeroFactura.ForeColor = Color.FromArgb(64, 0, 64);
            lbNumeroFactura.Location = new Point(12, 3);
            lbNumeroFactura.Name = "lbNumeroFactura";
            lbNumeroFactura.Size = new Size(83, 16);
            lbNumeroFactura.TabIndex = 9;
            lbNumeroFactura.Text = "Factura N°:";
            // 
            // lbTittleFactura
            // 
            lbTittleFactura.AutoSize = true;
            lbTittleFactura.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbTittleFactura.Location = new Point(133, -88);
            lbTittleFactura.Name = "lbTittleFactura";
            lbTittleFactura.Size = new Size(315, 45);
            lbTittleFactura.TabIndex = 10;
            lbTittleFactura.Text = "Factura de Compra";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, cliente, total });
            dataGridView1.Location = new Point(615, 681);
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(lblMisVentas);
            panel2.Location = new Point(13, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 71);
            panel2.TabIndex = 0;
            // 
            // lblMisVentas
            // 
            lblMisVentas.Anchor = AnchorStyles.Top;
            lblMisVentas.AutoSize = true;
            lblMisVentas.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblMisVentas.ForeColor = Color.FromArgb(241, 241, 241);
            lblMisVentas.Location = new Point(347, 25);
            lblMisVentas.Name = "lblMisVentas";
            lblMisVentas.Size = new Size(99, 39);
            lblMisVentas.TabIndex = 1;
            lblMisVentas.Text = "Factura";
            lblMisVentas.TextAlign = ContentAlignment.TopCenter;
            // 
            // printReporte
            // 
            printReporte.AutoScrollMargin = new Size(0, 0);
            printReporte.AutoScrollMinSize = new Size(0, 0);
            printReporte.ClientSize = new Size(400, 300);
            printReporte.Enabled = true;
            printReporte.Icon = (Icon)resources.GetObject("printReporte.Icon");
            printReporte.Name = "printReporte";
            printReporte.Visible = false;
            // 
            // iconImprimir
            // 
            iconImprimir.Cursor = Cursors.Hand;
            iconImprimir.FlatAppearance.BorderSize = 0;
            iconImprimir.FlatStyle = FlatStyle.Flat;
            iconImprimir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconImprimir.IconColor = Color.White;
            iconImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconImprimir.IconSize = 40;
            iconImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            iconImprimir.Location = new Point(148, 32);
            iconImprimir.Name = "iconImprimir";
            iconImprimir.Size = new Size(52, 45);
            iconImprimir.TabIndex = 0;
            iconImprimir.TextAlign = ContentAlignment.MiddleRight;
            iconImprimir.UseVisualStyleBackColor = true;
            iconImprimir.Click += iconImprimir_Click;
            // 
            // DetalleFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "DetalleFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleFactura";
            Load += DetalleFactura_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFactura).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn total;
        private Panel panel2;
        private Label lblMisVentas;
        private Panel panel4;
        private Label lbFactura;
        private Label lbPago;
        private Label lbDNICliente;
        private Label lbDatos;
        private Label lbFechaFactura;
        private Label lbDireccion;
        private Label lbTelefono;
        private Label lbNombreCliente;
        private Label lbNumeroFactura;
        private Label lbTittleFactura;
        private Panel panel7;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private DataGridView dataGridFactura;
        private Label lbDNIVendedor;
        private Label lbNombreVendedor;
        private Label label4;
        private Label lbTotal;
        private PrintPreviewDialog printReporte;
        private FontAwesome.Sharp.IconButton iconImprimir;
    }
}