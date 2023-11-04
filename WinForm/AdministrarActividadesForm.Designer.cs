namespace WinForm
{
    partial class AdministrarActividadesForm
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
            lblAdministrarActividades = new Label();
            dgvActividades = new DataGridView();
            btnActualizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // lblAdministrarActividades
            // 
            lblAdministrarActividades.AutoSize = true;
            lblAdministrarActividades.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdministrarActividades.Location = new Point(60, 62);
            lblAdministrarActividades.Name = "lblAdministrarActividades";
            lblAdministrarActividades.Size = new Size(515, 50);
            lblAdministrarActividades.TabIndex = 0;
            lblAdministrarActividades.Text = "Menu Administrar Actividades";
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.AllowUserToResizeColumns = false;
            dgvActividades.AllowUserToResizeRows = false;
            dgvActividades.BackgroundColor = SystemColors.ScrollBar;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.GridColor = SystemColors.ScrollBar;
            dgvActividades.Location = new Point(60, 158);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvActividades.Size = new Size(770, 253);
            dgvActividades.TabIndex = 1;
            dgvActividades.CellClick += dgvActividades_CellClick;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(60, 451);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(755, 86);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // AdministrarActividadesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 505);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(dgvActividades);
            Controls.Add(lblAdministrarActividades);
            Name = "AdministrarActividadesForm";
            Text = "Administrar Actividades";
            Load += AdministrarActividadesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdministrarActividades;
        private DataGridView dgvActividades;
        private Button btnActualizar;
        private Button btnAgregar;
    }
}