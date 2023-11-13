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
            btnConfirmarCompra = new Button();
            lblNombreProducto = new Label();
            txtNombreProducto = new TextBox();
            pnlMenu = new Panel();
            panel1 = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCliente).BeginInit();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 200);
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
            lblTitulo.Location = new Point(570, 134);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(375, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Seleccione los productos";
            // 
            // dgvProductosCliente
            // 
            dgvProductosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductosCliente.Location = new Point(760, 200);
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
            lblProductos.Location = new Point(283, 167);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(106, 30);
            lblProductos.TabIndex = 3;
            lblProductos.Text = "Productos";
            // 
            // lblCarritoCliente
            // 
            lblCarritoCliente.AutoSize = true;
            lblCarritoCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarritoCliente.Location = new Point(1095, 167);
            lblCarritoCliente.Name = "lblCarritoCliente";
            lblCarritoCliente.Size = new Size(75, 30);
            lblCarritoCliente.TabIndex = 4;
            lblCarritoCliente.Text = "Carrito";
            // 
            // btnConfirmarCompra
            // 
            btnConfirmarCompra.Location = new Point(657, 620);
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
            lblNombreProducto.Location = new Point(27, 630);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(116, 15);
            lblNombreProducto.TabIndex = 8;
            lblNombreProducto.Text = "Buscar Por Nombre: ";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(149, 627);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(190, 23);
            txtNombreProducto.TabIndex = 9;
            txtNombreProducto.TextChanged += txtNombreProducto_TextChanged;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MediumPurple;
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(picboxLogo);
            pnlMenu.Controls.Add(label1);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1468, 89);
            pnlMenu.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1326, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 89);
            panel1.TabIndex = 9;
            // 
            // bntMenuPrincipal
            // 
            bntMenuPrincipal.Location = new Point(0, 34);
            bntMenuPrincipal.Name = "bntMenuPrincipal";
            bntMenuPrincipal.Size = new Size(75, 23);
            bntMenuPrincipal.TabIndex = 8;
            bntMenuPrincipal.Text = "Volver";
            bntMenuPrincipal.UseVisualStyleBackColor = true;
            bntMenuPrincipal.Click += bntMenuPrincipal_Click;
            // 
            // picboxLogo
            // 
            picboxLogo.Image = Properties.Resources.sacachispas;
            picboxLogo.Location = new Point(3, 3);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(69, 79);
            picboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxLogo.TabIndex = 7;
            picboxLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(106, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 2;
            label1.Text = "Titulo";
            // 
            // ComprarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 684);
            Controls.Add(pnlMenu);
            Controls.Add(txtNombreProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(btnConfirmarCompra);
            Controls.Add(lblCarritoCliente);
            Controls.Add(lblProductos);
            Controls.Add(dgvProductosCliente);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProductos);
            Name = "ComprarProducto";
            Text = "Comprar Producto";
            Load += ComprarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductosCliente).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lblTitulo;
        private DataGridView dgvProductosCliente;
        private Label lblProductos;
        private Label lblCarritoCliente;
        private Button btnConfirmarCompra;
        private Label lblNombreProducto;
        private TextBox txtNombreProducto;
        private Panel pnlMenu;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label label1;
    }
}