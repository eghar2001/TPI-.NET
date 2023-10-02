using Negocio;
using Negocio.DTOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class HorarioForm : Form
    {
        private readonly int turno_id;
        
        private readonly Negocio.Turno negocio_turno = new Negocio.Turno();
        public HorarioForm(int turno_id)
        {
            InitializeComponent();
            this.listboxDias.Items.Clear();
            foreach(string dia in Negocio.Turno.diasSemana.Keys)
            {
                this.listboxDias.Items.Add(dia);
            }
            this.listboxDias.SelectedIndex = 0;
            this.turno_id = turno_id;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TimeOnly horaInicioTime = TimeOnly.Parse(timeInicio.HoraMinutos);
            TimeOnly horaFinTime = TimeOnly.Parse(timeFin.HoraMinutos);
            if (horaFinTime<= horaInicioTime)
            {
                MessageBox.Show("No se ingresó una hora válida","Hora no valida",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            { 
                Entidades.Horario horario_nuevo = new Entidades.Horario()
                {
                    TurnoId= turno_id,
                    DiaSemana = Negocio.Turno.diasSemana[listboxDias.SelectedItem.ToString()],
                    HoraInicio = timeInicio.HoraMinutos,
                    HoraFin = timeFin.HoraMinutos
                };
                negocio_turno.agregarHorarioTurno(horario_nuevo);
                this.DialogResult = DialogResult.OK;
            }
            catch (HorarioNoValidoException ex)
            {
                MessageBox.Show(ex.Message, "Horario Invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error inesperado", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        

        
    }
}
