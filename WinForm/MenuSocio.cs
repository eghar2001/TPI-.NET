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
    public partial class MenuSocio : Form
    {
        public MenuSocio()
        {
            InitializeComponent();
        }

        private void MenuSocio_Load(object sender, EventArgs e)
        {
            this.lblNombre.Text = DatosLogin.UsuarioLogueado.Nombre + " " + DatosLogin.UsuarioLogueado.Apellido;
            this.lblDni.Text = "" + DatosLogin.UsuarioLogueado.Dni;
        }






        private void btnInstalaciones_Click(object sender, EventArgs e)
        {
            this.subPanelnstalaciones.Visible = !this.subPanelnstalaciones.Visible;
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            this.subPanelActividades.Visible = !this.subPanelActividades.Visible;
        }

        private void btnManejoSocios_Click(object sender, EventArgs e)
        {
            Socios administrarSocios = new Socios();
            administrarSocios.ShowDialog();
        }

        private void btnMisCompras_Click(object sender, EventArgs e)
        {
            VerComprasSocio verComprasSocio = new VerComprasSocio();

            verComprasSocio.ShowDialog();
        }
    }
}
