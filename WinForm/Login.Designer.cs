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
            lblLogin = new Label();
            txtNombreUsuario = new TextBox();
            txtContrasenia = new TextBox();
            lblNombreUsuario = new Label();
            lblContrasenia = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(312, 58);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(73, 32);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(283, 114);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(138, 23);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(283, 161);
            txtContrasenia.Margin = new Padding(3, 2, 3, 2);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(138, 23);
            txtContrasenia.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(161, 116);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(94, 15);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Location = new Point(178, 161);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(70, 15);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contrasenia";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(338, 196);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 22);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnLogin);
            Controls.Add(lblContrasenia);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasenia;
        private Label lblNombreUsuario;
        private Label lblContrasenia;
        private Button btnLogin;
    }
}