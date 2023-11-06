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
            ((System.ComponentModel.ISupportInitialize)dgvInstalaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvInstalaciones
            // 
            dgvInstalaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstalaciones.Location = new Point(262, 53);
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
            lblTitulo.Location = new Point(11, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "INGRESE FECHA Y HORA DE INICIO";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.CustomFormat = "dd/MM/yyyy h:mm";
            dateTimePickerInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerInicio.Location = new Point(12, 71);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(176, 23);
            dateTimePickerInicio.TabIndex = 10;
            // 
            // btnBuscar_
            // 
            btnBuscar_.Location = new Point(11, 217);
            btnBuscar_.Name = "btnBuscar_";
            btnBuscar_.Size = new Size(75, 23);
            btnBuscar_.TabIndex = 13;
            btnBuscar_.Text = "Buscar";
            btnBuscar_.UseVisualStyleBackColor = true;
            btnBuscar_.Click += btnBuscar__Click_1;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(143, 164);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(45, 23);
            txtCant.TabIndex = 14;
            txtCant.KeyPress += txtCant_KeyPress;
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Location = new Point(12, 167);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(125, 15);
            lblCant.TabIndex = 15;
            lblCant.Text = "Cantidad de asistentes";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(317, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 32);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "INSTALACIONES DISPONIBLES";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(143, 118);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(45, 23);
            txtDuracion.TabIndex = 17;
            txtDuracion.KeyPress += txtDuracion_KeyPress;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(12, 121);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(55, 15);
            lblDuracion.TabIndex = 18;
            lblDuracion.Text = "Duracion";
            // 
            // ReservarInstalacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(731, 410);
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
    }
}