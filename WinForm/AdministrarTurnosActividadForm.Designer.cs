namespace WinForm
{
    partial class AdministrarTurnosActividadForm
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
            lblNombreActividad = new Label();
            lblPrecioActividad = new Label();
            lblDescripcion = new Label();
            dgvTurnos = new DataGridView();
            Turnos = new Label();
            btnAgregarTurno = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreActividad.ForeColor = SystemColors.HotTrack;
            lblNombreActividad.Location = new Point(55, 39);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(269, 33);
            lblNombreActividad.TabIndex = 0;
            lblNombreActividad.Text = "Nombre Actividad";
            // 
            // lblPrecioActividad
            // 
            lblPrecioActividad.AutoSize = true;
            lblPrecioActividad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioActividad.Location = new Point(591, 96);
            lblPrecioActividad.Name = "lblPrecioActividad";
            lblPrecioActividad.Size = new Size(163, 25);
            lblPrecioActividad.TabIndex = 1;
            lblPrecioActividad.Text = "$ Precio Actividad";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(55, 100);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(154, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion Actividad";
            // 
            // dgvTurnos
            // 
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(55, 224);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowHeadersWidth = 51;
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.Size = new Size(892, 219);
            dgvTurnos.TabIndex = 3;
            dgvTurnos.CellClick += dgvTurnos_CellClick;
            // 
            // Turnos
            // 
            Turnos.AutoSize = true;
            Turnos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Turnos.Location = new Point(55, 191);
            Turnos.Name = "Turnos";
            Turnos.Size = new Size(58, 21);
            Turnos.TabIndex = 4;
            Turnos.Text = "Turnos";
            // 
            // btnAgregarTurno
            // 
            btnAgregarTurno.Location = new Point(55, 466);
            btnAgregarTurno.Name = "btnAgregarTurno";
            btnAgregarTurno.Size = new Size(99, 23);
            btnAgregarTurno.TabIndex = 5;
            btnAgregarTurno.Text = "Agregar Turno";
            btnAgregarTurno.UseVisualStyleBackColor = true;
            btnAgregarTurno.Click += btnAgregarTurno_Click;
            // 
            // AdministrarTurnosActividadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1029, 590);
            Controls.Add(btnAgregarTurno);
            Controls.Add(Turnos);
            Controls.Add(dgvTurnos);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrecioActividad);
            Controls.Add(lblNombreActividad);
            Name = "AdministrarTurnosActividadForm";
            Text = "Turnos";
            Load += AdministrarTurnosActividadForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreActividad;
        private Label lblPrecioActividad;
        private Label lblDescripcion;
        private DataGridView dgvTurnos;
        private Label Turnos;
        private Button btnAgregarTurno;
    }
}