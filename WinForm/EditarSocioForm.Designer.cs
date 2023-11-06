namespace WinForm
{
    partial class EditarSocioForm
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtNombreUsuario = new TextBox();
            btnEditar = new Button();
            lblBuscarSocio = new Label();
            label1 = new Label();
            txtIdSocio = new TextBox();
            btnBuscarSocio = new Button();
            txtContrasenia = new TextBox();
            lblContrasenia = new Label();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(297, 157);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(159, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Form para editar socio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(145, 198);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(145, 230);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(161, 264);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(32, 20);
            lblDni.TabIndex = 3;
            lblDni.Text = "Dni";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(124, 293);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(118, 20);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(285, 195);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(269, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(285, 230);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(269, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(285, 264);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(269, 27);
            txtDni.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(285, 297);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(269, 27);
            txtNombreUsuario.TabIndex = 9;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(460, 381);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblBuscarSocio
            // 
            lblBuscarSocio.AutoSize = true;
            lblBuscarSocio.Location = new Point(285, 18);
            lblBuscarSocio.Name = "lblBuscarSocio";
            lblBuscarSocio.Size = new Size(146, 20);
            lblBuscarSocio.TabIndex = 12;
            lblBuscarSocio.Text = "Buscar socio a editar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 71);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 13;
            label1.Text = "Id del socio";
            // 
            // txtIdSocio
            // 
            txtIdSocio.Location = new Point(285, 68);
            txtIdSocio.Name = "txtIdSocio";
            txtIdSocio.Size = new Size(171, 27);
            txtIdSocio.TabIndex = 14;
            // 
            // btnBuscarSocio
            // 
            btnBuscarSocio.Location = new Point(362, 113);
            btnBuscarSocio.Name = "btnBuscarSocio";
            btnBuscarSocio.Size = new Size(94, 29);
            btnBuscarSocio.TabIndex = 15;
            btnBuscarSocio.Text = "Buscar";
            btnBuscarSocio.UseVisualStyleBackColor = true;
            btnBuscarSocio.Click += btnBuscarSocio_Click;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(285, 330);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(269, 27);
            txtContrasenia.TabIndex = 17;
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(124, 326);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(83, 20);
            lblContrasenia.TabIndex = 16;
            lblContrasenia.Text = "Contraseña";
            // 
            // EditarSocioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtContrasenia);
            Controls.Add(lblContrasenia);
            Controls.Add(btnBuscarSocio);
            Controls.Add(txtIdSocio);
            Controls.Add(label1);
            Controls.Add(lblBuscarSocio);
            Controls.Add(btnEditar);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblHeader);
            Name = "EditarSocioForm";
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
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtNombreUsuario;
        private Button btnEditar;
        private Label lblBuscarSocio;
        private Label label1;
        private TextBox txtIdSocio;
        private Button btnBuscarSocio;
        private TextBox txtContrasenia;
        private Label lblContrasenia;
    }
}