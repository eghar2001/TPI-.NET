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
            listboxInstalaciones = new ListBox();
            pnlBusqueda = new Panel();
            btnLimpiar = new Button();
            txtTitulo = new TextBox();
            lblFiltrar = new Label();
            pnlBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // listboxInstalaciones
            // 
            listboxInstalaciones.Dock = DockStyle.Bottom;
            listboxInstalaciones.FormattingEnabled = true;
            listboxInstalaciones.ItemHeight = 15;
            listboxInstalaciones.Location = new Point(0, 89);
            listboxInstalaciones.Name = "listboxInstalaciones";
            listboxInstalaciones.Size = new Size(660, 304);
            listboxInstalaciones.TabIndex = 3;
            listboxInstalaciones.SelectedIndexChanged += listboxInstalaciones_SelectedIndexChanged;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.Thistle;
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(txtTitulo);
            pnlBusqueda.Controls.Add(lblFiltrar);
            pnlBusqueda.Dock = DockStyle.Bottom;
            pnlBusqueda.Location = new Point(0, 0);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(660, 89);
            pnlBusqueda.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(533, 45);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(182, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(445, 23);
            txtTitulo.TabIndex = 6;
            txtTitulo.TextChanged += txtTitulo_TextChanged;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.BackColor = Color.Thistle;
            lblFiltrar.ForeColor = SystemColors.ControlText;
            lblFiltrar.Location = new Point(16, 12);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(95, 15);
            lblFiltrar.TabIndex = 5;
            lblFiltrar.Text = "Filtrar por titulo: ";
            // 
            // ListadoInstalaciones
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSize = true;
            Controls.Add(pnlBusqueda);
            Controls.Add(listboxInstalaciones);
            Name = "ListadoInstalaciones";
            Size = new Size(660, 393);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listboxInstalaciones;
        private Panel pnlBusqueda;
        private TextBox txtTitulo;
        private Label lblFiltrar;
        private Button btnLimpiar;
    }
}
