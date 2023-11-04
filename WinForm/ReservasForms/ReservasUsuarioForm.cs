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
           

        }

        private void dgvReservas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvReservas.Rows[e.RowIndex].Cells[e.ColumnIndex];
        
            if ("Eliminar" == cell.OwningColumn.HeaderText && !cell.ReadOnly )
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
    }
}
