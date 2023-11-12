using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class InscripcionActividadSeleccionTurno : Form
    {
        private Negocio.Actividad negocio_actividad = new Negocio.Actividad();
        private Negocio.Turno negocio_turno = new Negocio.Turno();

        private Entidades.Actividad actividad_elegida;


        private List<int> ids_turno;
        public InscripcionActividadSeleccionTurno(int idActividad)
        {
            actividad_elegida = negocio_actividad.get(idActividad);


            InitializeComponent();
        }

        private void ReservarTurnoActividad_Load(object sender, EventArgs e)
        {
            lblActividad.Text = "Actividad: " + actividad_elegida.Nombre;
            lblPrecio.Text = "Precio: " + actividad_elegida.UltimoPrecio;
            this.Listar();
            DataGridViewButtonColumn colAnotarse = new DataGridViewButtonColumn();

            colAnotarse.Name = "Ver Horarios";
            colAnotarse.Text = "Ver Horarios";
            colAnotarse.UseColumnTextForButtonValue = true;

            this.dgvTurnos.Columns.Add(colAnotarse);


        }

        private void Listar()
        {
            List<Entidades.Turno> turnos = negocio_turno.getTurnosActividad(actividad_elegida.Id);
            if (turnos.IsNullOrEmpty())
            {
                this.DialogResult = DialogResult.Cancel;
            }
            var turnosDisplay = turnos.Select(t => new
            {
                Descripcion = t.Descripcion,
                Profesor = t.Profesor,

            }).ToList();

            dgvTurnos.DataSource = turnosDisplay;
            ids_turno = turnos.Select(t => t.Id).ToList();

            dgvTurnos.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvTurnos.Columns[e.ColumnIndex].HeaderText;

                if ("Ver Horarios" == columnName)
                {
                    DataGridViewRow row = dgvTurnos.Rows[e.RowIndex];
                    int idTurno = ids_turno[e.RowIndex];
                    InscripcionTurnoSocio inscripcionTurnoSocio = new InscripcionTurnoSocio(idTurno);
                    inscripcionTurnoSocio.ShowDialog();
                    if (inscripcionTurnoSocio.DialogResult == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                    }

                }
            }
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
