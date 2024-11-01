namespace LibreriaRiot.Principal.lobi.Vendedor
{
    partial class VerClientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerClientes));
            panel3 = new Panel();
            btnElegir = new FontAwesome.Sharp.IconButton();
            txtBuscadorDNI = new TextBox();
            dataGridCliente = new DataGridView();
            label6 = new Label();
            label11 = new Label();
            txtBuscadorApellido = new TextBox();
            label10 = new Label();
            txtBuscadorNombre = new TextBox();
            panel1 = new Panel();
            btnRegistrarCliente = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblAgregarProducto = new Label();
            panel2 = new Panel();
            label5 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            lbBaja = new Label();
            checkBoxNo = new CheckBox();
            checkBoxSi = new CheckBox();
            label1 = new Label();
            dtFechaNac = new DateTimePicker();
            lbDeNacimiento = new Label();
            txtDomicilio = new TextBox();
            lbErrorMenssage = new Label();
            label9 = new Label();
            txtEmail = new TextBox();
            txtDNI = new TextBox();
            txtTelefono = new TextBox();
            lbEmail = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbNombre = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 0, 64);
            panel3.Controls.Add(btnElegir);
            panel3.Controls.Add(txtBuscadorDNI);
            panel3.Controls.Add(dataGridCliente);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtBuscadorApellido);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtBuscadorNombre);
            panel3.Location = new Point(-1, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(552, 472);
            panel3.TabIndex = 27;
            // 
            // btnElegir
            // 
            btnElegir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnElegir.BackColor = SystemColors.ControlDarkDark;
            btnElegir.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnElegir.FlatAppearance.BorderSize = 2;
            btnElegir.FlatStyle = FlatStyle.Flat;
            btnElegir.ForeColor = SystemColors.Window;
            btnElegir.IconChar = FontAwesome.Sharp.IconChar.User;
            btnElegir.IconColor = Color.White;
            btnElegir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnElegir.IconSize = 40;
            btnElegir.ImageAlign = ContentAlignment.MiddleLeft;
            btnElegir.Location = new Point(13, 431);
            btnElegir.Name = "btnElegir";
            btnElegir.Size = new Size(157, 38);
            btnElegir.TabIndex = 42;
            btnElegir.Text = "Seleccionar Cliente";
            btnElegir.TextAlign = ContentAlignment.MiddleRight;
            btnElegir.UseVisualStyleBackColor = false;
            btnElegir.Click += iconButton3_Click;
            // 
            // txtBuscadorDNI
            // 
            txtBuscadorDNI.Location = new Point(425, 16);
            txtBuscadorDNI.Name = "txtBuscadorDNI";
            txtBuscadorDNI.Size = new Size(114, 23);
            txtBuscadorDNI.TabIndex = 34;
            txtBuscadorDNI.TextChanged += txtBuscadorDNI_TextChanged;
            // 
            // dataGridCliente
            // 
            dataGridCliente.AllowUserToAddRows = false;
            dataGridCliente.AllowUserToDeleteRows = false;
            dataGridCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridCliente.BackgroundColor = Color.FromArgb(64, 0, 64);
            dataGridCliente.BorderStyle = BorderStyle.None;
            dataGridCliente.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Purple;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 0, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridCliente.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridCliente.GridColor = Color.Gray;
            dataGridCliente.Location = new Point(13, 55);
            dataGridCliente.MultiSelect = false;
            dataGridCliente.Name = "dataGridCliente";
            dataGridCliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridCliente.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridCliente.RowTemplate.Height = 25;
            dataGridCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCliente.Size = new Size(543, 373);
            dataGridCliente.TabIndex = 33;
            dataGridCliente.CellContentClick += dataGridUsuarios_CellContentClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(382, 19);
            label6.Name = "label6";
            label6.Size = new Size(37, 16);
            label6.TabIndex = 32;
            label6.Text = "DNI:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(190, 19);
            label11.Name = "label11";
            label11.Size = new Size(69, 16);
            label11.TabIndex = 30;
            label11.Text = "Apellido:";
            // 
            // txtBuscadorApellido
            // 
            txtBuscadorApellido.Location = new Point(262, 16);
            txtBuscadorApellido.Name = "txtBuscadorApellido";
            txtBuscadorApellido.Size = new Size(114, 23);
            txtBuscadorApellido.TabIndex = 29;
            txtBuscadorApellido.TextChanged += txtBuscadorApellido_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(9, 19);
            label10.Name = "label10";
            label10.Size = new Size(66, 16);
            label10.TabIndex = 28;
            label10.Text = "Nombre:";
            // 
            // txtBuscadorNombre
            // 
            txtBuscadorNombre.Location = new Point(74, 17);
            txtBuscadorNombre.Name = "txtBuscadorNombre";
            txtBuscadorNombre.Size = new Size(114, 23);
            txtBuscadorNombre.TabIndex = 27;
            txtBuscadorNombre.TextChanged += txtBuscadorNombre_TextChanged;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(btnRegistrarCliente);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblAgregarProducto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 65);
            panel1.TabIndex = 25;
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegistrarCliente.BackColor = Color.FromArgb(64, 0, 64);
            btnRegistrarCliente.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnRegistrarCliente.FlatAppearance.BorderSize = 2;
            btnRegistrarCliente.FlatStyle = FlatStyle.Flat;
            btnRegistrarCliente.ForeColor = SystemColors.Window;
            btnRegistrarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnRegistrarCliente.IconColor = Color.White;
            btnRegistrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrarCliente.IconSize = 40;
            btnRegistrarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarCliente.Location = new Point(755, 15);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(145, 43);
            btnRegistrarCliente.TabIndex = 75;
            btnRegistrarCliente.Text = "Registrar Cliente";
            btnRegistrarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarCliente.UseVisualStyleBackColor = false;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox2.Location = new Point(908, -1);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 71);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox1.Location = new Point(1706, -1);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 71);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox3.Location = new Point(-1, -1);
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
            lblAgregarProducto.Location = new Point(378, 13);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(223, 39);
            lblAgregarProducto.TabIndex = 0;
            lblAgregarProducto.Text = "Listado de Clientes";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(lbBaja);
            panel2.Controls.Add(checkBoxNo);
            panel2.Controls.Add(checkBoxSi);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtFechaNac);
            panel2.Controls.Add(lbDeNacimiento);
            panel2.Controls.Add(txtDomicilio);
            panel2.Controls.Add(lbErrorMenssage);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtDNI);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(lbEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbNombre);
            panel2.Location = new Point(547, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 476);
            panel2.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(241, 241, 241);
            label5.Location = new Point(46, 180);
            label5.Name = "label5";
            label5.Size = new Size(72, 16);
            label5.TabIndex = 39;
            label5.Text = "Domicilio";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(121, 96);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(232, 23);
            txtApellido.TabIndex = 38;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(121, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 37;
            txtNombre.TextChanged += txtNombre_TextChanged;
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
            btnLimpiar.Location = new Point(227, 395);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(87, 38);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = SystemColors.ControlDarkDark;
            btnEditar.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnEditar.FlatAppearance.BorderSize = 2;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.Window;
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            btnEditar.IconColor = Color.White;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 40;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(121, 395);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(88, 38);
            btnEditar.TabIndex = 32;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += iconButton2_Click;
            // 
            // lbBaja
            // 
            lbBaja.AutoSize = true;
            lbBaja.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbBaja.ForeColor = SystemColors.Window;
            lbBaja.Location = new Point(75, 333);
            lbBaja.Name = "lbBaja";
            lbBaja.Size = new Size(39, 16);
            lbBaja.TabIndex = 31;
            lbBaja.Text = "Baja";
            // 
            // checkBoxNo
            // 
            checkBoxNo.AutoSize = true;
            checkBoxNo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxNo.ForeColor = SystemColors.Window;
            checkBoxNo.Location = new Point(173, 333);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(43, 20);
            checkBoxNo.TabIndex = 30;
            checkBoxNo.Text = "no";
            checkBoxNo.UseVisualStyleBackColor = true;
            checkBoxNo.CheckedChanged += checkBoxNo_CheckedChanged;
            // 
            // checkBoxSi
            // 
            checkBoxSi.AutoSize = true;
            checkBoxSi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxSi.ForeColor = SystemColors.Window;
            checkBoxSi.Location = new Point(121, 332);
            checkBoxSi.Name = "checkBoxSi";
            checkBoxSi.Size = new Size(38, 20);
            checkBoxSi.TabIndex = 29;
            checkBoxSi.Text = "si";
            checkBoxSi.UseVisualStyleBackColor = true;
            checkBoxSi.CheckedChanged += checkBoxSi_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 241, 241);
            label1.Location = new Point(53, 180);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 27;
            // 
            // dtFechaNac
            // 
            dtFechaNac.CustomFormat = "";
            dtFechaNac.Location = new Point(121, 296);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(232, 23);
            dtFechaNac.TabIndex = 26;
            // 
            // lbDeNacimiento
            // 
            lbDeNacimiento.AutoSize = true;
            lbDeNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbDeNacimiento.ForeColor = Color.FromArgb(241, 241, 241);
            lbDeNacimiento.Location = new Point(7, 298);
            lbDeNacimiento.Name = "lbDeNacimiento";
            lbDeNacimiento.Size = new Size(108, 21);
            lbDeNacimiento.TabIndex = 25;
            lbDeNacimiento.Text = "Fecha de nac";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(121, 173);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(232, 23);
            txtDomicilio.TabIndex = 28;
            // 
            // lbErrorMenssage
            // 
            lbErrorMenssage.AutoSize = true;
            lbErrorMenssage.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lbErrorMenssage.ForeColor = Color.FromArgb(235, 133, 154);
            lbErrorMenssage.Image = (Image)resources.GetObject("lbErrorMenssage.Image");
            lbErrorMenssage.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage.Location = new Point(38, 364);
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
            label9.Location = new Point(109, 6);
            label9.Name = "label9";
            label9.Size = new Size(206, 39);
            label9.TabIndex = 19;
            label9.Text = "Modificar Cliente";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(121, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 13;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(121, 135);
            txtDNI.Multiline = true;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(232, 22);
            txtDNI.TabIndex = 12;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(121, 212);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(232, 23);
            txtTelefono.TabIndex = 11;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.ForeColor = Color.FromArgb(241, 241, 241);
            lbEmail.Location = new Point(68, 260);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 16);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(241, 241, 241);
            label4.Location = new Point(82, 141);
            label4.Name = "label4";
            label4.Size = new Size(33, 16);
            label4.TabIndex = 3;
            label4.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(241, 241, 241);
            label3.Location = new Point(46, 219);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 241, 241);
            label2.Location = new Point(50, 103);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbNombre.ForeColor = Color.FromArgb(241, 241, 241);
            lbNombre.Location = new Point(53, 65);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(62, 16);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre";
            // 
            // VerClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 535);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "VerClientes";
            Text = "VerClientes";
            Load += VerClientes_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCliente).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private DataGridView dataGridCliente;
        private Label label6;
        private Label label11;
        private TextBox txtBuscadorApellido;
        private Label label10;
        private TextBox txtBuscadorNombre;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label lblAgregarProducto;
        private Panel panel2;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private Label lbBaja;
        private CheckBox checkBoxNo;
        private CheckBox checkBoxSi;
        private Label label1;
        private DateTimePicker dtFechaNac;
        private Label lbDeNacimiento;
        private TextBox txtDomicilio;
        private Label lbErrorMenssage;
        private Label label9;
        private TextBox txtEmail;
        private TextBox txtDNI;
        private TextBox txtTelefono;
        private Label lbEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbNombre;
        private PictureBox pictureBox2;
        private Label label5;
        private TextBox txtBuscadorDNI;
        private FontAwesome.Sharp.IconButton btnRegistrarCliente;
        private FontAwesome.Sharp.IconButton btnElegir;
    }
}