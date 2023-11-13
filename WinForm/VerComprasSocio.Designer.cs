﻿namespace WinForm
{
    partial class VerComprasSocio
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
            dgvProductos = new DataGridView();
            btnCerrar = new Button();
            lblNombreUsuario = new Label();
            lblHistorialDeCompras = new Label();
            pnlMenu = new Panel();
            panel1 = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(12, 134);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(776, 269);
            dgvProductos.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(713, 423);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUsuario.Location = new Point(637, 106);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(151, 25);
            lblNombreUsuario.TabIndex = 4;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // lblHistorialDeCompras
            // 
            lblHistorialDeCompras.AutoSize = true;
            lblHistorialDeCompras.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorialDeCompras.Location = new Point(12, 101);
            lblHistorialDeCompras.Name = "lblHistorialDeCompras";
            lblHistorialDeCompras.Size = new Size(241, 30);
            lblHistorialDeCompras.TabIndex = 5;
            lblHistorialDeCompras.Text = "Tu Historial de Compras!";
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
            pnlMenu.Size = new Size(800, 89);
            pnlMenu.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(658, 0);
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
            lblTitulo.Size = new Size(153, 32);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Mis Compras";
            // 
            // VerComprasSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMenu);
            Controls.Add(lblHistorialDeCompras);
            Controls.Add(lblNombreUsuario);
            Controls.Add(btnCerrar);
            Controls.Add(dgvProductos);
            Name = "VerComprasSocio";
            Text = "VerComprasSocio";
            Load += VerComprasSocio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnCerrar;
        private Label lblNombreUsuario;
        private Label lblHistorialDeCompras;
        private Panel pnlMenu;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}