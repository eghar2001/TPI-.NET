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
        private Negocio.Usuario negocio_usuario = new Negocio.Usuario();
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
            Entidades.Usuario usuario = negocio_usuario.get(id);
            if (usuario == null)
            {
                MessageBox.Show("No se encontró el socio", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            negocio_usuario.borrar_usuario(usuario);
            MessageBox.Show("El socio se ha borrado", "Socio borrado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
