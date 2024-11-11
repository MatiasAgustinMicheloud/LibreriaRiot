namespace LibreriaRiot.Principal.lobi.Administrador
{
    partial class AgregarAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarAutor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            btnModificar = new FontAwesome.Sharp.IconButton();
            lblErrorModificar = new Label();
            txtModificarAutor = new TextBox();
            label2 = new Label();
            lblModificarAutor = new Label();
            dataGridAutores = new DataGridView();
            lblAgregarNuevoAutor = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            lblErrorAgregar = new Label();
            txtAutor = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            btnAtras = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblAutores = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAutores).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(lblErrorModificar);
            panel2.Controls.Add(txtModificarAutor);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblModificarAutor);
            panel2.Controls.Add(dataGridAutores);
            panel2.Controls.Add(lblAgregarNuevoAutor);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(lblErrorAgregar);
            panel2.Controls.Add(txtAutor);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-3, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 381);
            panel2.TabIndex = 5;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.BackColor = SystemColors.ControlDarkDark;
            btnModificar.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = SystemColors.Window;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnModificar.IconColor = Color.White;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.IconSize = 40;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(475, 285);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 38);
            btnModificar.TabIndex = 48;
            btnModificar.Text = "Editar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblErrorModificar
            // 
            lblErrorModificar.Anchor = AnchorStyles.Bottom;
            lblErrorModificar.AutoSize = true;
            lblErrorModificar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorModificar.ForeColor = Color.FromArgb(235, 133, 154);
            lblErrorModificar.Image = (Image)resources.GetObject("lblErrorModificar.Image");
            lblErrorModificar.ImageAlign = ContentAlignment.TopLeft;
            lblErrorModificar.Location = new Point(569, 293);
            lblErrorModificar.Name = "lblErrorModificar";
            lblErrorModificar.Size = new Size(128, 20);
            lblErrorModificar.TabIndex = 47;
            lblErrorModificar.Text = "Mensaje de error";
            lblErrorModificar.Visible = false;
            // 
            // txtModificarAutor
            // 
            txtModificarAutor.Anchor = AnchorStyles.Bottom;
            txtModificarAutor.Location = new Point(475, 253);
            txtModificarAutor.Name = "txtModificarAutor";
            txtModificarAutor.Size = new Size(183, 23);
            txtModificarAutor.TabIndex = 46;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 241, 241);
            label2.Location = new Point(394, 253);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 45;
            label2.Text = "Nombre";
            // 
            // lblModificarAutor
            // 
            lblModificarAutor.Anchor = AnchorStyles.Bottom;
            lblModificarAutor.AutoSize = true;
            lblModificarAutor.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblModificarAutor.ForeColor = Color.FromArgb(241, 241, 241);
            lblModificarAutor.Location = new Point(461, 211);
            lblModificarAutor.Name = "lblModificarAutor";
            lblModificarAutor.Size = new Size(150, 30);
            lblModificarAutor.TabIndex = 35;
            lblModificarAutor.Text = "Modificar Autor";
            lblModificarAutor.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridAutores
            // 
            dataGridAutores.AllowUserToAddRows = false;
            dataGridAutores.AllowUserToDeleteRows = false;
            dataGridAutores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridAutores.BackgroundColor = Color.FromArgb(64, 0, 64);
            dataGridAutores.BorderStyle = BorderStyle.None;
            dataGridAutores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridAutores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Purple;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 0, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridAutores.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridAutores.GridColor = Color.Gray;
            dataGridAutores.Location = new Point(394, 34);
            dataGridAutores.MultiSelect = false;
            dataGridAutores.Name = "dataGridAutores";
            dataGridAutores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridAutores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridAutores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridAutores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridAutores.RowTemplate.Height = 25;
            dataGridAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAutores.Size = new Size(303, 174);
            dataGridAutores.TabIndex = 34;
            dataGridAutores.CellContentClick += dataGridAutores_CellContentClick;
            // 
            // lblAgregarNuevoAutor
            // 
            lblAgregarNuevoAutor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblAgregarNuevoAutor.AutoSize = true;
            lblAgregarNuevoAutor.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarNuevoAutor.ForeColor = Color.FromArgb(241, 241, 241);
            lblAgregarNuevoAutor.Location = new Point(96, 73);
            lblAgregarNuevoAutor.Name = "lblAgregarNuevoAutor";
            lblAgregarNuevoAutor.Size = new Size(195, 30);
            lblAgregarNuevoAutor.TabIndex = 25;
            lblAgregarNuevoAutor.Text = "Agregar Nuevo Autor";
            lblAgregarNuevoAutor.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top;
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
            btnGuardar.Location = new Point(147, 217);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 40);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblErrorAgregar
            // 
            lblErrorAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblErrorAgregar.AutoSize = true;
            lblErrorAgregar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorAgregar.ForeColor = Color.FromArgb(235, 133, 154);
            lblErrorAgregar.Image = (Image)resources.GetObject("lblErrorAgregar.Image");
            lblErrorAgregar.ImageAlign = ContentAlignment.TopLeft;
            lblErrorAgregar.Location = new Point(147, 169);
            lblErrorAgregar.Name = "lblErrorAgregar";
            lblErrorAgregar.Size = new Size(128, 20);
            lblErrorAgregar.TabIndex = 23;
            lblErrorAgregar.Text = "Mensaje de error";
            lblErrorAgregar.TextAlign = ContentAlignment.TopCenter;
            lblErrorAgregar.Visible = false;
            // 
            // txtAutor
            // 
            txtAutor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtAutor.Location = new Point(147, 143);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(183, 23);
            txtAutor.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(66, 143);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btnAtras);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblAutores);
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 70);
            panel1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox4.Location = new Point(796, 0);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 71);
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Transparent;
            btnAtras.FlatAppearance.BorderColor = Color.FromArgb(64, 0, 64);
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            btnAtras.IconColor = Color.White;
            btnAtras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAtras.IconSize = 40;
            btnAtras.Location = new Point(16, 16);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(43, 48);
            btnAtras.TabIndex = 23;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox2.Location = new Point(1399, 0);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 71);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox1.Location = new Point(1999, -1);
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
            // lblAutores
            // 
            lblAutores.Anchor = AnchorStyles.Top;
            lblAutores.AutoSize = true;
            lblAutores.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblAutores.ForeColor = Color.FromArgb(241, 241, 241);
            lblAutores.Location = new Point(345, 16);
            lblAutores.Name = "lblAutores";
            lblAutores.Size = new Size(102, 39);
            lblAutores.TabIndex = 0;
            lblAutores.Text = "Autores";
            lblAutores.TextAlign = ContentAlignment.TopCenter;
            // 
            // AgregarAutor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarAutor";
            Text = "AgregarAutor";
            Load += AgregarAutor_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAutores).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtModificarAutor;
        private Label label2;
        //private FontAwesome.Sharp.IconButton btnModificar;
        //private Label lblErrorModificar;
        private Label lblModificarAutor;
        private DataGridView dataGridAutores;
        private Label lblAgregarNuevoAutor;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblErrorAgregar;
        private TextBox txtAutor;
        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAtras;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label lblAutores;
        private PictureBox pictureBox4;
        private FontAwesome.Sharp.IconButton btnModificar;
        private Label lblErrorModificar;
    }
}