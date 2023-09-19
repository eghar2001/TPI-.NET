namespace WinForm
{
    partial class ComprarProductoForm
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
            lblNombreProducto = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblPrecio = new Label();
            btnComprar = new Button();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreProducto.ForeColor = SystemColors.MenuHighlight;
            lblNombreProducto.Location = new Point(226, 41);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(291, 46);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(67, 154);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(310, 150);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(168, 238);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(57, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio: ";
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(565, 381);
            btnComprar.Margin = new Padding(3, 4, 3, 4);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(86, 31);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.ForeColor = SystemColors.Desktop;
            lblDescripcion.Location = new Point(310, 97);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(87, 20);
            lblDescripcion.TabIndex = 5;
            lblDescripcion.Text = "Descripcion";
            // 
            // ComprarProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(lblDescripcion);
            Controls.Add(btnComprar);
            Controls.Add(lblPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblNombreProducto);
            Name = "ComprarProductoForm";
            Text = "ComprarProductoForm";
            Load += ComprarProductoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreProducto;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblPrecio;
        private Button btnComprar;
        private Label lblDescripcion;
    }
}