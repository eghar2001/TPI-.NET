namespace WinForm
{
    partial class AdministrarTurnoForm
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
            lblActividad = new Label();
            lblProfesor = new Label();
            lblHorarios = new Label();
            listboxHorarios = new ListBox();
            lblAlertaBorrado = new Label();
            btnAgregar = new Button();
            lblUbicacion = new Label();
            lblPrecio = new Label();
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
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(84, 42);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(0, 15);
            lblActividad.TabIndex = 0;
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(84, 146);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(51, 15);
            lblProfesor.TabIndex = 4;
            lblProfesor.Text = "Profesor";
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorarios.Location = new Point(84, 188);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(149, 21);
            lblHorarios.TabIndex = 5;
            lblHorarios.Text = "Horarios del turno";
            // 
            // listboxHorarios
            // 
            listboxHorarios.FormattingEnabled = true;
            listboxHorarios.ItemHeight = 15;
            listboxHorarios.Location = new Point(84, 218);
            listboxHorarios.Margin = new Padding(3, 2, 3, 2);
            listboxHorarios.Name = "listboxHorarios";
            listboxHorarios.Size = new Size(627, 169);
            listboxHorarios.TabIndex = 7;
            listboxHorarios.SelectedIndexChanged += listboxHorarios_SelectedIndexChanged;
            // 
            // lblAlertaBorrado
            // 
            lblAlertaBorrado.AutoSize = true;
            lblAlertaBorrado.ForeColor = SystemColors.GrayText;
            lblAlertaBorrado.Location = new Point(84, 389);
            lblAlertaBorrado.Name = "lblAlertaBorrado";
            lblAlertaBorrado.Size = new Size(194, 15);
            lblAlertaBorrado.TabIndex = 8;
            lblAlertaBorrado.Text = "Click en algun horario para borrarlo";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(84, 438);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUbicacion.Location = new Point(84, 112);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(75, 20);
            lblUbicacion.TabIndex = 10;
            lblUbicacion.Text = "Ubicacion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(658, 110);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 21);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio";
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
            pnlMenu.Size = new Size(791, 89);
            pnlMenu.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(649, 0);
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
            lblTitulo.Size = new Size(75, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // AdministrarTurnoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 531);
            Controls.Add(pnlMenu);
            Controls.Add(lblPrecio);
            Controls.Add(lblUbicacion);
            Controls.Add(btnAgregar);
            Controls.Add(lblAlertaBorrado);
            Controls.Add(listboxHorarios);
            Controls.Add(lblHorarios);
            Controls.Add(lblProfesor);
            Controls.Add(lblActividad);
            Name = "AdministrarTurnoForm";
            Text = "Turnos";
            Load += TurnoForm_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblActividad;
        private Label lblProfesor;
        private Label lblHorarios;
        private ListBox listboxHorarios;
        private Label lblAlertaBorrado;
        private Button btnAgregar;
        private Label lblUbicacion;
        private Label lblPrecio;
        private Panel pnlMenu;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}