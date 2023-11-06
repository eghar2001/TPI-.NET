namespace WinForm.ReservasForms
{
    partial class ReservasUsuarioForm
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
            dgvReservas = new DataGridView();
            lblTitulo = new Label();
            lblUsuario = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.AllowUserToDeleteRows = false;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Location = new Point(97, 80);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.RowTemplate.Height = 25;
            dgvReservas.Size = new Size(745, 456);
            dgvReservas.TabIndex = 0;
            dgvReservas.CellClick += dgvReservas_CellClick;
            dgvReservas.CellPainting += dgvReservas_CellPainting;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(362, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(198, 37);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "MIS RESERVAS";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(12, 562);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(75, 21);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario : ";
            // 
            // ReservasUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(945, 592);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(dgvReservas);
            ForeColor = SystemColors.ControlText;
            Name = "ReservasUsuarioForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ReservasUsuarioForm";
            Load += ReservasUsuarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReservas;
        private Label lblTitulo;
        private Label lblUsuario;
    }
}