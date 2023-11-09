namespace WinForm
{
    partial class InscripcionTurnoSocio
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
            lblPrecio = new Label();
            lblUbicacion = new Label();
            btnInscribirse = new Button();
            listboxHorarios = new ListBox();
            lblHorarios = new Label();
            lblProfesor = new Label();
            lblNombreActividad = new Label();
            btnCerrrar = new Button();
            SuspendLayout();
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(640, 70);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 21);
            lblPrecio.TabIndex = 19;
            lblPrecio.Text = "Precio";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUbicacion.Location = new Point(71, 72);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(75, 20);
            lblUbicacion.TabIndex = 18;
            lblUbicacion.Text = "Ubicacion";
            // 
            // btnInscribirse
            // 
            btnInscribirse.Location = new Point(71, 408);
            btnInscribirse.Margin = new Padding(3, 2, 3, 2);
            btnInscribirse.Name = "btnInscribirse";
            btnInscribirse.Size = new Size(82, 22);
            btnInscribirse.TabIndex = 17;
            btnInscribirse.Text = "Inscribirse";
            btnInscribirse.UseVisualStyleBackColor = true;
            btnInscribirse.Click += btnInscribirse_Click;
            // 
            // listboxHorarios
            // 
            listboxHorarios.FormattingEnabled = true;
            listboxHorarios.ItemHeight = 15;
            listboxHorarios.Location = new Point(71, 188);
            listboxHorarios.Margin = new Padding(3, 2, 3, 2);
            listboxHorarios.Name = "listboxHorarios";
            listboxHorarios.Size = new Size(627, 169);
            listboxHorarios.TabIndex = 15;
            // 
            // lblHorarios
            // 
            lblHorarios.AutoSize = true;
            lblHorarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorarios.Location = new Point(71, 158);
            lblHorarios.Name = "lblHorarios";
            lblHorarios.Size = new Size(149, 21);
            lblHorarios.TabIndex = 14;
            lblHorarios.Text = "Horarios del turno";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Location = new Point(71, 116);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(51, 15);
            lblProfesor.TabIndex = 13;
            lblProfesor.Text = "Profesor";
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreActividad.ForeColor = SystemColors.HotTrack;
            lblNombreActividad.Location = new Point(62, 27);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(269, 33);
            lblNombreActividad.TabIndex = 12;
            lblNombreActividad.Text = "Nombre Actividad";
            // 
            // btnCerrrar
            // 
            btnCerrrar.Location = new Point(616, 394);
            btnCerrrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrrar.Name = "btnCerrrar";
            btnCerrrar.Size = new Size(82, 22);
            btnCerrrar.TabIndex = 20;
            btnCerrrar.Text = "Cerrar";
            btnCerrrar.UseVisualStyleBackColor = true;
            btnCerrrar.Click += btnCerrrar_Click;
            // 
            // InscripcionTurnoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 468);
            Controls.Add(btnCerrrar);
            Controls.Add(lblPrecio);
            Controls.Add(lblUbicacion);
            Controls.Add(btnInscribirse);
            Controls.Add(listboxHorarios);
            Controls.Add(lblHorarios);
            Controls.Add(lblProfesor);
            Controls.Add(lblNombreActividad);
            Name = "InscripcionTurnoSocio";
            Text = "Inscripcion a Actividad";
            Load += InscripcionTurnoSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecio;
        private Label lblUbicacion;
        private Button btnInscribirse;
        private ListBox listboxHorarios;
        private Label lblHorarios;
        private Label lblProfesor;
        private Label lblNombreActividad;
        private Button btnCerrrar;
    }
}