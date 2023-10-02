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
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(59, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(74, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(159, 105);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(193, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // listadoInstalaciones
            // 
            listadoInstalaciones.AutoSize = true;
            listadoInstalaciones.Instalaciones = null;
            listadoInstalaciones.InstalacionSeleccionada = null;
            listadoInstalaciones.Location = new Point(78, 165);
            listadoInstalaciones.Name = "listadoInstalaciones";
            listadoInstalaciones.Size = new Size(640, 427);
            listadoInstalaciones.TabIndex = 2;
            // 
            // TurnoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 592);
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
    }
}