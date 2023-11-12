namespace WinForm
{
    partial class ReservarInstalacionForm
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
            dgvInstalaciones = new DataGridView();
            lblTitulo = new Label();
            dateTimePickerInicio = new DateTimePicker();
            btnBuscar_ = new Button();
            txtCant = new TextBox();
            lblCant = new Label();
            lblTitle = new Label();
            txtDuracion = new TextBox();
            lblDuracion = new Label();
            pnlMenu = new Panel();
            panel1 = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInstalaciones).BeginInit();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvInstalaciones
            // 
            dgvInstalaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstalaciones.Location = new Point(263, 155);
            dgvInstalaciones.Name = "dgvInstalaciones";
            dgvInstalaciones.ReadOnly = true;
            dgvInstalaciones.RowTemplate.Height = 25;
            dgvInstalaciones.Size = new Size(442, 336);
            dgvInstalaciones.TabIndex = 0;
            dgvInstalaciones.CellClick += dgvInstalaciones_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 155);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "INGRESE FECHA Y HORA DE INICIO";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.CustomFormat = "dd/MM/yyyy h:mm";
            dateTimePickerInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerInicio.Location = new Point(13, 173);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(176, 23);
            dateTimePickerInicio.TabIndex = 10;
            // 
            // btnBuscar_
            // 
            btnBuscar_.Location = new Point(12, 319);
            btnBuscar_.Name = "btnBuscar_";
            btnBuscar_.Size = new Size(75, 23);
            btnBuscar_.TabIndex = 13;
            btnBuscar_.Text = "Buscar";
            btnBuscar_.UseVisualStyleBackColor = true;
            btnBuscar_.Click += btnBuscar__Click_1;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(144, 266);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(45, 23);
            txtCant.TabIndex = 14;
            txtCant.KeyPress += txtCant_KeyPress;
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Location = new Point(13, 269);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(125, 15);
            lblCant.TabIndex = 15;
            lblCant.Text = "Cantidad de asistentes";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(263, 108);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 32);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "INSTALACIONES DISPONIBLES";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(144, 220);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(45, 23);
            txtDuracion.TabIndex = 17;
            txtDuracion.KeyPress += txtDuracion_KeyPress;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(13, 223);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(55, 15);
            lblDuracion.TabIndex = 18;
            lblDuracion.Text = "Duracion";
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MediumPurple;
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(picboxLogo);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(731, 89);
            pnlMenu.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(589, 0);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(106, 24);
            label1.Name = "label1";
            label1.Size = new Size(334, 32);
            label1.TabIndex = 2;
            label1.Text = "Menu Administrar Actividades";
            // 
            // ReservarInstalacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(731, 514);
            Controls.Add(pnlMenu);
            Controls.Add(lblDuracion);
            Controls.Add(txtDuracion);
            Controls.Add(lblTitle);
            Controls.Add(lblCant);
            Controls.Add(txtCant);
            Controls.Add(btnBuscar_);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(lblTitulo);
            Controls.Add(dgvInstalaciones);
            Name = "ReservarInstalacionForm";
            Text = "ReservarInstalacionForm";
            Load += ReservarInstalacionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInstalaciones).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInstalaciones;
        private Label lblTitulo;
        private ComboBox comboBoxHora;
        private ComboBox comboBoxMinutos;
        private Button btnBuscar;
        private ComboBox comboBoxHoraFin;
        private ComboBox comboBoxMinutosFin;
        private DateTimePicker dateTimePickerInicio;
        private Button btnBuscar_;
        private TextBox txtCant;
        private Label lblCant;
        private Label lblTitle;
        private TextBox txtDuracion;
        private Label lblDuracion;
        private Panel pnlMenu;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label label1;
    }
}