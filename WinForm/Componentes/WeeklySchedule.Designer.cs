namespace WinForm.Componentes
{
    partial class WeeklySchedule
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
            pnlHorarios = new Panel();
            lblDomingo = new Label();
            lblSabado = new Label();
            lblViernes = new Label();
            lblJueves = new Label();
            lblMiercoles = new Label();
            lblMartes = new Label();
            lblLunes = new Label();
            listboxDomingo = new ListBox();
            listboxSabado = new ListBox();
            listboxViernes = new ListBox();
            listboxJueves = new ListBox();
            listboxMiercoles = new ListBox();
            listboxMartes = new ListBox();
            listboxLunes = new ListBox();
            lblTitulo = new Label();
            pnlHorarios.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHorarios
            // 
            pnlHorarios.BackColor = SystemColors.ActiveBorder;
            pnlHorarios.Controls.Add(lblDomingo);
            pnlHorarios.Controls.Add(lblSabado);
            pnlHorarios.Controls.Add(lblViernes);
            pnlHorarios.Controls.Add(lblJueves);
            pnlHorarios.Controls.Add(lblMiercoles);
            pnlHorarios.Controls.Add(lblMartes);
            pnlHorarios.Controls.Add(lblLunes);
            pnlHorarios.Controls.Add(listboxDomingo);
            pnlHorarios.Controls.Add(listboxSabado);
            pnlHorarios.Controls.Add(listboxViernes);
            pnlHorarios.Controls.Add(listboxJueves);
            pnlHorarios.Controls.Add(listboxMiercoles);
            pnlHorarios.Controls.Add(listboxMartes);
            pnlHorarios.Controls.Add(listboxLunes);
            pnlHorarios.Controls.Add(lblTitulo);
            pnlHorarios.Location = new Point(0, 0);
            pnlHorarios.Name = "pnlHorarios";
            pnlHorarios.Size = new Size(937, 305);
            pnlHorarios.TabIndex = 17;
            // 
            // lblDomingo
            // 
            lblDomingo.AutoSize = true;
            lblDomingo.Location = new Point(792, 74);
            lblDomingo.Name = "lblDomingo";
            lblDomingo.Size = new Size(57, 15);
            lblDomingo.TabIndex = 22;
            lblDomingo.Text = "Domingo";
            // 
            // lblSabado
            // 
            lblSabado.AutoSize = true;
            lblSabado.Location = new Point(650, 74);
            lblSabado.Name = "lblSabado";
            lblSabado.Size = new Size(46, 15);
            lblSabado.TabIndex = 21;
            lblSabado.Text = "Sabado";
            // 
            // lblViernes
            // 
            lblViernes.AutoSize = true;
            lblViernes.Location = new Point(526, 71);
            lblViernes.Name = "lblViernes";
            lblViernes.Size = new Size(45, 15);
            lblViernes.TabIndex = 20;
            lblViernes.Text = "Viernes";
            // 
            // lblJueves
            // 
            lblJueves.AutoSize = true;
            lblJueves.Location = new Point(405, 71);
            lblJueves.Name = "lblJueves";
            lblJueves.Size = new Size(41, 15);
            lblJueves.TabIndex = 19;
            lblJueves.Text = "Jueves";
            // 
            // lblMiercoles
            // 
            lblMiercoles.AutoSize = true;
            lblMiercoles.Location = new Point(257, 71);
            lblMiercoles.Name = "lblMiercoles";
            lblMiercoles.Size = new Size(58, 15);
            lblMiercoles.TabIndex = 18;
            lblMiercoles.Text = "Miercoles";
            // 
            // lblMartes
            // 
            lblMartes.AutoSize = true;
            lblMartes.Location = new Point(134, 71);
            lblMartes.Name = "lblMartes";
            lblMartes.Size = new Size(43, 15);
            lblMartes.TabIndex = 17;
            lblMartes.Text = "Martes";
            // 
            // lblLunes
            // 
            lblLunes.AutoSize = true;
            lblLunes.Location = new Point(11, 71);
            lblLunes.Name = "lblLunes";
            lblLunes.Size = new Size(38, 15);
            lblLunes.TabIndex = 16;
            lblLunes.Text = "Lunes";
            // 
            // listboxDomingo
            // 
            listboxDomingo.FormattingEnabled = true;
            listboxDomingo.ItemHeight = 15;
            listboxDomingo.Location = new Point(792, 92);
            listboxDomingo.Name = "listboxDomingo";
            listboxDomingo.Size = new Size(132, 169);
            listboxDomingo.TabIndex = 15;
            listboxDomingo.SelectedIndexChanged += listbox_SelectedIndexChanged;
            // 
            // listboxSabado
            // 
            listboxSabado.FormattingEnabled = true;
            listboxSabado.ItemHeight = 15;
            listboxSabado.Location = new Point(650, 92);
            listboxSabado.Name = "listboxSabado";
            listboxSabado.Size = new Size(126, 169);
            listboxSabado.TabIndex = 14;
            listboxSabado.SelectedIndexChanged += listbox_SelectedIndexChanged;
            // 
            // listboxViernes
            // 
            listboxViernes.FormattingEnabled = true;
            listboxViernes.ItemHeight = 15;
            listboxViernes.Location = new Point(526, 92);
            listboxViernes.Name = "listboxViernes";
            listboxViernes.Size = new Size(106, 169);
            listboxViernes.TabIndex = 13;
            listboxViernes.SelectedIndexChanged += listbox_SelectedIndexChanged;
            // 
            // listboxJueves
            // 
            listboxJueves.FormattingEnabled = true;
            listboxJueves.ItemHeight = 15;
            listboxJueves.Location = new Point(405, 92);
            listboxJueves.Name = "listboxJueves";
            listboxJueves.Size = new Size(106, 169);
            listboxJueves.TabIndex = 12;
            listboxJueves.SelectedIndexChanged += listbox_SelectedIndexChanged;
            // 
            // listboxMiercoles
            // 
            listboxMiercoles.FormattingEnabled = true;
            listboxMiercoles.ItemHeight = 15;
            listboxMiercoles.Location = new Point(257, 92);
            listboxMiercoles.Name = "listboxMiercoles";
            listboxMiercoles.Size = new Size(129, 169);
            listboxMiercoles.TabIndex = 11;
            listboxMiercoles.SelectedIndexChanged += listbox_SelectedIndexChanged;
            // 
            // listboxMartes
            // 
            listboxMartes.FormattingEnabled = true;
            listboxMartes.ItemHeight = 15;
            listboxMartes.Location = new Point(134, 92);
            listboxMartes.Name = "listboxMartes";
            listboxMartes.Size = new Size(106, 169);
            listboxMartes.TabIndex = 10;
            listboxMartes.SelectedIndexChanged += listbox_SelectedIndexChanged;
            // 
            // listboxLunes
            // 
            listboxLunes.FormattingEnabled = true;
            listboxLunes.ItemHeight = 15;
            listboxLunes.Location = new Point(12, 92);
            listboxLunes.Name = "listboxLunes";
            listboxLunes.Size = new Size(105, 169);
            listboxLunes.TabIndex = 9;
            listboxLunes.SelectedIndexChanged += listbox_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(75, 32);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Titulo";
            // 
            // WeekSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlHorarios);
            Name = "WeekSchedule";
            Size = new Size(937, 302);
            pnlHorarios.ResumeLayout(false);
            pnlHorarios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHorarios;
        private Label lblDomingo;
        private Label lblSabado;
        private Label lblViernes;
        private Label lblJueves;
        private Label lblMiercoles;
        private Label lblMartes;
        private Label lblLunes;
        private ListBox listboxDomingo;
        private ListBox listboxSabado;
        private ListBox listboxViernes;
        private ListBox listboxJueves;
        private ListBox listboxMiercoles;
        private ListBox listboxMartes;
        private ListBox listboxLunes;
        private Label lblTitulo;
    }
}
