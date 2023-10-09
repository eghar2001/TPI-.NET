using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.Componentes
{
    public partial class ListadoInstalaciones : UserControl
    {
        private List<Entidades.Instalacion> _instalaciones;
        private Entidades.Instalacion _instalacionSeleccionada;

        private List<Entidades.Instalacion> _instalacionesBusqueda;

        public List<Entidades.Instalacion> Instalaciones
        {
            get
            {
                return this._instalaciones;
            }
            set
            {
                this._instalaciones = value;
                this._instalacionesBusqueda = value;
                this.listboxInstalaciones.DataSource = this._instalaciones;
                AjustarAlturaListBox();
            }
        }
        public Entidades.Instalacion InstalacionSeleccionada
        {
            get
            {
                return this._instalacionSeleccionada;
            }
            set
            {
                this._instalacionSeleccionada = value;
            }
        }

        public ListadoInstalaciones()
        {
            InitializeComponent();

        }
        private void Refrescar()
        {
            this.listboxInstalaciones.DataSource = _instalacionesBusqueda;
            if (!_instalacionesBusqueda.IsNullOrEmpty())
            {
                this.listboxInstalaciones.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No hay instalaciones", "Sin instalaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            AjustarAlturaListBox();
        }


        private void listboxInstalaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InstalacionSeleccionada = this._instalacionesBusqueda[listboxInstalaciones.SelectedIndex];
        }

        private void AjustarAlturaListBox()
        {
            int itemHeight = listboxInstalaciones.ItemHeight;
            int border = SystemInformation.BorderSize.Height * 2; // Obtén el grosor del borde del ListBox.

            int listBoxHeight = ((listboxInstalaciones.Items.Count + 1) * itemHeight) + border;

            // Ajusta la altura del ListBox.
            listboxInstalaciones.Height = listBoxHeight;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this._instalacionesBusqueda = Instalaciones;
            this.txtTitulo.Text = "";
            this.listboxInstalaciones.SelectedIndex = 0;
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            _instalacionesBusqueda = Instalaciones.Where(i => i.Titulo.ToUpper().Contains(txtTitulo.Text.ToUpper())).ToList();
            Refrescar();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this._instalacionesBusqueda = Instalaciones;
            this.listboxInstalaciones.DataSource = this._instalacionesBusqueda;
            if (!_instalacionesBusqueda.IsNullOrEmpty())
            {
                this.listboxInstalaciones.SelectedIndex = 0;
            }
        }
    }
}
