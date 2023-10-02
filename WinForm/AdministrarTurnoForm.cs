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
    public partial class AdministrarTurnoForm : Form
    {
        private readonly Negocio.DTOS.TurnoDTO turno;
        private readonly Negocio.Turno negocio_turno;
        private List<HorarioDTO> horarios = null;
        public AdministrarTurnoForm(Negocio.DTOS.TurnoDTO turno)
        {
            InitializeComponent();
            this.turno = turno;
            this.negocio_turno = new Negocio.Turno();
        }
        private void ListarHorarios()
        {
            List<Negocio.DTOS.HorarioDTO> horarios = negocio_turno.getHorariosTurno(turno.Id);
            this.horarios = horarios;
            this.listboxHorarios.Items.Clear();
            foreach (Negocio.DTOS.HorarioDTO hor in horarios)
            {
                listboxHorarios.Items.Add(hor.DiaSemana + " " + hor.HoraInicio + "-" + hor.HoraFin);
            }
        }
        private void TurnoForm_Load(object sender, EventArgs e)
        {
            this.lblNombreActividad.Text = turno.Actividad + "(" + turno.Descripcion + ")";
            this.lblPrecio.Text = "Precio: $" + turno.Precio.ToString();
            this.lblUbicacion.Text = "Ubicacion: " + turno.Instalacion;
            this.lblProfesor.Text = "Profesor: " + turno.Profesor;



            this.ListarHorarios();


        }

        private void listboxHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea borrar " + listboxHorarios.SelectedItem, "Borrar horario", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                string diaSemanaEsp = this.horarios[listboxHorarios.SelectedIndex].DiaSemana;
                Entidades.Horario horario = new Entidades.Horario()
                {
                    TurnoId = this.turno.Id,
                    DiaSemana = Negocio.Turno.diasSemana[diaSemanaEsp]
                };
                negocio_turno.borrarHorarioTurno(horario);
                MessageBox.Show("El horario " + listboxHorarios.SelectedItem.ToString() + " se ha borrado correctamente", "Horario Borrado");
                this.ListarHorarios();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            HorarioForm horarioForm = new HorarioForm(turno.Id);
            horarioForm.ShowDialog();
            if (horarioForm.DialogResult == DialogResult.OK)
            {
                this.ListarHorarios();
            }
        }
    }
}
