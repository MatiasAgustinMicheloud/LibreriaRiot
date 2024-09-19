namespace LibreriaRiot.Principal.lobi
{
    partial class Lobi
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobi));
            panel1 = new Panel();
            Lfecha = new Label();
            Lhora = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnlobiMinimizar = new FontAwesome.Sharp.IconButton();
            btnlobiMaximizar = new FontAwesome.Sharp.IconButton();
            btnlobiSalir = new FontAwesome.Sharp.IconButton();
            lbTitleCurrentForm = new Label();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            lbNApe = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            lbRol = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            panel4 = new Panel();
            iconCargarCliente = new FontAwesome.Sharp.IconButton();
            iconRealizarVenta = new FontAwesome.Sharp.IconButton();
            iconExit = new FontAwesome.Sharp.IconButton();
            iconRespaldo = new FontAwesome.Sharp.IconButton();
            iconUsuarios = new FontAwesome.Sharp.IconButton();
            iconEstadistica = new FontAwesome.Sharp.IconButton();
            iconHistorialVentas = new FontAwesome.Sharp.IconButton();
            iconMisVentas = new FontAwesome.Sharp.IconButton();
            iconCatalogo = new FontAwesome.Sharp.IconButton();
            iconProducto = new FontAwesome.Sharp.IconButton();
            horaFecha = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 64);
            panel1.Controls.Add(Lfecha);
            panel1.Controls.Add(Lhora);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(208, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 513);
            panel1.TabIndex = 0;
            // 
            // Lfecha
            // 
            Lfecha.AutoSize = true;
            Lfecha.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lfecha.ForeColor = SystemColors.Window;
            Lfecha.Location = new Point(223, 385);
            Lfecha.Name = "Lfecha";
            Lfecha.Size = new Size(69, 30);
            Lfecha.TabIndex = 9;
            Lfecha.Text = "Fecha";
            // 
            // Lhora
            // 
            Lhora.AutoSize = true;
            Lhora.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Lhora.ForeColor = SystemColors.Window;
            Lhora.Location = new Point(364, 348);
            Lhora.Name = "Lhora";
            Lhora.Size = new Size(61, 30);
            Lhora.TabIndex = 8;
            Lhora.Text = "Hora";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDarkDark;
            pictureBox2.Location = new Point(256, 117);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(305, 207);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(btnlobiMinimizar);
            panel2.Controls.Add(btnlobiMaximizar);
            panel2.Controls.Add(btnlobiSalir);
            panel2.Controls.Add(lbTitleCurrentForm);
            panel2.Controls.Add(iconButton8);
            panel2.Controls.Add(lbNApe);
            panel2.Controls.Add(iconCurrentChildForm);
            panel2.Controls.Add(lbRol);
            panel2.Location = new Point(208, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(767, 89);
            panel2.TabIndex = 1;
            // 
            // btnlobiMinimizar
            // 
            btnlobiMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlobiMinimizar.BackColor = Color.Transparent;
            btnlobiMinimizar.FlatAppearance.BorderSize = 0;
            btnlobiMinimizar.FlatStyle = FlatStyle.Flat;
            btnlobiMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnlobiMinimizar.IconColor = Color.White;
            btnlobiMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlobiMinimizar.IconSize = 18;
            btnlobiMinimizar.ImageAlign = ContentAlignment.TopCenter;
            btnlobiMinimizar.Location = new Point(662, 3);
            btnlobiMinimizar.Name = "btnlobiMinimizar";
            btnlobiMinimizar.Size = new Size(30, 22);
            btnlobiMinimizar.TabIndex = 7;
            btnlobiMinimizar.UseVisualStyleBackColor = false;
            btnlobiMinimizar.Click += btnlobiMinimizar_Click;
            // 
            // btnlobiMaximizar
            // 
            btnlobiMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlobiMaximizar.BackColor = Color.Transparent;
            btnlobiMaximizar.FlatAppearance.BorderSize = 0;
            btnlobiMaximizar.FlatStyle = FlatStyle.Flat;
            btnlobiMaximizar.IconChar = FontAwesome.Sharp.IconChar.Expand;
            btnlobiMaximizar.IconColor = SystemColors.Menu;
            btnlobiMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlobiMaximizar.IconSize = 18;
            btnlobiMaximizar.ImageAlign = ContentAlignment.TopCenter;
            btnlobiMaximizar.Location = new Point(698, 3);
            btnlobiMaximizar.Name = "btnlobiMaximizar";
            btnlobiMaximizar.Size = new Size(30, 22);
            btnlobiMaximizar.TabIndex = 6;
            btnlobiMaximizar.UseVisualStyleBackColor = false;
            btnlobiMaximizar.Click += btnlobiMaximizar_Click;
            // 
            // btnlobiSalir
            // 
            btnlobiSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnlobiSalir.BackColor = Color.Transparent;
            btnlobiSalir.FlatAppearance.BorderSize = 0;
            btnlobiSalir.FlatStyle = FlatStyle.Flat;
            btnlobiSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            btnlobiSalir.IconColor = Color.Crimson;
            btnlobiSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlobiSalir.IconSize = 18;
            btnlobiSalir.ImageAlign = ContentAlignment.TopCenter;
            btnlobiSalir.Location = new Point(734, 3);
            btnlobiSalir.Name = "btnlobiSalir";
            btnlobiSalir.Size = new Size(30, 31);
            btnlobiSalir.TabIndex = 5;
            btnlobiSalir.UseVisualStyleBackColor = false;
            btnlobiSalir.Click += btnlobiSalir_Click;
            // 
            // lbTitleCurrentForm
            // 
            lbTitleCurrentForm.AutoSize = true;
            lbTitleCurrentForm.BackColor = Color.Transparent;
            lbTitleCurrentForm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitleCurrentForm.ForeColor = Color.Gainsboro;
            lbTitleCurrentForm.Location = new Point(54, 41);
            lbTitleCurrentForm.Name = "lbTitleCurrentForm";
            lbTitleCurrentForm.Size = new Size(46, 20);
            lbTitleCurrentForm.TabIndex = 3;
            lbTitleCurrentForm.Text = "Inicio";
            // 
            // iconButton8
            // 
            iconButton8.BackColor = SystemColors.ControlDarkDark;
            iconButton8.FlatAppearance.BorderSize = 0;
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconButton8.IconColor = Color.White;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 45;
            iconButton8.Location = new Point(590, 37);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(41, 40);
            iconButton8.TabIndex = 7;
            iconButton8.UseVisualStyleBackColor = false;
            // 
            // lbNApe
            // 
            lbNApe.AutoSize = true;
            lbNApe.ForeColor = SystemColors.Window;
            lbNApe.Location = new Point(637, 54);
            lbNApe.Name = "lbNApe";
            lbNApe.Size = new Size(107, 15);
            lbNApe.TabIndex = 0;
            lbNApe.Text = "Nombre y Apellido";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.Transparent;
            iconCurrentChildForm.ForeColor = Color.Gainsboro;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.Location = new Point(25, 37);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(32, 32);
            iconCurrentChildForm.TabIndex = 2;
            iconCurrentChildForm.TabStop = false;
            // 
            // lbRol
            // 
            lbRol.AutoSize = true;
            lbRol.ForeColor = SystemColors.Window;
            lbRol.Location = new Point(637, 37);
            lbRol.Name = "lbRol";
            lbRol.Size = new Size(24, 15);
            lbRol.TabIndex = 0;
            lbRol.Text = "Rol";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 89);
            panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox3.Location = new Point(207, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 92);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 26);
            label2.Name = "label2";
            label2.Size = new Size(94, 38);
            label2.TabIndex = 15;
            label2.Text = "RIOT";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.Controls.Add(iconCargarCliente);
            panel4.Controls.Add(iconRealizarVenta);
            panel4.Controls.Add(iconExit);
            panel4.Controls.Add(iconRespaldo);
            panel4.Controls.Add(iconUsuarios);
            panel4.Controls.Add(iconEstadistica);
            panel4.Controls.Add(iconHistorialVentas);
            panel4.Controls.Add(iconMisVentas);
            panel4.Controls.Add(iconCatalogo);
            panel4.Controls.Add(iconProducto);
            panel4.Location = new Point(1, 88);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 513);
            panel4.TabIndex = 0;
            // 
            // iconCargarCliente
            // 
            iconCargarCliente.Dock = DockStyle.Top;
            iconCargarCliente.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconCargarCliente.FlatAppearance.BorderSize = 2;
            iconCargarCliente.FlatStyle = FlatStyle.Flat;
            iconCargarCliente.ForeColor = SystemColors.Window;
            iconCargarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconCargarCliente.IconColor = Color.White;
            iconCargarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCargarCliente.IconSize = 40;
            iconCargarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            iconCargarCliente.Location = new Point(0, 432);
            iconCargarCliente.Name = "iconCargarCliente";
            iconCargarCliente.Size = new Size(209, 54);
            iconCargarCliente.TabIndex = 12;
            iconCargarCliente.Text = "Cargar Cliente";
            iconCargarCliente.UseVisualStyleBackColor = false;
            iconCargarCliente.Visible = false;
            // 
            // iconRealizarVenta
            // 
            iconRealizarVenta.BackColor = SystemColors.ControlDarkDark;
            iconRealizarVenta.Dock = DockStyle.Top;
            iconRealizarVenta.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconRealizarVenta.FlatAppearance.BorderSize = 2;
            iconRealizarVenta.FlatStyle = FlatStyle.Flat;
            iconRealizarVenta.ForeColor = SystemColors.Window;
            iconRealizarVenta.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            iconRealizarVenta.IconColor = Color.White;
            iconRealizarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRealizarVenta.IconSize = 40;
            iconRealizarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            iconRealizarVenta.Location = new Point(0, 378);
            iconRealizarVenta.Name = "iconRealizarVenta";
            iconRealizarVenta.Size = new Size(209, 54);
            iconRealizarVenta.TabIndex = 11;
            iconRealizarVenta.Text = "Realizar Venta";
            iconRealizarVenta.UseVisualStyleBackColor = false;
            iconRealizarVenta.Visible = false;
            iconRealizarVenta.Click += iconButton1_Click;
            // 
            // iconExit
            // 
            iconExit.BackColor = SystemColors.ControlDarkDark;
            iconExit.Dock = DockStyle.Bottom;
            iconExit.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconExit.FlatAppearance.BorderSize = 2;
            iconExit.FlatStyle = FlatStyle.Flat;
            iconExit.ForeColor = SystemColors.Window;
            iconExit.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            iconExit.IconColor = Color.White;
            iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconExit.IconSize = 40;
            iconExit.ImageAlign = ContentAlignment.MiddleLeft;
            iconExit.Location = new Point(0, 460);
            iconExit.Name = "iconExit";
            iconExit.Size = new Size(209, 53);
            iconExit.TabIndex = 8;
            iconExit.Text = "Cerrar Sesion";
            iconExit.UseVisualStyleBackColor = false;
            iconExit.Click += iconExit_Click;
            // 
            // iconRespaldo
            // 
            iconRespaldo.BackColor = SystemColors.ControlDarkDark;
            iconRespaldo.Dock = DockStyle.Top;
            iconRespaldo.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconRespaldo.FlatAppearance.BorderSize = 2;
            iconRespaldo.FlatStyle = FlatStyle.Flat;
            iconRespaldo.ForeColor = SystemColors.Window;
            iconRespaldo.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconRespaldo.IconColor = Color.White;
            iconRespaldo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconRespaldo.IconSize = 40;
            iconRespaldo.ImageAlign = ContentAlignment.MiddleLeft;
            iconRespaldo.Location = new Point(0, 324);
            iconRespaldo.Name = "iconRespaldo";
            iconRespaldo.Size = new Size(209, 54);
            iconRespaldo.TabIndex = 3;
            iconRespaldo.Text = "Base De Datos";
            iconRespaldo.UseVisualStyleBackColor = false;
            iconRespaldo.Visible = false;
            // 
            // iconUsuarios
            // 
            iconUsuarios.BackColor = SystemColors.ControlDarkDark;
            iconUsuarios.Dock = DockStyle.Top;
            iconUsuarios.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconUsuarios.FlatAppearance.BorderSize = 2;
            iconUsuarios.FlatStyle = FlatStyle.Flat;
            iconUsuarios.ForeColor = SystemColors.Window;
            iconUsuarios.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            iconUsuarios.IconColor = Color.White;
            iconUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUsuarios.IconSize = 40;
            iconUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            iconUsuarios.Location = new Point(0, 270);
            iconUsuarios.Name = "iconUsuarios";
            iconUsuarios.Size = new Size(209, 54);
            iconUsuarios.TabIndex = 10;
            iconUsuarios.Text = "Empleados";
            iconUsuarios.UseVisualStyleBackColor = false;
            iconUsuarios.Visible = false;
            iconUsuarios.Click += iconUsuarios_Click;
            // 
            // iconEstadistica
            // 
            iconEstadistica.BackColor = SystemColors.ControlDarkDark;
            iconEstadistica.Dock = DockStyle.Top;
            iconEstadistica.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconEstadistica.FlatAppearance.BorderSize = 2;
            iconEstadistica.FlatStyle = FlatStyle.Flat;
            iconEstadistica.ForeColor = SystemColors.Window;
            iconEstadistica.IconChar = FontAwesome.Sharp.IconChar.SquarePollVertical;
            iconEstadistica.IconColor = Color.White;
            iconEstadistica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEstadistica.IconSize = 40;
            iconEstadistica.ImageAlign = ContentAlignment.MiddleLeft;
            iconEstadistica.Location = new Point(0, 216);
            iconEstadistica.Name = "iconEstadistica";
            iconEstadistica.Size = new Size(209, 54);
            iconEstadistica.TabIndex = 9;
            iconEstadistica.Text = "Estadisticas";
            iconEstadistica.UseVisualStyleBackColor = false;
            iconEstadistica.Visible = false;
            // 
            // iconHistorialVentas
            // 
            iconHistorialVentas.BackColor = SystemColors.ControlDarkDark;
            iconHistorialVentas.Dock = DockStyle.Top;
            iconHistorialVentas.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconHistorialVentas.FlatAppearance.BorderSize = 2;
            iconHistorialVentas.FlatStyle = FlatStyle.Flat;
            iconHistorialVentas.ForeColor = SystemColors.Window;
            iconHistorialVentas.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            iconHistorialVentas.IconColor = Color.White;
            iconHistorialVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconHistorialVentas.IconSize = 40;
            iconHistorialVentas.ImageAlign = ContentAlignment.MiddleLeft;
            iconHistorialVentas.Location = new Point(0, 162);
            iconHistorialVentas.Name = "iconHistorialVentas";
            iconHistorialVentas.Size = new Size(209, 54);
            iconHistorialVentas.TabIndex = 5;
            iconHistorialVentas.Text = "Historial Ventas";
            iconHistorialVentas.UseVisualStyleBackColor = false;
            iconHistorialVentas.Visible = false;
            // 
            // iconMisVentas
            // 
            iconMisVentas.BackColor = SystemColors.ControlDarkDark;
            iconMisVentas.Dock = DockStyle.Top;
            iconMisVentas.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconMisVentas.FlatAppearance.BorderSize = 2;
            iconMisVentas.FlatStyle = FlatStyle.Flat;
            iconMisVentas.ForeColor = SystemColors.Window;
            iconMisVentas.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            iconMisVentas.IconColor = Color.White;
            iconMisVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMisVentas.IconSize = 40;
            iconMisVentas.ImageAlign = ContentAlignment.MiddleLeft;
            iconMisVentas.Location = new Point(0, 108);
            iconMisVentas.Name = "iconMisVentas";
            iconMisVentas.Size = new Size(209, 54);
            iconMisVentas.TabIndex = 4;
            iconMisVentas.Text = "Mis Ventas";
            iconMisVentas.UseVisualStyleBackColor = false;
            iconMisVentas.Visible = false;
            // 
            // iconCatalogo
            // 
            iconCatalogo.BackColor = SystemColors.ControlDarkDark;
            iconCatalogo.Dock = DockStyle.Top;
            iconCatalogo.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconCatalogo.FlatAppearance.BorderSize = 2;
            iconCatalogo.FlatStyle = FlatStyle.Flat;
            iconCatalogo.ForeColor = SystemColors.Window;
            iconCatalogo.IconChar = FontAwesome.Sharp.IconChar.Swatchbook;
            iconCatalogo.IconColor = Color.White;
            iconCatalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCatalogo.IconSize = 40;
            iconCatalogo.ImageAlign = ContentAlignment.MiddleLeft;
            iconCatalogo.Location = new Point(0, 54);
            iconCatalogo.Name = "iconCatalogo";
            iconCatalogo.Size = new Size(209, 54);
            iconCatalogo.TabIndex = 3;
            iconCatalogo.Text = "Catalogo";
            iconCatalogo.UseVisualStyleBackColor = false;
            iconCatalogo.Visible = false;
            // 
            // iconProducto
            // 
            iconProducto.BackColor = SystemColors.ControlDarkDark;
            iconProducto.Dock = DockStyle.Top;
            iconProducto.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            iconProducto.FlatAppearance.BorderSize = 2;
            iconProducto.FlatStyle = FlatStyle.Flat;
            iconProducto.ForeColor = SystemColors.Window;
            iconProducto.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            iconProducto.IconColor = Color.White;
            iconProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconProducto.IconSize = 40;
            iconProducto.ImageAlign = ContentAlignment.MiddleLeft;
            iconProducto.Location = new Point(0, 0);
            iconProducto.Name = "iconProducto";
            iconProducto.Size = new Size(209, 54);
            iconProducto.TabIndex = 2;
            iconProducto.Text = "Producto";
            iconProducto.UseVisualStyleBackColor = false;
            iconProducto.Visible = false;
            iconProducto.Click += iconProducto_Click;
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick_1;
            // 
            // Lobi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 601);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "Lobi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Lobi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconHistorialVentas;
        private FontAwesome.Sharp.IconButton iconMisVentas;
        private FontAwesome.Sharp.IconButton iconCatalogo;
        private FontAwesome.Sharp.IconButton iconProducto;
        public Label lbTitleCurrentForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton btnlobiMinimizar;
        private FontAwesome.Sharp.IconButton btnlobiMaximizar;
        private FontAwesome.Sharp.IconButton btnlobiSalir;
        private Label lbNApe;
        private Label lbRol;
        private FontAwesome.Sharp.IconButton iconEstadistica;
        private FontAwesome.Sharp.IconButton iconRespaldo;
        private FontAwesome.Sharp.IconButton iconUsuarios;
        private Label Lfecha;
        private Label Lhora;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer horaFecha;
        private Label label2;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton iconRealizarVenta;
        private FontAwesome.Sharp.IconButton iconCargarCliente;
    }
}