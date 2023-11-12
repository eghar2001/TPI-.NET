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
    public partial class AdministrarProfesores : Form
    {
        private Negocio.Profesor negocio_profesor = new Negocio.Profesor();
        private Entidades.Profesor profesor_a_editar;
        public AdministrarProfesores()
        {
            InitializeComponent();
        }


        public void Listar()
        {
            dgvProfesores.DataSource = negocio_profesor.find_all();
            dgvProfesores.Refresh();

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProfesorForm profesorform = new ProfesorForm();
            profesorform.ShowDialog();
            this.Listar();
        }



        private void Profesores_Load(object sender, EventArgs e)
        {
            this.Listar();
            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.HeaderText = "Editar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            colBorrar.HeaderText = "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            this.dgvProfesores.Columns.Add(colEditar);
            this.dgvProfesores.Columns.Add(colBorrar);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProfesores.AutoResizeColumns();
            dgvProfesores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            if ("Editar" == dgvProfesores.Columns[e.ColumnIndex].HeaderText)
            {
                DataGridViewRow row = dgvProfesores.Rows[e.RowIndex];
                int colId = int.Parse(row.Cells["Id"].Value.ToString());
                profesor_a_editar = negocio_profesor.get_one(colId);         // VER
                if (profesor_a_editar == null)
                {
                    MessageBox.Show("No se encontró el profesor", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    ProfesorForm editarProfesor = new ProfesorForm(profesor_a_editar);
                    editarProfesor.ShowDialog();
                    if (editarProfesor.DialogResult == DialogResult.OK)
                    {
                        this.Listar();
                    }
                }


            }


            if ("Borrar" == dgvProfesores.Columns[e.ColumnIndex].HeaderText)
            {
                DataGridViewRow row = dgvProfesores.Rows[e.RowIndex];
                int colId = int.Parse(row.Cells["Id"].Value.ToString());
                DialogResult resultado = MessageBox.Show($"¿Estás seguro que desea borrar el profesor:{row.Cells["Nombre"].Value.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        negocio_profesor.borrar_profesor(colId);
                        this.Listar();
                    }
                    catch (ProfesorInexistenteException)
                    {
                        MessageBox.Show("La instalacion no existe", "Profesor inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("La acción se realizó con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
