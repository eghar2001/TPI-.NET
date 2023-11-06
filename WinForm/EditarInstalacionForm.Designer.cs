namespace WinForm
{
    partial class EditarInstalacionForm
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
            txtTitulo = new TextBox();
            txtCupo = new TextBox();
            txtDesc = new TextBox();
            btnEditar = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(340, 136);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtCupo
            // 
            txtCupo.Location = new Point(340, 178);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(100, 23);
            txtCupo.TabIndex = 1;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(340, 216);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(145, 58);
            txtDesc.TabIndex = 2;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(526, 316);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // EditarInstalacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(txtDesc);
            Controls.Add(txtCupo);
            Controls.Add(txtTitulo);
            Name = "EditarInstalacionForm";
            Text = "EditarInstalacionForm";
            Load += EditarInstalacionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtCupo;
        private TextBox txtDesc;
        private Button btnEditar;
    }
}