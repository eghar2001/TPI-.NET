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
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            SuspendLayout();
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.AllowUserToAddRows = false;
            dgvInscripciones.AllowUserToDeleteRows = false;
            dgvInscripciones.AllowUserToResizeColumns = false;
            dgvInscripciones.AllowUserToResizeRows = false;
            dgvInscripciones.BackgroundColor = SystemColors.ScrollBar;
            dgvInscripciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.GridColor = SystemColors.ScrollBar;
            dgvInscripciones.Location = new Point(27, 29);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowTemplate.Height = 25;
            dgvInscripciones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvInscripciones.Size = new Size(1253, 393);
            dgvInscripciones.TabIndex = 12;
            // 
            // VerInscripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 450);
            Controls.Add(dgvInscripciones);
            Name = "VerInscripciones";
            Text = "VerInscripciones";
            Load += VerInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInscripciones;
    }
}