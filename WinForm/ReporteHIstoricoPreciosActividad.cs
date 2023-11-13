using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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
    public partial class ReporteHistoricoPreciosActividad : Form
    {
        private Negocio.Actividad negocio_actividad = new Negocio.Actividad();
        private Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        private List<Entidades.Actividad> actividades;
        private List<Entidades.Actividad> actividades_filtradas;
        public ReporteHistoricoPreciosActividad()
        {
            InitializeComponent();
        }

        private void ReservarActividad_Load(object sender, EventArgs e)
        {
            Listar();

            DataGridViewButtonColumn colGenerarReporte = new DataGridViewButtonColumn();

            colGenerarReporte.Name = "Generar Reporte";
            colGenerarReporte.Text = "Reporte";
            colGenerarReporte.UseColumnTextForButtonValue = true;

            this.dgvActividades.Columns.Add(colGenerarReporte);

        }

        private void Listar()
        {
            actividades = negocio_actividad.find_all();
            actividades_filtradas = actividades;
            dgvActividades.DataSource = actividades;


            dgvActividades.Refresh();
        }

        private void txtNombreActividad_TextChanged(object sender, EventArgs e)
        {

            actividades_filtradas = actividades.Where(a => a.Nombre.ToUpper().Contains(txtNombreActividad.Text.ToUpper())).ToList();






            dgvActividades.DataSource = actividades_filtradas;
        }
        private void dgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string columna = dgvActividades.Columns[e.ColumnIndex].Name;

            if (columna == "Generar Reporte")
            {
                Entidades.Actividad actividad = actividades_filtradas[e.RowIndex];
                List<Entidades.ValorActividad> valoresActividad = negocio_actividad.find_valores_actividad(actividad.Id);
                Reportes.GenerarReporteActividad(actividad, valoresActividad);
                MessageBox.Show("PDF generado con exito!", "PDF Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
