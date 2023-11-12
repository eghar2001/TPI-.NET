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
    public partial class AdministrarActividadesForm : Form
    {
        private readonly Negocio.Actividad negocio_actividad = new Negocio.Actividad();
        public AdministrarActividadesForm()
        {
            InitializeComponent();
        }
        private void Listar()
        {

            this.dgvActividades.DataSource = negocio_actividad.find_all();


        }

        private void AdministrarActividadesForm_Load(object sender, EventArgs e)
        {

            this.Listar();
            DataGridViewButtonColumn colTurnos = new DataGridViewButtonColumn();
            colTurnos.HeaderText = "Turnos";
            colTurnos.Text = "Ir a Turnos";
            colTurnos.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.HeaderText = "Editar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            colBorrar.HeaderText = "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;



            this.dgvActividades.Columns.Add(colTurnos);
            this.dgvActividades.Columns.Add(colEditar);

            this.dgvActividades.Columns.Add(colBorrar);




        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ActividadForm agregarActividadForm = new ActividadForm();
            agregarActividadForm.ShowDialog();
            if (agregarActividadForm.DialogResult == DialogResult.OK)
            {
                this.Listar();
            }
        }

        private void dgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            int id_actividad = Convert.ToInt32(dgvActividades.Rows[e.RowIndex].Cells["Id"].Value);
            Entidades.Actividad actividad = negocio_actividad.get(id_actividad);
            if (dgvActividades.Columns[e.ColumnIndex].HeaderText == "Editar")
            {

                ActividadForm editarActividadForm = new ActividadForm(actividad);
                editarActividadForm.ShowDialog();
                if (editarActividadForm.DialogResult == DialogResult.OK)
                {
                    this.Listar();
                }

            }
            else if (dgvActividades.Columns[e.ColumnIndex].HeaderText == "Borrar")
            {
                DialogResult resultado = MessageBox.Show("Desea borrar la actividad '" + actividad.Nombre + "'?", "Borrar Actividad", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.OK)
                {
                    negocio_actividad.borrar_actividad(actividad);
                    this.Listar();
                }
            }
            else if (dgvActividades.Columns[e.ColumnIndex].HeaderText == "Turnos")
            {

                AdministrarTurnosActividadForm turnosActividadForm = new AdministrarTurnosActividadForm(actividad);

                turnosActividadForm.FormClosed += (s, args) => { this.Show(); };
                turnosActividadForm.Show();
                this.Hide();

            }
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
