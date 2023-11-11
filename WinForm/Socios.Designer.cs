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
            btnCancelar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            SuspendLayout();
            // 
            // dgvSocios
            // 
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(32, 109);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.RowTemplate.Height = 25;
            dgvSocios.Size = new Size(613, 171);
            dgvSocios.TabIndex = 0;
            // 
            // lblTItulo
            // 
            lblTItulo.AutoSize = true;
            lblTItulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTItulo.Location = new Point(32, 28);
            lblTItulo.Name = "lblTItulo";
            lblTItulo.Size = new Size(278, 32);
            lblTItulo.TabIndex = 2;
            lblTItulo.Text = "Menu administrar Socios";
            // 
            // lblFiltrado
            // 
            lblFiltrado.AutoSize = true;
            lblFiltrado.Location = new Point(32, 76);
            lblFiltrado.Name = "lblFiltrado";
            lblFiltrado.Size = new Size(157, 15);
            lblFiltrado.TabIndex = 3;
            lblFiltrado.Text = "Filtrar por nombre y apellido";
            // 
            // txtNombreApellido
            // 
            txtNombreApellido.Location = new Point(210, 73);
            txtNombreApellido.Name = "txtNombreApellido";
            txtNombreApellido.Size = new Size(221, 23);
            txtNombreApellido.TabIndex = 4;
            txtNombreApellido.TextChanged += txtNombreApellido_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(570, 68);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(570, 286);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(480, 286);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // Socios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombreApellido);
            Controls.Add(lblFiltrado);
            Controls.Add(lblTItulo);
            Controls.Add(dgvSocios);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Socios";
            Text = "Administrar socios";
            Load += Socios_Load;
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
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
        private Button btnCancelar;
        private Button btnActualizar;
    }
}