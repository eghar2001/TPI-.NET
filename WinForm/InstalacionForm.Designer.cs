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
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            txtDesc = new TextBox();
            txtCupo = new TextBox();
            btnGuardar = new Button();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // lblTituloInstalacion
            // 
            lblTituloInstalacion.AutoSize = true;
            lblTituloInstalacion.Location = new Point(56, 106);
            lblTituloInstalacion.Name = "lblTituloInstalacion";
            lblTituloInstalacion.Size = new Size(46, 15);
            lblTituloInstalacion.TabIndex = 0;
            lblTituloInstalacion.Text = "Titulo : ";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(27, 164);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion :";
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(358, 103);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(42, 15);
            lblCupo.TabIndex = 2;
            lblCupo.Text = "Cupo :";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(141, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 22);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Agregar Instalacion";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(108, 103);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(181, 23);
            txtTitulo.TabIndex = 4;
            txtTitulo.Tag = "Titulo";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(108, 164);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(181, 67);
            txtDesc.TabIndex = 5;
            txtDesc.Tag = "Descripcion";
            // 
            // txtCupo
            // 
            txtCupo.Location = new Point(406, 100);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(68, 23);
            txtCupo.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(381, 265);
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
            lblPrecio.Location = new Point(358, 189);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(406, 186);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(68, 23);
            txtPrecio.TabIndex = 9;
            // 
            // InstalacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 356);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(btnGuardar);
            Controls.Add(txtCupo);
            Controls.Add(txtDesc);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblCupo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTituloInstalacion);
            Name = "InstalacionForm";
            Text = "AgregarInstalacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInstalacion;
        private Label lblDescripcion;
        private Label lblCupo;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private TextBox txtDesc;
        private TextBox txtCupo;
        private Button btnGuardar;
        private Label lblPrecio;
        private TextBox txtPrecio;
    }
}