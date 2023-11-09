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
    public partial class InscripcionTurnoSocio : Form
    {
        private Negocio.Turno negocio_turno = new Negocio.Turno();
        private readonly Negocio.InscripcionTurno negocio_inscripcionesTurno = new Negocio.InscripcionTurno();

        private Entidades.Turno turno_elegido;
        private List<Entidades.Horario> horarios_elegidos;
        public InscripcionTurnoSocio(int idTurno)
        {

            turno_elegido = this.negocio_turno.getTurno(idTurno);



            InitializeComponent();
        }

        private void InscripcionTurnoSocio_Load(object sender, EventArgs e)
        {
            this.lblNombreActividad.Text = this.turno_elegido.Actividad.Nombre + "(" + this.turno_elegido.Descripcion + ")"; ;
            this.lblProfesor.Text = "Profesor: " + this.turno_elegido.Profesor.Nombre + ' ' + this.turno_elegido.Profesor.Apellido;
            this.lblPrecio.Text = "Precio: $" + this.turno_elegido.Actividad.UltimoPrecio.ToString();
            this.lblUbicacion.Text = "Ubicacion: " + this.turno_elegido.Instalacion.Titulo;


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
            if (horarios_elegidos == null)
            {
                MessageBox.Show("No hay horarios en los que se pueda ir");
            }
            else
            {

                Entidades.InscripcionTurno nueva_inscripcion = new Entidades.InscripcionTurno()
                {
                    TurnoId = turno_elegido.Id,
                    UsuarioId = DatosLogin.UsuarioLogueado.Id,
                    FechaHoraInscripcion = DateTime.Now
                };
                try
                {
                    negocio_inscripcionesTurno.agregarInscripcionTurno(nueva_inscripcion);
                    MessageBox.Show("Se ha inscripto con exito", "Inscripcion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("No se encontro el turno ingresado", "Error Turno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (CupoMaximoException)
                {
                    //Aca dice cupo maximo del turno, pero en realidad el cupo esta guardado en actividad
                    MessageBox.Show("Se alcanzo el cupo maximo del turno", "Error Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (UsuarioYaInscriptoException)
                {
                    MessageBox.Show("Ya se encuentra inscripto esta actividad", "Error Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
