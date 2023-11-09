using Entidades;
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

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.HeaderText = "Editar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            this.dgvTurnos.Columns.Add(colEditar);

            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            colBorrar.HeaderText = "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            this.dgvTurnos.Columns.Add(colBorrar);
        }

        private void ListarTurnos()
        {
            this.dgvTurnos.DataSource = negocio_turno.getTurnosActividad(actividad.Id);
            this.dgvTurnos.Columns.Remove("InstalacionId");
            this.dgvTurnos.Columns.Remove("ActividadId");
            this.dgvTurnos.Columns.Remove("ProfesorId");
        }

        private void dgvTurnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            string columna = this.dgvTurnos.Columns[e.ColumnIndex].HeaderText;
            int id_turno = Convert.ToInt32(dgvTurnos.Rows[e.RowIndex].Cells["Id"].Value);
            Entidades.Turno turno = negocio_turno.getTurno(id_turno);
            if (columna == "Horarios")
            {

                AdministrarTurnoForm turnoForm = new AdministrarTurnoForm(turno);
                turnoForm.ShowDialog();
            }
            else if (columna == "Editar")
            {
                TurnoForm turnoForm = new TurnoForm(turno);
                turnoForm.ShowDialog();
                if (turnoForm.DialogResult == DialogResult.OK)
                {
                    this.ListarTurnos();
                }
            }
            else if (columna == "Borrar")
            {
                string messageBoxString = "Esta seguro que desea borrar el turno '" + turno.Descripcion + "' de la actividad +" + turno.Actividad.Nombre + "'";
                DialogResult resultado = MessageBox.Show(messageBoxString, "Borrar Turno", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                
                if (resultado == DialogResult.OK)
                {
                    negocio_turno.borrarTurno(turno);
                    this.ListarTurnos();
                }
            }
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            TurnoForm turnoForm = new TurnoForm(this.actividad);
            turnoForm.ShowDialog();
            if (turnoForm.DialogResult == DialogResult.OK)
            {
                this.ListarTurnos();
            }
        }
    }
}
