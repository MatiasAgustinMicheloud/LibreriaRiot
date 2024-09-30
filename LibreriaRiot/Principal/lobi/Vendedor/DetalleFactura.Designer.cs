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
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            titulo = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            genero = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precioTotal = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            lbFechaF = new Label();
            label2 = new Label();
            lbTipoF = new Label();
            lbDireccionC = new Label();
            lbDni = new Label();
            lbMetodo = new Label();
            lbTelefonoC = new Label();
            lbNombre = new Label();
            lbFactura = new Label();
            lbPago = new Label();
            lbDNICliente = new Label();
            panel7 = new Panel();
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
            factura = new DataGridViewLinkColumn();
            panel2 = new Panel();
            lblMisVentas = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            panel3.Controls.Add(dataGridView2);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(1406, 741);
            panel3.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { titulo, autor, editorial, genero, precio, cantidad, precioTotal });
            dataGridView2.Location = new Point(34, 201);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(738, 170);
            dataGridView2.TabIndex = 11;
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.Name = "titulo";
            // 
            // autor
            // 
            autor.HeaderText = "Autor";
            autor.Name = "autor";
            // 
            // editorial
            // 
            editorial.HeaderText = "Editorial";
            editorial.Name = "editorial";
            // 
            // genero
            // 
            genero.HeaderText = "Genero";
            genero.Name = "genero";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            // 
            // precioTotal
            // 
            precioTotal.HeaderText = "Total";
            precioTotal.Name = "precioTotal";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(lbFechaF);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lbTipoF);
            panel4.Controls.Add(lbDireccionC);
            panel4.Controls.Add(lbDni);
            panel4.Controls.Add(lbMetodo);
            panel4.Controls.Add(lbTelefonoC);
            panel4.Controls.Add(lbNombre);
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
            panel4.Location = new Point(115, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(576, 180);
            panel4.TabIndex = 10;
            // 
            // lbFechaF
            // 
            lbFechaF.AutoSize = true;
            lbFechaF.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbFechaF.ForeColor = Color.White;
            lbFechaF.Location = new Point(69, 152);
            lbFechaF.Name = "lbFechaF";
            lbFechaF.Size = new Size(112, 16);
            lbFechaF.TabIndex = 31;
            lbFechaF.Text = "Fecha de Factura";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(101, 3);
            label2.Name = "label2";
            label2.Size = new Size(122, 16);
            label2.TabIndex = 30;
            label2.Text = "Numero de Factura";
            // 
            // lbTipoF
            // 
            lbTipoF.AutoSize = true;
            lbTipoF.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbTipoF.ForeColor = Color.White;
            lbTipoF.Location = new Point(343, 3);
            lbTipoF.Name = "lbTipoF";
            lbTipoF.Size = new Size(35, 16);
            lbTipoF.TabIndex = 29;
            lbTipoF.Text = "Tipo";
            // 
            // lbDireccionC
            // 
            lbDireccionC.AutoSize = true;
            lbDireccionC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDireccionC.ForeColor = Color.White;
            lbDireccionC.Location = new Point(286, 87);
            lbDireccionC.Name = "lbDireccionC";
            lbDireccionC.Size = new Size(130, 16);
            lbDireccionC.TabIndex = 28;
            lbDireccionC.Text = "Direccion del Cliente";
            // 
            // lbDni
            // 
            lbDni.AutoSize = true;
            lbDni.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbDni.ForeColor = Color.White;
            lbDni.Location = new Point(253, 61);
            lbDni.Name = "lbDni";
            lbDni.Size = new Size(97, 16);
            lbDni.TabIndex = 27;
            lbDni.Text = "numero de DNI";
            // 
            // lbMetodo
            // 
            lbMetodo.AutoSize = true;
            lbMetodo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbMetodo.ForeColor = Color.White;
            lbMetodo.Location = new Point(131, 118);
            lbMetodo.Name = "lbMetodo";
            lbMetodo.Size = new Size(53, 16);
            lbMetodo.TabIndex = 26;
            lbMetodo.Text = "Metodo";
            // 
            // lbTelefonoC
            // 
            lbTelefonoC.AutoSize = true;
            lbTelefonoC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbTelefonoC.ForeColor = Color.White;
            lbTelefonoC.Location = new Point(82, 87);
            lbTelefonoC.Name = "lbTelefonoC";
            lbTelefonoC.Size = new Size(122, 16);
            lbTelefonoC.TabIndex = 25;
            lbTelefonoC.Text = "Numero Telefonico";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbNombre.ForeColor = Color.White;
            lbNombre.Location = new Point(69, 61);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(56, 16);
            lbNombre.TabIndex = 24;
            lbNombre.Text = "Nombre";
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
            lbPago.ForeColor = Color.FromArgb(64, 0, 64);
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
            lbDNICliente.ForeColor = Color.FromArgb(64, 0, 64);
            lbDNICliente.Location = new Point(214, 61);
            lbDNICliente.Name = "lbDNICliente";
            lbDNICliente.Size = new Size(33, 16);
            lbDNICliente.TabIndex = 21;
            lbDNICliente.Text = "DNI:";
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Controls.Add(iconButton4);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(471, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(105, 180);
            panel7.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(19, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 16);
            label1.TabIndex = 21;
            label1.Text = "Acciones";
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
            iconButton4.IconSize = 25;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(34, 27);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(34, 30);
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
            lbDireccion.ForeColor = Color.FromArgb(64, 0, 64);
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
            lbTelefono.ForeColor = Color.FromArgb(64, 0, 64);
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
            lbNombreCliente.ForeColor = Color.FromArgb(64, 0, 64);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Fecha, cliente, total, factura });
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
            // DetalleFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "DetalleFactura";
            Text = "DetalleFactura";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private DataGridViewLinkColumn factura;
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
        private Label lbDireccionC;
        private Label lbDni;
        private Label lbMetodo;
        private Label lbTelefonoC;
        private Label lbNombre;
        private Label lbTipoF;
        private Label lbFechaF;
        private Label label2;
        private Panel panel7;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn editorial;
        private DataGridViewTextBoxColumn genero;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precioTotal;
    }
}