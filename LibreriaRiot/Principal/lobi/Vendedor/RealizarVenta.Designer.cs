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
            lbMensaje = new Label();
            lbProductos = new Label();
            lblPrecioTotal = new Label();
            btnConfirmarCompra = new FontAwesome.Sharp.IconButton();
            btVaciarCarrito = new FontAwesome.Sharp.IconButton();
            dataGridDetalleCat = new DataGridView();
            panel2 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            lblCarrito = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDetalleCat).BeginInit();
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
            panel3.Controls.Add(lbMensaje);
            panel3.Controls.Add(lbProductos);
            panel3.Controls.Add(lblPrecioTotal);
            panel3.Controls.Add(btnConfirmarCompra);
            panel3.Controls.Add(btVaciarCarrito);
            panel3.Controls.Add(dataGridDetalleCat);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(821, 528);
            panel3.TabIndex = 1;
            // 
            // lbMensaje
            // 
            lbMensaje.Anchor = AnchorStyles.Top;
            lbMensaje.AutoSize = true;
            lbMensaje.BackColor = Color.FromArgb(64, 0, 64);
            lbMensaje.FlatStyle = FlatStyle.Flat;
            lbMensaje.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbMensaje.ForeColor = Color.White;
            lbMensaje.Location = new Point(334, 217);
            lbMensaje.Name = "lbMensaje";
            lbMensaje.Size = new Size(184, 31);
            lbMensaje.TabIndex = 54;
            lbMensaje.Text = "Carrito Vacio";
            lbMensaje.Visible = false;
            // 
            // lbProductos
            // 
            lbProductos.Anchor = AnchorStyles.None;
            lbProductos.AutoSize = true;
            lbProductos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductos.ForeColor = SystemColors.Window;
            lbProductos.Location = new Point(77, 9);
            lbProductos.Name = "lbProductos";
            lbProductos.Size = new Size(151, 16);
            lbProductos.TabIndex = 53;
            lbProductos.Text = "Productos Añadidos:";
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.Anchor = AnchorStyles.Bottom;
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioTotal.ForeColor = SystemColors.Window;
            lblPrecioTotal.Location = new Point(77, 474);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(96, 16);
            lblPrecioTotal.TabIndex = 52;
            lblPrecioTotal.Text = "Precio Total:";
            // 
            // btnConfirmarCompra
            // 
            btnConfirmarCompra.Anchor = AnchorStyles.Bottom;
            btnConfirmarCompra.BackColor = SystemColors.ControlDarkDark;
            btnConfirmarCompra.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnConfirmarCompra.FlatAppearance.BorderSize = 2;
            btnConfirmarCompra.FlatStyle = FlatStyle.Flat;
            btnConfirmarCompra.ForeColor = SystemColors.Window;
            btnConfirmarCompra.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            btnConfirmarCompra.IconColor = Color.White;
            btnConfirmarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConfirmarCompra.IconSize = 40;
            btnConfirmarCompra.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirmarCompra.Location = new Point(628, 462);
            btnConfirmarCompra.Name = "btnConfirmarCompra";
            btnConfirmarCompra.Size = new Size(132, 41);
            btnConfirmarCompra.TabIndex = 50;
            btnConfirmarCompra.Text = "Realizar Venta";
            btnConfirmarCompra.TextAlign = ContentAlignment.MiddleRight;
            btnConfirmarCompra.UseVisualStyleBackColor = false;
            btnConfirmarCompra.Click += btnConfirmarCompra_Click;
            // 
            // btVaciarCarrito
            // 
            btVaciarCarrito.Anchor = AnchorStyles.Bottom;
            btVaciarCarrito.BackColor = SystemColors.ControlDarkDark;
            btVaciarCarrito.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btVaciarCarrito.FlatAppearance.BorderSize = 2;
            btVaciarCarrito.FlatStyle = FlatStyle.Flat;
            btVaciarCarrito.ForeColor = SystemColors.Window;
            btVaciarCarrito.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btVaciarCarrito.IconColor = Color.White;
            btVaciarCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btVaciarCarrito.IconSize = 40;
            btVaciarCarrito.ImageAlign = ContentAlignment.MiddleLeft;
            btVaciarCarrito.Location = new Point(462, 462);
            btVaciarCarrito.Name = "btVaciarCarrito";
            btVaciarCarrito.Size = new Size(132, 41);
            btVaciarCarrito.TabIndex = 49;
            btVaciarCarrito.Text = "Vaciar Carrito";
            btVaciarCarrito.TextAlign = ContentAlignment.MiddleRight;
            btVaciarCarrito.UseVisualStyleBackColor = false;
            btVaciarCarrito.Click += btVaciarCarrito_Click;
            // 
            // dataGridDetalleCat
            // 
            dataGridDetalleCat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridDetalleCat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDetalleCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDetalleCat.Location = new Point(77, 28);
            dataGridDetalleCat.Name = "dataGridDetalleCat";
            dataGridDetalleCat.RowTemplate.Height = 25;
            dataGridDetalleCat.Size = new Size(683, 419);
            dataGridDetalleCat.TabIndex = 0;
            dataGridDetalleCat.CellContentClick += dataGridDetalleCat_CellContentClick;
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
            Load += RealizarVenta_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDetalleCat).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btVaciarCarrito;
        private DataGridView dataGridDetalleCat;
        private Panel panel2;
        private Label lblCarrito;
        private FontAwesome.Sharp.IconButton btnConfirmarCompra;
        private Label lblPrecioTotal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lbProductos;
        private Label lbMensaje;
    }
}