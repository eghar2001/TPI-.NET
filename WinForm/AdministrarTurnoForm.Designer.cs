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
            lblNombreActividad = new Label();
            lblProfesor = new Label();
            lblHorarios = new Label();
            listboxHorarios = new ListBox();
            lblAlertaBorrado = new Label();
            btnAgregar = new Button();
            lblUbicacion = new Label();
            lblPrecio = new Label();
            SuspendLayout();
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.Location = new Point(96, 56);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(0, 20);
            lblActividad.TabIndex = 0;
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreActividad.ForeColor = SystemColors.HotTrack;
            lblNombreActividad.Location = new Point(86, 76);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(342, 43);
            lblNombreActividad.TabIndex = 1;
            lblNombreActividad.Text = "Nombre Actividad";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(96, 194);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(64, 20);
            lblProfesor.TabIndex = 4;
            lblProfesor.Text = "Profesor";
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorarios.Location = new Point(96, 250);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(93, 28);
            lblHorarios.TabIndex = 5;
            lblHorarios.Text = "Horarios";
            // 
            // listboxHorarios
            // 
            listboxHorarios.FormattingEnabled = true;
            listboxHorarios.ItemHeight = 20;
            listboxHorarios.Location = new Point(96, 291);
            listboxHorarios.Name = "listboxHorarios";
            listboxHorarios.Size = new Size(716, 184);
            listboxHorarios.TabIndex = 7;
            listboxHorarios.SelectedIndexChanged += listboxHorarios_SelectedIndexChanged;
            // 
            // lblAlertaBorrado
            // 
            lblAlertaBorrado.AutoSize = true;
            lblAlertaBorrado.ForeColor = SystemColors.GrayText;
            lblAlertaBorrado.Location = new Point(96, 478);
            lblAlertaBorrado.Name = "lblAlertaBorrado";
            lblAlertaBorrado.Size = new Size(245, 20);
            lblAlertaBorrado.TabIndex = 8;
            lblAlertaBorrado.Text = "Click en algun horario para borrarlo";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(96, 522);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUbicacion.Location = new Point(96, 136);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(89, 25);
            lblUbicacion.TabIndex = 10;
            lblUbicacion.Text = "Ubicacion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(746, 133);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(66, 28);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio";
            // 
            // AdministrarTurnoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 708);
            Controls.Add(lblPrecio);
            Controls.Add(lblUbicacion);
            Controls.Add(btnAgregar);
            Controls.Add(lblAlertaBorrado);
            Controls.Add(listboxHorarios);
            Controls.Add(lblHorarios);
            Controls.Add(lblProfesor);
            Controls.Add(lblNombreActividad);
            Controls.Add(lblActividad);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdministrarTurnoForm";
            Text = "TurnoForm";
            Load += TurnoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblActividad;
        private Label lblNombreActividad;
        private Label lblProfesor;
        private Label lblHorarios;
        private ListBox listboxHorarios;
        private Label lblAlertaBorrado;
        private Button btnAgregar;
        private Label lblUbicacion;
        private Label lblPrecio;
    }
}