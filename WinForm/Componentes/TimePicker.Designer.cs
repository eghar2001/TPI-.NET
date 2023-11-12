namespace WinForm.Componentes
{
    partial class TimePicker
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtHora = new TextBox();
            lblHora = new Label();
            btnBajarHora = new Button();
            btnBajarMinuto = new Button();
            btnSubirMinuto = new Button();
            lblMinutos = new Label();
            txtMinutos = new TextBox();
            btnSubirHora = new Button();
            SuspendLayout();
            // 
            // txtHora
            // 
            txtHora.Location = new Point(24, 76);
            txtHora.Margin = new Padding(3, 2, 3, 2);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(110, 23);
            txtHora.TabIndex = 0;
            txtHora.Text = "0";
            txtHora.TextAlign = HorizontalAlignment.Center;
            txtHora.TextChanged += txtHora_TextChanged;
            txtHora.KeyPress += txtHora_KeyPress;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.ForeColor = SystemColors.ControlText;
            lblHora.Location = new Point(59, 12);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(33, 15);
            lblHora.TabIndex = 1;
            lblHora.Text = "Hora";
            // 
            // btnBajarHora
            // 
            btnBajarHora.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBajarHora.ImageAlign = ContentAlignment.TopCenter;
            btnBajarHora.Location = new Point(24, 98);
            btnBajarHora.Margin = new Padding(0);
            btnBajarHora.Name = "btnBajarHora";
            btnBajarHora.Size = new Size(109, 39);
            btnBajarHora.TabIndex = 4;
            btnBajarHora.Text = " ⇩";
            btnBajarHora.TextAlign = ContentAlignment.TopCenter;
            btnBajarHora.UseVisualStyleBackColor = false;
            btnBajarHora.Click += btnBajarHora_Click;
            // 
            // btnBajarMinuto
            // 
            btnBajarMinuto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnBajarMinuto.ImageAlign = ContentAlignment.TopCenter;
            btnBajarMinuto.Location = new Point(156, 98);
            btnBajarMinuto.Margin = new Padding(0);
            btnBajarMinuto.Name = "btnBajarMinuto";
            btnBajarMinuto.Size = new Size(109, 39);
            btnBajarMinuto.TabIndex = 8;
            btnBajarMinuto.Text = " ⇩";
            btnBajarMinuto.TextAlign = ContentAlignment.TopCenter;
            btnBajarMinuto.UseVisualStyleBackColor = false;
            btnBajarMinuto.Click += btnBajarMinuto_Click;
            // 
            // btnSubirMinuto
            // 
            btnSubirMinuto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubirMinuto.ImageAlign = ContentAlignment.TopCenter;
            btnSubirMinuto.Location = new Point(156, 34);
            btnSubirMinuto.Margin = new Padding(0);
            btnSubirMinuto.Name = "btnSubirMinuto";
            btnSubirMinuto.Size = new Size(109, 39);
            btnSubirMinuto.TabIndex = 7;
            btnSubirMinuto.Text = " ⇧";
            btnSubirMinuto.TextAlign = ContentAlignment.TopCenter;
            btnSubirMinuto.UseVisualStyleBackColor = false;
            btnSubirMinuto.Click += btnSubirMinuto_Click;
            // 
            // lblMinutos
            // 
            lblMinutos.AutoSize = true;
            lblMinutos.ForeColor = SystemColors.Desktop;
            lblMinutos.Location = new Point(181, 12);
            lblMinutos.Name = "lblMinutos";
            lblMinutos.Size = new Size(51, 15);
            lblMinutos.TabIndex = 6;
            lblMinutos.Text = "Minutos";
            // 
            // txtMinutos
            // 
            txtMinutos.Location = new Point(156, 76);
            txtMinutos.Margin = new Padding(3, 2, 3, 2);
            txtMinutos.Name = "txtMinutos";
            txtMinutos.Size = new Size(110, 23);
            txtMinutos.TabIndex = 5;
            txtMinutos.Text = "0";
            txtMinutos.TextAlign = HorizontalAlignment.Center;
            txtMinutos.TextChanged += txtMinutos_TextChanged;
            txtMinutos.KeyPress += txtMinutos_KeyPress;
            // 
            // btnSubirHora
            // 
            btnSubirHora.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubirHora.ImageAlign = ContentAlignment.TopCenter;
            btnSubirHora.Location = new Point(24, 34);
            btnSubirHora.Margin = new Padding(0);
            btnSubirHora.Name = "btnSubirHora";
            btnSubirHora.Size = new Size(109, 39);
            btnSubirHora.TabIndex = 9;
            btnSubirHora.Text = " ⇧";
            btnSubirHora.TextAlign = ContentAlignment.TopCenter;
            btnSubirHora.UseVisualStyleBackColor = false;
            btnSubirHora.Click += btnSubirHora_Click;
            // 
            // TimePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(btnSubirHora);
            Controls.Add(btnBajarMinuto);
            Controls.Add(btnSubirMinuto);
            Controls.Add(lblMinutos);
            Controls.Add(txtMinutos);
            Controls.Add(btnBajarHora);
            Controls.Add(lblHora);
            Controls.Add(txtHora);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TimePicker";
            Size = new Size(287, 165);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHora;
        private Label lblHora;
        private Button btnBajarHora;
        private Button btnBajarMinuto;
        private Button btnSubirMinuto;
        private Label lblMinutos;
        private TextBox txtMinutos;
        private Button btnSubirHora;
    }
}
