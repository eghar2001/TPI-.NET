namespace WinForm
{
    partial class AdministrarProfesores
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
            dgvProfesores = new DataGridView();
            btnAgregar = new Button();
            btnSalir = new Button();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            SuspendLayout();
            // 
            // dgvProfesores
            // 
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Location = new Point(38, 35);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.RowTemplate.Height = 25;
            dgvProfesores.Size = new Size(711, 355);
            dgvProfesores.TabIndex = 0;
            dgvProfesores.CellClick += dgvProfesores_CellClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(593, 396);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(674, 396);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(52, 396);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // AdministrarProfesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProfesores);
            Name = "AdministrarProfesores";
            Text = "Profesores";
            Load += Profesores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProfesores;
        private Button btnAgregar;
        private Button btnSalir;
        private Button btnListar;
    }
}