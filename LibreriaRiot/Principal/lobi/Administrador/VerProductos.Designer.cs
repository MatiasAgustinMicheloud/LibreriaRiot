namespace LibreriaRiot.Principal.lobi.Administrador
{
    partial class VerProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProductos));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            lbBaja = new Label();
            checkBoxNo = new CheckBox();
            checkBoxSi = new CheckBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            lbErrorMenssage = new Label();
            label9 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cbCategoria = new ComboBox();
            pbPortada = new PictureBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtAutor = new TextBox();
            txtEditorial = new TextBox();
            txtTitulo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblAgregarProducto = new Label();
            pictureBox5 = new PictureBox();
            dataGridView1 = new DataGridView();
            txtBuscadorTitulo = new TextBox();
            label10 = new Label();
            txtBuscadorAutor = new TextBox();
            label11 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            cbBuscadorCategoria = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortada).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(lbBaja);
            panel2.Controls.Add(checkBoxNo);
            panel2.Controls.Add(checkBoxSi);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(lbErrorMenssage);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(cbCategoria);
            panel2.Controls.Add(pbPortada);
            panel2.Controls.Add(txtStock);
            panel2.Controls.Add(txtPrecio);
            panel2.Controls.Add(txtDescripcion);
            panel2.Controls.Add(txtAutor);
            panel2.Controls.Add(txtEditorial);
            panel2.Controls.Add(txtTitulo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(545, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 517);
            panel2.TabIndex = 3;
            // 
            // lbBaja
            // 
            lbBaja.AutoSize = true;
            lbBaja.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbBaja.ForeColor = SystemColors.Window;
            lbBaja.Location = new Point(279, 343);
            lbBaja.Name = "lbBaja";
            lbBaja.Size = new Size(39, 16);
            lbBaja.TabIndex = 27;
            lbBaja.Text = "Baja";
            // 
            // checkBoxNo
            // 
            checkBoxNo.AutoSize = true;
            checkBoxNo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxNo.ForeColor = SystemColors.Window;
            checkBoxNo.Location = new Point(306, 369);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(43, 20);
            checkBoxNo.TabIndex = 26;
            checkBoxNo.Text = "no";
            checkBoxNo.UseVisualStyleBackColor = true;
            checkBoxNo.CheckedChanged += checkBoxNo_CheckedChanged;
            // 
            // checkBoxSi
            // 
            checkBoxSi.AutoSize = true;
            checkBoxSi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxSi.ForeColor = SystemColors.Window;
            checkBoxSi.Location = new Point(256, 369);
            checkBoxSi.Name = "checkBoxSi";
            checkBoxSi.Size = new Size(38, 20);
            checkBoxSi.TabIndex = 25;
            checkBoxSi.Text = "si";
            checkBoxSi.UseVisualStyleBackColor = true;
            checkBoxSi.CheckedChanged += checkBoxSi_CheckedChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlDarkDark;
            btnLimpiar.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = SystemColors.Window;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 35;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(231, 442);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(87, 38);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lbErrorMenssage
            // 
            lbErrorMenssage.AutoSize = true;
            lbErrorMenssage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage.Image = (Image)resources.GetObject("lbErrorMenssage.Image");
            lbErrorMenssage.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage.Location = new Point(117, 418);
            lbErrorMenssage.Name = "lbErrorMenssage";
            lbErrorMenssage.Size = new Size(128, 20);
            lbErrorMenssage.TabIndex = 22;
            lbErrorMenssage.Text = "Mensaje de error";
            lbErrorMenssage.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(241, 241, 241);
            label9.Location = new Point(106, 13);
            label9.Name = "label9";
            label9.Size = new Size(188, 39);
            label9.TabIndex = 19;
            label9.Text = "Modificar Libro";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ControlDarkDark;
            btnGuardar.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 40;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(124, 442);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 38);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Editar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Romance", "Drama", "Terror", "Fantasia" });
            cbCategoria.Location = new Point(117, 238);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(232, 23);
            cbCategoria.TabIndex = 16;
            // 
            // pbPortada
            // 
            pbPortada.BackColor = Color.White;
            pbPortada.Location = new Point(117, 325);
            pbPortada.Name = "pbPortada";
            pbPortada.Size = new Size(121, 90);
            pbPortada.TabIndex = 15;
            pbPortada.TabStop = false;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(117, 296);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(232, 23);
            txtStock.TabIndex = 14;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(117, 267);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(232, 23);
            txtPrecio.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(117, 146);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(232, 86);
            txtDescripcion.TabIndex = 12;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(117, 118);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(232, 23);
            txtAutor.TabIndex = 11;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(117, 89);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(232, 23);
            txtEditorial.TabIndex = 10;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(117, 60);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(232, 23);
            txtTitulo.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(241, 241, 241);
            label8.Location = new Point(47, 343);
            label8.Name = "label8";
            label8.Size = new Size(62, 16);
            label8.TabIndex = 7;
            label8.Text = "Portada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(241, 241, 241);
            label7.Location = new Point(53, 270);
            label7.Name = "label7";
            label7.Size = new Size(52, 16);
            label7.TabIndex = 6;
            label7.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(241, 241, 241);
            label6.Location = new Point(59, 298);
            label6.Name = "label6";
            label6.Size = new Size(46, 16);
            label6.TabIndex = 5;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(241, 241, 241);
            label5.Location = new Point(27, 240);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(241, 241, 241);
            label4.Location = new Point(15, 148);
            label4.Name = "label4";
            label4.Size = new Size(90, 16);
            label4.TabIndex = 3;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(241, 241, 241);
            label3.Location = new Point(59, 120);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 2;
            label3.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 241, 241);
            label2.Location = new Point(37, 89);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 1;
            label2.Text = "Editorial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(57, 59);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
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
            iconButton1.Location = new Point(19, 13);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(43, 48);
            iconButton1.TabIndex = 20;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblAgregarProducto);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 70);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox1.Location = new Point(908, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 71);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 71);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // lblAgregarProducto
            // 
            lblAgregarProducto.Anchor = AnchorStyles.None;
            lblAgregarProducto.AutoSize = true;
            lblAgregarProducto.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarProducto.ForeColor = Color.FromArgb(241, 241, 241);
            lblAgregarProducto.Location = new Point(371, 13);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(205, 39);
            lblAgregarProducto.TabIndex = 0;
            lblAgregarProducto.Text = "Listado de Libros";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox5.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox5.Location = new Point(-6, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(938, 10);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 0, 64);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Purple;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 0, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Gray;
            dataGridView1.Location = new Point(6, 45);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(535, 460);
            dataGridView1.TabIndex = 22;
            // 
            // txtBuscadorTitulo
            // 
            txtBuscadorTitulo.Location = new Point(62, 16);
            txtBuscadorTitulo.Name = "txtBuscadorTitulo";
            txtBuscadorTitulo.Size = new Size(116, 23);
            txtBuscadorTitulo.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(6, 23);
            label10.Name = "label10";
            label10.Size = new Size(50, 16);
            label10.TabIndex = 24;
            label10.Text = "Titulo:";
            // 
            // txtBuscadorAutor
            // 
            txtBuscadorAutor.Location = new Point(237, 16);
            txtBuscadorAutor.Name = "txtBuscadorAutor";
            txtBuscadorAutor.Size = new Size(104, 23);
            txtBuscadorAutor.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(184, 23);
            label11.Name = "label11";
            label11.Size = new Size(47, 16);
            label11.TabIndex = 26;
            label11.Text = "Autor:";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 0, 64);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(cbBuscadorCategoria);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtBuscadorAutor);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtBuscadorTitulo);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(pictureBox5);
            panel3.Location = new Point(0, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 517);
            panel3.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(241, 241, 241);
            label12.Location = new Point(349, 23);
            label12.Name = "label12";
            label12.Size = new Size(79, 16);
            label12.TabIndex = 28;
            label12.Text = "Categoria:";
            // 
            // cbBuscadorCategoria
            // 
            cbBuscadorCategoria.FormattingEnabled = true;
            cbBuscadorCategoria.Items.AddRange(new object[] { "Romance", "Drama", "Terror", "Fantasia" });
            cbBuscadorCategoria.Location = new Point(430, 16);
            cbBuscadorCategoria.Name = "cbBuscadorCategoria";
            cbBuscadorCategoria.Size = new Size(118, 23);
            cbBuscadorCategoria.TabIndex = 28;
            // 
            // VerProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 582);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VerProductos";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerProductos";
            Load += VerProductos_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortada).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cbCategoria;
        private PictureBox pbPortada;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtAutor;
        private TextBox txtEditorial;
        private TextBox txtTitulo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label lblAgregarProducto;
        private Label label9;
        private Label lbErrorMenssage;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private Label lbBaja;
        private CheckBox checkBoxNo;
        private CheckBox checkBoxSi;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private DataGridView dataGridView1;
        private TextBox txtBuscadorTitulo;
        private Label label10;
        private TextBox txtBuscadorAutor;
        private Label label11;
        private Panel panel3;
        private Label label12;
        private ComboBox cbBuscadorCategoria;
    }
}