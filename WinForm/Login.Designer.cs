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
            lblLogin.Location = new Point(360, 102);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
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
            txtContrasenia.Location = new Point(323, 215);
            txtContrasenia.Name = "txtContrasenia";
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
            lblContrasenia.Location = new Point(204, 215);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(87, 20);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contrasenia";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(386, 262);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(lblContrasenia);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblLogin);
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