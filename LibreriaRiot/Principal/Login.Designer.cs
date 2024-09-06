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
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            btnIniciar = new Button();
            lblPassword = new Label();
            lblUsuario = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(22, 81);
            txtPassword.MaxLength = 20;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(178, 23);
            txtPassword.TabIndex = 9;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(22, 30);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(178, 23);
            txtUsuario.TabIndex = 8;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(22, 129);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 7;
            btnIniciar.Text = "Ingresar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(22, 63);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(67, 15);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(22, 12);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 73);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsuario);
            panel1.Location = new Point(114, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 196);
            panel1.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 288);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Button btnIniciar;
        private Label lblPassword;
        private Label lblUsuario;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}