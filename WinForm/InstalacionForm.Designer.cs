namespace WinForm
{
    partial class InstalacionForm
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
            lblTituloInstalacion = new Label();
            lblDescripcion = new Label();
            lblCupo = new Label();
            txtTitulo = new TextBox();
            txtDesc = new TextBox();
            txtCupo = new TextBox();
            btnGuardar = new Button();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            pnlMenu = new Panel();
            panel1 = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            lblTitulo = new Label();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTituloInstalacion
            // 
            lblTituloInstalacion.AutoSize = true;
            lblTituloInstalacion.Location = new Point(56, 140);
            lblTituloInstalacion.Name = "lblTituloInstalacion";
            lblTituloInstalacion.Size = new Size(46, 15);
            lblTituloInstalacion.TabIndex = 0;
            lblTituloInstalacion.Text = "Titulo : ";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(27, 198);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion :";
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(358, 137);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(42, 15);
            lblCupo.TabIndex = 2;
            lblCupo.Text = "Cupo :";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(108, 137);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(181, 23);
            txtTitulo.TabIndex = 4;
            txtTitulo.Tag = "Titulo";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(108, 198);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(181, 67);
            txtDesc.TabIndex = 5;
            txtDesc.Tag = "Descripcion";
            // 
            // txtCupo
            // 
            txtCupo.Location = new Point(406, 134);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(68, 23);
            txtCupo.TabIndex = 6;
            txtCupo.KeyPress += txtCupo_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(381, 299);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 43);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(358, 223);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(406, 220);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(68, 23);
            txtPrecio.TabIndex = 9;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MediumPurple;
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(picboxLogo);
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(547, 89);
            pnlMenu.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(405, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 89);
            panel1.TabIndex = 9;
            // 
            // bntMenuPrincipal
            // 
            bntMenuPrincipal.Location = new Point(0, 34);
            bntMenuPrincipal.Name = "bntMenuPrincipal";
            bntMenuPrincipal.Size = new Size(75, 23);
            bntMenuPrincipal.TabIndex = 8;
            bntMenuPrincipal.Text = "Volver";
            bntMenuPrincipal.UseVisualStyleBackColor = true;
            bntMenuPrincipal.Click += bntMenuPrincipal_Click;
            // 
            // picboxLogo
            // 
            picboxLogo.Image = Properties.Resources.sacachispas;
            picboxLogo.Location = new Point(3, 3);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(69, 79);
            picboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxLogo.TabIndex = 7;
            picboxLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(106, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(75, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // InstalacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 369);
            Controls.Add(pnlMenu);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(btnGuardar);
            Controls.Add(txtCupo);
            Controls.Add(txtDesc);
            Controls.Add(txtTitulo);
            Controls.Add(lblCupo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTituloInstalacion);
            Name = "InstalacionForm";
            Text = "Instalacion Form";
           
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInstalacion;
        private Label lblDescripcion;
        private Label lblCupo;
        private TextBox txtTitulo;
        private TextBox txtDesc;
        private TextBox txtCupo;
        private Button btnGuardar;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Panel pnlMenu;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}