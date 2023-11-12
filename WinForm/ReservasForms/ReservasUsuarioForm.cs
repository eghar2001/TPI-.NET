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

namespace WinForm.ReservasForms
{
    /// <summary>
    /// Clases personalizadas para el manejo de botones
    /// </summary>
    public partial class ReservasUsuarioForm : Form
    {
        private Negocio.Reserva negocio_reserva = new Negocio.Reserva();
        public ReservasUsuarioForm()
        {
            InitializeComponent();

        }
        public void Listar()
        {
            int id = DatosLogin.UsuarioLogueado.Id;
            this.dgvReservas.DataSource = negocio_reserva.get_by_UsuarioId(id);

        }

        private void ReservasUsuarioForm_Load(object sender, EventArgs e)
        {
            this.Listar();
            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.Name = "Eliminar";

            colEliminar.Text = "Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            dgvReservas.Columns.Add(colEliminar);

            this.lblUsuario.Text = lblUsuario.Text + DatosLogin.UsuarioLogueado.NombreUsuario.ToString();
            dgvReservas.Columns[0].Visible = false; dgvReservas.Columns[1].Visible = false; dgvReservas.Columns[4].Visible = false; dgvReservas.Columns[5].Visible = false;
            dgvReservas.Columns[2].HeaderText = "Instalacion"; dgvReservas.Columns[3].HeaderText = "Fecha Reservado"; dgvReservas.Columns[6].HeaderText = "Duracion"; dgvReservas.Columns[7].HeaderText = "Cantidad de Personas";
            dgvReservas.Columns[8].HeaderText = "Fecha y hora inicio"; dgvReservas.Columns[9].HeaderText = "Fecha y hora fin";

            dgvReservas.RowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            dgvReservas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;


            dgvReservas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCyan;
            dgvReservas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            DataGridViewCell cell = dgvReservas.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if ("Eliminar" == dgvReservas.Columns[e.ColumnIndex].HeaderText)
            {
                DataGridViewRow row = dgvReservas.Rows[e.RowIndex];
                int colId = int.Parse(row.Cells["Id"].Value.ToString());
                DialogResult resultado = MessageBox.Show($"¿Estás seguro que desea borrar la reserva?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        negocio_reserva.remover_reserva(colId);
                    }
                    catch (ProfesorInexistenteException)
                    {

                        return;
                    }
                    MessageBox.Show("La acción se realizó con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Listar();
                }

            }
        }



        private void dgvReservas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            e.CellStyle.BackColor = Color.LightBlue;
            e.CellStyle.ForeColor = Color.Black;


            if (e.RowIndex >= 0 && e.ColumnIndex == dgvReservas.Columns["FechaHoraUso"].Index)
            {
                if (DateTime.TryParse(e.Value?.ToString(), out DateTime fechaUso))
                {
                    TimeSpan diferencia = fechaUso - DateTime.Now;
                    int diasDiferencia = (int)diferencia.TotalDays;
                    DataGridViewButtonCell celdaEliminar = (DataGridViewButtonCell)dgvReservas.Rows[e.RowIndex].Cells["Eliminar"];
                    if (diasDiferencia < 2)
                    {

                        celdaEliminar.ReadOnly = true;
                    }
                    else
                    {

                        celdaEliminar.ReadOnly = false;
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
