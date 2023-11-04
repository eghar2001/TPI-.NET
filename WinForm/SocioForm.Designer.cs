namespace WinForm
{
    partial class SocioForm
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblNombreUsuario = new Label();
            lblContrasenia = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtNombreUsuario = new TextBox();
            txtContrasenia = new TextBox();
            btnGuardar = new Button();
            lblErrorNombre = new Label();
            lblErrorApellido = new Label();
            LblErrorDni = new Label();
            lblErrroNombreUsuario = new Label();
            lblErrorContrasenia = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(248, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(168, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Form Socio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(139, 121);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(139, 183);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(155, 243);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 20);
            lblDni.TabIndex = 3;
            lblDni.Text = "Dni";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(118, 302);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(118, 20);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(141, 372);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(83, 20);
            lblContrasenia.TabIndex = 5;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(242, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(269, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(242, 179);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(269, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(242, 239);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(269, 27);
            txtDni.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(242, 302);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(269, 27);
            txtNombreUsuario.TabIndex = 9;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(244, 372);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(269, 27);
            txtContrasenia.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(419, 434);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(242, 144);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(100, 20);
            lblErrorNombre.TabIndex = 12;
            lblErrorNombre.Text = "Error Nombre";
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.ForeColor = Color.Red;
            lblErrorApellido.Location = new Point(242, 209);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(102, 20);
            lblErrorApellido.TabIndex = 13;
            lblErrorApellido.Text = "Error Apellido";
            // 
            // LblErrorDni
            // 
            LblErrorDni.AutoSize = true;
            LblErrorDni.ForeColor = Color.Red;
            LblErrorDni.Location = new Point(242, 269);
            LblErrorDni.Name = "LblErrorDni";
            LblErrorDni.Size = new Size(71, 20);
            LblErrorDni.TabIndex = 14;
            LblErrorDni.Text = "Error DNI";
            // 
            // lblErrroNombreUsuario
            // 
            lblErrroNombreUsuario.AutoSize = true;
            lblErrroNombreUsuario.ForeColor = Color.Red;
            lblErrroNombreUsuario.Location = new Point(242, 332);
            lblErrroNombreUsuario.Name = "lblErrroNombreUsuario";
            lblErrroNombreUsuario.Size = new Size(154, 20);
            lblErrroNombreUsuario.TabIndex = 15;
            lblErrroNombreUsuario.Text = "Error Nombre Usuario";
            // 
            // lblErrorContrasenia
            // 
            lblErrorContrasenia.AutoSize = true;
            lblErrorContrasenia.ForeColor = Color.Red;
            lblErrorContrasenia.Location = new Point(242, 402);
            lblErrorContrasenia.Name = "lblErrorContrasenia";
            lblErrorContrasenia.Size = new Size(119, 20);
            lblErrorContrasenia.TabIndex = 16;
            lblErrorContrasenia.Text = "Error Contraseña";
            // 
            // SocioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 493);
            Controls.Add(lblErrorContrasenia);
            Controls.Add(lblErrroNombreUsuario);
            Controls.Add(LblErrorDni);
            Controls.Add(lblErrorApellido);
            Controls.Add(lblErrorNombre);
            Controls.Add(btnGuardar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblContrasenia);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "SocioForm";
            Text = "Socio Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblNombreUsuario;
        private Label lblContrasenia;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasenia;
        private Button btnGuardar;
        private Label lblErrorNombre;
        private Label lblErrorApellido;
        private Label LblErrorDni;
        private Label lblErrroNombreUsuario;
        private Label lblErrorContrasenia;
    }
}