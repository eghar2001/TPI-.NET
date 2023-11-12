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
            lblSocio = new Label();
            pnlMenu = new Panel();
            panel1 = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
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
            dgvInscripciones.Location = new Point(26, 149);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.RowTemplate.Height = 25;
            dgvInscripciones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvInscripciones.Size = new Size(801, 301);
            dgvInscripciones.TabIndex = 12;
            dgvInscripciones.CellClick += dgvInscripciones_CellClick;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(41, 117);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(39, 15);
            lblSocio.TabIndex = 14;
            lblSocio.Text = "Socio:";
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
            pnlMenu.Size = new Size(854, 89);
            pnlMenu.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(712, 0);
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
            lblTitulo.Size = new Size(180, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Mis Actividades";
            // 
            // VerInscripciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 491);
            Controls.Add(pnlMenu);
            Controls.Add(lblSocio);
            Controls.Add(dgvInscripciones);
            Name = "VerInscripciones";
            Text = "Mis Actividades";
            Load += VerInscripciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInscripciones;
        private Label lblSocio;
        private Panel pnlMenu;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}