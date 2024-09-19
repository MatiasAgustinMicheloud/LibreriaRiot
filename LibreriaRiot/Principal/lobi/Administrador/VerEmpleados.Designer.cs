namespace LibreriaRiot.Principal.lobi.Administrador
{
    partial class VerEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerEmpleados));
            Portada = new DataGridViewImageColumn();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            lbErrorMenssage = new Label();
            label9 = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cbCategoria = new ComboBox();
            pbPortada = new PictureBox();
            txtStock = new TextBox();
            Stock = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Autor = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtAutor = new TextBox();
            Precio = new DataGridViewTextBoxColumn();
            txtEditorial = new TextBox();
            textBox1 = new TextBox();
            txtTitulo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Categoria = new DataGridViewTextBoxColumn();
            Editorial = new DataGridViewTextBoxColumn();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            lblAgregarProducto = new Label();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbPortada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Portada
            // 
            Portada.HeaderText = "Portada";
            Portada.Name = "Portada";
            Portada.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlDarkDark;
            btnLimpiar.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = SystemColors.Window;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnLimpiar.IconColor = Color.White;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(244, 325);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 50);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlDarkDark;
            btnEliminar.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.Window;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(242, 381);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(107, 50);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lbErrorMenssage
            // 
            lbErrorMenssage.AutoSize = true;
            lbErrorMenssage.ForeColor = Color.Brown;
            lbErrorMenssage.Image = (Image)resources.GetObject("lbErrorMenssage.Image");
            lbErrorMenssage.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage.Location = new Point(117, 424);
            lbErrorMenssage.Name = "lbErrorMenssage";
            lbErrorMenssage.Size = new Size(95, 15);
            lbErrorMenssage.TabIndex = 22;
            lbErrorMenssage.Text = "Mensaje de error";
            lbErrorMenssage.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(241, 241, 241);
            label9.Location = new Point(74, 16);
            label9.Name = "label9";
            label9.Size = new Size(123, 39);
            label9.TabIndex = 19;
            label9.Text = "Modificar";
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
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(254, 19);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 38);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Editar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(117, 238);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(127, 23);
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
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Autor
            // 
            Autor.HeaderText = "Autor";
            Autor.Name = "Autor";
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.Name = "Titulo";
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
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(117, 89);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(232, 23);
            txtEditorial.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 23;
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
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(90, 16);
            label4.TabIndex = 3;
            label4.Text = "Descripcion";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Titulo, Autor, Descripcion, Stock, Precio, Portada, Categoria, Editorial });
            dataGridView1.Location = new Point(9, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(530, 405);
            dataGridView1.TabIndex = 22;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Editorial
            // 
            Editorial.HeaderText = "Editorial";
            Editorial.Name = "Editorial";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox5.Location = new Point(-6, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(936, 10);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(241, 241, 241);
            label3.Location = new Point(59, 113);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 2;
            label3.Text = "Autor";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(pictureBox5);
            panel3.Location = new Point(-1, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 466);
            panel3.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(59, 16);
            label10.TabIndex = 24;
            label10.Text = "Buscar:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblAgregarProducto
            // 
            lblAgregarProducto.AutoSize = true;
            lblAgregarProducto.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarProducto.ForeColor = Color.FromArgb(241, 241, 241);
            lblAgregarProducto.Location = new Point(371, 13);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(255, 39);
            lblAgregarProducto.TabIndex = 0;
            lblAgregarProducto.Text = "Listado de Empleados";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblAgregarProducto);
            panel1.Controls.Add(iconButton1);
            panel1.Location = new Point(-4, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 70);
            panel1.TabIndex = 22;
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
            iconButton1.Location = new Point(88, 15);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(43, 48);
            iconButton1.TabIndex = 20;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnEliminar);
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
            panel2.Location = new Point(547, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 467);
            panel2.TabIndex = 23;
            // 
            // VerEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 526);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "VerEmpleados";
            Text = "VerEmpleados";
            ((System.ComponentModel.ISupportInitialize)pbPortada).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridViewImageColumn Portada;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Label lbErrorMenssage;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cbCategoria;
        private PictureBox pbPortada;
        private TextBox txtStock;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Titulo;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtAutor;
        private DataGridViewTextBoxColumn Precio;
        private TextBox txtEditorial;
        private TextBox textBox1;
        private TextBox txtTitulo;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Editorial;
        private PictureBox pictureBox5;
        private Label label3;
        private Panel panel3;
        private Label label10;
        private PictureBox pictureBox1;
        private Label lblAgregarProducto;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private Label label1;
        private Panel panel2;
    }
}