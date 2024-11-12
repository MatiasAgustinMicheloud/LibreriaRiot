namespace LibreriaRiot.Principal.lobi.Administrador
{
    partial class HistorialVentas
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialVentas));
            panel3 = new Panel();
            label12 = new Label();
            label13 = new Label();
            dateTimePickerHasta = new DateTimePicker();
            dateTimePickerDesde = new DateTimePicker();
            label11 = new Label();
            txtBuscadorNombre = new TextBox();
            label10 = new Label();
            txtBuscadorApellido = new TextBox();
            dataGridVentas = new DataGridView();
            panel2 = new Panel();
            lbBaja = new Label();
            checkBoxNo = new CheckBox();
            checkBoxSi = new CheckBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            lbErrorMenssage = new Label();
            label9 = new Label();
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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblHistorialVentas = new Label();
            txBuscadorDni = new TextBox();
            label14 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortada).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(64, 0, 64);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txBuscadorDni);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(dateTimePickerHasta);
            panel3.Controls.Add(dateTimePickerDesde);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtBuscadorNombre);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtBuscadorApellido);
            panel3.Controls.Add(dataGridVentas);
            panel3.Location = new Point(0, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(924, 517);
            panel3.TabIndex = 24;
            panel3.Paint += panel3_Paint;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.FlatStyle = FlatStyle.Flat;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(752, 19);
            label12.Name = "label12";
            label12.Size = new Size(48, 16);
            label12.TabIndex = 59;
            label12.Text = "Hasta";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(574, 20);
            label13.Name = "label13";
            label13.Size = new Size(53, 16);
            label13.TabIndex = 56;
            label13.Text = "Desde";
            // 
            // dateTimePickerHasta
            // 
            dateTimePickerHasta.Anchor = AnchorStyles.Top;
            dateTimePickerHasta.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerHasta.CalendarForeColor = Color.IndianRed;
            dateTimePickerHasta.CalendarMonthBackground = SystemColors.MenuHighlight;
            dateTimePickerHasta.CalendarTitleBackColor = Color.DarkSlateGray;
            dateTimePickerHasta.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dateTimePickerHasta.CalendarTrailingForeColor = Color.CadetBlue;
            dateTimePickerHasta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerHasta.Location = new Point(802, 17);
            dateTimePickerHasta.Name = "dateTimePickerHasta";
            dateTimePickerHasta.Size = new Size(109, 21);
            dateTimePickerHasta.TabIndex = 58;
            dateTimePickerHasta.ValueChanged += dateTimePickerHasta_ValueChanged;
            // 
            // dateTimePickerDesde
            // 
            dateTimePickerDesde.Anchor = AnchorStyles.Top;
            dateTimePickerDesde.CalendarFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDesde.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDesde.Location = new Point(633, 18);
            dateTimePickerDesde.Name = "dateTimePickerDesde";
            dateTimePickerDesde.Size = new Size(109, 21);
            dateTimePickerDesde.TabIndex = 57;
            dateTimePickerDesde.ValueChanged += dateTimePickerDesde_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Window;
            label11.Location = new Point(203, 19);
            label11.Name = "label11";
            label11.Size = new Size(66, 16);
            label11.TabIndex = 26;
            label11.Text = "Nombre:";
            // 
            // txtBuscadorNombre
            // 
            txtBuscadorNombre.Location = new Point(275, 16);
            txtBuscadorNombre.Name = "txtBuscadorNombre";
            txtBuscadorNombre.Size = new Size(114, 23);
            txtBuscadorNombre.TabIndex = 25;
            txtBuscadorNombre.TextChanged += txtBuscadorAutor_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(6, 19);
            label10.Name = "label10";
            label10.Size = new Size(69, 16);
            label10.TabIndex = 24;
            label10.Text = "Apellido:";
            // 
            // txtBuscadorApellido
            // 
            txtBuscadorApellido.Location = new Point(81, 17);
            txtBuscadorApellido.Name = "txtBuscadorApellido";
            txtBuscadorApellido.Size = new Size(116, 23);
            txtBuscadorApellido.TabIndex = 23;
            txtBuscadorApellido.TextChanged += txtBuscadorTitulo_TextChanged;
            // 
            // dataGridVentas
            // 
            dataGridVentas.AllowUserToAddRows = false;
            dataGridVentas.AllowUserToDeleteRows = false;
            dataGridVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridVentas.BackgroundColor = Color.FromArgb(64, 0, 64);
            dataGridVentas.BorderStyle = BorderStyle.None;
            dataGridVentas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Purple;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(64, 0, 64);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridVentas.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridVentas.GridColor = Color.Gray;
            dataGridVentas.Location = new Point(12, 45);
            dataGridVentas.MultiSelect = false;
            dataGridVentas.Name = "dataGridVentas";
            dataGridVentas.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.Purple;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridVentas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridVentas.RowTemplate.Height = 25;
            dataGridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridVentas.Size = new Size(897, 460);
            dataGridVentas.TabIndex = 22;
            dataGridVentas.CellContentClick += dataGridVentas_CellContentClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(lbBaja);
            panel2.Controls.Add(checkBoxNo);
            panel2.Controls.Add(checkBoxSi);
            panel2.Controls.Add(btnLimpiar);
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
            panel2.Location = new Point(548, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 23;
            // 
            // lbBaja
            // 
            lbBaja.AutoSize = true;
            lbBaja.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbBaja.ForeColor = SystemColors.Window;
            lbBaja.Location = new Point(279, 343);
            lbBaja.Name = "lbBaja";
            lbBaja.Size = new Size(39, 16);
            lbBaja.TabIndex = 27;
            lbBaja.Text = "Baja";
            // 
            // checkBoxNo
            // 
            checkBoxNo.AutoSize = true;
            checkBoxNo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxNo.ForeColor = SystemColors.Window;
            checkBoxNo.Location = new Point(306, 369);
            checkBoxNo.Name = "checkBoxNo";
            checkBoxNo.Size = new Size(43, 20);
            checkBoxNo.TabIndex = 26;
            checkBoxNo.Text = "no";
            checkBoxNo.UseVisualStyleBackColor = true;
            // 
            // checkBoxSi
            // 
            checkBoxSi.AutoSize = true;
            checkBoxSi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxSi.ForeColor = SystemColors.Window;
            checkBoxSi.Location = new Point(256, 369);
            checkBoxSi.Name = "checkBoxSi";
            checkBoxSi.Size = new Size(38, 20);
            checkBoxSi.TabIndex = 25;
            checkBoxSi.Text = "si";
            checkBoxSi.UseVisualStyleBackColor = true;
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
            btnLimpiar.Location = new Point(231, 442);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(87, 38);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lbErrorMenssage
            // 
            lbErrorMenssage.AutoSize = true;
            lbErrorMenssage.ForeColor = Color.Brown;
            lbErrorMenssage.Image = (Image)resources.GetObject("lbErrorMenssage.Image");
            lbErrorMenssage.ImageAlign = ContentAlignment.TopLeft;
            lbErrorMenssage.Location = new Point(177, 424);
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
            label9.Location = new Point(106, 13);
            label9.Name = "label9";
            label9.Size = new Size(188, 39);
            label9.TabIndex = 19;
            label9.Text = "Modificar Libro";
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
            btnGuardar.IconSize = 40;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(124, 442);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 38);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Editar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Items.AddRange(new object[] { "Romance", "Drama", "Terror", "Fantasia" });
            cbCategoria.Location = new Point(117, 238);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(232, 23);
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
            // txtEditorial
            // 
            txtEditorial.Location = new Point(117, 89);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(232, 23);
            txtEditorial.TabIndex = 10;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblHistorialVentas);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 70);
            panel1.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox2.Location = new Point(911, -1);
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
            pictureBox1.Location = new Point(1251, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 71);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(64, 0, 64);
            pictureBox3.Location = new Point(0, -1);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 71);
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // lblHistorialVentas
            // 
            lblHistorialVentas.Anchor = AnchorStyles.None;
            lblHistorialVentas.AutoSize = true;
            lblHistorialVentas.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorialVentas.ForeColor = Color.FromArgb(241, 241, 241);
            lblHistorialVentas.Location = new Point(345, 13);
            lblHistorialVentas.Name = "lblHistorialVentas";
            lblHistorialVentas.Size = new Size(228, 39);
            lblHistorialVentas.TabIndex = 0;
            lblHistorialVentas.Text = "Historial De Ventas";
            // 
            // txBuscadorDni
            // 
            txBuscadorDni.Location = new Point(454, 16);
            txBuscadorDni.Name = "txBuscadorDni";
            txBuscadorDni.Size = new Size(114, 23);
            txBuscadorDni.TabIndex = 60;
            txBuscadorDni.TextChanged += txBuscadorDni_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Window;
            label14.Location = new Point(411, 20);
            label14.Name = "label14";
            label14.Size = new Size(37, 16);
            label14.TabIndex = 61;
            label14.Text = "DNI:";
            // 
            // HistorialVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 582);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HistorialVentas";
            Text = "HistorialVentas";
            Load += HistorialVentas_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVentas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPortada).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label11;
        private TextBox txtBuscadorNombre;
        private Label label10;
        private TextBox txtBuscadorApellido;
        private DataGridView dataGridVentas;
        private Panel panel2;
        private Label lbBaja;
        private CheckBox checkBoxNo;
        private CheckBox checkBoxSi;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private Label lbErrorMenssage;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private ComboBox cbCategoria;
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
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label lblHistorialVentas;
        private PictureBox pictureBox2;
        private Label label12;
        private Label label13;
        private DateTimePicker dateTimePickerHasta;
        private DateTimePicker dateTimePickerDesde;
        private Label label14;
        private TextBox txBuscadorDni;
    }
}