namespace WinForm
{
    partial class HorarioForm
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
            timeInicio = new Componentes.TimePicker();
            timeFin = new Componentes.TimePicker();
            lblHoraInicio = new Label();
            lblHoraFin = new Label();
            listboxDias = new ListBox();
            lblDiaSemana = new Label();
            btnAgregar = new Button();
            weekScheduleInstalaciones = new Componentes.WeeklySchedule();
            weekScheduleProfesores = new Componentes.WeeklySchedule();
            pnlMenu = new Panel();
            panel1 = new Panel();
            bntMenuPrincipal = new Button();
            picboxLogo = new PictureBox();
            lblTitulo = new Label();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxLogo).BeginInit();
            SuspendLayout();
            // 
            // timeInicio
            // 
            timeInicio.HoraMinutos = "00:00";
            timeInicio.Location = new Point(30, 267);
            timeInicio.Margin = new Padding(3, 2, 3, 2);
            timeInicio.Name = "timeInicio";
            timeInicio.Size = new Size(301, 158);
            timeInicio.TabIndex = 0;
            // 
            // timeFin
            // 
            timeFin.HoraMinutos = "00:00";
            timeFin.Location = new Point(30, 448);
            timeFin.Margin = new Padding(3, 2, 3, 2);
            timeFin.Name = "timeFin";
            timeFin.Size = new Size(301, 158);
            timeFin.TabIndex = 1;
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoraInicio.Location = new Point(49, 244);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(88, 21);
            lblHoraInicio.TabIndex = 2;
            lblHoraInicio.Text = "Hora Inicio:";
            // 
            // lblHoraFin
            // 
            lblHoraFin.AutoSize = true;
            lblHoraFin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoraFin.Location = new Point(50, 425);
            lblHoraFin.Name = "lblHoraFin";
            lblHoraFin.Size = new Size(72, 21);
            lblHoraFin.TabIndex = 3;
            lblHoraFin.Text = "Hora Fin:";
            // 
            // listboxDias
            // 
            listboxDias.FormattingEnabled = true;
            listboxDias.ItemHeight = 15;
            listboxDias.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" });
            listboxDias.Location = new Point(199, 119);
            listboxDias.Margin = new Padding(3, 2, 3, 2);
            listboxDias.Name = "listboxDias";
            listboxDias.Size = new Size(132, 109);
            listboxDias.TabIndex = 4;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaSemana.Location = new Point(48, 119);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(133, 21);
            lblDiaSemana.TabIndex = 5;
            lblDiaSemana.Text = "Dia de la Semana:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(224, 656);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // weekScheduleInstalaciones
            // 
            weekScheduleInstalaciones.Horarios = null;
            weekScheduleInstalaciones.Location = new Point(402, 98);
            weekScheduleInstalaciones.Name = "weekScheduleInstalaciones";
            weekScheduleInstalaciones.Size = new Size(941, 302);
            weekScheduleInstalaciones.TabIndex = 8;
            weekScheduleInstalaciones.Titulo = "Titulo";
            // 
            // weekScheduleProfesores
            // 
            weekScheduleProfesores.Horarios = null;
            weekScheduleProfesores.Location = new Point(402, 406);
            weekScheduleProfesores.Name = "weekScheduleProfesores";
            weekScheduleProfesores.Size = new Size(941, 302);
            weekScheduleProfesores.TabIndex = 9;
            weekScheduleProfesores.Titulo = "Titulo";
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
            pnlMenu.Size = new Size(1368, 89);
            pnlMenu.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.Controls.Add(bntMenuPrincipal);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1226, 0);
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
            // HorarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 720);
            Controls.Add(pnlMenu);
            Controls.Add(weekScheduleProfesores);
            Controls.Add(weekScheduleInstalaciones);
            Controls.Add(btnAgregar);
            Controls.Add(lblDiaSemana);
            Controls.Add(listboxDias);
            Controls.Add(lblHoraFin);
            Controls.Add(lblHoraInicio);
            Controls.Add(timeFin);
            Controls.Add(timeInicio);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HorarioForm";
            Text = "HorarioForm";
            Load += HorarioForm_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picboxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Componentes.TimePicker timeInicio;
        private Componentes.TimePicker timeFin;
        private Label lblHoraInicio;
        private Label lblHoraFin;
        private ListBox listboxDias;
        private Label lblDiaSemana;
        private Button btnAgregar;
        private Componentes.WeeklySchedule weekScheduleInstalaciones;
        private Componentes.WeeklySchedule weekScheduleProfesores;
        private Panel pnlMenu;
        private Panel panel1;
        private Button bntMenuPrincipal;
        private PictureBox picboxLogo;
        private Label lblTitulo;
    }
}