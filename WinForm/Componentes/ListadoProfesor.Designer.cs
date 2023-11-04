namespace WinForm.Componentes
{
    partial class ListadoProfesores
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
            listboxProfesores = new ListBox();
            pnlBusqueda = new Panel();
            btnLimpiar = new Button();
            txtFiltrar = new TextBox();
            lblFiltrar = new Label();
            pnlBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // listboxProfesores
            // 
            listboxProfesores.Dock = DockStyle.Bottom;
            listboxProfesores.FormattingEnabled = true;
            listboxProfesores.ItemHeight = 20;
            listboxProfesores.Location = new Point(0, 94);
            listboxProfesores.Name = "listboxProfesores";
            listboxProfesores.Size = new Size(683, 304);
            listboxProfesores.TabIndex = 3;
            listboxProfesores.SelectedIndexChanged += listboxProfesores_SelectedIndexChanged;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = SystemColors.ControlDark;
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(txtFiltrar);
            pnlBusqueda.Controls.Add(lblFiltrar);
            pnlBusqueda.Dock = DockStyle.Bottom;
            pnlBusqueda.Location = new Point(0, 0);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(683, 94);
            pnlBusqueda.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(574, 55);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Location = new Point(223, 12);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(445, 27);
            txtFiltrar.TabIndex = 6;
            txtFiltrar.TextChanged += txtTitulo_TextChanged;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.Location = new Point(12, 15);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(205, 20);
            lblFiltrar.TabIndex = 5;
            lblFiltrar.Text = "Filtrar por Nombre y Apellido";
            // 
            // ListadoProfesores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(pnlBusqueda);
            Controls.Add(listboxProfesores);
            Name = "ListadoProfesores";
            Size = new Size(683, 398);
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listboxProfesores;
        private Panel pnlBusqueda;
        private TextBox txtFiltrar;
        private Label lblFiltrar;
        private Button btnLimpiar;
    }
}
