namespace LibreriaRiot.Principal
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            lbErrorMenssage = new Label();
            iconEye = new FontAwesome.Sharp.IconButton();
            btnminimizar = new PictureBox();
            btncerrar = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            btnIniciar = new Button();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(lbErrorMenssage);
            panel1.Controls.Add(iconEye);
            panel1.Controls.Add(btnminimizar);
            panel1.Controls.Add(btncerrar);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnIniciar);
            panel1.Location = new Point(192, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 288);
            panel1.TabIndex = 25;
            // 
            // lbErrorMenssage
            // 
            lbErrorMenssage.AutoSize = true;
            lbErrorMenssage.ForeColor = Color.Brown;
            lbErrorMenssage.Image = (Image)resources.GetObject("lbErrorMenssage.Image");
            lbErrorMenssage.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage.Location = new Point(22, 188);
            lbErrorMenssage.Name = "lbErrorMenssage";
            lbErrorMenssage.Size = new Size(95, 15);
            lbErrorMenssage.TabIndex = 0;
            lbErrorMenssage.Text = "Mensaje de error";
            lbErrorMenssage.Visible = false;
            // 
            // iconEye
            // 
            iconEye.BackColor = Color.White;
            iconEye.FlatAppearance.BorderSize = 0;
            iconEye.FlatStyle = FlatStyle.Flat;
            iconEye.ForeColor = SystemColors.ControlDark;
            iconEye.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconEye.IconColor = Color.DarkGray;
            iconEye.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconEye.IconSize = 23;
            iconEye.Location = new Point(432, 148);
            iconEye.Name = "iconEye";
            iconEye.Size = new Size(24, 16);
            iconEye.TabIndex = 15;
            iconEye.UseVisualStyleBackColor = false;
            iconEye.Visible = false;
            iconEye.Click += iconEye_Click;
            // 
            // btnminimizar
            // 
            btnminimizar.BackColor = Color.Transparent;
            btnminimizar.Image = (Image)resources.GetObject("btnminimizar.Image");
            btnminimizar.Location = new Point(418, 0);
            btnminimizar.Name = "btnminimizar";
            btnminimizar.Size = new Size(30, 27);
            btnminimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnminimizar.TabIndex = 17;
            btnminimizar.TabStop = false;
            btnminimizar.Click += btnminimizar_Click;
            // 
            // btncerrar
            // 
            btncerrar.Image = (Image)resources.GetObject("btncerrar.Image");
            btncerrar.Location = new Point(444, 0);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(30, 27);
            btncerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btncerrar.TabIndex = 16;
            btncerrar.TabStop = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox4.Location = new Point(22, 171);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(435, 3);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox5.Location = new Point(22, 121);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(435, 3);
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(187, 8);
            label1.Name = "label1";
            label1.Size = new Size(100, 34);
            label1.TabIndex = 13;
            label1.Text = "LOGIN";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(21, 145);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(435, 20);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(22, 95);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(435, 20);
            txtUsuario.TabIndex = 8;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(110, 221);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(261, 32);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 288);
            panel2.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 188);
            label2.Name = "label2";
            label2.Size = new Size(94, 38);
            label2.TabIndex = 14;
            label2.Text = "RIOT";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 127);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AcceptButton = btnIniciar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 286);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btncerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Button btnIniciar;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox btnminimizar;
        private PictureBox btncerrar;
        private FontAwesome.Sharp.IconButton iconEye;
        private Label lbErrorMenssage;
    }
}