namespace WinForm
{
    partial class BorrarSocioForm
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
            lblBorrar = new Label();
            lblIdSocio = new Label();
            txtIdSocio = new TextBox();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // lblBorrar
            // 
            lblBorrar.AutoSize = true;
            lblBorrar.Location = new Point(312, 46);
            lblBorrar.Name = "lblBorrar";
            lblBorrar.Size = new Size(91, 20);
            lblBorrar.TabIndex = 0;
            lblBorrar.Text = "Borrar Socio";
            // 
            // lblIdSocio
            // 
            lblIdSocio.AutoSize = true;
            lblIdSocio.Location = new Point(112, 116);
            lblIdSocio.Name = "lblIdSocio";
            lblIdSocio.Size = new Size(143, 20);
            lblIdSocio.TabIndex = 1;
            lblIdSocio.Text = "Id del socio a Borrar";
            // 
            // txtIdSocio
            // 
            txtIdSocio.Location = new Point(299, 109);
            txtIdSocio.Name = "txtIdSocio";
            txtIdSocio.Size = new Size(125, 27);
            txtIdSocio.TabIndex = 2;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(330, 159);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(txtIdSocio);
            Controls.Add(lblIdSocio);
            Controls.Add(lblBorrar);
            Name = "Form1";
            Text = "Menu Borrar Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBorrar;
        private Label lblIdSocio;
        private TextBox txtIdSocio;
        private Button btnBorrar;
    }
}