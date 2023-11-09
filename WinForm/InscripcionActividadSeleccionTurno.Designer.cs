namespace WinForm
{
    partial class InscripcionActividadSeleccionTurno
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
            dgvTurnos = new DataGridView();
            btnCancelar = new Button();
            lblTitulo = new Label();
            lblActividad = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // dgvTurnos
            // 
            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.AllowUserToResizeColumns = false;
            dgvTurnos.AllowUserToResizeRows = false;
            dgvTurnos.BackgroundColor = SystemColors.ScrollBar;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.GridColor = SystemColors.ScrollBar;
            dgvTurnos.Location = new Point(56, 146);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTurnos.Size = new Size(1150, 259);
            dgvTurnos.TabIndex = 11;
            dgvTurnos.CellContentClick += dgvTurnos_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1131, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(56, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 32);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Seleccionar turno";
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblActividad.Location = new Point(56, 74);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(81, 21);
            lblActividad.TabIndex = 16;
            lblActividad.Text = "Actividad: ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(879, 74);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 21);
            lblPrecio.TabIndex = 17;
            lblPrecio.Text = "Precio:";
            // 
            // InscripcionActividadSeleccionTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 474);
            Controls.Add(lblPrecio);
            Controls.Add(lblActividad);
            Controls.Add(lblTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(dgvTurnos);
            Name = "InscripcionActividadSeleccionTurno";
            Text = "Inscripcion a Actividad";
            Load += ReservarTurnoActividad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTurnos;
        private Button btnCancelar;
        private Label lblTitulo;
        private Label lblActividad;
        private Label lblPrecio;
    }
}