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
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(307, 41);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(128, 20);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(88, 111);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(331, 106);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 2;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(189, 195);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(57, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio: ";
            // 
            // ComprarProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}