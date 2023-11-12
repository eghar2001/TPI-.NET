using Negocio;
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

        private readonly Entidades.Turno turno;

        private readonly Negocio.Turno negocio_turno = new Negocio.Turno();
        private readonly Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        private readonly Negocio.Profesor negocio_profesor = new Negocio.Profesor();
        public HorarioForm(Entidades.Turno turno)
        {
            InitializeComponent();
            this.listboxDias.Items.Clear();

            foreach (string dia in Entidades.Horario.diasSemanaEsp)
            {
                this.listboxDias.Items.Add(dia);
            }
            this.listboxDias.SelectedIndex = 0;
            this.turno = turno;

            this.lblTitulo.Text = "Agregar horario a " + turno.Actividad.Nombre + "(" + turno.Descripcion + ")";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TimeOnly horaInicioTime = TimeOnly.Parse(timeInicio.HoraMinutos);
            TimeOnly horaFinTime = TimeOnly.Parse(timeFin.HoraMinutos);
            if (horaFinTime <= horaInicioTime)
            {
                MessageBox.Show("No se ingresó una hora válida", "Hora no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int ind_dia = Entidades.Horario.diasSemanaEsp.ToList().IndexOf(listboxDias.SelectedItem.ToString());
                Entidades.Horario horario_nuevo = new Entidades.Horario()
                {
                    TurnoId = turno.Id,
                    DiaSemana = Entidades.Horario.diasSemana[ind_dia],
                    HoraInicio = timeInicio.HoraMinutos,
                    HoraFin = timeFin.HoraMinutos
                };
                negocio_turno.agregarHorarioTurno(horario_nuevo);
                this.DialogResult = DialogResult.OK;
            }
            catch (DiaOcupadoException ex)
            {
                MessageBox.Show(ex.Message, "Dia Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HorarioNoValidoException ex)
            {
                MessageBox.Show(ex.Message, "Horario no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (HorarioSuperpuestoException ex)
            {
                MessageBox.Show(ex.Message, "Horario Ocupado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void HorarioForm_Load(object sender, EventArgs e)
        {
            weekScheduleInstalaciones.Titulo = "Horarios Ocupados de Instalacion: " + turno.Instalacion.Titulo;
            weekScheduleInstalaciones.Horarios = negocio_instalacion.GetHorariosInstalacion(turno.Instalacion);

            weekScheduleProfesores.Titulo = "Horarios Ocupados de Profesor: " + turno.Profesor.getNombApell();
            weekScheduleProfesores.Horarios = negocio_profesor.getHorariosProfesor(turno.Profesor);
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
