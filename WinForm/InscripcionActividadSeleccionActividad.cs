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
    public partial class InscripcionActividadSeleccionActividad : Form
    {
        private Negocio.Actividad negocio_actividad = new Negocio.Actividad();
        private Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        private List<Entidades.Actividad> actividades;
        public InscripcionActividadSeleccionActividad()
        {
            InitializeComponent();
        }

        private void ReservarActividad_Load(object sender, EventArgs e)
        {
            Listar();

            DataGridViewButtonColumn colVerTurnos = new DataGridViewButtonColumn();

            colVerTurnos.Name = "Ver Turnos";
            colVerTurnos.Text = "Ver Turnos";
            colVerTurnos.UseColumnTextForButtonValue = true;

            this.dgvActividades.Columns.Add(colVerTurnos);

        }

        private void Listar()
        {
            actividades = negocio_usuario.actividadesNoInscriptas(DatosLogin.UsuarioLogueado.Id);

            dgvActividades.DataSource = actividades;


            dgvActividades.Refresh();
        }

        private void txtNombreActividad_TextChanged(object sender, EventArgs e)
        {
            List<Entidades.Actividad> actividades_filtradas = actividades.Where(a => a.Nombre.ToUpper().Contains(txtNombreActividad.Text.ToUpper())).ToList();


            dgvActividades.DataSource = actividades_filtradas;

        }

        private void dgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvActividades.Columns[e.ColumnIndex].Name;

                if ("Ver Turnos" == dgvActividades.Columns[e.ColumnIndex].HeaderText)
                {
                    DataGridViewRow row = dgvActividades.Rows[e.RowIndex];
                    int idActividad = Int32.Parse(row.Cells["Id"].Value.ToString());

                    InscripcionActividadSeleccionTurno reservarTurnoActividad = new InscripcionActividadSeleccionTurno(idActividad);
                    reservarTurnoActividad.Show();
                    if (reservarTurnoActividad.DialogResult == DialogResult.OK)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (reservarTurnoActividad.DialogResult == DialogResult.Cancel)
                    {
                        MessageBox.Show("La actividad seleccionada no tiene turnos cargados todavia");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
