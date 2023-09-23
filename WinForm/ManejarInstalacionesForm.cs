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
    public partial class ManejarInstalacionesForm : Form
    {
        private Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        public ManejarInstalacionesForm()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            dgvInstalaciones.DataSource = null;
            dgvInstalaciones.DataSource = negocio_instalacion.find_all();
            dgvInstalaciones.Refresh();
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvInstalaciones.Columns["DGVColBorrar"].Visible = true;
            dgvInstalaciones.Columns["DGVColEditar"].Visible = true;
            Listar();
            int columnIndex = dgvInstalaciones.Columns["DGVColEditar"].Index;
            int lastIndex = dgvInstalaciones.Columns.Count - 1;

            if (columnIndex != lastIndex)
            {
                dgvInstalaciones.Columns["DGVColBorrar"].DisplayIndex = lastIndex;
                dgvInstalaciones.Columns["DGVColEditar"].DisplayIndex = lastIndex - 1;
            }
        }




        private void dgvInstalaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInstalaciones.AutoResizeColumns();
            dgvInstalaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvInstalaciones.Columns["DGVColEditar"].Index)
            {
                DataGridViewRow row = dgvInstalaciones.Rows[e.RowIndex];
                int colId = int.Parse(row.Cells["Id"].Value.ToString());




            }


            if (e.RowIndex >= 0 && e.ColumnIndex == dgvInstalaciones.Columns["DGVColBorrar"].Index)
            {
                DataGridViewRow row = dgvInstalaciones.Rows[e.RowIndex];
                int colId = int.Parse(row.Cells["Id"].Value.ToString());
                DialogResult resultado = MessageBox.Show($"¿Estás seguro que desea borrar la inslatacion:{row.Cells["Titulo"].Value.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        negocio_instalacion.remover_Instalacion(colId);
                    }
                    catch (InstalacionInexistenteException)
                    {
                        MessageBox.Show("La instalacion no existe", "Instalacion inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("La acción se realizó con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

                MessageBox.Show("La acción fue cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarInstalacionForm InstalacionForm = new AgregarInstalacionForm();
            InstalacionForm.ShowDialog();

        }

        private void ManejarInstalacionesForm_Load(object sender, EventArgs e)
        {
            dgvInstalaciones.Columns["DGVColEditar"].Visible = false;
            dgvInstalaciones.Columns["DGVColBorrar"].Visible = false;
        }
    }
}
