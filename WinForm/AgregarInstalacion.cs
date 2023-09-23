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
    public partial class AgregarInstalacionForm : Form
    {
        Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        public AgregarInstalacionForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string desc = txtDesc.Text;
            int cupo = 0;
            try
            {
                 cupo = int.Parse(txtCupo.Text);
            }
            catch (FormatException) { MessageBox.Show("El Cupo debe ser un entero", "Problema de Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error); }





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
            catch (TituloRepetidoException)
            {
                MessageBox.Show("El Titulo se encuentra repetido", "Problema de titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("El Cupo debe ser mayor a 0", "Problema de Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
    }
}
