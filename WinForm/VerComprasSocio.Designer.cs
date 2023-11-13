namespace WinForm
{
    partial class VerComprasSocio
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
            dgvProductos = new DataGridView();
            lblTitulo = new Label();
            btnCerrar = new Button();
            lblNombreUsuario = new Label();
            lblHistorialDeCompras = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 126);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(776, 269);
            dgvProductos.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(343, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(101, 45);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(713, 415);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(637, 98);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(151, 25);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblHistorialDeCompras
            // 
            lblHistorialDeCompras.AutoSize = true;
            lblHistorialDeCompras.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorialDeCompras.Location = new Point(12, 93);
            lblHistorialDeCompras.Name = "lblHistorialDeCompras";
            lblHistorialDeCompras.Size = new Size(241, 30);
            lblHistorialDeCompras.TabIndex = 5;
            lblHistorialDeCompras.Text = "Tu Historial de Compras!";
            // 
            // VerComprasSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHistorialDeCompras);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnCerrar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProductos);
            Name = "VerComprasSocio";
            Text = "VerComprasSocio";
            Load += VerComprasSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lblTitulo;
        private Button btnCerrar;
        private Label lblNombreUsuario;
        private Label lblHistorialDeCompras;
    }
}