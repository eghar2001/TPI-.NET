namespace WinForm
{
    partial class EleccionClienteCompraProducto
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
            txtNombreUsuario = new TextBox();
            lblNombreUsuario = new Label();
            lblTitulo = new Label();
            dgvUsuarios = new DataGridView();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(126, 104);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(132, 23);
            txtNombreUsuario.TabIndex = 0;
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Location = new Point(12, 107);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(113, 15);
            lblNombreUsuario.TabIndex = 1;
            lblNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(423, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(170, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Buscar Usuario";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(264, 104);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(682, 256);
            dgvUsuarios.TabIndex = 3;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(871, 423);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // EleccionClienteCompraProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 458);
            Controls.Add(btnCerrar);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtNombreUsuario);
            Name = "EleccionClienteCompraProducto";
            Text = "EleccionClienteCompraProducto";
            Load += EleccionClienteCompraProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreUsuario;
        private Label lblNombreUsuario;
        private Label lblTitulo;
        private DataGridView dgvUsuarios;
        private Button btnCerrar;
    }
}