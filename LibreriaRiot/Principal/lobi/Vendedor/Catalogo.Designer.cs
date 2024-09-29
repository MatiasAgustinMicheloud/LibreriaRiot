namespace LibreriaRiot.Principal.lobi.Vendedor
{
    partial class Catalogo
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
            btnVerCarrito = new FontAwesome.Sharp.IconButton();
            cBBuscadorPerfil = new ComboBox();
            label6 = new Label();
            label10 = new Label();
            txtBuscadorNombre = new TextBox();
            dataGridView1 = new DataGridView();
            titulo = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            genero = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            agregar = new DataGridViewButtonColumn();
            panel2 = new Panel();
            lblCatalogo = new Label();
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
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnVerCarrito);
            panel3.Controls.Add(cBBuscadorPerfil);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtBuscadorNombre);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 384);
            panel3.TabIndex = 1;
            // 
            // btnVerCarrito
            // 
            btnVerCarrito.Anchor = AnchorStyles.Top;
            btnVerCarrito.BackColor = SystemColors.ControlDarkDark;
            btnVerCarrito.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnVerCarrito.FlatAppearance.BorderSize = 2;
            btnVerCarrito.FlatStyle = FlatStyle.Flat;
            btnVerCarrito.ForeColor = SystemColors.Window;
            btnVerCarrito.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnVerCarrito.IconColor = Color.White;
            btnVerCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerCarrito.IconSize = 40;
            btnVerCarrito.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerCarrito.Location = new Point(611, 13);
            btnVerCarrito.Name = "btnVerCarrito";
            btnVerCarrito.Size = new Size(112, 41);
            btnVerCarrito.TabIndex = 49;
            btnVerCarrito.Text = "Ver Carrito";
            btnVerCarrito.TextAlign = ContentAlignment.MiddleRight;
            btnVerCarrito.UseVisualStyleBackColor = false;
            btnVerCarrito.Click += btnVerCarrito_Click;
            // 
            // cBBuscadorPerfil
            // 
            cBBuscadorPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cBBuscadorPerfil.FormattingEnabled = true;
            cBBuscadorPerfil.Items.AddRange(new object[] { "Administrador", "Gerente", "Vendedor" });
            cBBuscadorPerfil.Location = new Point(333, 23);
            cBBuscadorPerfil.Name = "cBBuscadorPerfil";
            cBBuscadorPerfil.Size = new Size(125, 23);
            cBBuscadorPerfil.TabIndex = 45;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(265, 25);
            label6.Name = "label6";
            label6.Size = new Size(62, 16);
            label6.TabIndex = 44;
            label6.Text = "Genero:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(85, 25);
            label10.Name = "label10";
            label10.Size = new Size(50, 16);
            label10.TabIndex = 41;
            label10.Text = "Titulo:";
            // 
            // txtBuscadorNombre
            // 
            txtBuscadorNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtBuscadorNombre.Location = new Point(141, 23);
            txtBuscadorNombre.Name = "txtBuscadorNombre";
            txtBuscadorNombre.Size = new Size(114, 23);
            txtBuscadorNombre.TabIndex = 40;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { titulo, autor, editorial, genero, stock, precio, agregar });
            dataGridView1.Location = new Point(71, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(663, 303);
            dataGridView1.TabIndex = 0;
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.Name = "titulo";
            titulo.Width = 150;
            // 
            // autor
            // 
            autor.HeaderText = "Autor";
            autor.Name = "autor";
            autor.Width = 80;
            // 
            // editorial
            // 
            editorial.HeaderText = "Editorial";
            editorial.Name = "editorial";
            editorial.Width = 80;
            // 
            // genero
            // 
            genero.HeaderText = "Genero";
            genero.Name = "genero";
            genero.Width = 80;
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.Width = 50;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.Width = 80;
            // 
            // agregar
            // 
            agregar.FlatStyle = FlatStyle.System;
            agregar.HeaderText = "Agregar al carrito";
            agregar.Name = "agregar";
            agregar.Text = "Agregar";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(lblCatalogo);
            panel2.Location = new Point(12, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 70);
            panel2.TabIndex = 0;
            // 
            // lblCatalogo
            // 
            lblCatalogo.Anchor = AnchorStyles.Top;
            lblCatalogo.AutoSize = true;
            lblCatalogo.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatalogo.ForeColor = Color.FromArgb(241, 241, 241);
            lblCatalogo.Location = new Point(321, 12);
            lblCatalogo.Name = "lblCatalogo";
            lblCatalogo.Size = new Size(111, 39);
            lblCatalogo.TabIndex = 1;
            lblCatalogo.Text = "Catalogo";
            lblCatalogo.TextAlign = ContentAlignment.TopCenter;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Catalogo";
            Text = "Catalogo";
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
        private ComboBox cBBuscadorPerfil;
        private Label label6;
        private Label label10;
        private TextBox txtBuscadorNombre;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label lblCatalogo;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn autor;
        private DataGridViewTextBoxColumn editorial;
        private DataGridViewTextBoxColumn genero;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewButtonColumn agregar;
        private FontAwesome.Sharp.IconButton btnVerCarrito;
    }
}