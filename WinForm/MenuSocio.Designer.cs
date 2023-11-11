namespace WinForm
{
    partial class MenuSocio
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
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            lblDni = new Label();
            toolTip1 = new ToolTip(components);
            panelMenuLateral = new Panel();
            subPanelActividades = new Panel();
            btnVerReservasActividad = new Button();
            btnReservarActividad = new Button();
            btnMisActividades = new Button();
            subPanelnstalaciones = new Panel();
            btnVerReservas = new Button();
            btnReservarInstalacion = new Button();
            btnInstalaciones = new Button();
            btnMisCompras = new Button();
            panelLogo = new Panel();
            panel1 = new Panel();
            lblTituloClub = new Label();
            picboxLogo = new PictureBox();
            lblLogo = new Label();
            picboxSocio = new PictureBox();
            lblMenu = new Label();
            panel2 = new Panel();
            panelMenuLateral.SuspendLayout();
            subPanelActividades.SuspendLayout();
            subPanelnstalaciones.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxSocio).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Maroon;
            lblNombre.Location = new Point(88, 11);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(193, 30);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre y Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.Black;
            lblDni.Location = new Point(88, 217);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 25);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.MediumPurple;
            panelMenuLateral.Controls.Add(subPanelActividades);
            panelMenuLateral.Controls.Add(btnMisActividades);
            panelMenuLateral.Controls.Add(subPanelnstalaciones);
            panelMenuLateral.Controls.Add(btnInstalaciones);
            panelMenuLateral.Controls.Add(btnMisCompras);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Margin = new Padding(3, 2, 3, 2);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(254, 451);
            panelMenuLateral.TabIndex = 2;
            // 
            // subPanelActividades
            // 
            subPanelActividades.BackColor = Color.MediumPurple;
            subPanelActividades.Controls.Add(btnVerReservasActividad);
            subPanelActividades.Controls.Add(btnReservarActividad);
            subPanelActividades.Dock = DockStyle.Top;
            subPanelActividades.Location = new Point(0, 246);
            subPanelActividades.Margin = new Padding(3, 2, 3, 2);
            subPanelActividades.Name = "subPanelActividades";
            subPanelActividades.Padding = new Padding(4);
            subPanelActividades.Size = new Size(254, 51);
            subPanelActividades.TabIndex = 8;
            subPanelActividades.Visible = false;
            // 
            // btnVerReservasActividad
            // 
            btnVerReservasActividad.Dock = DockStyle.Top;
            btnVerReservasActividad.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerReservasActividad.ForeColor = Color.FromArgb(64, 64, 64);
            btnVerReservasActividad.ImageAlign = ContentAlignment.BottomLeft;
            btnVerReservasActividad.Location = new Point(4, 26);
            btnVerReservasActividad.Margin = new Padding(3, 2, 3, 2);
            btnVerReservasActividad.Name = "btnVerReservasActividad";
            btnVerReservasActividad.Size = new Size(246, 25);
            btnVerReservasActividad.TabIndex = 1;
            btnVerReservasActividad.Text = "Ver Inscripciones";
            btnVerReservasActividad.TextAlign = ContentAlignment.MiddleRight;
            btnVerReservasActividad.UseVisualStyleBackColor = true;
            btnVerReservasActividad.Click += btnVerReservasActividad_Click;
            // 
            // btnReservarActividad
            // 
            btnReservarActividad.Dock = DockStyle.Top;
            btnReservarActividad.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservarActividad.ForeColor = Color.FromArgb(64, 64, 64);
            btnReservarActividad.ImageAlign = ContentAlignment.BottomLeft;
            btnReservarActividad.Location = new Point(4, 4);
            btnReservarActividad.Margin = new Padding(3, 2, 3, 2);
            btnReservarActividad.Name = "btnReservarActividad";
            btnReservarActividad.Size = new Size(246, 22);
            btnReservarActividad.TabIndex = 0;
            btnReservarActividad.Text = "Reservar Actividad";
            btnReservarActividad.TextAlign = ContentAlignment.MiddleRight;
            btnReservarActividad.UseVisualStyleBackColor = true;
            btnReservarActividad.Click += btnReservarActividad_Click;
            // 
            // btnMisActividades
            // 
            btnMisActividades.Dock = DockStyle.Top;
            btnMisActividades.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMisActividades.Location = new Point(0, 212);
            btnMisActividades.Margin = new Padding(3, 2, 3, 2);
            btnMisActividades.Name = "btnMisActividades";
            btnMisActividades.Size = new Size(254, 34);
            btnMisActividades.TabIndex = 7;
            btnMisActividades.Text = "Mis Actividades";
            btnMisActividades.TextAlign = ContentAlignment.MiddleRight;
            btnMisActividades.UseVisualStyleBackColor = true;
            btnMisActividades.Click += btnMisActividades_Click;
            // 
            // subPanelnstalaciones
            // 
            subPanelnstalaciones.BackColor = Color.MediumPurple;
            subPanelnstalaciones.Controls.Add(btnVerReservas);
            subPanelnstalaciones.Controls.Add(btnReservarInstalacion);
            subPanelnstalaciones.Dock = DockStyle.Top;
            subPanelnstalaciones.Location = new Point(0, 161);
            subPanelnstalaciones.Margin = new Padding(3, 2, 3, 2);
            subPanelnstalaciones.Name = "subPanelnstalaciones";
            subPanelnstalaciones.Padding = new Padding(4);
            subPanelnstalaciones.Size = new Size(254, 51);
            subPanelnstalaciones.TabIndex = 6;
            subPanelnstalaciones.Visible = false;
            // 
            // btnVerReservas
            // 
            btnVerReservas.Dock = DockStyle.Top;
            btnVerReservas.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerReservas.ForeColor = Color.FromArgb(64, 64, 64);
            btnVerReservas.ImageAlign = ContentAlignment.BottomLeft;
            btnVerReservas.Location = new Point(4, 26);
            btnVerReservas.Margin = new Padding(3, 2, 3, 2);
            btnVerReservas.Name = "btnVerReservas";
            btnVerReservas.Size = new Size(246, 22);
            btnVerReservas.TabIndex = 1;
            btnVerReservas.Text = "Ver Reservas";
            btnVerReservas.TextAlign = ContentAlignment.MiddleRight;
            btnVerReservas.UseVisualStyleBackColor = true;
            btnVerReservas.Click += btnVerReservas_Click;
            // 
            // btnReservarInstalacion
            // 
            btnReservarInstalacion.Dock = DockStyle.Top;
            btnReservarInstalacion.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservarInstalacion.ForeColor = Color.FromArgb(64, 64, 64);
            btnReservarInstalacion.ImageAlign = ContentAlignment.BottomLeft;
            btnReservarInstalacion.Location = new Point(4, 4);
            btnReservarInstalacion.Margin = new Padding(3, 2, 3, 2);
            btnReservarInstalacion.Name = "btnReservarInstalacion";
            btnReservarInstalacion.Size = new Size(246, 22);
            btnReservarInstalacion.TabIndex = 0;
            btnReservarInstalacion.Text = "Reservar Instalacion";
            btnReservarInstalacion.TextAlign = ContentAlignment.MiddleRight;
            btnReservarInstalacion.UseVisualStyleBackColor = true;
            btnReservarInstalacion.Click += btnReservarInstalacion_Click;
            // 
            // btnInstalaciones
            // 
            btnInstalaciones.Dock = DockStyle.Top;
            btnInstalaciones.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInstalaciones.Location = new Point(0, 127);
            btnInstalaciones.Margin = new Padding(3, 2, 3, 2);
            btnInstalaciones.Name = "btnInstalaciones";
            btnInstalaciones.Size = new Size(254, 34);
            btnInstalaciones.TabIndex = 5;
            btnInstalaciones.Text = "Instalaciones";
            btnInstalaciones.TextAlign = ContentAlignment.MiddleRight;
            btnInstalaciones.UseVisualStyleBackColor = true;
            btnInstalaciones.Click += btnInstalaciones_Click;
            // 
            // btnMisCompras
            // 
            btnMisCompras.Dock = DockStyle.Top;
            btnMisCompras.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMisCompras.Location = new Point(0, 93);
            btnMisCompras.Margin = new Padding(3, 2, 3, 2);
            btnMisCompras.Name = "btnMisCompras";
            btnMisCompras.Size = new Size(254, 34);
            btnMisCompras.TabIndex = 2;
            btnMisCompras.Text = "Mis Compras";
            btnMisCompras.TextAlign = ContentAlignment.MiddleRight;
            btnMisCompras.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(panel1);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(254, 93);
            panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(lblTituloClub);
            panel1.Controls.Add(picboxLogo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 94);
            panel1.TabIndex = 1;
            // 
            // lblTituloClub
            // 
            lblTituloClub.AutoSize = true;
            lblTituloClub.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloClub.ForeColor = SystemColors.ButtonHighlight;
            lblTituloClub.Location = new Point(79, 37);
            lblTituloClub.Name = "lblTituloClub";
            lblTituloClub.Size = new Size(166, 23);
            lblTituloClub.TabIndex = 1;
            lblTituloClub.Text = "Club Facha Fc";
            // 
            // picboxLogo
            // 
            picboxLogo.Image = Properties.Resources.sacachispas;
            picboxLogo.Location = new Point(0, 3);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(69, 82);
            picboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxLogo.TabIndex = 0;
            picboxLogo.TabStop = false;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.White;
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogo.Location = new Point(29, 22);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(185, 32);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "INSERTAR LOGO";
            // 
            // picboxSocio
            // 
            picboxSocio.Location = new Point(67, 43);
            picboxSocio.Margin = new Padding(3, 2, 3, 2);
            picboxSocio.Name = "picboxSocio";
            picboxSocio.Size = new Size(239, 172);
            picboxSocio.SizeMode = PictureBoxSizeMode.Zoom;
            picboxSocio.TabIndex = 3;
            picboxSocio.TabStop = false;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenu.Location = new Point(428, 3);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(234, 44);
            lblMenu.TabIndex = 4;
            lblMenu.Text = "Menu Socio";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(picboxSocio);
            panel2.Controls.Add(lblDni);
            panel2.Controls.Add(lblNombre);
            panel2.Location = new Point(366, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 266);
            panel2.TabIndex = 5;
            // 
            // MenuSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(824, 451);
            Controls.Add(panel2);
            Controls.Add(lblMenu);
            Controls.Add(panelMenuLateral);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuSocio";
            Text = "Menu Socio";
            Load += MenuSocio_Load;
            panelMenuLateral.ResumeLayout(false);
            subPanelActividades.ResumeLayout(false);
            subPanelnstalaciones.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxSocio).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDni;
        private ToolTip toolTip1;
        private Panel panelMenuLateral;
        private Button btnMisCompras;
        private PictureBox picboxSocio;
        private Button btnInstalaciones;
        private Panel subPanelActividades;
        private Button btnAdministrarProfesores;
        private Button btnAdministrarActividades;
        private Button btnMisActividades;
        private Label lblMenu;
        private Button button2;
        private Button button3;
        private Panel subPanelnstalaciones;
        private Button btnVerReservas;
        private Button btnReservarInstalacion;
        private Panel subPanel;
        private Button btnVerReservasActividad;
        private Button btnReservarActividad;
        private Panel panelLogo;
        private Label lblLogo;
        private Panel panel1;
        private Label lblTituloClub;
        private PictureBox picboxLogo;
        private Panel panel2;
    }
}