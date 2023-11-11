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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtNombreUsuario = new TextBox();
            btnGuardar = new Button();
            lblErrorNombre = new Label();
            lblErrorApellido = new Label();
            LblErrorDni = new Label();
            lblErrorNombreUsuario = new Label();
            lblErrorContrasenia = new Label();
            txtContrasenia = new TextBox();
            lblContrasenia = new Label();
            txtConfirmarContraseña = new TextBox();
            lblConfirmarContrasenia = new Label();
            picboxImagen = new PictureBox();
            lblImagen = new Label();
            btnExaminar = new Button();
            ((System.ComponentModel.ISupportInitialize)picboxImagen).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(95, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(75, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(95, 255);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(95, 303);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(95, 348);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(25, 15);
            lblDni.TabIndex = 3;
            lblDni.Text = "Dni";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(526, 256);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(94, 15);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(259, 249);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 23);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(259, 298);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(236, 23);
            txtApellido.TabIndex = 7;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(259, 343);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(236, 23);
            txtDni.TabIndex = 8;
            txtDni.TextChanged += txtDni_TextChanged;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(690, 251);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(236, 23);
            txtNombreUsuario.TabIndex = 9;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(844, 434);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(259, 272);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(79, 15);
            lblErrorNombre.TabIndex = 12;
            lblErrorNombre.Text = "Error Nombre";
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.ForeColor = Color.Red;
            lblErrorApellido.Location = new Point(259, 321);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(79, 15);
            lblErrorApellido.TabIndex = 13;
            lblErrorApellido.Text = "Error Apellido";
            // 
            // LblErrorDni
            // 
            LblErrorDni.AutoSize = true;
            LblErrorDni.ForeColor = Color.Red;
            LblErrorDni.Location = new Point(259, 368);
            LblErrorDni.Name = "LblErrorDni";
            LblErrorDni.Size = new Size(55, 15);
            LblErrorDni.TabIndex = 14;
            LblErrorDni.Text = "Error DNI";
            // 
            // lblErrorNombreUsuario
            // 
            lblErrorNombreUsuario.AutoSize = true;
            lblErrorNombreUsuario.ForeColor = Color.Red;
            lblErrorNombreUsuario.Location = new Point(690, 274);
            lblErrorNombreUsuario.Name = "lblErrorNombreUsuario";
            lblErrorNombreUsuario.Size = new Size(122, 15);
            lblErrorNombreUsuario.TabIndex = 15;
            lblErrorNombreUsuario.Text = "Error Nombre Usuario";
            // 
            // lblErrorContrasenia
            // 
            lblErrorContrasenia.AutoSize = true;
            lblErrorContrasenia.ForeColor = Color.Red;
            lblErrorContrasenia.Location = new Point(690, 365);
            lblErrorContrasenia.Name = "lblErrorContrasenia";
            lblErrorContrasenia.Size = new Size(95, 15);
            lblErrorContrasenia.TabIndex = 18;
            lblErrorContrasenia.Text = "Error Contraseña";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(690, 318);
            txtContrasenia.Margin = new Padding(3, 2, 3, 2);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(236, 23);
            txtContrasenia.TabIndex = 17;
            txtContrasenia.TextChanged += txtContrasenia_TextChanged;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(526, 323);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(67, 15);
            lblContrasenia.TabIndex = 16;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Location = new Point(690, 343);
            txtConfirmarContraseña.Margin = new Padding(3, 2, 3, 2);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.PasswordChar = '*';
            txtConfirmarContraseña.Size = new Size(236, 23);
            txtConfirmarContraseña.TabIndex = 20;
            txtConfirmarContraseña.TextChanged += txtConfirmarContraseña_TextChanged;
            // 
            // lblConfirmarContrasenia
            // 
            lblConfirmarContrasenia.AutoSize = true;
            lblConfirmarContrasenia.Location = new Point(526, 348);
            lblConfirmarContrasenia.Name = "lblConfirmarContrasenia";
            lblConfirmarContrasenia.Size = new Size(124, 15);
            lblConfirmarContrasenia.TabIndex = 19;
            lblConfirmarContrasenia.Text = "Confirmar Contraseña";
            // 
            // picboxImagen
            // 
            picboxImagen.Location = new Point(690, 44);
            picboxImagen.Name = "picboxImagen";
            picboxImagen.Size = new Size(150, 158);
            picboxImagen.SizeMode = PictureBoxSizeMode.Zoom;
            picboxImagen.TabIndex = 21;
            picboxImagen.TabStop = false;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(690, 26);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(47, 15);
            lblImagen.TabIndex = 22;
            lblImagen.Text = "Imagen";
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(690, 208);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(150, 23);
            btnExaminar.TabIndex = 23;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // SocioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 552);
            Controls.Add(btnExaminar);
            Controls.Add(lblImagen);
            Controls.Add(picboxImagen);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(lblConfirmarContrasenia);
            Controls.Add(lblErrorContrasenia);
            Controls.Add(txtContrasenia);
            Controls.Add(lblContrasenia);
            Controls.Add(lblErrorNombreUsuario);
            Controls.Add(LblErrorDni);
            Controls.Add(lblErrorApellido);
            Controls.Add(lblErrorNombre);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SocioForm";
            Text = "Socio Form";
            Load += SocioForm_Load;
            ((System.ComponentModel.ISupportInitialize)picboxImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblNombreUsuario;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtNombreUsuario;
        private Button btnGuardar;
        private Label lblErrorNombre;
        private Label lblErrorApellido;
        private Label LblErrorDni;
        private Label lblErrorNombreUsuario;
        private Label lblErrorContrasenia;
        private TextBox txtContrasenia;
        private Label lblContrasenia;
        private TextBox txtConfirmarContraseña;
        private Label lblConfirmarContrasenia;
        private PictureBox picboxImagen;
        private Label lblImagen;
        private Button btnExaminar;
    }
}