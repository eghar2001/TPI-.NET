namespace WinForm.Componentes
{
    partial class ListadoInstalaciones
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblFiltrar = new Label();
            txtTitulo = new TextBox();
            listboxInstalaciones = new ListBox();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Location = new Point(16, 32);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(120, 20);
            lblFiltrar.TabIndex = 1;
            lblFiltrar.Text = "Filtrar por titulo: ";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(182, 32);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(445, 27);
            txtTitulo.TabIndex = 2;
            txtTitulo.TextChanged += textBox1_TextChanged;
            // 
            // listboxInstalaciones
            // 
            listboxInstalaciones.Dock = DockStyle.Bottom;
            listboxInstalaciones.FormattingEnabled = true;
            listboxInstalaciones.ItemHeight = 20;
            listboxInstalaciones.Location = new Point(0, 141);
            listboxInstalaciones.Name = "listboxInstalaciones";
            listboxInstalaciones.Size = new Size(643, 304);
            listboxInstalaciones.TabIndex = 3;
            listboxInstalaciones.SelectedIndexChanged += listboxInstalaciones_SelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(533, 92);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Reset";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ListadoInstalaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(btnLimpiar);
            Controls.Add(listboxInstalaciones);
            Controls.Add(txtTitulo);
            Controls.Add(lblFiltrar);
            Name = "ListadoInstalaciones";
            Size = new Size(643, 445);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFiltrar;
        private TextBox txtTitulo;
        private ListBox listboxInstalaciones;
        private Button btnLimpiar;
    }
}
