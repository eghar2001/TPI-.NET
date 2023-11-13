namespace WinForm
{
    partial class MenuEmpleado
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
            btnMiCuenta = new Button();
            btnAdministrarProfes = new Button();
            subPanelActividades = new Panel();
            btnReporteActividades = new Button();
            btnAdministrarActividades = new Button();
            btnActividades = new Button();
            subPanelnstalaciones = new Panel();
            btnManejarInstalaciones = new Button();
            btnInstalaciones = new Button();
            subPanelProductos = new Panel();
            btnCompraProducto = new Button();
            btnAdministrarProductos = new Button();
            btnProductos = new Button();
            btnManejoSocios = new Button();
            panelLogo = new Panel();
            lblTituloClub = new Label();
            picboxLogo = new PictureBox();
            picboxEmpleado = new PictureBox();
            lblMenu = new Label();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            tsbCerrarSesion = new ToolStripButton();
            panelMenuLateral.SuspendLayout();
            subPanelActividades.SuspendLayout();
            subPanelnstalaciones.SuspendLayout();
            subPanelProductos.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxEmpleado).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = SystemColors.ControlText;
            lblNombre.Location = new Point(50, 19);
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
            lblDni.Location = new Point(50, 253);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 25);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.MediumPurple;
            panelMenuLateral.Controls.Add(btnMiCuenta);
            panelMenuLateral.Controls.Add(btnAdministrarProfes);
            panelMenuLateral.Controls.Add(subPanelActividades);
            panelMenuLateral.Controls.Add(btnActividades);
            panelMenuLateral.Controls.Add(subPanelnstalaciones);
            panelMenuLateral.Controls.Add(btnInstalaciones);
            panelMenuLateral.Controls.Add(subPanelProductos);
            panelMenuLateral.Controls.Add(btnProductos);
            panelMenuLateral.Controls.Add(btnManejoSocios);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Margin = new Padding(3, 2, 3, 2);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(254, 553);
            panelMenuLateral.TabIndex = 2;
            // 
            // btnMiCuenta
            // 
            btnMiCuenta.Dock = DockStyle.Bottom;
            btnMiCuenta.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMiCuenta.Image = Properties.Resources.account;
            btnMiCuenta.ImageAlign = ContentAlignment.MiddleRight;
            btnMiCuenta.Location = new Point(0, 519);
            btnMiCuenta.Margin = new Padding(3, 2, 3, 2);
            btnMiCuenta.Name = "btnMiCuenta";
            btnMiCuenta.Size = new Size(254, 34);
            btnMiCuenta.TabIndex = 10;
            btnMiCuenta.Text = "Mi Cuenta";
            btnMiCuenta.TextAlign = ContentAlignment.MiddleLeft;
            btnMiCuenta.UseVisualStyleBackColor = true;
            btnMiCuenta.Click += btnMiCuenta_Click;
            // 
            // btnAdministrarProfes
            // 
            btnAdministrarProfes.Dock = DockStyle.Top;
            btnAdministrarProfes.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministrarProfes.Image = Properties.Resources.pe_teacher;
            btnAdministrarProfes.ImageAlign = ContentAlignment.MiddleRight;
            btnAdministrarProfes.Location = new Point(0, 364);
            btnAdministrarProfes.Margin = new Padding(3, 2, 3, 2);
            btnAdministrarProfes.Name = "btnAdministrarProfes";
            btnAdministrarProfes.Size = new Size(254, 34);
            btnAdministrarProfes.TabIndex = 9;
            btnAdministrarProfes.Text = "Administrar Profesores";
            btnAdministrarProfes.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministrarProfes.UseVisualStyleBackColor = true;
            btnAdministrarProfes.Click += btnAdministrarProfes_Click;
            // 
            // subPanelActividades
            // 
            subPanelActividades.BackColor = Color.MediumPurple;
            subPanelActividades.Controls.Add(btnReporteActividades);
            subPanelActividades.Controls.Add(btnAdministrarActividades);
            subPanelActividades.Dock = DockStyle.Top;
            subPanelActividades.Location = new Point(0, 311);
            subPanelActividades.Margin = new Padding(3, 2, 3, 2);
            subPanelActividades.Name = "subPanelActividades";
            subPanelActividades.Padding = new Padding(4);
            subPanelActividades.Size = new Size(254, 53);
            subPanelActividades.TabIndex = 8;
            subPanelActividades.Visible = false;
            // 
            // btnReporteActividades
            // 
            btnReporteActividades.Dock = DockStyle.Top;
            btnReporteActividades.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporteActividades.ForeColor = Color.FromArgb(64, 64, 64);
            btnReporteActividades.ImageAlign = ContentAlignment.BottomLeft;
            btnReporteActividades.Location = new Point(4, 26);
            btnReporteActividades.Margin = new Padding(3, 2, 3, 2);
            btnReporteActividades.Name = "btnReporteActividades";
            btnReporteActividades.Size = new Size(246, 22);
            btnReporteActividades.TabIndex = 1;
            btnReporteActividades.Text = "Reporte Precios Actividad";
            btnReporteActividades.TextAlign = ContentAlignment.BottomLeft;
            btnReporteActividades.UseVisualStyleBackColor = true;
            btnReporteActividades.Click += btnReporteActividades_Click;
            // 
            // btnAdministrarActividades
            // 
            btnAdministrarActividades.Dock = DockStyle.Top;
            btnAdministrarActividades.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministrarActividades.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdministrarActividades.ImageAlign = ContentAlignment.BottomLeft;
            btnAdministrarActividades.Location = new Point(4, 4);
            btnAdministrarActividades.Margin = new Padding(3, 2, 3, 2);
            btnAdministrarActividades.Name = "btnAdministrarActividades";
            btnAdministrarActividades.Size = new Size(246, 22);
            btnAdministrarActividades.TabIndex = 0;
            btnAdministrarActividades.Text = "Administrar Actividades";
            btnAdministrarActividades.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministrarActividades.UseVisualStyleBackColor = true;
            btnAdministrarActividades.Click += btnAdministrarActividades_Click;
            // 
            // btnActividades
            // 
            btnActividades.Dock = DockStyle.Top;
            btnActividades.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnActividades.Image = Properties.Resources.activity;
            btnActividades.ImageAlign = ContentAlignment.MiddleRight;
            btnActividades.Location = new Point(0, 277);
            btnActividades.Margin = new Padding(3, 2, 3, 2);
            btnActividades.Name = "btnActividades";
            btnActividades.Size = new Size(254, 34);
            btnActividades.TabIndex = 7;
            btnActividades.Text = "Actividades";
            btnActividades.TextAlign = ContentAlignment.MiddleLeft;
            btnActividades.UseVisualStyleBackColor = true;
            btnActividades.Click += btnActividades_Click;
            // 
            // subPanelnstalaciones
            // 
            subPanelnstalaciones.BackColor = Color.MediumPurple;
            subPanelnstalaciones.Controls.Add(btnManejarInstalaciones);
            subPanelnstalaciones.Dock = DockStyle.Top;
            subPanelnstalaciones.Location = new Point(0, 248);
            subPanelnstalaciones.Margin = new Padding(3, 2, 3, 2);
            subPanelnstalaciones.Name = "subPanelnstalaciones";
            subPanelnstalaciones.Padding = new Padding(4);
            subPanelnstalaciones.Size = new Size(254, 29);
            subPanelnstalaciones.TabIndex = 6;
            subPanelnstalaciones.Visible = false;
            // 
            // btnManejarInstalaciones
            // 
            btnManejarInstalaciones.Dock = DockStyle.Top;
            btnManejarInstalaciones.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnManejarInstalaciones.ForeColor = Color.FromArgb(64, 64, 64);
            btnManejarInstalaciones.ImageAlign = ContentAlignment.BottomLeft;
            btnManejarInstalaciones.Location = new Point(4, 4);
            btnManejarInstalaciones.Margin = new Padding(3, 2, 3, 2);
            btnManejarInstalaciones.Name = "btnManejarInstalaciones";
            btnManejarInstalaciones.Size = new Size(246, 22);
            btnManejarInstalaciones.TabIndex = 0;
            btnManejarInstalaciones.Text = "Manejar Instalaciones";
            btnManejarInstalaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnManejarInstalaciones.UseVisualStyleBackColor = true;
            btnManejarInstalaciones.Click += btnManejarInstalaciones_Click;
            // 
            // btnInstalaciones
            // 
            btnInstalaciones.Dock = DockStyle.Top;
            btnInstalaciones.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInstalaciones.Image = Properties.Resources.footbal_pitch;
            btnInstalaciones.ImageAlign = ContentAlignment.MiddleRight;
            btnInstalaciones.Location = new Point(0, 214);
            btnInstalaciones.Margin = new Padding(3, 2, 3, 2);
            btnInstalaciones.Name = "btnInstalaciones";
            btnInstalaciones.Size = new Size(254, 34);
            btnInstalaciones.TabIndex = 5;
            btnInstalaciones.Text = "Instalaciones";
            btnInstalaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnInstalaciones.UseVisualStyleBackColor = true;
            btnInstalaciones.Click += btnInstalaciones_Click;
            // 
            // subPanelProductos
            // 
            subPanelProductos.BackColor = Color.MediumPurple;
            subPanelProductos.Controls.Add(btnCompraProducto);
            subPanelProductos.Controls.Add(btnAdministrarProductos);
            subPanelProductos.Dock = DockStyle.Top;
            subPanelProductos.Location = new Point(0, 162);
            subPanelProductos.Margin = new Padding(3, 2, 3, 2);
            subPanelProductos.Name = "subPanelProductos";
            subPanelProductos.Padding = new Padding(4);
            subPanelProductos.Size = new Size(254, 52);
            subPanelProductos.TabIndex = 4;
            subPanelProductos.Visible = false;
            // 
            // btnCompraProducto
            // 
            btnCompraProducto.Dock = DockStyle.Top;
            btnCompraProducto.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompraProducto.ForeColor = Color.FromArgb(64, 64, 64);
            btnCompraProducto.ImageAlign = ContentAlignment.BottomLeft;
            btnCompraProducto.Location = new Point(4, 26);
            btnCompraProducto.Margin = new Padding(3, 2, 3, 2);
            btnCompraProducto.Name = "btnCompraProducto";
            btnCompraProducto.Size = new Size(246, 22);
            btnCompraProducto.TabIndex = 3;
            btnCompraProducto.Text = "Compra Productos";
            btnCompraProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnCompraProducto.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarProductos
            // 
            btnAdministrarProductos.Dock = DockStyle.Top;
            btnAdministrarProductos.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministrarProductos.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdministrarProductos.ImageAlign = ContentAlignment.BottomLeft;
            btnAdministrarProductos.Location = new Point(4, 4);
            btnAdministrarProductos.Margin = new Padding(3, 2, 3, 2);
            btnAdministrarProductos.Name = "btnAdministrarProductos";
            btnAdministrarProductos.Size = new Size(246, 22);
            btnAdministrarProductos.TabIndex = 2;
            btnAdministrarProductos.Text = "Administrar Productos";
            btnAdministrarProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnAdministrarProductos.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.Image = Properties.Resources.product;
            btnProductos.ImageAlign = ContentAlignment.MiddleRight;
            btnProductos.Location = new Point(0, 128);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(254, 34);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnManejoSocios
            // 
            btnManejoSocios.Dock = DockStyle.Top;
            btnManejoSocios.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnManejoSocios.Image = Properties.Resources.socio;
            btnManejoSocios.ImageAlign = ContentAlignment.MiddleRight;
            btnManejoSocios.Location = new Point(0, 94);
            btnManejoSocios.Margin = new Padding(3, 2, 3, 2);
            btnManejoSocios.Name = "btnManejoSocios";
            btnManejoSocios.Size = new Size(254, 34);
            btnManejoSocios.TabIndex = 1;
            btnManejoSocios.Text = "Administrar Socios";
            btnManejoSocios.TextAlign = ContentAlignment.MiddleLeft;
            btnManejoSocios.UseVisualStyleBackColor = true;
            btnManejoSocios.Click += btnManejoSocios_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.MediumSlateBlue;
            panelLogo.Controls.Add(lblTituloClub);
            panelLogo.Controls.Add(picboxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(254, 94);
            panelLogo.TabIndex = 0;
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
            // picboxEmpleado
            // 
            picboxEmpleado.Location = new Point(50, 50);
            picboxEmpleado.Margin = new Padding(3, 2, 3, 2);
            picboxEmpleado.Name = "picboxEmpleado";
            picboxEmpleado.Size = new Size(246, 201);
            picboxEmpleado.SizeMode = PictureBoxSizeMode.Zoom;
            picboxEmpleado.TabIndex = 3;
            picboxEmpleado.TabStop = false;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.DarkRed;
            lblMenu.Location = new Point(395, 77);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(296, 51);
            lblMenu.TabIndex = 4;
            lblMenu.Text = "Menu Empleado";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(picboxEmpleado);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(395, 139);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 298);
            panel1.TabIndex = 5;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbCerrarSesion });
            toolStrip1.Location = new Point(254, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(644, 25);
            toolStrip1.TabIndex = 7;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbCerrarSesion
            // 
            tsbCerrarSesion.ForeColor = SystemColors.HotTrack;
            tsbCerrarSesion.Image = Properties.Resources.logout_icon;
            tsbCerrarSesion.ImageTransparentColor = Color.Magenta;
            tsbCerrarSesion.Name = "tsbCerrarSesion";
            tsbCerrarSesion.Size = new Size(96, 22);
            tsbCerrarSesion.Text = "Cerrar Sesion";
            tsbCerrarSesion.Click += tsbCerrarSesion_Click;
            // 
            // MenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 553);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(lblMenu);
            Controls.Add(panelMenuLateral);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuEmpleado";
            Text = "Menu Empleado";
            Load += MenuEmpleado_Load;
            panelMenuLateral.ResumeLayout(false);
            subPanelActividades.ResumeLayout(false);
            subPanelnstalaciones.ResumeLayout(false);
            subPanelProductos.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxEmpleado).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDni;
        private ToolTip toolTip1;
        private Panel panelMenuLateral;
        private Button btnProductos;
        private Button btnManejoSocios;
        private Panel panelLogo;
        private PictureBox picboxEmpleado;
        private Button btnInstalaciones;
        private Panel subPanelnstalaciones;
        private Button btnManejarInstalaciones;
        private Panel subPanelActividades;
        private Button btnAdministrarActividades;
        private Button btnActividades;
        private Label lblMenu;
        private Panel subPanelProductos;
        private Button button2;
        private Button button3;
        private Button btnCompraProducto;
        private Button btnAdministrarProductos;
        private Button btnAdministrarProfes;
        private Button btnReporteActividades;
        private Label lblTituloClub;
        private PictureBox picboxLogo;
        private Panel panel1;
        private Button btnMiCuenta;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbCerrarSesion;
    }
}