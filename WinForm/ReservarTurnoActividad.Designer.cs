namespace WinForm
{
    partial class ReservarTurnoActividad
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
            dgvTurnos = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            SuspendLayout();
            // 
            // dgvTurnos
            // 
            dgvTurnos.AllowUserToAddRows = false;
            dgvTurnos.AllowUserToDeleteRows = false;
            dgvTurnos.AllowUserToResizeColumns = false;
            dgvTurnos.AllowUserToResizeRows = false;
            dgvTurnos.BackgroundColor = SystemColors.ScrollBar;
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.GridColor = SystemColors.ScrollBar;
            dgvTurnos.Location = new Point(12, 12);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTurnos.Size = new Size(1253, 393);
            dgvTurnos.TabIndex = 11;
            dgvTurnos.CellContentClick += dgvTurnos_CellContentClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1169, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // ReservarTurnoActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 450);
            Controls.Add(btnCancelar);
            Controls.Add(dgvTurnos);
            Name = "ReservarTurnoActividad";
            Text = "ReservarTurnoActividad";
            Load += ReservarTurnoActividad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTurnos;
        private Button btnCancelar;
    }
}