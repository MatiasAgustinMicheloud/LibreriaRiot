namespace LibreriaRiot.Principal.lobi.Administrador
{
    partial class AgregarEditorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEditorial));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnAtras = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblEditoriales = new Label();
            label1 = new Label();
            txtEditorial = new TextBox();
            lblErrorAgregar = new Label();
            panel2 = new Panel();
            txtModificarEditorial = new TextBox();
            label2 = new Label();
            btnModificar = new FontAwesome.Sharp.IconButton();
            lblErrorModificar = new Label();
            lblModificarEditorial = new Label();
            dataGridEditoriales = new DataGridView();
            lblAgregarNuevaEditorial = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEditoriales).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnAtras);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblEditoriales);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 70);
            panel1.TabIndex = 2;
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
            pictureBox2.Location = new Point(796, 0);
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
            pictureBox1.Location = new Point(1396, -1);
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
            // lblEditoriales
            // 
            lblEditoriales.Anchor = AnchorStyles.Top;
            lblEditoriales.AutoSize = true;
            lblEditoriales.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblEditoriales.ForeColor = Color.FromArgb(241, 241, 241);
            lblEditoriales.Location = new Point(335, 18);
            lblEditoriales.Name = "lblEditoriales";
            lblEditoriales.Size = new Size(135, 39);
            lblEditoriales.TabIndex = 0;
            lblEditoriales.Text = "Editoriales";
            lblEditoriales.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(59, 145);
            label1.Name = "label1";
            label1.Size = new Size(75, 21);
            label1.TabIndex = 0;
            label1.Text = "Editorial";
            // 
            // txtEditorial
            // 
            txtEditorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtEditorial.Location = new Point(140, 145);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(183, 23);
            txtEditorial.TabIndex = 9;
            // 
            // lblErrorAgregar
            // 
            lblErrorAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblErrorAgregar.AutoSize = true;
            lblErrorAgregar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblErrorAgregar.ForeColor = Color.FromArgb(235, 133, 154);
            lblErrorAgregar.Image = (Image)resources.GetObject("lblErrorAgregar.Image");
            lblErrorAgregar.ImageAlign = ContentAlignment.TopLeft;
            lblErrorAgregar.Location = new Point(140, 171);
            lblErrorAgregar.Name = "lblErrorAgregar";
            lblErrorAgregar.Size = new Size(128, 20);
            lblErrorAgregar.TabIndex = 23;
            lblErrorAgregar.Text = "Mensaje de error";
            lblErrorAgregar.TextAlign = ContentAlignment.TopCenter;
            lblErrorAgregar.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(txtModificarEditorial);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(lblErrorModificar);
            panel2.Controls.Add(lblModificarEditorial);
            panel2.Controls.Add(dataGridEditoriales);
            panel2.Controls.Add(lblAgregarNuevaEditorial);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(lblErrorAgregar);
            panel2.Controls.Add(txtEditorial);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-4, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 381);
            panel2.TabIndex = 3;
            // 
            // txtModificarEditorial
            // 
            txtModificarEditorial.Anchor = AnchorStyles.Bottom;
            txtModificarEditorial.Location = new Point(482, 263);
            txtModificarEditorial.Name = "txtModificarEditorial";
            txtModificarEditorial.Size = new Size(183, 23);
            txtModificarEditorial.TabIndex = 46;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 241, 241);
            label2.Location = new Point(401, 263);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 45;
            label2.Text = "Editorial";
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
            btnModificar.Location = new Point(482, 292);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(88, 38);
            btnModificar.TabIndex = 44;
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
            lblErrorModificar.Location = new Point(576, 300);
            lblErrorModificar.Name = "lblErrorModificar";
            lblErrorModificar.Size = new Size(128, 20);
            lblErrorModificar.TabIndex = 40;
            lblErrorModificar.Text = "Mensaje de error";
            lblErrorModificar.Visible = false;
            // 
            // lblModificarEditorial
            // 
            lblModificarEditorial.Anchor = AnchorStyles.Bottom;
            lblModificarEditorial.AutoSize = true;
            lblModificarEditorial.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblModificarEditorial.ForeColor = Color.FromArgb(241, 241, 241);
            lblModificarEditorial.Location = new Point(468, 221);
            lblModificarEditorial.Name = "lblModificarEditorial";
            lblModificarEditorial.Size = new Size(178, 30);
            lblModificarEditorial.TabIndex = 35;
            lblModificarEditorial.Text = "Modificar Editorial";
            lblModificarEditorial.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridEditoriales
            // 
            dataGridEditoriales.AllowUserToAddRows = false;
            dataGridEditoriales.AllowUserToDeleteRows = false;
            dataGridEditoriales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridEditoriales.BackgroundColor = Color.FromArgb(64, 0, 64);
            dataGridEditoriales.BorderStyle = BorderStyle.None;
            dataGridEditoriales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridEditoriales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridEditoriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Purple;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 0, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridEditoriales.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridEditoriales.GridColor = Color.Gray;
            dataGridEditoriales.Location = new Point(397, 25);
            dataGridEditoriales.MultiSelect = false;
            dataGridEditoriales.Name = "dataGridEditoriales";
            dataGridEditoriales.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridEditoriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridEditoriales.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridEditoriales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridEditoriales.RowTemplate.Height = 25;
            dataGridEditoriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEditoriales.Size = new Size(303, 181);
            dataGridEditoriales.TabIndex = 34;
            dataGridEditoriales.CellContentClick += dataGridEditoriales_CellContentClick;
            // 
            // lblAgregarNuevaEditorial
            // 
            lblAgregarNuevaEditorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblAgregarNuevaEditorial.AutoSize = true;
            lblAgregarNuevaEditorial.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregarNuevaEditorial.ForeColor = Color.FromArgb(241, 241, 241);
            lblAgregarNuevaEditorial.Location = new Point(89, 75);
            lblAgregarNuevaEditorial.Name = "lblAgregarNuevaEditorial";
            lblAgregarNuevaEditorial.Size = new Size(223, 30);
            lblAgregarNuevaEditorial.TabIndex = 25;
            lblAgregarNuevaEditorial.Text = "Agregar Nueva Editorial";
            lblAgregarNuevaEditorial.TextAlign = ContentAlignment.TopCenter;
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
            btnGuardar.Location = new Point(140, 219);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 40);
            btnGuardar.TabIndex = 24;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AgregarEditorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarEditorial";
            Text = "AgregarEditorial";
            Load += AgregarEditorial_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEditoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label lblEditoriales;
        private Label label1;
        private TextBox txtEditorial;
        private Label lblErrorAgregar;
        private Panel panel2;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblAgregarNuevaEditorial;
        private Label lblModificarEditorial;
        private TextBox txtModificarEditorial;
        private Label label2;
        private FontAwesome.Sharp.IconButton btnModificar;
        private Label lblErrorModificar;
        private FontAwesome.Sharp.IconButton btnAtras;
        private DataGridView dataGridEditoriales;
    }
}