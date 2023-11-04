namespace WinForm
{
    partial class ProfesorForm
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtSalario = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblSalario = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(200, 114);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(200, 169);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(200, 221);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(114, 117);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(114, 177);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(114, 224);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(45, 15);
            lblSalario.TabIndex = 5;
            lblSalario.Text = "Salario:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(382, 319);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(463, 319);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(261, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(80, 22);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "TITULO";
            // 
            // ProfesorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblSalario);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtSalario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "ProfesorForm";
            Text = "ProfesorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtSalario;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblSalario;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblTitulo;
    }
}