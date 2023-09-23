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
            btnEliminar = new Button();
            dgvInstalaciones = new DataGridView();
            DGVColEditar = new DataGridViewButtonColumn();
            DGVColBorrar = new DataGridViewButtonColumn();
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
            btnAgregar.Location = new Point(324, 342);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(136, 25);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(466, 342);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(136, 25);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvInstalaciones
            // 
            dgvInstalaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstalaciones.Columns.AddRange(new DataGridViewColumn[] { DGVColEditar, DGVColBorrar });
            dgvInstalaciones.Location = new Point(52, 22);
            dgvInstalaciones.Name = "dgvInstalaciones";
            dgvInstalaciones.RowTemplate.Height = 25;
            dgvInstalaciones.Size = new Size(668, 301);
            dgvInstalaciones.TabIndex = 3;
            dgvInstalaciones.CellContentClick += dgvInstalaciones_CellContentClick;
            // 
            // DGVColEditar
            // 
            DGVColEditar.HeaderText = "Editar";
            DGVColEditar.Name = "DGVColEditar";
            // 
            // DGVColBorrar
            // 
            DGVColBorrar.HeaderText = "Borrar";
            DGVColBorrar.Name = "DGVColBorrar";
            // 
            // ManejarInstalacionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvInstalaciones);
            Controls.Add(btnEliminar);
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
        private Button btnEliminar;
        private DataGridView dgvInstalaciones;
        private DataGridViewButtonColumn DGVColEditar;
        private DataGridViewButtonColumn DGVColBorrar;
    }
}