namespace WinForm
{
    partial class Login
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
            txtNombreUsuario = new TextBox();
            txtContrasenia = new TextBox();
            lblNombreUsuario = new Label();
            lblContrasenia = new Label();
            btnLogin = new Button();
            lblErrorNombreUsuario = new Label();
            lblErrorContrasenia = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(323, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(122, 54);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Login";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(323, 152);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(157, 27);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(323, 229);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(157, 27);
            txtContrasenia.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(184, 155);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(118, 20);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(203, 229);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(83, 20);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(386, 297);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorNombreUsuario
            // 
            lblErrorNombreUsuario.AutoSize = true;
            lblErrorNombreUsuario.ForeColor = Color.Red;
            lblErrorNombreUsuario.Location = new Point(323, 182);
            lblErrorNombreUsuario.Name = "lblErrorNombreUsuario";
            lblErrorNombreUsuario.Size = new Size(154, 20);
            lblErrorNombreUsuario.TabIndex = 6;
            lblErrorNombreUsuario.Text = "Error Nombre Usuario";
            // 
            // lblErrorContrasenia
            // 
            lblErrorContrasenia.AutoSize = true;
            lblErrorContrasenia.ForeColor = Color.Red;
            lblErrorContrasenia.Location = new Point(323, 259);
            lblErrorContrasenia.Name = "lblErrorContrasenia";
            lblErrorContrasenia.Size = new Size(119, 20);
            lblErrorContrasenia.TabIndex = 7;
            lblErrorContrasenia.Text = "Error Contraseña";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(lblErrorContrasenia);
            Controls.Add(lblErrorNombreUsuario);
            Controls.Add(btnLogin);
            Controls.Add(lblContrasenia);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblTitulo);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasenia;
        private Label lblNombreUsuario;
        private Label lblContrasenia;
        private Button btnLogin;
        private Label lblErrorNombreUsuario;
        private Label lblErrorContrasenia;
    }
}