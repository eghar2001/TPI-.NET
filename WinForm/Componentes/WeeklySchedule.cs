using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Componentes
{
    public partial class WeeklySchedule : UserControl
    {
        private List<Entidades.Horario> _horarios;
        private string _titulo = "Titulo";
        private ListBox[] listboxes_dias = new ListBox[7];
        public WeeklySchedule()
        {
            InitializeComponent();
            this.listboxes_dias = new ListBox[7] {this.listboxLunes, this.listboxMartes, this.listboxMiercoles, this.listboxJueves, this.listboxViernes,
                                                        this.listboxSabado, this.listboxDomingo};

        }
        private void deseleccionarListboxes()
        {
            foreach (ListBox listbox_dia in listboxes_dias)
            {
                listbox_dia.SelectedIndex = -1;
            }
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            deseleccionarListboxes();
        }



        public List<Entidades.Horario> Horarios
        {
            get
            {
                return this._horarios;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                this._horarios = value;

                for (int i = 0; i < 7; i++)
                {
                    DayOfWeek dia_semana = Entidades.Horario.diasSemana[i];
                    List<Entidades.Horario> horarios_dia = _horarios.Where(ins => ins.DiaSemana == dia_semana).ToList();
                    listboxes_dias[i].DataSource = horarios_dia;
                }
                deseleccionarListboxes();
            }
        }
        public string Titulo
        {
            get
            {
                return this._titulo;
            }
            set
            {
                if (value == null)
                {
                    return;
                }

                this._titulo = value;
                this.lblTitulo.Text = value;

            }
        }

    }
}
