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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _instalacionesBusqueda = Instalaciones.Where(i => i.Titulo.Contains(txtTitulo.Text)).ToList();
            this.listboxInstalaciones.DataSource = _instalacionesBusqueda;
            this.listboxInstalaciones.SelectedIndex = 0;
        }

        private void listboxInstalaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.InstalacionSeleccionada = this._instalacionesBusqueda[listboxInstalaciones.SelectedIndex];
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this._instalacionesBusqueda = Instalaciones;
            this.txtTitulo.Text = "";
            this.listboxInstalaciones.SelectedIndex = 0;
        }
    }
}
