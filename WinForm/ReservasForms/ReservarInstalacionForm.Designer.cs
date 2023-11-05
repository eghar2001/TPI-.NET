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
            dgvInstalaciones.Location = new Point(378, 71);
            dgvInstalaciones.Margin = new Padding(3, 4, 3, 4);
            dgvInstalaciones.Name = "dgvInstalaciones";
            dgvInstalaciones.ReadOnly = true;
            dgvInstalaciones.RowHeadersWidth = 51;
            dgvInstalaciones.RowTemplate.Height = 25;
            dgvInstalaciones.Size = new Size(1050, 448);
            dgvInstalaciones.TabIndex = 0;
            dgvInstalaciones.CellClick += dgvInstalaciones_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(13, 71);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(243, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "INGRESE FECHA Y HORA DE INICIO";
            // 
            // dateTimePickerInicio
            // 
            dateTimePickerInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerInicio.Format = DateTimePickerFormat.Custom;
            dateTimePickerInicio.Location = new Point(14, 95);
            dateTimePickerInicio.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerInicio.Name = "dateTimePickerInicio";
            dateTimePickerInicio.Size = new Size(228, 27);
            dateTimePickerInicio.TabIndex = 10;
            // 
            // btnBuscar_
            // 
            btnBuscar_.Location = new Point(13, 332);
            btnBuscar_.Margin = new Padding(3, 4, 3, 4);
            btnBuscar_.Name = "btnBuscar_";
            btnBuscar_.Size = new Size(86, 31);
            btnBuscar_.TabIndex = 13;
            btnBuscar_.Text = "Buscar";
            btnBuscar_.UseVisualStyleBackColor = true;
            btnBuscar_.Click += btnBuscar__Click_1;
            // 
            // txtCant
            // 
            txtCant.Location = new Point(205, 260);
            txtCant.Margin = new Padding(3, 4, 3, 4);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(51, 27);
            txtCant.TabIndex = 14;
            txtCant.KeyPress += txtCant_KeyPress;
            // 
            // lblCant
            // 
            lblCant.AutoSize = true;
            lblCant.Location = new Point(13, 263);
            lblCant.Name = "lblCant";
            lblCant.Size = new Size(158, 20);
            lblCant.TabIndex = 15;
            lblCant.Text = "Cantidad de asistentes";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(719, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 41);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "INSTALACIONES DISPONIBLES";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(205, 197);
            txtDuracion.Margin = new Padding(3, 4, 3, 4);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(51, 27);
            txtDuracion.TabIndex = 17;
            txtDuracion.KeyPress += txtDuracion_KeyPress;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(13, 197);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(69, 20);
            lblDuracion.TabIndex = 18;
            lblDuracion.Text = "Duracion";
            // 
            // ReservarInstalacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1447, 831);
            Controls.Add(lblDuracion);
            Controls.Add(txtDuracion);
            Controls.Add(lblTitle);
            Controls.Add(lblCant);
            Controls.Add(txtCant);
            Controls.Add(btnBuscar_);
            Controls.Add(dateTimePickerInicio);
            Controls.Add(lblTitulo);
            Controls.Add(dgvInstalaciones);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReservarInstalacionForm";
            Text = "Reservar Instalacion";
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