namespace WinForm
{
    partial class AdministrarInstalacionesForm
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
            btnListar = new Button();
            btnAgregar = new Button();
            dgvInstalaciones = new DataGridView();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInstalaciones).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(50, 399);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(136, 25);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(620, 48);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 25);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvInstalaciones
            // 
            dgvInstalaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstalaciones.Location = new Point(50, 93);
            dgvInstalaciones.Name = "dgvInstalaciones";
            dgvInstalaciones.RowTemplate.Height = 25;
            dgvInstalaciones.Size = new Size(706, 300);
            dgvInstalaciones.TabIndex = 3;
            dgvInstalaciones.CellClick += dgvInstalaciones_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(50, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(261, 40);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Menu Instalaciones";
            // 
            // AdministrarInstalacionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(dgvInstalaciones);
            Controls.Add(btnAgregar);
            Controls.Add(btnListar);
            Name = "AdministrarInstalacionesForm";
            Text = "Administrar Instalaciones";
            Load += ManejarInstalacionesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInstalaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListar;
        private Button btnAgregar;
        private DataGridView dgvInstalaciones;
        private Label lblTitulo;
    }
}