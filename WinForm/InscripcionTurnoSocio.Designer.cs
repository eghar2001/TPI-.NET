namespace WinForm
{
    partial class InscripcionTurnoSocio
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
            lblPrecio = new Label();
            lblUbicacion = new Label();
            btnInscribirse = new Button();
            listboxHorarios = new ListBox();
            lblHorarios = new Label();
            lblProfesor = new Label();
            lblNombreActividad = new Label();
            pnlMenu = new Panel();
            panel1 = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            lblTitulo = new Label();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(632, 164);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 21);
            lblPrecio.TabIndex = 19;
            lblPrecio.Text = "Precio";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUbicacion.Location = new Point(63, 166);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(75, 20);
            lblUbicacion.TabIndex = 18;
            lblUbicacion.Text = "Ubicacion";
            // 
            // btnInscribirse
            // 
            btnInscribirse.Location = new Point(608, 480);
            btnInscribirse.Margin = new Padding(3, 2, 3, 2);
            btnInscribirse.Name = "btnInscribirse";
            btnInscribirse.Size = new Size(82, 22);
            btnInscribirse.TabIndex = 17;
            btnInscribirse.Text = "Inscribirse";
            btnInscribirse.UseVisualStyleBackColor = true;
            btnInscribirse.Click += btnInscribirse_Click;
            // 
            // listboxHorarios
            // 
            listboxHorarios.FormattingEnabled = true;
            listboxHorarios.ItemHeight = 15;
            listboxHorarios.Location = new Point(63, 282);
            listboxHorarios.Margin = new Padding(3, 2, 3, 2);
            listboxHorarios.Name = "listboxHorarios";
            listboxHorarios.Size = new Size(627, 169);
            listboxHorarios.TabIndex = 15;
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorarios.Location = new Point(63, 252);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(149, 21);
            lblHorarios.TabIndex = 14;
            lblHorarios.Text = "Horarios del turno";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(63, 210);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(51, 15);
            lblProfesor.TabIndex = 13;
            lblProfesor.Text = "Profesor";
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreActividad.ForeColor = SystemColors.HotTrack;
            lblNombreActividad.Location = new Point(54, 121);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(269, 33);
            lblNombreActividad.TabIndex = 12;
            lblNombreActividad.Text = "Nombre Actividad";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MediumPurple;
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(picboxLogo);
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(781, 89);
            pnlMenu.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(639, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 89);
            panel1.TabIndex = 9;
            // 
            // bntMenuPrincipal
            // 
            bntMenuPrincipal.Location = new Point(0, 34);
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
            lblTitulo.Size = new Size(255, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Inscripcion A Actividad";
            // 
            // InscripcionTurnoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 536);
            Controls.Add(pnlMenu);
            Controls.Add(lblPrecio);
            Controls.Add(lblUbicacion);
            Controls.Add(btnInscribirse);
            Controls.Add(listboxHorarios);
            Controls.Add(lblHorarios);
            Controls.Add(lblProfesor);
            Controls.Add(lblNombreActividad);
            Name = "InscripcionTurnoSocio";
            Text = "Inscripcion a Actividad";
            Load += InscripcionTurnoSocio_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecio;
        private Label lblUbicacion;
        private Button btnInscribirse;
        private ListBox listboxHorarios;
        private Label lblHorarios;
        private Label lblProfesor;
        private Label lblNombreActividad;
        private Panel pnlMenu;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}