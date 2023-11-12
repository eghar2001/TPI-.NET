namespace WinForm
{
    partial class AdministrarTurnosActividadForm
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
            lblPrecioActividad = new Label();
            lblDescripcion = new Label();
            dgvTurnos = new DataGridView();
            Turnos = new Label();
            btnAgregarTurno = new Button();
            pnlMenu = new Panel();
            panel1 = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).BeginInit();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // lblPrecioActividad
            // 
            lblPrecioActividad.AutoSize = true;
            lblPrecioActividad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioActividad.Location = new Point(589, 158);
            lblPrecioActividad.Name = "lblPrecioActividad";
            lblPrecioActividad.Size = new Size(163, 25);
            lblPrecioActividad.TabIndex = 1;
            lblPrecioActividad.Text = "$ Precio Actividad";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(53, 158);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(154, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion Actividad";
            // 
            // dgvTurnos
            // 
            dgvTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTurnos.Location = new Point(55, 224);
            dgvTurnos.Name = "dgvTurnos";
            dgvTurnos.RowHeadersWidth = 51;
            dgvTurnos.RowTemplate.Height = 25;
            dgvTurnos.Size = new Size(892, 219);
            dgvTurnos.TabIndex = 3;
            dgvTurnos.CellClick += dgvTurnos_CellClick;
            // 
            // Turnos
            // 
            Turnos.AutoSize = true;
            Turnos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Turnos.Location = new Point(55, 191);
            Turnos.Name = "Turnos";
            Turnos.Size = new Size(58, 21);
            Turnos.TabIndex = 4;
            Turnos.Text = "Turnos";
            // 
            // btnAgregarTurno
            // 
            btnAgregarTurno.Location = new Point(55, 466);
            btnAgregarTurno.Name = "btnAgregarTurno";
            btnAgregarTurno.Size = new Size(99, 23);
            btnAgregarTurno.TabIndex = 5;
            btnAgregarTurno.Text = "Agregar Turno";
            btnAgregarTurno.UseVisualStyleBackColor = true;
            btnAgregarTurno.Click += btnAgregarTurno_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.MediumPurple;
            pnlMenu.Controls.Add(panel1);
            pnlMenu.Controls.Add(picboxLogo);
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Dock = DockStyle.Top;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1029, 89);
            pnlMenu.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(887, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 89);
            panel1.TabIndex = 9;
            // 
            // bntMenuPrincipal
            // 
            bntMenuPrincipal.Location = new Point(0, 34);
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
            lblTitulo.Size = new Size(75, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // AdministrarTurnosActividadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1029, 590);
            Controls.Add(pnlMenu);
            Controls.Add(btnAgregarTurno);
            Controls.Add(Turnos);
            Controls.Add(dgvTurnos);
            Controls.Add(lblDescripcion);
            Controls.Add(lblPrecioActividad);
            Name = "AdministrarTurnosActividadForm";
            Text = "Turnos";
            Load += AdministrarTurnosActividadForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTurnos).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPrecioActividad;
        private Label lblDescripcion;
        private DataGridView dgvTurnos;
        private Label Turnos;
        private Button btnAgregarTurno;
        private Panel pnlMenu;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}