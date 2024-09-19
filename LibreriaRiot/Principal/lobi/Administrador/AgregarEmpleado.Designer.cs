namespace LibreriaRiot.Principal.lobi.Administrador
{
    partial class AgregarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEmpleado));
            panel2 = new Panel();
            dtFechaAlta = new DateTimePicker();
            lbErrorMenssage = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnVerProductos = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            cbRol = new ComboBox();
            pbFoto = new PictureBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblAgregarProducto = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(dtFechaAlta);
            panel2.Controls.Add(lbErrorMenssage);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(btnVerProductos);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(cbRol);
            panel2.Controls.Add(pbFoto);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(txtDNI);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-6, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 388);
            panel2.TabIndex = 3;
            // 
            // dtFechaAlta
            // 
            dtFechaAlta.Format = DateTimePickerFormat.Short;
            dtFechaAlta.Location = new Point(191, 179);
            dtFechaAlta.Name = "dtFechaAlta";
            dtFechaAlta.Size = new Size(114, 23);
            dtFechaAlta.TabIndex = 22;
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
            btnVerProductos.Text = "Ver Empleados";
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
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
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
            // cbRol
            // 
            cbRol.FormattingEnabled = true;
            cbRol.Location = new Point(506, 46);
            cbRol.Name = "cbRol";
            cbRol.Size = new Size(183, 23);
            cbRol.TabIndex = 16;
            // 
            // pbFoto
            // 
            pbFoto.BackColor = Color.White;
            pbFoto.Location = new Point(506, 179);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(126, 99);
            pbFoto.TabIndex = 15;
            pbFoto.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(507, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(506, 91);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(183, 23);
            txtTelefono.TabIndex = 13;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(191, 135);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(183, 23);
            txtDNI.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(191, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(183, 23);
            txtApellido.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(191, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(241, 241, 241);
            label8.Location = new Point(456, 176);
            label8.Name = "label8";
            label8.Size = new Size(44, 21);
            label8.TabIndex = 7;
            label8.Text = "Foto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(241, 241, 241);
            label7.Location = new Point(73, 180);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 6;
            label7.Text = "Fecha de Alta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(241, 241, 241);
            label6.Location = new Point(448, 133);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(241, 241, 241);
            label5.Location = new Point(465, 44);
            label5.Name = "label5";
            label5.Size = new Size(35, 21);
            label5.TabIndex = 4;
            label5.Text = "Rol";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(241, 241, 241);
            label4.Location = new Point(424, 91);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(241, 241, 241);
            label3.Location = new Point(146, 133);
            label3.Name = "label3";
            label3.Size = new Size(40, 21);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 241, 241);
            label2.Location = new Point(111, 89);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(113, 44);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblAgregarProducto);
            panel1.Location = new Point(-6, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 70);
            panel1.TabIndex = 2;
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
            lblAgregarProducto.Size = new Size(219, 39);
            lblAgregarProducto.TabIndex = 0;
            lblAgregarProducto.Text = "Agregar Empleado";
            // 
            // AgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarEmpleado";
            Text = "AgregarEmpleado";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label lbErrorMenssage;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnVerProductos;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cbRol;
        private PictureBox pbFoto;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblAgregarProducto;
        private DateTimePicker dtFechaAlta;
    }
}