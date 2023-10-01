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
    public partial class InstalacionForm : Form
    {
        Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        private Entidades.Instalacion? instalacion_a_editar = null;

        public InstalacionForm()
        {
            InitializeComponent();
        }

        public InstalacionForm(Entidades.Instalacion instalacion_a_editar)
        {
            InitializeComponent();
            this.instalacion_a_editar = instalacion_a_editar;
            this.Text = "Editar Actividad";
            this.txtCupo.Text = instalacion_a_editar.Cupo.ToString();
            this.txtDesc.Text = instalacion_a_editar.Descripcion;
            this.txtTitulo.Text = instalacion_a_editar.Titulo;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string desc = txtDesc.Text;
            int cupo = 0;
            try
            {
                cupo = int.Parse(txtCupo.Text);
            }
            catch (FormatException) { MessageBox.Show("El Cupo debe ser un entero", "Problema de Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            if (this.instalacion_a_editar == null)
            {
                Entidades.Instalacion instalacion = new Entidades.Instalacion()
                {
                    Titulo = titulo,
                    Cupo = cupo,
                    Descripcion = desc,
                };

                try
                {
                    negocio_instalacion.agregar_instalacion(instalacion);
                    this.DialogResult = DialogResult.OK;
                }
                catch (TituloInstalacionRepetidoException)
                {
                    MessageBox.Show("El Titulo se encuentra repetido", "Problema de titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El Cupo debe ser mayor a 0", "Problema de Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                Entidades.Instalacion instalacion = new Entidades.Instalacion()
                {
                    Id = instalacion_a_editar.Id,
                    Titulo = titulo,
                    Cupo = cupo,
                    Descripcion = desc,
                };
                negocio_instalacion.modificar_Instalacion(instalacion);
            }

            this.DialogResult = DialogResult.OK;
        }


    }
}
