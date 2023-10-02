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
            lblForm = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // timeInicio
            // 
            timeInicio.HoraMinutos = "00:00";
            timeInicio.Location = new Point(34, 329);
            timeInicio.Name = "timeInicio";
            timeInicio.Size = new Size(344, 210);
            timeInicio.TabIndex = 0;
            // 
            // timeFin
            // 
            timeFin.HoraMinutos = "00:00";
            timeFin.Location = new Point(424, 329);
            timeFin.Name = "timeFin";
            timeFin.Size = new Size(344, 210);
            timeFin.TabIndex = 1;
            // 
            // lblHoraInicio
            // 
            lblHoraInicio.AutoSize = true;
            lblHoraInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoraInicio.Location = new Point(56, 298);
            lblHoraInicio.Name = "lblHoraInicio";
            lblHoraInicio.Size = new Size(111, 28);
            lblHoraInicio.TabIndex = 2;
            lblHoraInicio.Text = "Hora Inicio:";
            // 
            // lblHoraFin
            // 
            lblHoraFin.AutoSize = true;
            lblHoraFin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoraFin.Location = new Point(447, 298);
            lblHoraFin.Name = "lblHoraFin";
            lblHoraFin.Size = new Size(90, 28);
            lblHoraFin.TabIndex = 3;
            lblHoraFin.Text = "Hora Fin:";
            // 
            // listboxDias
            // 
            listboxDias.FormattingEnabled = true;
            listboxDias.ItemHeight = 20;
            listboxDias.Items.AddRange(new object[] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" });
            listboxDias.Location = new Point(228, 95);
            listboxDias.Name = "listboxDias";
            listboxDias.Size = new Size(150, 144);
            listboxDias.TabIndex = 4;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiaSemana.Location = new Point(56, 95);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(166, 28);
            lblDiaSemana.TabIndex = 5;
            lblDiaSemana.Text = "Dia de la Semana:";
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblForm.Location = new Point(56, 20);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(256, 34);
            lblForm.TabIndex = 6;
            lblForm.Text = "Agregar Horario";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(664, 556);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // HorarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 609);
            Controls.Add(btnAgregar);
            Controls.Add(lblForm);
            Controls.Add(lblDiaSemana);
            Controls.Add(listboxDias);
            Controls.Add(lblHoraFin);
            Controls.Add(lblHoraInicio);
            Controls.Add(timeFin);
            Controls.Add(timeInicio);
            Name = "HorarioForm";
            Text = "HorarioForm";
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
        private Label lblForm;
        private Button btnAgregar;
    }
}