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
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // lblAdministrarActividades
            // 
            lblAdministrarActividades.AutoSize = true;
            lblAdministrarActividades.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdministrarActividades.Location = new Point(228, 39);
            lblAdministrarActividades.Name = "lblAdministrarActividades";
            lblAdministrarActividades.Size = new Size(515, 50);
            lblAdministrarActividades.TabIndex = 0;
            lblAdministrarActividades.Text = "Menu Administrar Actividades";
            // 
            // dgvActividades
            // 
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Location = new Point(238, 110);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.Size = new Size(492, 150);
            dgvActividades.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(394, 380);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // AdministrarActividadesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}