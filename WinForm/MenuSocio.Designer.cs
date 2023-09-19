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
            btnMisActividades = new Button();
            subPanelnstalaciones = new Panel();
            btnVerReservas = new Button();
            btnReservarInstalacion = new Button();
            btnInstalaciones = new Button();
            btnMisCompras = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            pictureBox1 = new PictureBox();
            lblMenu = new Label();
            panelMenuLateral.SuspendLayout();
            subPanelnstalaciones.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Maroon;
            lblNombre.Location = new Point(612, 152);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(243, 38);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre y Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDni.ForeColor = Color.Black;
            lblDni.Location = new Point(805, 202);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(50, 30);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.IndianRed;
            panelMenuLateral.Controls.Add(btnMisActividades);
            panelMenuLateral.Controls.Add(subPanelnstalaciones);
            panelMenuLateral.Controls.Add(btnInstalaciones);
            panelMenuLateral.Controls.Add(btnMisCompras);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(290, 601);
            panelMenuLateral.TabIndex = 2;
            // 
            // btnMisActividades
            // 
            btnMisActividades.Dock = DockStyle.Top;
            btnMisActividades.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMisActividades.Location = new Point(0, 265);
            btnMisActividades.Name = "btnMisActividades";
            btnMisActividades.Size = new Size(290, 45);
            btnMisActividades.TabIndex = 7;
            btnMisActividades.Text = "Mis Actividades";
            btnMisActividades.TextAlign = ContentAlignment.MiddleRight;
            btnMisActividades.UseVisualStyleBackColor = true;
            btnMisActividades.Click += btnActividades_Click;
            // 
            // subPanelnstalaciones
            // 
            subPanelnstalaciones.BackColor = Color.Brown;
            subPanelnstalaciones.Controls.Add(btnVerReservas);
            subPanelnstalaciones.Controls.Add(btnReservarInstalacion);
            subPanelnstalaciones.Dock = DockStyle.Top;
            subPanelnstalaciones.Location = new Point(0, 193);
            subPanelnstalaciones.Name = "subPanelnstalaciones";
            subPanelnstalaciones.Padding = new Padding(5);
            subPanelnstalaciones.Size = new Size(290, 72);
            subPanelnstalaciones.TabIndex = 6;
            subPanelnstalaciones.Visible = false;
            // 
            // btnVerReservas
            // 
            btnVerReservas.Dock = DockStyle.Top;
            btnVerReservas.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerReservas.ForeColor = Color.FromArgb(64, 64, 64);
            btnVerReservas.ImageAlign = ContentAlignment.BottomLeft;
            btnVerReservas.Location = new Point(5, 34);
            btnVerReservas.Name = "btnVerReservas";
            btnVerReservas.Size = new Size(280, 29);
            btnVerReservas.TabIndex = 1;
            btnVerReservas.Text = "Ver Reservas";
            btnVerReservas.TextAlign = ContentAlignment.MiddleRight;
            btnVerReservas.UseVisualStyleBackColor = true;
            // 
            // btnReservarInstalacion
            // 
            btnReservarInstalacion.Dock = DockStyle.Top;
            btnReservarInstalacion.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservarInstalacion.ForeColor = Color.FromArgb(64, 64, 64);
            btnReservarInstalacion.ImageAlign = ContentAlignment.BottomLeft;
            btnReservarInstalacion.Location = new Point(5, 5);
            btnReservarInstalacion.Name = "btnReservarInstalacion";
            btnReservarInstalacion.Size = new Size(280, 29);
            btnReservarInstalacion.TabIndex = 0;
            btnReservarInstalacion.Text = "Reservar Instalacion";
            btnReservarInstalacion.TextAlign = ContentAlignment.MiddleRight;
            btnReservarInstalacion.UseVisualStyleBackColor = true;
            // 
            // btnInstalaciones
            // 
            btnInstalaciones.Dock = DockStyle.Top;
            btnInstalaciones.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInstalaciones.Location = new Point(0, 148);
            btnInstalaciones.Name = "btnInstalaciones";
            btnInstalaciones.Size = new Size(290, 45);
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
            btnMisCompras.Location = new Point(0, 103);
            btnMisCompras.Name = "btnMisCompras";
            btnMisCompras.Size = new Size(290, 45);
            btnMisCompras.TabIndex = 2;
            btnMisCompras.Text = "Mis Compras";
            btnMisCompras.TextAlign = ContentAlignment.MiddleRight;
            btnMisCompras.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(290, 103);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.White;
            lblLogo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogo.Location = new Point(33, 29);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(235, 41);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "INSERTAR LOGO";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(582, 285);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(273, 229);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Arial Rounded MT Bold", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenu.Location = new Point(544, 49);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(286, 54);
            lblMenu.TabIndex = 4;
            lblMenu.Text = "Menu Socio";
            // 
            // MenuSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 601);
            Controls.Add(lblMenu);
            Controls.Add(pictureBox1);
            Controls.Add(panelMenuLateral);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Name = "MenuSocio";
            Text = "Menu Socio";
            Load += MenuSocio_Load;
            panelMenuLateral.ResumeLayout(false);
            subPanelnstalaciones.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDni;
        private ToolTip toolTip1;
        private Panel panelMenuLateral;
        private Button btnMisCompras;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnInstalaciones;
        private Panel subPanelActividades;
        private Button btnAdministrarProfesores;
        private Button btnAdministrarActividades;
        private Button btnMisActividades;
        private Label lblLogo;
        private Label lblMenu;
        private Button button2;
        private Button button3;
        private Panel subPanelnstalaciones;
        private Button btnVerReservas;
        private Button btnReservarInstalacion;
    }
}