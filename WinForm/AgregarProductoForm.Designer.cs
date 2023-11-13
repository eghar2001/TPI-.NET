namespace WinForm
{
    partial class AgregarProductoForm
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
            txtNombreProducto = new TextBox();
            txtDescripcion = new TextBox();
            txtStock = new TextBox();
            btnAgregar = new Button();
            lblNombreProducto = new Label();
            lblDescripcion = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(279, 84);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(192, 23);
            txtNombreProducto.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(279, 133);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(192, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(279, 187);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(42, 23);
            txtStock.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(574, 403);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(148, 84);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(125, 15);
            lblNombreProducto.TabIndex = 4;
            lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(201, 133);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(200, 190);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(73, 15);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock Inicial:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(201, 239);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(67, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio C/U:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(279, 236);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 8;
            // 
            // AgregarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombreProducto);
            Controls.Add(btnAgregar);
            Controls.Add(txtStock);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreProducto);
            Name = "AgregarProductoForm";
            Text = "AgregarProductoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtDescripcion;
        private TextBox txtStock;
        private Button btnAgregar;
        private Label lblNombreProducto;
        private Label lblDescripcion;
        private Label lblStock;
        private Label lblPrecio;
        private TextBox txtPrecio;
    }
}