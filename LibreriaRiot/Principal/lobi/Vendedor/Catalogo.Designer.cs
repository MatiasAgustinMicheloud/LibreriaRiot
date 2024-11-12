namespace LibreriaRiot.Principal.lobi.Vendedor
{
    partial class Catalogo
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
            panel1 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel = new FlowLayoutPanel();
            lbContador = new Label();
            btnVerCarrito = new FontAwesome.Sharp.IconButton();
            cBBuscadorGenero = new ComboBox();
            label6 = new Label();
            label10 = new Label();
            txtBuscadorNombre = new TextBox();
            panel2 = new Panel();
            lblCatalogo = new Label();
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
            panel1.Size = new Size(803, 510);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(flowLayoutPanel);
            panel3.Controls.Add(lbContador);
            panel3.Controls.Add(btnVerCarrito);
            panel3.Controls.Add(cBBuscadorGenero);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(txtBuscadorNombre);
            panel3.Location = new Point(0, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(803, 437);
            panel3.TabIndex = 1;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BackColor = SystemColors.ControlDarkDark;
            flowLayoutPanel.Location = new Point(12, 66);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(777, 358);
            flowLayoutPanel.TabIndex = 77;
            // 
            // lbContador
            // 
            lbContador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbContador.AutoSize = true;
            lbContador.BackColor = SystemColors.ControlDarkDark;
            lbContador.FlatStyle = FlatStyle.Flat;
            lbContador.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbContador.ForeColor = Color.White;
            lbContador.Location = new Point(649, 23);
            lbContador.Margin = new Padding(0);
            lbContador.Name = "lbContador";
            lbContador.Size = new Size(21, 24);
            lbContador.TabIndex = 76;
            lbContador.Text = "0";
            lbContador.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnVerCarrito
            // 
            btnVerCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerCarrito.BackColor = SystemColors.ControlDarkDark;
            btnVerCarrito.FlatAppearance.BorderColor = SystemColors.ControlDark;
            btnVerCarrito.FlatAppearance.BorderSize = 2;
            btnVerCarrito.FlatStyle = FlatStyle.Flat;
            btnVerCarrito.ForeColor = SystemColors.Window;
            btnVerCarrito.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btnVerCarrito.IconColor = Color.White;
            btnVerCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnVerCarrito.IconSize = 40;
            btnVerCarrito.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerCarrito.Location = new Point(673, 13);
            btnVerCarrito.Name = "btnVerCarrito";
            btnVerCarrito.Size = new Size(116, 41);
            btnVerCarrito.TabIndex = 49;
            btnVerCarrito.Text = "Ver Carrito";
            btnVerCarrito.TextAlign = ContentAlignment.MiddleRight;
            btnVerCarrito.UseVisualStyleBackColor = false;
            btnVerCarrito.Click += btnVerCarrito_Click;
            // 
            // cBBuscadorGenero
            // 
            cBBuscadorGenero.FormattingEnabled = true;
            cBBuscadorGenero.Items.AddRange(new object[] { "Administrador", "Gerente", "Vendedor" });
            cBBuscadorGenero.Location = new Point(263, 23);
            cBBuscadorGenero.Name = "cBBuscadorGenero";
            cBBuscadorGenero.Size = new Size(125, 23);
            cBBuscadorGenero.TabIndex = 45;
            cBBuscadorGenero.SelectedIndexChanged += cBBuscadorPerfil_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(195, 25);
            label6.Name = "label6";
            label6.Size = new Size(62, 16);
            label6.TabIndex = 44;
            label6.Text = "Genero:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(15, 25);
            label10.Name = "label10";
            label10.Size = new Size(50, 16);
            label10.TabIndex = 41;
            label10.Text = "Titulo:";
            // 
            // txtBuscadorNombre
            // 
            txtBuscadorNombre.Location = new Point(71, 23);
            txtBuscadorNombre.Name = "txtBuscadorNombre";
            txtBuscadorNombre.Size = new Size(114, 23);
            txtBuscadorNombre.TabIndex = 40;
            txtBuscadorNombre.TextChanged += txtBuscadorNombre_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(lblCatalogo);
            panel2.Location = new Point(12, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(777, 70);
            panel2.TabIndex = 0;
            // 
            // lblCatalogo
            // 
            lblCatalogo.Anchor = AnchorStyles.Top;
            lblCatalogo.AutoSize = true;
            lblCatalogo.Font = new Font("Sitka Banner", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lblCatalogo.ForeColor = Color.FromArgb(241, 241, 241);
            lblCatalogo.Location = new Point(321, 12);
            lblCatalogo.Name = "lblCatalogo";
            lblCatalogo.Size = new Size(111, 39);
            lblCatalogo.TabIndex = 1;
            lblCatalogo.Text = "Catalogo";
            lblCatalogo.TextAlign = ContentAlignment.TopCenter;
            // 
            // Catalogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(panel1);
            Name = "Catalogo";
            Text = "Catalogo";
            Load += Catalogo_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private ComboBox cBBuscadorGenero;
        private Label label6;
        private Label label10;
        private TextBox txtBuscadorNombre;
        private Panel panel2;
        private Label lblCatalogo;
        private FontAwesome.Sharp.IconButton btnVerCarrito;
        private Label lbContador;
        private FlowLayoutPanel flowLayoutPanel;
    }
}