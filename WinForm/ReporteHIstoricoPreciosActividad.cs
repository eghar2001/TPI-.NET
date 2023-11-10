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
                GenerarReporte(actividad, valoresActividad);
            }

        }

        private void GenerarReporte(Entidades.Actividad actividad, List<Entidades.ValorActividad> valoresActividad)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string nombre_actividad = actividad.Nombre.Replace(" ", "_");
            saveFileDialog.FileName = "reporte_precios_actividad-"+ nombre_actividad + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            string paginahtml_texto = Properties.Resources.reporte_historico_precios_actividad.ToString();



            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Entidades.ValorActividad valorInicial = valoresActividad[0];
                Entidades.ValorActividad valorFinal = valoresActividad[valoresActividad.Count - 1];

                paginahtml_texto = paginahtml_texto.Replace("@Actividad", actividad.Nombre);
                paginahtml_texto = paginahtml_texto.Replace("@FechaInicio", valorInicial.FechaDesde.ToString("dd/MM/yyyy"));
                paginahtml_texto = paginahtml_texto.Replace("@PrecioInicial","$" +  valorInicial.Precio.ToString());


                paginahtml_texto = paginahtml_texto.Replace("@FechaActual", DateTime.Now.ToString("dd/MM/yyyy"));
                paginahtml_texto = paginahtml_texto.Replace("@PrecioActual","$"+ valorFinal.Precio.ToString());


                string valores = "";

                foreach (Entidades.ValorActividad valor in valoresActividad)
                {
                    valores += "<tr>";

                    valores += "<td>" + valor.FechaDesde.ToString("dd/MM/yyyy") + "</td>";
                    valores += "<td> $" + valor.Precio.ToString() + "</td>";

                    valores += "</tr>";
                }

                paginahtml_texto = paginahtml_texto.Replace("@Valores", valores);


                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.sacachispas, System.Drawing.Imaging.ImageFormat.Png);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 80);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }

                MessageBox.Show("PDF generado con exito!", "PDF Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
