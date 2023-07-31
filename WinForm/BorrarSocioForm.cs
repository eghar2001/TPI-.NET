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
    public partial class BorrarSocioForm : Form
    {
        private Negocio.Socio negocio_socio = new Negocio.Socio();
        public BorrarSocioForm()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = Int32.Parse(txtIdSocio.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No ingreso un id numerico", "Error de Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Entidades.Socio socio = negocio_socio.get(id);
            if (socio == null)
            {
                MessageBox.Show("No se encontró el socio", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            negocio_socio.borrar_socio(socio);
            MessageBox.Show("El socio se ha borrado", "Socio borrado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
