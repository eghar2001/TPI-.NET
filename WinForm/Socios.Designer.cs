namespace WinForm
{
    partial class Socios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            socioBindingSource = new BindingSource(components);
            socioBindingSource1 = new BindingSource(components);
            socioBindingSource2 = new BindingSource(components);
            dgvSocios = new DataGridView();
            lblTItulo = new Label();
            lblFiltrado = new Label();
            txtNombreApellido = new TextBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            panel1 = new Panel();
            picboxLogo = new PictureBox();
            bntMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // dgvSocios
            // 
            dgvSocios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(40, 130);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.RowTemplate.Height = 25;
            dgvSocios.Size = new Size(632, 357);
            dgvSocios.TabIndex = 0;
            dgvSocios.CellClick += dgvSocios_CellClick;
            // 
            // lblTItulo
            // 
            lblTItulo.AutoSize = true;
            lblTItulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTItulo.ForeColor = SystemColors.ControlLightLight;
            lblTItulo.Location = new Point(106, 24);
            lblTItulo.Name = "lblTItulo";
            lblTItulo.Size = new Size(278, 32);
            lblTItulo.TabIndex = 2;
            lblTItulo.Text = "Menu administrar Socios";
            // 
            // lblFiltrado
            // 
            lblFiltrado.AutoSize = true;
            lblFiltrado.Location = new Point(40, 104);
            lblFiltrado.Name = "lblFiltrado";
            lblFiltrado.Size = new Size(157, 15);
            lblFiltrado.TabIndex = 3;
            lblFiltrado.Text = "Filtrar por nombre y apellido";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(218, 101);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(221, 23);
            txtNombreApellido.TabIndex = 4;
            txtNombreApellido.TextChanged += txtNombreApellido_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(597, 95);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(597, 514);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Controls.Add(picboxLogo);
            panel1.Controls.Add(lblTItulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 89);
            panel1.TabIndex = 8;
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
            // bntMenuPrincipal
            // 
            bntMenuPrincipal.Location = new Point(597, 34);
            bntMenuPrincipal.Name = "bntMenuPrincipal";
            bntMenuPrincipal.Size = new Size(75, 23);
            bntMenuPrincipal.TabIndex = 8;
            bntMenuPrincipal.Text = "Volver";
            bntMenuPrincipal.UseVisualStyleBackColor = true;
            bntMenuPrincipal.Click += bntMenuPrincipal_Click;
            // 
            // Socios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 565);
            Controls.Add(panel1);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreApellido);
            Controls.Add(lblFiltrado);
            Controls.Add(dgvSocios);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Socios";
            Text = "Administrar socios";
            Load += Socios_Load;
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource socioBindingSource;
        private BindingSource socioBindingSource1;
        private BindingSource socioBindingSource2;
        private DataGridView dgvSocios;
        private Label lblTItulo;
        private Label lblFiltrado;
        private TextBox txtNombreApellido;
        private Button btnAgregar;
        private Button btnActualizar;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
    }
}