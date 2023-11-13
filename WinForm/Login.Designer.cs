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
            pnlLogin = new Panel();
            picboxLogo = new PictureBox();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ControlLightLight;
            lblLogin.Location = new Point(175, 21);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(73, 32);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(161, 86);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(138, 23);
            txtNombreUsuario.TabIndex = 1;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(161, 133);
            txtContrasenia.Margin = new Padding(3, 2, 3, 2);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(138, 23);
            txtContrasenia.TabIndex = 2;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.ForeColor = SystemColors.ControlLightLight;
            lblNombreUsuario.Location = new Point(39, 88);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(94, 15);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.ForeColor = SystemColors.ControlLightLight;
            lblContrasenia.Location = new Point(56, 133);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(70, 15);
            lblContrasenia.TabIndex = 4;
            lblContrasenia.Text = "Contrasenia";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(175, 191);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(82, 26);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.MediumPurple;
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblContrasenia);
            pnlLogin.Controls.Add(lblNombreUsuario);
            pnlLogin.Controls.Add(txtContrasenia);
            pnlLogin.Controls.Add(txtNombreUsuario);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Location = new Point(70, 112);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(395, 246);
            pnlLogin.TabIndex = 6;
            // 
            // picboxLogo
            // 
            picboxLogo.Image = Properties.Resources.sacachispas;
            picboxLogo.Location = new Point(245, 12);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(69, 82);
            picboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxLogo.TabIndex = 6;
            picboxLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 403);
            Controls.Add(picboxLogo);
            Controls.Add(pnlLogin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblLogin;
        private TextBox txtNombreUsuario;
        private TextBox txtContrasenia;
        private Label lblNombreUsuario;
        private Label lblContrasenia;
        private Button btnLogin;
        private Panel pnlLogin;
        private PictureBox picboxLogo;
    }
}