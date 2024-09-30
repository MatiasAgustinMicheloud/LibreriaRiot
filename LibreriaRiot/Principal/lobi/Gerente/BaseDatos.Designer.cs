namespace LibreriaRiot.Principal.lobi.Gerente
{
    partial class BaseDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseDatos));
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            lblBaseDatos = new Label();
            iconImportar = new FontAwesome.Sharp.IconButton();
            lbErrorModificar = new Label();
            lbNameDataBase = new Label();
            iconBackup = new FontAwesome.Sharp.IconButton();
            iconSeleccionar = new FontAwesome.Sharp.IconButton();
            textBoxRuta = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(iconImportar);
            panel3.Controls.Add(lbErrorModificar);
            panel3.Controls.Add(lbNameDataBase);
            panel3.Controls.Add(iconBackup);
            panel3.Controls.Add(iconSeleccionar);
            panel3.Controls.Add(textBoxRuta);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 387);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(lblBaseDatos);
            panel2.Location = new Point(13, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 70);
            panel2.TabIndex = 1;
            // 
            // lblBaseDatos
            // 
            lblBaseDatos.Anchor = AnchorStyles.Top;
            lblBaseDatos.AutoSize = true;
            lblBaseDatos.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaseDatos.ForeColor = Color.FromArgb(241, 241, 241);
            lblBaseDatos.Location = new Point(337, 25);
            lblBaseDatos.Name = "lblBaseDatos";
            lblBaseDatos.Size = new Size(167, 39);
            lblBaseDatos.TabIndex = 1;
            lblBaseDatos.Text = "Base de Datos";
            lblBaseDatos.TextAlign = ContentAlignment.TopCenter;
            // 
            // iconImportar
            // 
            iconImportar.Anchor = AnchorStyles.None;
            iconImportar.BackColor = Color.FromArgb(113, 58, 190);
            iconImportar.FlatAppearance.BorderSize = 0;
            iconImportar.FlatStyle = FlatStyle.Flat;
            iconImportar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconImportar.ForeColor = Color.Gainsboro;
            iconImportar.IconChar = FontAwesome.Sharp.IconChar.CloudDownload;
            iconImportar.IconColor = Color.Gainsboro;
            iconImportar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconImportar.IconSize = 25;
            iconImportar.ImageAlign = ContentAlignment.MiddleLeft;
            iconImportar.Location = new Point(300, 264);
            iconImportar.Name = "iconImportar";
            iconImportar.Size = new Size(210, 35);
            iconImportar.TabIndex = 56;
            iconImportar.Text = "Importar Base De Datos";
            iconImportar.TextAlign = ContentAlignment.MiddleRight;
            iconImportar.UseVisualStyleBackColor = false;
            // 
            // lbErrorModificar
            // 
            lbErrorModificar.Anchor = AnchorStyles.None;
            lbErrorModificar.AutoSize = true;
            lbErrorModificar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorModificar.ForeColor = Color.Brown;
            lbErrorModificar.Image = (Image)resources.GetObject("lbErrorModificar.Image");
            lbErrorModificar.ImageAlign = ContentAlignment.MiddleLeft;
            lbErrorModificar.Location = new Point(187, 306);
            lbErrorModificar.Name = "lbErrorModificar";
            lbErrorModificar.Size = new Size(40, 22);
            lbErrorModificar.TabIndex = 55;
            lbErrorModificar.Text = "Error";
            lbErrorModificar.TextAlign = ContentAlignment.MiddleCenter;
            lbErrorModificar.UseCompatibleTextRendering = true;
            lbErrorModificar.Visible = false;
            // 
            // lbNameDataBase
            // 
            lbNameDataBase.Anchor = AnchorStyles.None;
            lbNameDataBase.AutoSize = true;
            lbNameDataBase.BackColor = Color.FromArgb(221, 230, 237);
            lbNameDataBase.FlatStyle = FlatStyle.Flat;
            lbNameDataBase.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNameDataBase.ForeColor = Color.FromArgb(18, 72, 107);
            lbNameDataBase.Location = new Point(338, 83);
            lbNameDataBase.Name = "lbNameDataBase";
            lbNameDataBase.Size = new Size(175, 25);
            lbNameDataBase.TabIndex = 54;
            lbNameDataBase.Text = "bd_virtualBiblio";
            // 
            // iconBackup
            // 
            iconBackup.Anchor = AnchorStyles.None;
            iconBackup.BackColor = Color.FromArgb(65, 145, 151);
            iconBackup.FlatAppearance.BorderSize = 0;
            iconBackup.FlatStyle = FlatStyle.Flat;
            iconBackup.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconBackup.ForeColor = Color.Gainsboro;
            iconBackup.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            iconBackup.IconColor = Color.Gainsboro;
            iconBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBackup.IconSize = 20;
            iconBackup.ImageAlign = ContentAlignment.MiddleLeft;
            iconBackup.Location = new Point(434, 213);
            iconBackup.Name = "iconBackup";
            iconBackup.Size = new Size(158, 35);
            iconBackup.TabIndex = 53;
            iconBackup.Text = "      Realizar BackUp";
            iconBackup.UseVisualStyleBackColor = false;
            // 
            // iconSeleccionar
            // 
            iconSeleccionar.Anchor = AnchorStyles.None;
            iconSeleccionar.BackColor = Color.FromArgb(18, 72, 107);
            iconSeleccionar.FlatAppearance.BorderSize = 0;
            iconSeleccionar.FlatStyle = FlatStyle.Flat;
            iconSeleccionar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconSeleccionar.ForeColor = Color.Gainsboro;
            iconSeleccionar.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            iconSeleccionar.IconColor = Color.Gainsboro;
            iconSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSeleccionar.IconSize = 20;
            iconSeleccionar.ImageAlign = ContentAlignment.MiddleLeft;
            iconSeleccionar.Location = new Point(237, 213);
            iconSeleccionar.Name = "iconSeleccionar";
            iconSeleccionar.Size = new Size(158, 35);
            iconSeleccionar.TabIndex = 52;
            iconSeleccionar.Text = "Seccione Carpeta";
            iconSeleccionar.TextAlign = ContentAlignment.MiddleRight;
            iconSeleccionar.UseVisualStyleBackColor = false;
            // 
            // textBoxRuta
            // 
            textBoxRuta.Anchor = AnchorStyles.None;
            textBoxRuta.Enabled = false;
            textBoxRuta.Location = new Point(280, 161);
            textBoxRuta.Name = "textBoxRuta";
            textBoxRuta.ReadOnly = true;
            textBoxRuta.Size = new Size(271, 23);
            textBoxRuta.TabIndex = 51;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(307, 134);
            label2.Name = "label2";
            label2.Size = new Size(210, 24);
            label2.TabIndex = 50;
            label2.Text = "Ubicacion de Guardado";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(300, 45);
            label1.Name = "label1";
            label1.Size = new Size(251, 24);
            label1.TabIndex = 49;
            label1.Text = "Nombre de la Base de Datos";
            // 
            // BaseDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "BaseDatos";
            Text = "BaseDatos";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblBaseDatos;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconImportar;
        private Label lbErrorModificar;
        private Label lbNameDataBase;
        private FontAwesome.Sharp.IconButton iconBackup;
        private FontAwesome.Sharp.IconButton iconSeleccionar;
        private TextBox textBoxRuta;
        private Label label2;
        private Label label1;
    }
}