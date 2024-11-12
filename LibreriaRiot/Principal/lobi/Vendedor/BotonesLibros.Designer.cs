namespace LibreriaRiot.Principal.lobi.Vendedor
{
    partial class BotonesLibros
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btAñadir = new FontAwesome.Sharp.IconButton();
            rtbDescripcionCatalogo = new RichTextBox();
            panel3 = new Panel();
            lbStockCatalogo = new Label();
            lbPrecioCatalogo = new Label();
            panel2 = new Panel();
            lbTituloCatalog = new Label();
            lbTituloCatalogo = new Label();
            pbImagenCatalogo = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagenCatalogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(btAñadir);
            panel1.Controls.Add(rtbDescripcionCatalogo);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pbImagenCatalogo);
            panel1.Location = new Point(-14, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 438);
            panel1.TabIndex = 0;
            // 
            // btAñadir
            // 
            btAñadir.BackColor = Color.FromArgb(64, 0, 64);
            btAñadir.Dock = DockStyle.Bottom;
            btAñadir.FlatStyle = FlatStyle.Flat;
            btAñadir.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btAñadir.IconColor = Color.White;
            btAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btAñadir.Location = new Point(0, 392);
            btAñadir.Name = "btAñadir";
            btAñadir.Size = new Size(250, 46);
            btAñadir.TabIndex = 4;
            btAñadir.UseVisualStyleBackColor = false;
            // 
            // rtbDescripcionCatalogo
            // 
            rtbDescripcionCatalogo.Anchor = AnchorStyles.None;
            rtbDescripcionCatalogo.BackColor = Color.Purple;
            rtbDescripcionCatalogo.BorderStyle = BorderStyle.None;
            rtbDescripcionCatalogo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDescripcionCatalogo.ForeColor = SystemColors.Window;
            rtbDescripcionCatalogo.Location = new Point(15, 297);
            rtbDescripcionCatalogo.Name = "rtbDescripcionCatalogo";
            rtbDescripcionCatalogo.ReadOnly = true;
            rtbDescripcionCatalogo.Size = new Size(220, 98);
            rtbDescripcionCatalogo.TabIndex = 3;
            rtbDescripcionCatalogo.Text = "";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(64, 0, 64);
            panel3.Controls.Add(lbStockCatalogo);
            panel3.Controls.Add(lbPrecioCatalogo);
            panel3.Location = new Point(15, 261);
            panel3.Name = "panel3";
            panel3.Size = new Size(220, 36);
            panel3.TabIndex = 2;
            // 
            // lbStockCatalogo
            // 
            lbStockCatalogo.Anchor = AnchorStyles.Right;
            lbStockCatalogo.AutoSize = true;
            lbStockCatalogo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbStockCatalogo.ForeColor = SystemColors.ControlLightLight;
            lbStockCatalogo.Location = new Point(139, 16);
            lbStockCatalogo.Name = "lbStockCatalogo";
            lbStockCatalogo.Size = new Size(41, 16);
            lbStockCatalogo.TabIndex = 4;
            lbStockCatalogo.Text = "Stock";
            // 
            // lbPrecioCatalogo
            // 
            lbPrecioCatalogo.Anchor = AnchorStyles.None;
            lbPrecioCatalogo.AutoSize = true;
            lbPrecioCatalogo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbPrecioCatalogo.ForeColor = SystemColors.ControlLightLight;
            lbPrecioCatalogo.Location = new Point(3, 16);
            lbPrecioCatalogo.Name = "lbPrecioCatalogo";
            lbPrecioCatalogo.Size = new Size(53, 16);
            lbPrecioCatalogo.TabIndex = 3;
            lbPrecioCatalogo.Text = "$Precio";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(64, 0, 64);
            panel2.Controls.Add(lbTituloCatalog);
            panel2.Controls.Add(lbTituloCatalogo);
            panel2.Location = new Point(15, 216);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 39);
            panel2.TabIndex = 1;
            // 
            // lbTituloCatalog
            // 
            lbTituloCatalog.Anchor = AnchorStyles.None;
            lbTituloCatalog.AutoSize = true;
            lbTituloCatalog.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloCatalog.ForeColor = SystemColors.ControlLightLight;
            lbTituloCatalog.Location = new Point(3, 16);
            lbTituloCatalog.Name = "lbTituloCatalog";
            lbTituloCatalog.Size = new Size(53, 20);
            lbTituloCatalog.TabIndex = 3;
            lbTituloCatalog.Text = "Titulo";
            // 
            // lbTituloCatalogo
            // 
            lbTituloCatalogo.Anchor = AnchorStyles.None;
            lbTituloCatalogo.AutoSize = true;
            lbTituloCatalogo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTituloCatalogo.ForeColor = SystemColors.ControlLightLight;
            lbTituloCatalogo.Location = new Point(-10, -187);
            lbTituloCatalogo.Name = "lbTituloCatalogo";
            lbTituloCatalogo.Size = new Size(53, 20);
            lbTituloCatalogo.TabIndex = 2;
            lbTituloCatalogo.Text = "Titulo";
            // 
            // pbImagenCatalogo
            // 
            pbImagenCatalogo.Anchor = AnchorStyles.None;
            pbImagenCatalogo.BackColor = Color.Purple;
            pbImagenCatalogo.Location = new Point(15, 0);
            pbImagenCatalogo.Name = "pbImagenCatalogo";
            pbImagenCatalogo.Size = new Size(220, 219);
            pbImagenCatalogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenCatalogo.TabIndex = 0;
            pbImagenCatalogo.TabStop = false;
            // 
            // BotonesLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "BotonesLibros";
            Size = new Size(222, 436);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagenCatalogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pbImagenCatalogo;
        private FontAwesome.Sharp.IconButton btAñadir;
        private RichTextBox rtbDescripcionCatalogo;
        private Label lbPrecioCatalogo;
        private Label lbTituloCatalogo;
        private Label lbStockCatalogo;
        private Label lbTituloCatalog;
    }
}
