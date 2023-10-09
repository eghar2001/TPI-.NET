using Negocio.DTOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class AdministrarTurnosActividadForm : Form
    {
        private Entidades.Actividad actividad;

        private readonly Negocio.Turno negocio_turno = new Negocio.Turno();
        public AdministrarTurnosActividadForm(Entidades.Actividad actividad)
        {

            InitializeComponent();
            this.actividad = actividad;
        }

        private void AdministrarTurnosActividadForm_Load(object sender, EventArgs e)
        {
            this.Text += " - " + this.actividad.Nombre;
            this.lblNombreActividad.Text = actividad.Nombre;
            this.lblDescripcion.Text = actividad.Descripcion;
            this.lblPrecioActividad.Text = "Coste Inscripcion: $" + actividad.UltimoPrecio.ToString();



            ListarTurnos();

            DataGridViewButtonColumn colHorarios = new DataGridViewButtonColumn();
            colHorarios.HeaderText = "Horarios";
            colHorarios.Text = "Horarios";
            colHorarios.UseColumnTextForButtonValue = true;
            this.dgvTurnos.Columns.Add(colHorarios);
        }

        private void ListarTurnos()
        {
            this.dgvTurnos.DataSource = negocio_turno.getTurnosDTOActividad(actividad);
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (this.dgvTurnos.Columns[e.ColumnIndex].HeaderText == "Horarios")
            {
                int id_turno = Convert.ToInt32(dgvTurnos.Rows[e.RowIndex].Cells["Id"].Value);
                Negocio.DTOS.TurnoDTO turno = negocio_turno.getTurno(id_turno);
                AdministrarTurnoForm turnoForm = new AdministrarTurnoForm(turno);
                turnoForm.ShowDialog();
            }
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            TurnoForm turnoForm = new TurnoForm(this.actividad);
            turnoForm.ShowDialog();
        }
    }
}
