namespace WinForm
{
    partial class AgregarSocio
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
            lblHeader = new Label();
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
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(248, 34);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(172, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Form para agregar socio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(96, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(96, 122);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(112, 156);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 20);
            lblDni.TabIndex = 3;
            lblDni.Text = "Dni";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(75, 185);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(118, 20);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(96, 218);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(83, 20);
            lblContrasenia.TabIndex = 5;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(236, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(269, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(236, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(269, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(236, 156);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(269, 27);
            txtDni.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(236, 189);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(269, 27);
            txtNombreUsuario.TabIndex = 9;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(236, 222);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(269, 27);
            txtContrasenia.TabIndex = 10;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(401, 289);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AgregarSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
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
            Controls.Add(lblHeader);
            Name = "AgregarSocio";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
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
        private Button btnAgregar;
    }
}