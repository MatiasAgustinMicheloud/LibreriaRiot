namespace LibreriaRiot.Principal.lobi.Vendedor
{
    partial class RealizarVenta
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
            lbProductosAñadidos = new Label();
            label1 = new Label();
            txtPrecioTotal = new TextBox();
            btnRealizarVenta = new FontAwesome.Sharp.IconButton();
            btnVaciarCarrito = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            titulo = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            genero = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precioTotal = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblCarrito = new Label();
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
            panel1.Size = new Size(821, 598);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lbProductosAñadidos);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtPrecioTotal);
            panel3.Controls.Add(btnRealizarVenta);
            panel3.Controls.Add(btnVaciarCarrito);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(821, 528);
            panel3.TabIndex = 1;
            // 
            // lbProductosAñadidos
            // 
            lbProductosAñadidos.Anchor = AnchorStyles.None;
            lbProductosAñadidos.AutoSize = true;
            lbProductosAñadidos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductosAñadidos.ForeColor = SystemColors.Window;
            lbProductosAñadidos.Location = new Point(77, 9);
            lbProductosAñadidos.Name = "lbProductosAñadidos";
            lbProductosAñadidos.Size = new Size(151, 16);
            lbProductosAñadidos.TabIndex = 53;
            lbProductosAñadidos.Text = "Productos Añadidos:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(173, 474);
            label1.Name = "label1";
            label1.Size = new Size(96, 16);
            label1.TabIndex = 52;
            label1.Text = "Precio Total:";
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Anchor = AnchorStyles.Bottom;
            txtPrecioTotal.Location = new Point(271, 472);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.ReadOnly = true;
            txtPrecioTotal.Size = new Size(155, 23);
            txtPrecioTotal.TabIndex = 51;
            // 
            // btnRealizarVenta
            // 
            btnRealizarVenta.Anchor = AnchorStyles.Bottom;
            btnRealizarVenta.BackColor = SystemColors.ControlDarkDark;
            btnRealizarVenta.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnRealizarVenta.FlatAppearance.BorderSize = 2;
            btnRealizarVenta.FlatStyle = FlatStyle.Flat;
            btnRealizarVenta.ForeColor = SystemColors.Window;
            btnRealizarVenta.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            btnRealizarVenta.IconColor = Color.White;
            btnRealizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRealizarVenta.IconSize = 40;
            btnRealizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnRealizarVenta.Location = new Point(628, 462);
            btnRealizarVenta.Name = "btnRealizarVenta";
            btnRealizarVenta.Size = new Size(132, 41);
            btnRealizarVenta.TabIndex = 50;
            btnRealizarVenta.Text = "Realizar Venta";
            btnRealizarVenta.TextAlign = ContentAlignment.MiddleRight;
            btnRealizarVenta.UseVisualStyleBackColor = false;
            btnRealizarVenta.Click += btnRealizarVenta_Click;
            // 
            // btnVaciarCarrito
            // 
            btnVaciarCarrito.Anchor = AnchorStyles.Bottom;
            btnVaciarCarrito.BackColor = SystemColors.ControlDarkDark;
            btnVaciarCarrito.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnVaciarCarrito.FlatAppearance.BorderSize = 2;
            btnVaciarCarrito.FlatStyle = FlatStyle.Flat;
            btnVaciarCarrito.ForeColor = SystemColors.Window;
            btnVaciarCarrito.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnVaciarCarrito.IconColor = Color.White;
            btnVaciarCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVaciarCarrito.IconSize = 40;
            btnVaciarCarrito.ImageAlign = ContentAlignment.MiddleLeft;
            btnVaciarCarrito.Location = new Point(462, 462);
            btnVaciarCarrito.Name = "btnVaciarCarrito";
            btnVaciarCarrito.Size = new Size(132, 41);
            btnVaciarCarrito.TabIndex = 49;
            btnVaciarCarrito.Text = "Vaciar Carrito";
            btnVaciarCarrito.TextAlign = ContentAlignment.MiddleRight;
            btnVaciarCarrito.UseVisualStyleBackColor = false;
            btnVaciarCarrito.Click += btnVaciarCarrito_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { titulo, autor, editorial, genero, precio, cantidad, precioTotal });
            dataGridView1.Location = new Point(77, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(683, 419);
            dataGridView1.TabIndex = 0;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(lblCarrito);
            panel2.Location = new Point(12, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(795, 70);
            panel2.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(12, 15);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(43, 48);
            iconButton1.TabIndex = 21;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // lblCarrito
            // 
            lblCarrito.Anchor = AnchorStyles.Top;
            lblCarrito.AutoSize = true;
            lblCarrito.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblCarrito.ForeColor = Color.FromArgb(241, 241, 241);
            lblCarrito.Location = new Point(289, 12);
            lblCarrito.Name = "lblCarrito";
            lblCarrito.Size = new Size(231, 39);
            lblCarrito.TabIndex = 1;
            lblCarrito.Text = "Carrito de Compras";
            lblCarrito.TextAlign = ContentAlignment.TopCenter;
            // 
            // RealizarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 591);
            Controls.Add(panel1);
            Name = "RealizarVenta";
            Text = "RealizarVenta";
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
        private FontAwesome.Sharp.IconButton btnVaciarCarrito;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label lblCarrito;
        private FontAwesome.Sharp.IconButton btnRealizarVenta;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn editorial;
        private DataGridViewTextBoxColumn genero;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precioTotal;
        private Label label1;
        private TextBox txtPrecioTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lbProductosAñadidos;
    }
}