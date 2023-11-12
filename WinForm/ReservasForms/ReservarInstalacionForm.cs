using Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForm
{
    public partial class ReservarInstalacionForm : Form
    {
        private Negocio.Reserva negocio_reserva = new Negocio.Reserva();
        private Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        private Entidades.Instalacion instalacion_a_reservar = new Entidades.Instalacion();
        public ReservarInstalacionForm()
        {
            InitializeComponent();

        }


        private void ReservarInstalacionForm_Load(object sender, EventArgs e)
        {
        }


        private void btnBuscar__Click_1(object sender, EventArgs e)
        {
            DateTime fecha_inicio;
            DateTime fecha_fin;
            fecha_inicio = this.dateTimePickerInicio.Value;

            int cant = 0;
            int duracion;
            try
            {
                cant = int.Parse(txtCant.Text);
                if (string.IsNullOrWhiteSpace((txtCant.Text)))
                {
                    throw new FormatException();
                };

            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("La cantidad ser un entero", "Problema de Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            catch (FormatException) { MessageBox.Show("Formato invalido", "Problema de Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            try
            {
                duracion = int.Parse(txtDuracion.Text);
                if (string.IsNullOrWhiteSpace((txtDuracion.Text)))
                {
                    throw new FormatException();
                };

            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("La duración debe ser un entero", "Problema de Cantidad", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            catch (FormatException) { MessageBox.Show("Formato invalido", "Problema en Duracion", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }



            try
            {
                if (duracion <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Duración inválida. La duración debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.dgvInstalaciones.DataSource = negocio_instalacion.BuscarInstalacionesDisponibles(fecha_inicio, duracion, cant);

            DataGridViewButtonColumn colReservar = new DataGridViewButtonColumn();
            colReservar.Name = "Reservar";

            colReservar.Text = "Reservar";
            colReservar.UseColumnTextForButtonValue = true;

            dgvInstalaciones.Columns[4].HeaderText = "Precio";
            this.dgvInstalaciones.Columns.Add(colReservar);
            this.dgvInstalaciones.Columns["Reservar"].Visible = true;
            dgvInstalaciones.Columns[1].Visible = false; dgvInstalaciones.Columns[0].Visible = false;
            dgvInstalaciones.RowsDefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;



            dgvInstalaciones.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCyan;
            dgvInstalaciones.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }


        private DataGridViewRow selectedRow;
        private void dgvInstalaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DateTime fecha_inicio;
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            if ("Reservar" == dgvInstalaciones.Columns[e.ColumnIndex].HeaderText)
            {
                fecha_inicio = this.dateTimePickerInicio.Value;

                int duracion = int.Parse(txtDuracion.Text);


                int cant = int.Parse(txtCant.Text);
                DataGridViewRow row = dgvInstalaciones.Rows[e.RowIndex];
                int colId = int.Parse(row.Cells["Id"].Value.ToString());
                Entidades.Reserva reserva = new Entidades.Reserva()
                {
                    DuracionEnHoras = duracion,
                    InstalacionId = colId,
                    FechaHoraReserva = DateTime.Now,
                    UsuarioId = DatosLogin.UsuarioLogueado.Id,
                    CantidadAsitentes = cant,
                    FechaHoraUso = fecha_inicio



                };
                negocio_reserva.agregar_reserva(reserva);
                MessageBox.Show("Has reservado correctamente la instalacion ", "Reserva Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dgvInstalaciones.DataSource = null;
            }
            else
            {

            }
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) { e.Handled = true; }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) { e.Handled = true; }
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}


