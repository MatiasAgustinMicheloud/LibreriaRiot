namespace LibreriaRiot.Principal.lobi.Administrador
{
    partial class AgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblAgregarProducto = new Label();
            btnVerProductos = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTitulo = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            pbPortada = new PictureBox();
            cbCategoria = new ComboBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            lbErrorMenssage2 = new Label();
            panel2 = new Panel();
            cbAutor = new ComboBox();
            cbEditorial = new ComboBox();
            lbErrorMenssage8 = new Label();
            lbErrorMenssage7 = new Label();
            lbErrorMenssage6 = new Label();
            lbErrorMenssage5 = new Label();
            lbErrorMenssage4 = new Label();
            lbErrorMenssage3 = new Label();
            lbErrorMenssage1 = new Label();
            lbPathTittleP = new Label();
            btAgregarImagen = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPortada).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblAgregarProducto);
            panel1.Controls.Add(btnVerProductos);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 70);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox1.Location = new Point(790, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 71);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 71);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // lblAgregarProducto
            // 
            lblAgregarProducto.Anchor = AnchorStyles.Top;
            lblAgregarProducto.AutoSize = true;
            lblAgregarProducto.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarProducto.ForeColor = Color.FromArgb(241, 241, 241);
            lblAgregarProducto.Location = new Point(310, 18);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(209, 39);
            lblAgregarProducto.TabIndex = 0;
            lblAgregarProducto.Text = "Agregar Producto";
            lblAgregarProducto.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnVerProductos
            // 
            btnVerProductos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerProductos.BackColor = Color.FromArgb(64, 0, 64);
            btnVerProductos.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnVerProductos.FlatAppearance.BorderSize = 2;
            btnVerProductos.FlatStyle = FlatStyle.Flat;
            btnVerProductos.ForeColor = SystemColors.Window;
            btnVerProductos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnVerProductos.IconColor = Color.White;
            btnVerProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerProductos.IconSize = 40;
            btnVerProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerProductos.Location = new Point(654, 14);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(129, 43);
            btnVerProductos.TabIndex = 19;
            btnVerProductos.Text = "Ver Productos";
            btnVerProductos.TextAlign = ContentAlignment.MiddleRight;
            btnVerProductos.UseVisualStyleBackColor = false;
            btnVerProductos.Click += btnVerProductos_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(124, 40);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 241, 241);
            label2.Location = new Point(104, 86);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Editorial";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(241, 241, 241);
            label3.Location = new Point(126, 129);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(241, 241, 241);
            label4.Location = new Point(79, 174);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 3;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(241, 241, 241);
            label5.Location = new Point(410, 40);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(241, 241, 241);
            label6.Location = new Point(442, 133);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 5;
            label6.Text = "Stock";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(241, 241, 241);
            label7.Location = new Point(436, 86);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 6;
            label7.Text = "Precio";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(241, 241, 241);
            label8.Location = new Point(424, 179);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 7;
            label8.Text = "Portada";
            // 
            // txtTitulo
            // 
            txtTitulo.Anchor = AnchorStyles.None;
            txtTitulo.Location = new Point(185, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(183, 23);
            txtTitulo.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.Location = new Point(185, 174);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(183, 79);
            txtDescripcion.TabIndex = 12;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.None;
            txtPrecio.Location = new Point(500, 83);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(183, 23);
            txtPrecio.TabIndex = 13;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.None;
            txtStock.Location = new Point(500, 131);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(183, 23);
            txtStock.TabIndex = 14;
            // 
            // pbPortada
            // 
            pbPortada.Anchor = AnchorStyles.None;
            pbPortada.BackColor = Color.White;
            pbPortada.Location = new Point(500, 181);
            pbPortada.Name = "pbPortada";
            pbPortada.Size = new Size(126, 99);
            pbPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPortada.TabIndex = 15;
            pbPortada.TabStop = false;
            // 
            // cbCategoria
            // 
            cbCategoria.Anchor = AnchorStyles.None;
            cbCategoria.AutoCompleteCustomSource.AddRange(new string[] { "Terror", "Romance", "Drama", "Ficcion", "Ciencia Ficcion" });
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Romance", "Drama", "Terror", "Fantasia" });
            cbCategoria.Location = new Point(500, 38);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(183, 23);
            cbCategoria.TabIndex = 16;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = SystemColors.ControlDarkDark;
            btnGuardar.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 40;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(344, 304);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 40);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lbErrorMenssage2
            // 
            lbErrorMenssage2.Anchor = AnchorStyles.None;
            lbErrorMenssage2.AutoSize = true;
            lbErrorMenssage2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage2.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage2.Image = (Image)resources.GetObject("lbErrorMenssage2.Image");
            lbErrorMenssage2.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage2.Location = new Point(185, 108);
            lbErrorMenssage2.Name = "lbErrorMenssage2";
            lbErrorMenssage2.Size = new Size(128, 20);
            lbErrorMenssage2.TabIndex = 21;
            lbErrorMenssage2.Text = "Mensaje de error";
            lbErrorMenssage2.TextAlign = ContentAlignment.TopCenter;
            lbErrorMenssage2.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(cbAutor);
            panel2.Controls.Add(cbEditorial);
            panel2.Controls.Add(lbErrorMenssage8);
            panel2.Controls.Add(lbErrorMenssage7);
            panel2.Controls.Add(lbErrorMenssage6);
            panel2.Controls.Add(lbErrorMenssage5);
            panel2.Controls.Add(lbErrorMenssage4);
            panel2.Controls.Add(lbErrorMenssage3);
            panel2.Controls.Add(lbErrorMenssage1);
            panel2.Controls.Add(lbPathTittleP);
            panel2.Controls.Add(btAgregarImagen);
            panel2.Controls.Add(lbErrorMenssage2);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(cbCategoria);
            panel2.Controls.Add(pbPortada);
            panel2.Controls.Add(txtStock);
            panel2.Controls.Add(txtPrecio);
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(txtTitulo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 381);
            panel2.TabIndex = 1;
            // 
            // cbAutor
            // 
            cbAutor.Anchor = AnchorStyles.None;
            cbAutor.AutoCompleteCustomSource.AddRange(new string[] { "Terror", "Romance", "Drama", "Ficcion", "Ciencia Ficcion" });
            cbAutor.FormattingEnabled = true;
            cbAutor.Items.AddRange(new object[] { "Gabriel García Márquez", "Isabel Allende", "Jorge Luis Borges", "Julio Cortázar", "Mario Vargas Llosa" });
            cbAutor.Location = new Point(185, 131);
            cbAutor.Name = "cbAutor";
            cbAutor.Size = new Size(183, 23);
            cbAutor.TabIndex = 31;
            // 
            // cbEditorial
            // 
            cbEditorial.Anchor = AnchorStyles.None;
            cbEditorial.AutoCompleteCustomSource.AddRange(new string[] { "Terror", "Romance", "Drama", "Ficcion", "Ciencia Ficcion" });
            cbEditorial.FormattingEnabled = true;
            cbEditorial.Items.AddRange(new object[] { "Penguin Random House", "HarperCollins", "Hachette Book Group", "Macmillan Publishers" });
            cbEditorial.Location = new Point(185, 87);
            cbEditorial.Name = "cbEditorial";
            cbEditorial.Size = new Size(183, 23);
            cbEditorial.TabIndex = 30;
            // 
            // lbErrorMenssage8
            // 
            lbErrorMenssage8.Anchor = AnchorStyles.None;
            lbErrorMenssage8.AutoSize = true;
            lbErrorMenssage8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage8.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage8.Image = (Image)resources.GetObject("lbErrorMenssage8.Image");
            lbErrorMenssage8.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage8.Location = new Point(500, 283);
            lbErrorMenssage8.Name = "lbErrorMenssage8";
            lbErrorMenssage8.Size = new Size(128, 20);
            lbErrorMenssage8.TabIndex = 29;
            lbErrorMenssage8.Text = "Mensaje de error";
            lbErrorMenssage8.TextAlign = ContentAlignment.TopCenter;
            lbErrorMenssage8.Visible = false;
            // 
            // lbErrorMenssage7
            // 
            lbErrorMenssage7.Anchor = AnchorStyles.None;
            lbErrorMenssage7.AutoSize = true;
            lbErrorMenssage7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage7.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage7.Image = (Image)resources.GetObject("lbErrorMenssage7.Image");
            lbErrorMenssage7.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage7.Location = new Point(500, 158);
            lbErrorMenssage7.Name = "lbErrorMenssage7";
            lbErrorMenssage7.Size = new Size(128, 20);
            lbErrorMenssage7.TabIndex = 28;
            lbErrorMenssage7.Text = "Mensaje de error";
            lbErrorMenssage7.TextAlign = ContentAlignment.TopCenter;
            lbErrorMenssage7.Visible = false;
            // 
            // lbErrorMenssage6
            // 
            lbErrorMenssage6.Anchor = AnchorStyles.None;
            lbErrorMenssage6.AutoSize = true;
            lbErrorMenssage6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage6.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage6.Image = (Image)resources.GetObject("lbErrorMenssage6.Image");
            lbErrorMenssage6.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage6.Location = new Point(500, 108);
            lbErrorMenssage6.Name = "lbErrorMenssage6";
            lbErrorMenssage6.Size = new Size(128, 20);
            lbErrorMenssage6.TabIndex = 27;
            lbErrorMenssage6.Text = "Mensaje de error";
            lbErrorMenssage6.TextAlign = ContentAlignment.TopCenter;
            lbErrorMenssage6.Visible = false;
            // 
            // lbErrorMenssage5
            // 
            lbErrorMenssage5.Anchor = AnchorStyles.None;
            lbErrorMenssage5.AutoSize = true;
            lbErrorMenssage5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage5.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage5.Image = (Image)resources.GetObject("lbErrorMenssage5.Image");
            lbErrorMenssage5.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage5.Location = new Point(500, 60);
            lbErrorMenssage5.Name = "lbErrorMenssage5";
            lbErrorMenssage5.Size = new Size(128, 20);
            lbErrorMenssage5.TabIndex = 26;
            lbErrorMenssage5.Text = "Mensaje de error";
            lbErrorMenssage5.TextAlign = ContentAlignment.TopCenter;
            lbErrorMenssage5.Visible = false;
            // 
            // lbErrorMenssage4
            // 
            lbErrorMenssage4.Anchor = AnchorStyles.None;
            lbErrorMenssage4.AutoSize = true;
            lbErrorMenssage4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage4.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage4.Image = (Image)resources.GetObject("lbErrorMenssage4.Image");
            lbErrorMenssage4.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage4.Location = new Point(185, 253);
            lbErrorMenssage4.Name = "lbErrorMenssage4";
            lbErrorMenssage4.Size = new Size(128, 20);
            lbErrorMenssage4.TabIndex = 25;
            lbErrorMenssage4.Text = "Mensaje de error";
            lbErrorMenssage4.TextAlign = ContentAlignment.TopCenter;
            lbErrorMenssage4.Visible = false;
            // 
            // lbErrorMenssage3
            // 
            lbErrorMenssage3.Anchor = AnchorStyles.None;
            lbErrorMenssage3.AutoSize = true;
            lbErrorMenssage3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage3.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage3.Image = (Image)resources.GetObject("lbErrorMenssage3.Image");
            lbErrorMenssage3.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage3.Location = new Point(185, 151);
            lbErrorMenssage3.Name = "lbErrorMenssage3";
            lbErrorMenssage3.Size = new Size(128, 20);
            lbErrorMenssage3.TabIndex = 24;
            lbErrorMenssage3.Text = "Mensaje de error";
            lbErrorMenssage3.TextAlign = ContentAlignment.TopCenter;
            lbErrorMenssage3.Visible = false;
            // 
            // lbErrorMenssage1
            // 
            lbErrorMenssage1.Anchor = AnchorStyles.None;
            lbErrorMenssage1.AutoSize = true;
            lbErrorMenssage1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage1.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage1.Image = (Image)resources.GetObject("lbErrorMenssage1.Image");
            lbErrorMenssage1.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage1.Location = new Point(185, 64);
            lbErrorMenssage1.Name = "lbErrorMenssage1";
            lbErrorMenssage1.Size = new Size(128, 20);
            lbErrorMenssage1.TabIndex = 23;
            lbErrorMenssage1.Text = "Mensaje de error";
            lbErrorMenssage1.TextAlign = ContentAlignment.TopCenter;
            lbErrorMenssage1.Visible = false;
            // 
            // lbPathTittleP
            // 
            lbPathTittleP.Anchor = AnchorStyles.None;
            lbPathTittleP.AutoSize = true;
            lbPathTittleP.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPathTittleP.ForeColor = Color.FromArgb(241, 241, 241);
            lbPathTittleP.Location = new Point(664, 181);
            lbPathTittleP.Name = "lbPathTittleP";
            lbPathTittleP.Size = new Size(46, 21);
            lbPathTittleP.TabIndex = 22;
            lbPathTittleP.Text = "libro";
            // 
            // btAgregarImagen
            // 
            btAgregarImagen.Anchor = AnchorStyles.None;
            btAgregarImagen.BackColor = Color.FromArgb(64, 0, 64);
            btAgregarImagen.FlatAppearance.BorderSize = 0;
            btAgregarImagen.FlatStyle = FlatStyle.Flat;
            btAgregarImagen.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            btAgregarImagen.IconColor = SystemColors.Window;
            btAgregarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btAgregarImagen.IconSize = 30;
            btAgregarImagen.Location = new Point(633, 174);
            btAgregarImagen.Name = "btAgregarImagen";
            btAgregarImagen.Size = new Size(25, 39);
            btAgregarImagen.TabIndex = 2;
            btAgregarImagen.UseVisualStyleBackColor = false;
            btAgregarImagen.Click += iconButton1_Click;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarProducto";
            Load += AgregarProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPortada).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAgregarProducto;
        private FontAwesome.Sharp.IconButton btnVerProductos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTitulo;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private PictureBox pbPortada;
        private ComboBox cbCategoria;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lbErrorMenssage2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton btAgregarImagen;
        private Label lbPathTittleP;
        private Label lbErrorMenssage6;
        private Label lbErrorMenssage5;
        private Label lbErrorMenssage4;
        private Label lbErrorMenssage3;
        private Label lbErrorMenssage1;
        private Label lbErrorMenssage8;
        private Label lbErrorMenssage7;
        private ComboBox cbAutor;
        private ComboBox cbEditorial;
    }
}