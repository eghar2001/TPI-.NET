using Entidades;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace WinForm
{
    public class Reportes
    {
        public static void GenerarCarnet(Entidades.Usuario socio)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            string default_filename = socio.Dni +"_"+ DateTime.Now.ToString("ddMMyyyyHHmmss") + "_carnet.pdf";
            saveFileDialog.FileName = default_filename;
            string paginahtml_texto = Properties.Resources.carnet_socio;



            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {


                paginahtml_texto = paginahtml_texto.Replace("@NombreYApellido", socio.Nombre +" "+ socio.Apellido);
                paginahtml_texto = paginahtml_texto.Replace("@NombreUsuario", socio.NombreUsuario);
                paginahtml_texto = paginahtml_texto.Replace("@DNI", socio.Dni.ToString());
                System.Drawing.Image imagen_socio = System.Drawing.Image.FromFile(socio.FotoAbsolutePath);
                imagen_socio = Utils.ResizeImage(imagen_socio, new Size(100, 100));

                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));


                    iTextSharp.text.Image carnet = iTextSharp.text.Image.GetInstance(Properties.Resources.carnet_foto, System.Drawing.Imaging.ImageFormat.Png);
                    carnet.Alignment = iTextSharp.text.Image.UNDERLYING;
                    carnet.SetAbsolutePosition(pdfDoc.RightMargin + 20, pdfDoc.Top - 450);
                    pdfDoc.Add(carnet);

                    iTextSharp.text.Image logo_grande = iTextSharp.text.Image.GetInstance(Properties.Resources.sacachispas, System.Drawing.Imaging.ImageFormat.Png);
                    logo_grande.Alignment = iTextSharp.text.Image.UNDERLYING;
                    logo_grande.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 90);
                    pdfDoc.Add(logo_grande);

                   

                    



                    iTextSharp.text.Image imagen_socio_en_pdf = iTextSharp.text.Image.GetInstance(imagen_socio, System.Drawing.Imaging.ImageFormat.Png);
                    imagen_socio_en_pdf.Alignment = iTextSharp.text.Image.UNDERLYING;

                    imagen_socio_en_pdf.SetAbsolutePosition(pdfDoc.LeftMargin+50, pdfDoc.Top -270);
                    pdfDoc.Add(imagen_socio_en_pdf);




                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }


                    

                    pdfDoc.Close();
                    stream.Close();
                }


            }


        }
        public static void GenerarReporteActividad(Entidades.Actividad actividad, List<Entidades.ValorActividad> valoresActividad)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string nombre_actividad = actividad.Nombre.Replace(" ", "_");
            saveFileDialog.FileName = "reporte_precios_actividad-" + nombre_actividad + "-" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";

            string paginahtml_texto = Properties.Resources.reporte_historico_precios_actividad.ToString();



            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Entidades.ValorActividad valorInicial = valoresActividad[0];
                Entidades.ValorActividad valorFinal = valoresActividad[valoresActividad.Count - 1];

                paginahtml_texto = paginahtml_texto.Replace("@Actividad", actividad.Nombre);
                paginahtml_texto = paginahtml_texto.Replace("@FechaInicio", valorInicial.FechaDesde.ToString("dd/MM/yyyy"));
                paginahtml_texto = paginahtml_texto.Replace("@PrecioInicial", "$" + valorInicial.Precio.ToString());


                paginahtml_texto = paginahtml_texto.Replace("@FechaActual", DateTime.Now.ToString("dd/MM/yyyy"));
                paginahtml_texto = paginahtml_texto.Replace("@PrecioActual", "$" + valorFinal.Precio.ToString());


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
            }
        }
    }
}
