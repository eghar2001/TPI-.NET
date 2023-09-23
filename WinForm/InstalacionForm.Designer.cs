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
            lblTitulo = new Label();
            lblDescripcion = new Label();
            lblCupo = new Label();
            label1 = new Label();
            txtTitulo = new TextBox();
            txtDesc = new TextBox();
            txtCupo = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(56, 106);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(46, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo : ";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 40);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 3;
            label1.Text = "Agregar Instalacion";
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
            // InstalacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 356);
            Controls.Add(btnGuardar);
            Controls.Add(txtCupo);
            Controls.Add(txtDesc);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Controls.Add(lblCupo);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Name = "InstalacionForm";
            Text = "AgregarInstalacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblCupo;
        private Label label1;
        private TextBox txtTitulo;
        private TextBox txtDesc;
        private TextBox txtCupo;
        private Button btnGuardar;
    }
}