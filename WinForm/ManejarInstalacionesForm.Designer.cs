namespace WinForm
{
    partial class ManejarInstalacionesForm
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
            ((System.ComponentModel.ISupportInitialize)dgvInstalaciones).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(182, 342);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(136, 25);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(446, 342);
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
            dgvInstalaciones.Location = new Point(156, 51);
            dgvInstalaciones.Name = "dgvInstalaciones";
            dgvInstalaciones.RowTemplate.Height = 25;
            dgvInstalaciones.Size = new Size(458, 270);
            dgvInstalaciones.TabIndex = 3;
            dgvInstalaciones.CellClick += dgvInstalaciones_CellClick;
            // 
            // ManejarInstalacionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvInstalaciones);
            Controls.Add(btnAgregar);
            Controls.Add(btnListar);
            Name = "ManejarInstalacionesForm";
            Text = "ManejarInstalaciones";
            Load += ManejarInstalacionesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInstalaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnListar;
        private Button btnAgregar;
        private DataGridView dgvInstalaciones;
    }
}