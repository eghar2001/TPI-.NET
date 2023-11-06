namespace WinForm
{
    partial class ReservarActividad
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
            lblNombreActividad = new Label();
            txtNombreActividad = new TextBox();
            dgvActividades = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Location = new Point(15, 29);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(135, 15);
            lblNombreActividad.TabIndex = 9;
            lblNombreActividad.Text = "Nombre de la Actividad:";
            // 
            // txtNombreActividad
            // 
            txtNombreActividad.Location = new Point(156, 26);
            txtNombreActividad.Name = "txtNombreActividad";
            txtNombreActividad.Size = new Size(146, 23);
            txtNombreActividad.TabIndex = 6;
            txtNombreActividad.TextChanged += txtNombreActividad_TextChanged;
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
            dgvActividades.Location = new Point(308, 12);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvActividades.Size = new Size(865, 388);
            dgvActividades.TabIndex = 10;
            dgvActividades.CellContentClick += dgvActividades_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(96, 377);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ReservarActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 408);
            Controls.Add(btnCancelar);
            Controls.Add(dgvActividades);
            Controls.Add(lblNombreActividad);
            Controls.Add(txtNombreActividad);
            Name = "ReservarActividad";
            Text = "ReservarActividad";
            Load += ReservarActividad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreActividad;
        private TextBox txtNombreActividad;
        private DataGridView dgvActividades;
        private Button btnCancelar;
    }
}