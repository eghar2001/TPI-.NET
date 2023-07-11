namespace WinForm
{
    partial class Socios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Negocio.Socio negocio_socio = new Negocio.Socio();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Socios));
            socioBindingSource = new BindingSource(components);
            socioBindingSource1 = new BindingSource(components);
            socioBindingSource2 = new BindingSource(components);
            tcSocios = new ToolStripContainer();
            tlSocios = new TableLayoutPanel();
            btnActualizar = new Button();
            btnSalir = new Button();
            dgvSocios = new DataGridView();
            tsSocios = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource2).BeginInit();
            tcSocios.ContentPanel.SuspendLayout();
            tcSocios.TopToolStripPanel.SuspendLayout();
            tcSocios.SuspendLayout();
            tlSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            tsSocios.SuspendLayout();
            SuspendLayout();
            // 
            // socioBindingSource
            // 
            socioBindingSource.DataSource = typeof(Negocio.Socio);
            // 
            // socioBindingSource1
            // 
            socioBindingSource1.DataSource = typeof(Negocio.Socio);
            // 
            // socioBindingSource2
            // 
            socioBindingSource2.DataSource = typeof(Entidades.Socio);
            // 
            // tcSocios
            // 
            // 
            // tcSocios.ContentPanel
            // 
            tcSocios.ContentPanel.Controls.Add(tlSocios);
            tcSocios.ContentPanel.Size = new Size(800, 423);
            tcSocios.Dock = DockStyle.Fill;
            tcSocios.Location = new Point(0, 0);
            tcSocios.Name = "tcSocios";
            tcSocios.Size = new Size(800, 450);
            tcSocios.TabIndex = 0;
            tcSocios.Text = "toolStripContainer1";
            // 
            // tcSocios.TopToolStripPanel
            // 
            tcSocios.TopToolStripPanel.Controls.Add(tsSocios);
            // 
            // tlSocios
            // 
            tlSocios.ColumnCount = 2;
            tlSocios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlSocios.ColumnStyles.Add(new ColumnStyle());
            tlSocios.Controls.Add(btnActualizar, 0, 1);
            tlSocios.Controls.Add(btnSalir, 1, 1);
            tlSocios.Controls.Add(dgvSocios, 0, 0);
            tlSocios.Dock = DockStyle.Fill;
            tlSocios.Location = new Point(0, 0);
            tlSocios.Name = "tlSocios";
            tlSocios.RowCount = 2;
            tlSocios.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlSocios.RowStyles.Add(new RowStyle());
            tlSocios.Size = new Size(800, 423);
            tlSocios.TabIndex = 0;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Location = new Point(603, 391);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(703, 391);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvSocios
            // 
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlSocios.SetColumnSpan(dgvSocios, 2);
            dgvSocios.Dock = DockStyle.Fill;
            dgvSocios.Location = new Point(3, 3);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.RowHeadersWidth = 51;
            dgvSocios.RowTemplate.Height = 29;
            dgvSocios.Size = new Size(794, 382);
            dgvSocios.TabIndex = 3;
            // 
            // tsSocios
            // 
            tsSocios.Dock = DockStyle.None;
            tsSocios.ImageScalingSize = new Size(20, 20);
            tsSocios.Items.AddRange(new ToolStripItem[] { tsbNuevo });
            tsSocios.Location = new Point(4, 0);
            tsSocios.Name = "tsSocios";
            tsSocios.Size = new Size(42, 27);
            tsSocios.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(29, 24);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // Socios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcSocios);
            Name = "Socios";
            Text = "Form1";
            Load += Socios_Load;
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource2).EndInit();
            tcSocios.ContentPanel.ResumeLayout(false);
            tcSocios.TopToolStripPanel.ResumeLayout(false);
            tcSocios.TopToolStripPanel.PerformLayout();
            tcSocios.ResumeLayout(false);
            tcSocios.PerformLayout();
            tlSocios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            tsSocios.ResumeLayout(false);
            tsSocios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource socioBindingSource;
        private BindingSource socioBindingSource1;
        private BindingSource socioBindingSource2;
        private ToolStripContainer tcSocios;
        private TableLayoutPanel tlSocios;
        private Button btnActualizar;
        private Button btnSalir;
        private ToolStrip tsSocios;
        private ToolStripButton tsbNuevo;
        private DataGridView dgvSocios;
    }
}