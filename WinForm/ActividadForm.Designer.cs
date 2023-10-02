namespace WinForm
{
    partial class ActividadForm
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
            lblErrorDescripcion = new Label();
            lblErrorNombre = new Label();
            lblErrorPrecio = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblTitulo = new Label();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblErrorDescripcion
            // 
            lblErrorDescripcion.AutoSize = true;
            lblErrorDescripcion.ForeColor = Color.Firebrick;
            lblErrorDescripcion.Location = new Point(281, 370);
            lblErrorDescripcion.Name = "lblErrorDescripcion";
            lblErrorDescripcion.Size = new Size(140, 15);
            lblErrorDescripcion.TabIndex = 19;
            lblErrorDescripcion.Text = " Texto Error   Descripcion ";
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.ForeColor = Color.Firebrick;
            lblErrorNombre.Location = new Point(281, 106);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(173, 15);
            lblErrorNombre.TabIndex = 18;
            lblErrorNombre.Text = " Texto error  Nombre                   ";
            // 
            // lblErrorPrecio
            // 
            lblErrorPrecio.AutoSize = true;
            lblErrorPrecio.ForeColor = Color.Firebrick;
            lblErrorPrecio.Location = new Point(281, 169);
            lblErrorPrecio.Name = "lblErrorPrecio";
            lblErrorPrecio.Size = new Size(141, 15);
            lblErrorPrecio.TabIndex = 17;
            lblErrorPrecio.Text = " Texto Error   Precio           ";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(281, 143);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(141, 23);
            txtPrecio.TabIndex = 16;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(161, 146);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(281, 205);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(362, 153);
            txtDescripcion.TabIndex = 14;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(161, 208);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 13;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(161, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(281, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(362, 23);
            txtNombre.TabIndex = 11;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(281, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(137, 32);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Titulo Form";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(568, 398);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // ActividadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(lblErrorDescripcion);
            Controls.Add(lblErrorNombre);
            Controls.Add(lblErrorPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTitulo);
            MaximizeBox = false;
            Name = "ActividadForm";
            Text = "Agregar Actividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblErrorDescripcion;
        private Label lblErrorNombre;
        private Label lblErrorPrecio;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblTitulo;
        private Button btnGuardar;
    }
}