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
            listboxProfesores.ItemHeight = 15;
            listboxProfesores.Location = new Point(0, 70);
            listboxProfesores.Margin = new Padding(3, 2, 3, 2);
            listboxProfesores.Name = "listboxProfesores";
            listboxProfesores.Size = new Size(598, 229);
            listboxProfesores.TabIndex = 3;
            listboxProfesores.SelectedIndexChanged += listboxProfesores_SelectedIndexChanged;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.Thistle;
            pnlBusqueda.Controls.Add(btnLimpiar);
            pnlBusqueda.Controls.Add(txtFiltrar);
            pnlBusqueda.Controls.Add(lblFiltrar);
            pnlBusqueda.Dock = DockStyle.Bottom;
            pnlBusqueda.Location = new Point(0, 0);
            pnlBusqueda.Margin = new Padding(3, 2, 3, 2);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(598, 70);
            pnlBusqueda.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(502, 41);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(82, 22);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtFiltrar
            // 
            txtFiltrar.Location = new Point(195, 9);
            txtFiltrar.Margin = new Padding(3, 2, 3, 2);
            txtFiltrar.Name = "txtFiltrar";
            txtFiltrar.Size = new Size(390, 23);
            txtFiltrar.TabIndex = 6;
            txtFiltrar.TextChanged += txtTitulo_TextChanged;
            // 
            // lblFiltrar
            // 
            lblFiltrar.AutoSize = true;
            lblFiltrar.ForeColor = SystemColors.ControlText;
            lblFiltrar.Location = new Point(10, 11);
            lblFiltrar.Name = "lblFiltrar";
            lblFiltrar.Size = new Size(161, 15);
            lblFiltrar.TabIndex = 5;
            lblFiltrar.Text = "Filtrar por Nombre y Apellido";
            // 
            // ListadoProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(pnlBusqueda);
            Controls.Add(listboxProfesores);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListadoProfesores";
            Size = new Size(598, 299);
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
