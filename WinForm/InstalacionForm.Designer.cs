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
            lblErrorTitulo = new Label();
            lblErrorCupo = new Label();
            lblErrorDescripcion = new Label();
            lblErrorPrecio = new Label();
            SuspendLayout();
            // 
            // lblTituloInstalacion
            // 
            lblTituloInstalacion.AutoSize = true;
            lblTituloInstalacion.Location = new Point(37, 117);
            lblTituloInstalacion.Name = "lblTituloInstalacion";
            lblTituloInstalacion.Size = new Size(67, 20);
            lblTituloInstalacion.TabIndex = 0;
            lblTituloInstalacion.Text = "Titulo (*)";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(37, 372);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblCupo
            // 
            lblCupo.AutoSize = true;
            lblCupo.Location = new Point(37, 283);
            lblCupo.Name = "lblCupo";
            lblCupo.Size = new Size(64, 20);
            lblCupo.TabIndex = 2;
            lblCupo.Text = "Cupo (*)";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(19, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(77, 28);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(123, 107);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(286, 27);
            txtTitulo.TabIndex = 4;
            txtTitulo.Tag = "Titulo";
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(128, 368);
            txtDesc.Margin = new Padding(3, 4, 3, 4);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(286, 88);
            txtDesc.TabIndex = 5;
            txtDesc.Tag = "Descripcion";
            txtDesc.TextChanged += txtDesc_TextChanged;
            // 
            // txtCupo
            // 
            txtCupo.Location = new Point(128, 272);
            txtCupo.Margin = new Padding(3, 4, 3, 4);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(205, 27);
            txtCupo.TabIndex = 6;
            txtCupo.TextChanged += txtCupo_TextChanged;
            txtCupo.KeyPress += txtCupo_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(272, 507);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 57);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(38, 196);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(70, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio (*)";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(128, 185);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(205, 27);
            txtPrecio.TabIndex = 9;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblErrorTitulo
            // 
            lblErrorTitulo.AutoSize = true;
            lblErrorTitulo.ForeColor = Color.Red;
            lblErrorTitulo.Location = new Point(123, 141);
            lblErrorTitulo.Name = "lblErrorTitulo";
            lblErrorTitulo.Size = new Size(83, 20);
            lblErrorTitulo.TabIndex = 10;
            lblErrorTitulo.Text = "Error Titulo";
            // 
            // lblErrorCupo
            // 
            lblErrorCupo.AutoSize = true;
            lblErrorCupo.ForeColor = Color.Red;
            lblErrorCupo.Location = new Point(128, 307);
            lblErrorCupo.Name = "lblErrorCupo";
            lblErrorCupo.Size = new Size(80, 20);
            lblErrorCupo.TabIndex = 11;
            lblErrorCupo.Text = "Error Cupo";
            // 
            // lblErrorDescripcion
            // 
            lblErrorDescripcion.AutoSize = true;
            lblErrorDescripcion.ForeColor = Color.Red;
            lblErrorDescripcion.Location = new Point(128, 461);
            lblErrorDescripcion.Name = "lblErrorDescripcion";
            lblErrorDescripcion.Size = new Size(123, 20);
            lblErrorDescripcion.TabIndex = 12;
            lblErrorDescripcion.Text = "Error Descripcion";
            // 
            // lblErrorPrecio
            // 
            lblErrorPrecio.AutoSize = true;
            lblErrorPrecio.ForeColor = Color.Red;
            lblErrorPrecio.Location = new Point(123, 220);
            lblErrorPrecio.Name = "lblErrorPrecio";
            lblErrorPrecio.Size = new Size(86, 20);
            lblErrorPrecio.TabIndex = 13;
            lblErrorPrecio.Text = "Error Precio";
            // 
            // InstalacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 592);
            Controls.Add(lblErrorPrecio);
            Controls.Add(lblErrorDescripcion);
            Controls.Add(lblErrorCupo);
            Controls.Add(lblErrorTitulo);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "InstalacionForm";
            Text = "InstalacionForm";
            Load += InstalacionForm_Load;
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
        private Label lblErrorTitulo;
        private Label lblErrorCupo;
        private Label lblErrorDescripcion;
        private Label lblErrorPrecio;
    }
}