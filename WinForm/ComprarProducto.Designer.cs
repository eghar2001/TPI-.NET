namespace WinForm
{
    partial class ComprarProducto
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
            dgvProductosCliente = new DataGridView();
            lblProductos = new Label();
            lblCarritoCliente = new Label();
            lblCliente = new Label();
            btnCancelar = new Button();
            btnConfirmarCompra = new Button();
            lblNombreProducto = new Label();
            txtNombreProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 75);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(735, 414);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(570, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(375, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Seleccione los productos";
            // 
            // dgvProductosCliente
            // 
            dgvProductosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosCliente.Location = new Point(760, 75);
            dgvProductosCliente.Name = "dgvProductosCliente";
            dgvProductosCliente.RowTemplate.Height = 25;
            dgvProductosCliente.Size = new Size(696, 414);
            dgvProductosCliente.TabIndex = 2;
            dgvProductosCliente.CellContentClick += dgvProductosCliente_CellContentClick;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductos.Location = new Point(283, 42);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(106, 30);
            lblProductos.TabIndex = 3;
            lblProductos.Text = "Productos";
            // 
            // lblCarritoCliente
            // 
            lblCarritoCliente.AutoSize = true;
            lblCarritoCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarritoCliente.Location = new Point(1095, 42);
            lblCarritoCliente.Name = "lblCarritoCliente";
            lblCarritoCliente.Size = new Size(75, 30);
            lblCarritoCliente.TabIndex = 4;
            lblCarritoCliente.Text = "Carrito";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.Location = new Point(1067, 505);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(89, 32);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(657, 567);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(185, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmarCompra
            // 
            btnConfirmarCompra.Location = new Point(657, 495);
            btnConfirmarCompra.Name = "btnConfirmarCompra";
            btnConfirmarCompra.Size = new Size(185, 45);
            btnConfirmarCompra.TabIndex = 7;
            btnConfirmarCompra.Text = "Confirmar Compra";
            btnConfirmarCompra.UseVisualStyleBackColor = true;
            btnConfirmarCompra.Click += btnConfirmarCompra_Click;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(27, 505);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(116, 15);
            lblNombreProducto.TabIndex = 8;
            lblNombreProducto.Text = "Buscar Por Nombre: ";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(149, 502);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(190, 23);
            txtNombreProducto.TabIndex = 9;
            txtNombreProducto.TextChanged += txtNombreProducto_TextChanged;
            // 
            // ComprarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 602);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(btnConfirmarCompra);
            Controls.Add(btnCancelar);
            Controls.Add(lblCliente);
            Controls.Add(lblCarritoCliente);
            Controls.Add(lblProductos);
            Controls.Add(dgvProductosCliente);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProductos);
            Name = "ComprarProducto";
            Text = "ComprarProducto";
            Load += ComprarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lblTitulo;
        private DataGridView dgvProductosCliente;
        private Label lblProductos;
        private Label lblCarritoCliente;
        private Label lblCliente;
        private Button btnCancelar;
        private Button btnConfirmarCompra;
        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
    }
}