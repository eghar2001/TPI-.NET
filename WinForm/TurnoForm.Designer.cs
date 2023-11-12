namespace WinForm
{
    partial class TurnoForm
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
            txtDescripcion = new TextBox();
            listadoInstalaciones = new Componentes.ListadoInstalaciones();
            listadoProfesores = new Componentes.ListadoProfesores();
            lblDescripcion = new Label();
            LblInstalacion = new Label();
            lblProfesor = new Label();
            btnGuardar = new Button();
            lblErrorDescripcion = new Label();
            pnlMenu = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            lblTitulo = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(226, 141);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(539, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // listadoInstalaciones
            // 
            listadoInstalaciones.AutoSize = true;
            listadoInstalaciones.Instalaciones = null;
            listadoInstalaciones.InstalacionSeleccionada = null;
            listadoInstalaciones.Location = new Point(94, 215);
            listadoInstalaciones.Margin = new Padding(3, 2, 3, 2);
            listadoInstalaciones.Name = "listadoInstalaciones";
            listadoInstalaciones.Size = new Size(671, 108);
            listadoInstalaciones.TabIndex = 2;
            // 
            // listadoProfesores
            // 
            listadoProfesores.AutoSize = true;
            listadoProfesores.Location = new Point(95, 450);
            listadoProfesores.Margin = new Padding(3, 2, 3, 2);
            listadoProfesores.Name = "listadoProfesores";
            listadoProfesores.Profesores = null;
            listadoProfesores.ProfesorSeleccionado = null;
            listadoProfesores.Size = new Size(670, 89);
            listadoProfesores.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(94, 140);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(94, 21);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion:";
            // 
            // LblInstalacion
            // 
            LblInstalacion.AutoSize = true;
            LblInstalacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblInstalacion.Location = new Point(94, 191);
            LblInstalacion.Name = "LblInstalacion";
            LblInstalacion.Size = new Size(84, 21);
            LblInstalacion.TabIndex = 5;
            LblInstalacion.Text = "Instalacion";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfesor.Location = new Point(95, 427);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(69, 21);
            lblProfesor.TabIndex = 6;
            lblProfesor.Text = "Profesor";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(683, 667);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblErrorDescripcion
            // 
            lblErrorDescripcion.AutoSize = true;
            lblErrorDescripcion.ForeColor = Color.Red;
            lblErrorDescripcion.Location = new Point(94, 169);
            lblErrorDescripcion.Name = "lblErrorDescripcion";
            lblErrorDescripcion.Size = new Size(97, 15);
            lblErrorDescripcion.TabIndex = 8;
            lblErrorDescripcion.Text = "Error Descripcion";
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
            pnlMenu.Size = new Size(862, 89);
            pnlMenu.TabIndex = 26;
            // 
            // bntMenuPrincipal
            // 
            bntMenuPrincipal.Location = new Point(690, 34);
            bntMenuPrincipal.Name = "bntMenuPrincipal";
            bntMenuPrincipal.Size = new Size(75, 23);
            bntMenuPrincipal.TabIndex = 8;
            bntMenuPrincipal.Text = "Volver";
            bntMenuPrincipal.UseVisualStyleBackColor = true;
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
            // TurnoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 719);
            Controls.Add(pnlMenu);
            Controls.Add(lblErrorDescripcion);
            Controls.Add(btnGuardar);
            Controls.Add(lblProfesor);
            Controls.Add(LblInstalacion);
            Controls.Add(lblDescripcion);
            Controls.Add(listadoProfesores);
            Controls.Add(listadoInstalaciones);
            Controls.Add(txtDescripcion);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TurnoForm";
            Text = "TurnoForm";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDescripcion;
        private Componentes.ListadoInstalaciones listadoInstalaciones;
        private Componentes.ListadoProfesores listadoProfesores;
        private Label lblDescripcion;
        private Label LblInstalacion;
        private Label lblProfesor;
        private Button btnGuardar;
        private Label lblErrorDescripcion;
        private Panel pnlMenu;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}