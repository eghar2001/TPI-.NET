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
                if (value == null)
                {
                    this._instalacionSeleccionada = null;
                    return;
                }
                else if (value is not Entidades.Instalacion)
                {
                    MessageBox.Show("No se ingresó un profesor");
                    return;
                }

                int index = this._instalacionesBusqueda.IndexOf(value);
                if (index == -1)
                {
                    MessageBox.Show("La instalacion ingresada no se encuentra");
                }
                else
                {
                    this.listboxInstalaciones.SelectedIndex = index;
                    this._instalacionSeleccionada = this._instalacionesBusqueda[index];
                }
            }
        }

        public ListadoInstalaciones()
        {
            InitializeComponent();
            AjustarAlturaListBox();
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
            if (!_instalacionesBusqueda.IsNullOrEmpty())
            {
                this.listboxInstalaciones.SelectedIndex = 0;
                Refrescar();
            }
           
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            _instalacionesBusqueda = Instalaciones.Where(i => i.Titulo.ToUpper().Contains(txtTitulo.Text.ToUpper())).ToList();
            Refrescar();
            if (_instalacionesBusqueda.IsNullOrEmpty())
            {
                this.InstalacionSeleccionada = null;
            }
        }

       
    }
}
