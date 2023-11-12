namespace WinForm
{
    partial class ProfesorForm
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtSalario = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblSalario = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            pnlMenu = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            lblTitulo = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(200, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(200, 169);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(211, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(200, 221);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(211, 23);
            txtSalario.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(114, 117);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(114, 177);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(114, 224);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(45, 15);
            lblSalario.TabIndex = 5;
            lblSalario.Text = "Salario:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(255, 287);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(336, 287);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MediumPurple;
            pnlMenu.Controls.Add(bntMenuPrincipal);
            pnlMenu.Controls.Add(picboxLogo);
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(469, 89);
            pnlMenu.TabIndex = 27;
            // 
            // bntMenuPrincipal
            // 
            bntMenuPrincipal.Location = new Point(336, 34);
            bntMenuPrincipal.Name = "bntMenuPrincipal";
            bntMenuPrincipal.Size = new Size(75, 23);
            bntMenuPrincipal.TabIndex = 8;
            bntMenuPrincipal.Text = "Volver";
            bntMenuPrincipal.UseVisualStyleBackColor = true;
            bntMenuPrincipal.Click += bntMenuPrincipal_Click;
            // 
            // picboxLogo
            // 
            picboxLogo.Image = Properties.Resources.sacachispas;
            picboxLogo.Location = new Point(3, 3);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(69, 79);
            picboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxLogo.TabIndex = 7;
            picboxLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(106, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(75, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // ProfesorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 338);
            Controls.Add(pnlMenu);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblSalario);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtSalario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "ProfesorForm";
            Text = "ProfesorForm";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtSalario;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblSalario;
        private Button btnGuardar;
        private Button btnCancelar;
        private Panel pnlMenu;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}