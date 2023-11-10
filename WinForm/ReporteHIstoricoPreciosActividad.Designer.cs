namespace WinForm
{
    partial class ReporteHistoricoPreciosActividad
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
            label1 = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            SuspendLayout();
            // 
            // lblNombreActividad
            // 
            lblNombreActividad.AutoSize = true;
            lblNombreActividad.Location = new Point(40, 112);
            lblNombreActividad.Name = "lblNombreActividad";
            lblNombreActividad.Size = new Size(112, 15);
            lblNombreActividad.TabIndex = 9;
            lblNombreActividad.Text = "Filtrar por actividad:";
            // 
            // txtNombreActividad
            // 
            txtNombreActividad.Location = new Point(181, 112);
            txtNombreActividad.Name = "txtNombreActividad";
            txtNombreActividad.Size = new Size(146, 23);
            txtNombreActividad.TabIndex = 6;
            txtNombreActividad.TextChanged += txtNombreActividad_TextChanged;
            // 
            // dgvActividades
            // 
            dgvActividades.AllowUserToAddRows = false;
            dgvActividades.AllowUserToDeleteRows = false;
            dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvActividades.BackgroundColor = SystemColors.ScrollBar;
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.GridColor = SystemColors.ScrollBar;
            dgvActividades.Location = new Point(333, 112);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvActividades.Size = new Size(774, 316);
            dgvActividades.TabIndex = 10;
            dgvActividades.CellClick += dgvActividades_CellClick;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(120, 405);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-29, 432);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 14;
            label1.Text = "label1";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(40, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(348, 32);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Seleccionar actividad a reportar";
            // 
            // ReporteHistoricoPreciosActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 490);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(dgvActividades);
            Controls.Add(lblNombreActividad);
            Controls.Add(txtNombreActividad);
            Name = "ReporteHistoricoPreciosActividad";
            Text = "Reporte Actividad";
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
        private Label label1;
        private Label lblTitulo;
    }
}