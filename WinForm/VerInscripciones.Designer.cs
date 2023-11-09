namespace WinForm
{
    partial class VerInscripciones
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
            dgvInscripciones = new DataGridView();
            lblTitulo = new Label();
            lblSocio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.AllowUserToAddRows = false;
            dgvInscripciones.AllowUserToDeleteRows = false;
            dgvInscripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvInscripciones.BackgroundColor = SystemColors.ScrollBar;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.GridColor = SystemColors.ScrollBar;
            dgvInscripciones.Location = new Point(27, 121);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowTemplate.Height = 25;
            dgvInscripciones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvInscripciones.Size = new Size(801, 301);
            dgvInscripciones.TabIndex = 12;
            dgvInscripciones.CellClick += dgvInscripciones_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(27, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 32);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Mis Actividades";
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(27, 81);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(39, 15);
            lblSocio.TabIndex = 14;
            lblSocio.Text = "Socio:";
            // 
            // VerInscripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 450);
            Controls.Add(lblSocio);
            Controls.Add(lblTitulo);
            Controls.Add(dgvInscripciones);
            Name = "VerInscripciones";
            Text = "Mis Actividades";
            Load += VerInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInscripciones;
        private Label lblTitulo;
        private Label lblSocio;
    }
}