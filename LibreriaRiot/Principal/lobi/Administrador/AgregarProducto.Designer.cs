namespace LibreriaRiot.Principal.lobi.Administrador
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblAgregarProducto = new Label();
            panel2 = new Panel();
            lbErrorMenssage = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnVerProductos = new FontAwesome.Sharp.IconButton();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortada).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblAgregarProducto);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 70);
            panel1.TabIndex = 0;
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
            lblAgregarProducto.Location = new Point(301, 18);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(209, 39);
            lblAgregarProducto.TabIndex = 0;
            lblAgregarProducto.Text = "Agregar Producto";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(lbErrorMenssage);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(btnVerProductos);
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
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 388);
            panel2.TabIndex = 1;
            // 
            // lbErrorMenssage
            // 
            lbErrorMenssage.AutoSize = true;
            lbErrorMenssage.ForeColor = Color.Brown;
            lbErrorMenssage.Image = (Image)resources.GetObject("lbErrorMenssage.Image");
            lbErrorMenssage.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage.Location = new Point(350, 12);
            lbErrorMenssage.Name = "lbErrorMenssage";
            lbErrorMenssage.Size = new Size(95, 15);
            lbErrorMenssage.TabIndex = 21;
            lbErrorMenssage.Text = "Mensaje de error";
            lbErrorMenssage.Visible = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(64, 0, 64);
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(12, 320);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(43, 48);
            iconButton1.TabIndex = 20;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnVerProductos
            // 
            btnVerProductos.BackColor = SystemColors.ControlDarkDark;
            btnVerProductos.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnVerProductos.FlatAppearance.BorderSize = 2;
            btnVerProductos.FlatStyle = FlatStyle.Flat;
            btnVerProductos.ForeColor = SystemColors.Window;
            btnVerProductos.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            btnVerProductos.IconColor = Color.White;
            btnVerProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerProductos.Location = new Point(659, 320);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(129, 48);
            btnVerProductos.TabIndex = 19;
            btnVerProductos.Text = "Ver Productos";
            btnVerProductos.TextAlign = ContentAlignment.MiddleRight;
            btnVerProductos.UseVisualStyleBackColor = false;
            btnVerProductos.Click += btnVerProductos_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ControlDarkDark;
            btnGuardar.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.Window;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(350, 303);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 50);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(506, 42);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(183, 23);
            cbCategoria.TabIndex = 16;
            // 
            // pbPortada
            // 
            pbPortada.Location = new Point(506, 178);
            pbPortada.Name = "pbPortada";
            pbPortada.Size = new Size(126, 99);
            pbPortada.TabIndex = 15;
            pbPortada.TabStop = false;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(506, 135);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(183, 23);
            txtStock.TabIndex = 14;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(506, 87);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(183, 23);
            txtPrecio.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(191, 178);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(183, 79);
            txtDescripcion.TabIndex = 12;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(191, 135);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(183, 23);
            txtAutor.TabIndex = 11;
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(191, 87);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(183, 23);
            txtEditorial.TabIndex = 10;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(191, 42);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(183, 23);
            txtTitulo.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(241, 241, 241);
            label8.Location = new Point(430, 196);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 7;
            label8.Text = "Portada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(241, 241, 241);
            label7.Location = new Point(442, 90);
            label7.Name = "label7";
            label7.Size = new Size(58, 21);
            label7.TabIndex = 6;
            label7.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(241, 241, 241);
            label6.Location = new Point(448, 137);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 5;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(241, 241, 241);
            label5.Location = new Point(416, 44);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 4;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(241, 241, 241);
            label4.Location = new Point(85, 178);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 3;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(241, 241, 241);
            label3.Location = new Point(132, 133);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 2;
            label3.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 241, 241);
            label2.Location = new Point(110, 90);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Editorial";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(130, 44);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 0;
            label1.Text = "Titulo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAgregarProducto;
        private Panel panel2;
        private Label label1;
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
        private ComboBox cbCategoria;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnVerProductos;
        private Label lbErrorMenssage;
    }
}