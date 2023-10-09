namespace WinForm
{
    partial class TurnoForm
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
            lblTitulo = new Label();
            txtDescripcion = new TextBox();
            listadoInstalaciones = new Componentes.ListadoInstalaciones();
            listadoProfesores = new Componentes.ListadoProfesores();
            lblDescripcion = new Label();
            LblInstalacion = new Label();
            lblProfesor = new Label();
            btnGuardar = new Button();
            lblErrorDescripcion = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(108, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(92, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(258, 113);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(548, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // listadoInstalaciones
            // 
            listadoInstalaciones.AutoSize = true;
            listadoInstalaciones.Instalaciones = null;
            listadoInstalaciones.InstalacionSeleccionada = null;
            listadoInstalaciones.Location = new Point(108, 202);
            listadoInstalaciones.Name = "listadoInstalaciones";
            listadoInstalaciones.Size = new Size(698, 93);
            listadoInstalaciones.TabIndex = 2;
            // 
            // listadoProfesores
            // 
            listadoProfesores.AutoSize = true;
            listadoProfesores.Location = new Point(108, 545);
            listadoProfesores.Name = "listadoProfesores";
            listadoProfesores.Profesores = null;
            listadoProfesores.ProfesorSeleccionado = null;
            listadoProfesores.Size = new Size(698, 98);
            listadoProfesores.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(108, 112);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(118, 28);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion:";
            // 
            // LblInstalacion
            // 
            LblInstalacion.AutoSize = true;
            LblInstalacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblInstalacion.Location = new Point(108, 171);
            LblInstalacion.Name = "LblInstalacion";
            LblInstalacion.Size = new Size(105, 28);
            LblInstalacion.TabIndex = 5;
            LblInstalacion.Text = "Instalacion";
            // 
            // lblProfesor
            // 
            lblProfesor.AutoSize = true;
            lblProfesor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfesor.Location = new Point(108, 514);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(85, 28);
            lblProfesor.TabIndex = 6;
            lblProfesor.Text = "Profesor";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(712, 771);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblErrorDescripcion
            // 
            lblErrorDescripcion.AutoSize = true;
            lblErrorDescripcion.ForeColor = Color.Red;
            lblErrorDescripcion.Location = new Point(108, 151);
            lblErrorDescripcion.Name = "lblErrorDescripcion";
            lblErrorDescripcion.Size = new Size(123, 20);
            lblErrorDescripcion.TabIndex = 8;
            lblErrorDescripcion.Text = "Error Descripcion";
            // 
            // TurnoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 841);
            Controls.Add(lblErrorDescripcion);
            Controls.Add(btnGuardar);
            Controls.Add(lblProfesor);
            Controls.Add(LblInstalacion);
            Controls.Add(lblDescripcion);
            Controls.Add(listadoProfesores);
            Controls.Add(listadoInstalaciones);
            Controls.Add(txtDescripcion);
            Controls.Add(lblTitulo);
            Name = "TurnoForm";
            Text = "TurnoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtDescripcion;
        private Componentes.ListadoInstalaciones listadoInstalaciones;
        private Componentes.ListadoProfesores listadoProfesores;
        private Label lblDescripcion;
        private Label LblInstalacion;
        private Label lblProfesor;
        private Button btnGuardar;
        private Label lblErrorDescripcion;
    }
}