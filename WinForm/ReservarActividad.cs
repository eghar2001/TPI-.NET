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
    public partial class ReservarActividad : Form
    {
        private Negocio.Actividad negocio_actividad = new Negocio.Actividad();
        private Negocio.Turno negocio_turno = new Negocio.Turno();
        private Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        public ReservarActividad()
        {
            InitializeComponent();
        }

        private void ReservarActividad_Load(object sender, EventArgs e)
        {
            Listar();

            DataGridViewButtonColumn colReservar = new DataGridViewButtonColumn();

            colReservar.Name = "Reservar";
            colReservar.Text = "Reservar";
            colReservar.UseColumnTextForButtonValue = true;

            this.dgvActividades.Columns.Add(colReservar);

        }

        private void Listar()
        {
            //List<Entidades.Instalacion> instalaciones = negocio_instalacion.find_all();
            //List<Entidades.Turno> turnos = negocio_turno.find_all();

            /*var actividadesTurnosInstalacion = from ati in actividades
                                               join t in turnos on ati.Id equals t.ActividadId into turnosLeft
                                               from t in turnosLeft.DefaultIfEmpty()
                                               join i in instalaciones on (t?.InstalacionId) equals i.Id into instalacionesLeft
                                               from i in instalacionesLeft.DefaultIfEmpty()
                                               select new
                                               {
                                                   ati.Id,
                                                   ati.Nombre,
                                                   ati.Descripcion,
                                                   ati.UltimoPrecio,
                                                   Cupo = i?.Cupo
                                               };*/

            dgvActividades.DataSource = negocio_actividad.find_all();


            dgvActividades.Refresh();
        }

        private void txtNombreActividad_TextChanged(object sender, EventArgs e)
        {
            List<Entidades.Actividad> misActividades = negocio_actividad.find_all();
            //List<Entidades.Instalacion> instalaciones = negocio_instalacion.find_all();
            //List<Entidades.Turno> turnos = negocio_turno.find_all();

            var actividades_filtradas = from a in misActividades where a.Nombre.ToLower().Contains(txtNombreActividad.Text.ToLower()) select a;

            /*var actividadesTurnosInstalacion = from ati in misActividades
                                               join t in turnos on ati.Id equals t.ActividadId into turnosLeft
                                               from t in turnosLeft.DefaultIfEmpty()
                                               join i in instalaciones on (t?.InstalacionId) equals i.Id into instalacionesLeft
                                               from i in instalacionesLeft.DefaultIfEmpty()
                                               where ati.Nombre.ToLower().Contains(txtNombreActividad.Text.ToLower())
                                               select new
                                               {
                                                   ati.Id,
                                                   ati.Nombre,
                                                   ati.Descripcion,
                                                   ati.UltimoPrecio,
                                                   Cupo = i?.Cupo
                                               };*/





            dgvActividades.DataSource = actividades_filtradas.ToList();
        }

        private void dgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvActividades.Columns[e.ColumnIndex].Name;

                if ("Reservar" == dgvActividades.Columns[e.ColumnIndex].HeaderText)
                {
                    DataGridViewRow row = dgvActividades.Rows[e.RowIndex];
                    int idActividad = Int32.Parse(row.Cells["Id"].Value.ToString());

                    ReservarTurnoActividad reservarTurnoActividad = new ReservarTurnoActividad(idActividad);
                    reservarTurnoActividad.Show();

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
