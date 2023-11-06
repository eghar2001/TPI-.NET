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
    public partial class ReservarTurnoActividad : Form
    {
        private Negocio.Actividad negocio_actividad = new Negocio.Actividad();
        private Negocio.Turno negocio_turno = new Negocio.Turno();
        private Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        private Negocio.Profesor negocio_profesor = new Negocio.Profesor();

        private Entidades.Actividad actividad_elegida;
        public ReservarTurnoActividad(int idActividad)
        {
            actividad_elegida = negocio_actividad.get(idActividad);

            InitializeComponent();
        }

        private void ReservarTurnoActividad_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn colAnotarse = new DataGridViewButtonColumn();

            colAnotarse.Name = "Ver Horarios";
            colAnotarse.Text = "Ver Horarios";
            colAnotarse.UseColumnTextForButtonValue = true;

            this.dgvTurnos.Columns.Add(colAnotarse);

            this.Listar();
        }

        private void Listar()
        {
            List<Entidades.Instalacion> instalaciones = negocio_instalacion.find_all();
            List<Entidades.Turno> turnos = negocio_turno.find_all();
            List<Entidades.Profesor> profesores = negocio_profesor.find_all();

            var actividadesTurnosInstalacion = from t in turnos
                                               join p in profesores on t.ProfesorId equals p.Id
                                               join i in instalaciones on (t?.InstalacionId) equals i.Id into instalacionesLeft
                                               from i in instalacionesLeft.DefaultIfEmpty()
                                               where t.ActividadId == actividad_elegida.Id
                                               select new
                                               {
                                                   t.Id,
                                                   t.Descripcion,
                                                   t.ProfesorId,
                                                   p.Nombre,
                                                   p.Apellido,
                                                   i.Titulo,
                                                   Cupo = i?.Cupo,
                                                   i.UltimoPrecio,
                                                   t.InstalacionId
                                               };

            dgvTurnos.DataSource = actividadesTurnosInstalacion.ToList();


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
                string columnName = dgvTurnos.Columns[e.ColumnIndex].Name;

                if ("Ver Horarios" == dgvTurnos.Columns[e.ColumnIndex].HeaderText)
                {
                    DataGridViewRow row = dgvTurnos.Rows[e.RowIndex];
                    int idTurno = Int32.Parse(row.Cells["Id"].Value.ToString());
                    int idInstalacion = Int32.Parse(row.Cells["InstalacionId"].Value.ToString());
                    int cupo = Int32.Parse(row.Cells["Cupo"].Value.ToString());
                    int idProfesor = Int32.Parse(row.Cells["ProfesorId"].Value.ToString());

                    if ((cupo) <= 0)
                    {
                        MessageBox.Show("No hay cupos suficientes para esta actividad en este turno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        InscripcionTurnoSocio inscripcionTurnoSocio = new InscripcionTurnoSocio(actividad_elegida.Id, idInstalacion, idProfesor, idTurno);
                        inscripcionTurnoSocio.ShowDialog();
                    }

                }
            }
        }
    }
}
