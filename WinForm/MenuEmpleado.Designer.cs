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
            subPanelActividades = new Panel();
            btnAdministrarProfesores = new Button();
            btnAdministrarActividades = new Button();
            btnActividades = new Button();
            subPanelnstalaciones = new Panel();
            btnManejarProductos = new Button();
            btnManejarInstalaciones = new Button();
            btnInstalaciones = new Button();
            subPanelProductos = new Panel();
            btnCompraProducto = new Button();
            btnAdministrarProductos = new Button();
            btnProductos = new Button();
            btnManejoSocios = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            pictureBox1 = new PictureBox();
            lblMenu = new Label();
            panelMenuLateral.SuspendLayout();
            subPanelActividades.SuspendLayout();
            subPanelnstalaciones.SuspendLayout();
            subPanelProductos.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Maroon;
            lblNombre.Location = new Point(536, 290);
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
            lblDni.Location = new Point(704, 322);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(43, 25);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.IndianRed;
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
            panelMenuLateral.Size = new Size(254, 451);
            panelMenuLateral.TabIndex = 2;
            // 
            // subPanelActividades
            // 
            subPanelActividades.BackColor = Color.Brown;
            subPanelActividades.Controls.Add(btnAdministrarProfesores);
            subPanelActividades.Controls.Add(btnAdministrarActividades);
            subPanelActividades.Dock = DockStyle.Top;
            subPanelActividades.Location = new Point(0, 319);
            subPanelActividades.Margin = new Padding(3, 2, 3, 2);
            subPanelActividades.Name = "subPanelActividades";
            subPanelActividades.Padding = new Padding(4, 4, 4, 4);
            subPanelActividades.Size = new Size(254, 53);
            subPanelActividades.TabIndex = 8;
            subPanelActividades.Visible = false;
            // 
            // btnAdministrarProfesores
            // 
            btnAdministrarProfesores.Dock = DockStyle.Top;
            btnAdministrarProfesores.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdministrarProfesores.ForeColor = Color.FromArgb(64, 64, 64);
            btnAdministrarProfesores.ImageAlign = ContentAlignment.BottomLeft;
            btnAdministrarProfesores.Location = new Point(4, 26);
            btnAdministrarProfesores.Margin = new Padding(3, 2, 3, 2);
            btnAdministrarProfesores.Name = "btnAdministrarProfesores";
            btnAdministrarProfesores.Size = new Size(246, 22);
            btnAdministrarProfesores.TabIndex = 1;
            btnAdministrarProfesores.Text = "Reporte Instalaciones\r\n";
            btnAdministrarProfesores.TextAlign = ContentAlignment.MiddleRight;
            btnAdministrarProfesores.UseVisualStyleBackColor = true;
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
            btnAdministrarActividades.TextAlign = ContentAlignment.MiddleRight;
            btnAdministrarActividades.UseVisualStyleBackColor = true;
            btnAdministrarActividades.Click += btnAdministrarActividades_Click;
            // 
            // btnActividades
            // 
            btnActividades.Dock = DockStyle.Top;
            btnActividades.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnActividades.Location = new Point(0, 285);
            btnActividades.Margin = new Padding(3, 2, 3, 2);
            btnActividades.Name = "btnActividades";
            btnActividades.Size = new Size(254, 34);
            btnActividades.TabIndex = 7;
            btnActividades.Text = "Actividades";
            btnActividades.TextAlign = ContentAlignment.MiddleRight;
            btnActividades.UseVisualStyleBackColor = true;
            btnActividades.Click += btnActividades_Click;
            // 
            // subPanelnstalaciones
            // 
            subPanelnstalaciones.BackColor = Color.Brown;
            subPanelnstalaciones.Controls.Add(btnManejarProductos);
            subPanelnstalaciones.Controls.Add(btnManejarInstalaciones);
            subPanelnstalaciones.Dock = DockStyle.Top;
            subPanelnstalaciones.Location = new Point(0, 231);
            subPanelnstalaciones.Margin = new Padding(3, 2, 3, 2);
            subPanelnstalaciones.Name = "subPanelnstalaciones";
            subPanelnstalaciones.Padding = new Padding(4, 4, 4, 4);
            subPanelnstalaciones.Size = new Size(254, 54);
            subPanelnstalaciones.TabIndex = 6;
            subPanelnstalaciones.Visible = false;
            // 
            // btnManejarProductos
            // 
            btnManejarProductos.Dock = DockStyle.Top;
            btnManejarProductos.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnManejarProductos.ForeColor = Color.FromArgb(64, 64, 64);
            btnManejarProductos.ImageAlign = ContentAlignment.BottomLeft;
            btnManejarProductos.Location = new Point(4, 26);
            btnManejarProductos.Margin = new Padding(3, 2, 3, 2);
            btnManejarProductos.Name = "btnManejarProductos";
            btnManejarProductos.Size = new Size(246, 22);
            btnManejarProductos.TabIndex = 1;
            btnManejarProductos.Text = "Reporte Instalaciones\r\n";
            btnManejarProductos.TextAlign = ContentAlignment.MiddleRight;
            btnManejarProductos.UseVisualStyleBackColor = true;
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
            btnManejarInstalaciones.TextAlign = ContentAlignment.MiddleRight;
            btnManejarInstalaciones.UseVisualStyleBackColor = true;
            // 
            // btnInstalaciones
            // 
            btnInstalaciones.Dock = DockStyle.Top;
            btnInstalaciones.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnInstalaciones.Location = new Point(0, 197);
            btnInstalaciones.Margin = new Padding(3, 2, 3, 2);
            btnInstalaciones.Name = "btnInstalaciones";
            btnInstalaciones.Size = new Size(254, 34);
            btnInstalaciones.TabIndex = 5;
            btnInstalaciones.Text = "Instalaciones";
            btnInstalaciones.TextAlign = ContentAlignment.MiddleRight;
            btnInstalaciones.UseVisualStyleBackColor = true;
            btnInstalaciones.Click += btnInstalaciones_Click;
            // 
            // subPanelProductos
            // 
            subPanelProductos.BackColor = Color.Brown;
            subPanelProductos.Controls.Add(btnCompraProducto);
            subPanelProductos.Controls.Add(btnAdministrarProductos);
            subPanelProductos.Dock = DockStyle.Top;
            subPanelProductos.Location = new Point(0, 145);
            subPanelProductos.Margin = new Padding(3, 2, 3, 2);
            subPanelProductos.Name = "subPanelProductos";
            subPanelProductos.Padding = new Padding(4, 4, 4, 4);
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
            btnCompraProducto.TextAlign = ContentAlignment.MiddleRight;
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
            btnAdministrarProductos.TextAlign = ContentAlignment.MiddleRight;
            btnAdministrarProductos.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductos.Location = new Point(0, 111);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(254, 34);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleRight;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnManejoSocios
            // 
            btnManejoSocios.Dock = DockStyle.Top;
            btnManejoSocios.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnManejoSocios.Location = new Point(0, 77);
            btnManejoSocios.Margin = new Padding(3, 2, 3, 2);
            btnManejoSocios.Name = "btnManejoSocios";
            btnManejoSocios.Size = new Size(254, 34);
            btnManejoSocios.TabIndex = 1;
            btnManejoSocios.Text = "Administrar Socios";
            btnManejoSocios.TextAlign = ContentAlignment.MiddleRight;
            btnManejoSocios.UseVisualStyleBackColor = true;
            btnManejoSocios.Click += btnManejoSocios_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(254, 77);
            panelLogo.TabIndex = 0;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(502, 77);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 201);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblMenu.Location = new Point(408, 9);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(312, 51);
            lblMenu.TabIndex = 4;
            lblMenu.Text = "Menu Empleados";
            // 
            // MenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 451);
            Controls.Add(lblMenu);
            Controls.Add(pictureBox1);
            Controls.Add(panelMenuLateral);
            Controls.Add(lblDni);
            Controls.Add(lblNombre);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuEmpleado";
            Text = "MenuEmpleado";
            Load += MenuEmpleado_Load;
            panelMenuLateral.ResumeLayout(false);
            subPanelActividades.ResumeLayout(false);
            subPanelnstalaciones.ResumeLayout(false);
            subPanelProductos.ResumeLayout(false);
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
        private Button btnProductos;
        private Button btnManejoSocios;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Button btnInstalaciones;
        private Panel subPanelnstalaciones;
        private Button btnManejarProductos;
        private Button btnManejarInstalaciones;
        private Panel subPanelActividades;
        private Button btnAdministrarProfesores;
        private Button btnAdministrarActividades;
        private Button btnActividades;
        private Label lblLogo;
        private Label lblMenu;
        private Panel subPanelProductos;
        private Button button2;
        private Button button3;
        private Button btnCompraProducto;
        private Button btnAdministrarProductos;
    }
}