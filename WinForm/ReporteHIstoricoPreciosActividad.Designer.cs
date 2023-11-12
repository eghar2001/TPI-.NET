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
            pnlMenu = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
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
            txtNombreActividad.Size = new Size(520, 23);
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
            dgvActividades.Location = new Point(40, 162);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvActividades.Size = new Size(661, 316);
            dgvActividades.TabIndex = 10;
            dgvActividades.CellClick += dgvActividades_CellClick;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MediumPurple;
            pnlMenu.Controls.Add(bntMenuPrincipal);
            pnlMenu.Controls.Add(picboxLogo);
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(762, 89);
            pnlMenu.TabIndex = 27;
            // 
            // bntMenuPrincipal
            // 
            bntMenuPrincipal.Location = new Point(626, 34);
            bntMenuPrincipal.Name = "bntMenuPrincipal";
            bntMenuPrincipal.Size = new Size(75, 23);
            bntMenuPrincipal.TabIndex = 8;
            bntMenuPrincipal.Text = "Volver";
            bntMenuPrincipal.UseVisualStyleBackColor = true;
            bntMenuPrincipal.Click += bntMenuPrincipal_Click;
            // 
            // picboxLogo
            // 
            picboxLogo.Image = Properties.Resources.sacachispas;
            picboxLogo.Location = new Point(3, 3);
            picboxLogo.Name = "picboxLogo";
            picboxLogo.Size = new Size(69, 79);
            picboxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picboxLogo.TabIndex = 7;
            picboxLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.Location = new Point(106, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(293, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Generar Reporte Actividad";
            // 
            // ReporteHistoricoPreciosActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 490);
            Controls.Add(pnlMenu);
            Controls.Add(dgvActividades);
            Controls.Add(lblNombreActividad);
            Controls.Add(txtNombreActividad);
            Name = "ReporteHistoricoPreciosActividad";
            Text = "Reporte Actividad";
            Load += ReservarActividad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreActividad;
        private TextBox txtNombreActividad;
        private DataGridView dgvActividades;
        private Panel pnlMenu;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}