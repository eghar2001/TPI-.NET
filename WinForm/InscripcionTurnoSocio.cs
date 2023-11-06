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
    public partial class InscripcionTurnoSocio : Form
    {
        private Negocio.Actividad negocio_actividad = new Negocio.Actividad();
        private Negocio.Turno negocio_turno = new Negocio.Turno();
        private Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        private Negocio.Profesor negocio_profesor = new Negocio.Profesor();
        private Negocio.InscripcionTurno negocio_inscripcionTurno = new Negocio.InscripcionTurno();

        private Entidades.Profesor profesor_elegido;
        private Entidades.Actividad actividad_elegida;
        private Entidades.Instalacion instalacion_elegida;
        private Entidades.Turno turno_elegido;
        private List<Entidades.Horario> horarios_elegidos;
        public InscripcionTurnoSocio(int idActividad, int idInstalacion, int idProfesor, int idTurno)
        {
            profesor_elegido = this.negocio_profesor.get_one(idProfesor);
            actividad_elegida = this.negocio_actividad.get(idActividad);
            instalacion_elegida = this.negocio_instalacion.get_one(idInstalacion);
            turno_elegido = this.negocio_turno.getTurno(idTurno);



            InitializeComponent();
        }

        private void InscripcionTurnoSocio_Load(object sender, EventArgs e)
        {
            this.lblNombreActividad.Text = this.actividad_elegida.Nombre + "(" + this.turno_elegido.Descripcion + ")"; ;
            this.lblProfesor.Text = "Profesor: " + this.profesor_elegido.Nombre + ' ' + this.profesor_elegido.Apellido;
            this.lblPrecio.Text = "Precio: $" + this.actividad_elegida.UltimoPrecio.ToString();
            this.lblUbicacion.Text = "Ubicacion: " + this.instalacion_elegida.Titulo;


            this.ListarHorarios();
        }

        private void ListarHorarios()
        {
            List<Entidades.Horario> horarios = negocio_turno.getHorariosTurno(turno_elegido);
            this.horarios_elegidos = horarios;
            this.listboxHorarios.Items.Clear();
            foreach (Entidades.Horario hor in horarios)
            {
                listboxHorarios.Items.Add(hor.DiaSemanaEsp + " " + hor.HoraInicio + "-" + hor.HoraFin);
            }
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            if(horarios_elegidos == null)
            {
                MessageBox.Show("No hay horarios en los que se pueda ir");
            }
            else
            {
                Entidades.InscripcionTurno nueva_inscripcion = new Entidades.InscripcionTurno();
                nueva_inscripcion.TurnoId = turno_elegido.Id;
                nueva_inscripcion.UsuarioId = DatosLogin.UsuarioLogueado.Id;
                nueva_inscripcion.FechaHoraInscripcion = DateTime.Now;
                negocio_inscripcionTurno.agregarInscripcionTurno(nueva_inscripcion);
                turno_elegido.Instalacion.Cupo -= 1;
                negocio_turno.modificarTurno(turno_elegido);

                DialogResult = DialogResult.OK;
            }
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
