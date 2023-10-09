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
    public partial class ListadoProfesores : UserControl
    {
        private List<Entidades.Profesor> _profesores;
        private Entidades.Profesor _profesorSeleccionado;

        private List<Entidades.Profesor> _profesoresBusqueda;

        public List<Entidades.Profesor> Profesores
        {
            get
            {
                return this._profesores;
            }
            set
            {
                this._profesores = value;
                this._profesoresBusqueda = value;
                this.listboxProfesores.DataSource = this._profesores;
                AjustarAlturaListBox();
            }
        }
        public Entidades.Profesor ProfesorSeleccionado
        {
            get
            {
                return this._profesorSeleccionado;
            }
            set
            {
                this._profesorSeleccionado = value;
            }
        }

        public ListadoProfesores()
        {
            InitializeComponent();

        }
        private void Refrescar()
        {
            this.listboxProfesores.DataSource = _profesoresBusqueda;
            if (!_profesoresBusqueda.IsNullOrEmpty())
            {
                this.listboxProfesores.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("No hay profesores", "Sin instalaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            AjustarAlturaListBox();
        }


        private void listboxProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ProfesorSeleccionado = this._profesoresBusqueda[listboxProfesores.SelectedIndex];
        }

        private void AjustarAlturaListBox()
        {
            int itemHeight = listboxProfesores.ItemHeight;
            int border = SystemInformation.BorderSize.Height * 2; // Obtén el grosor del borde del ListBox.

            int listBoxHeight = ((listboxProfesores.Items.Count + 1) * itemHeight) + border;

            // Ajusta la altura del ListBox.
            listboxProfesores.Height = listBoxHeight;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this._profesoresBusqueda = Profesores;
            this.listboxProfesores.DataSource = this._profesoresBusqueda;
            this.ProfesorSeleccionado = null;
            if (!_profesoresBusqueda.IsNullOrEmpty())
            {
                Refrescar();
                this.listboxProfesores.SelectedIndex = 0;
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            _profesoresBusqueda = Profesores.Where(i => i.getNombApell().ToUpper().Contains(txtFiltrar.Text.ToUpper())).ToList();
            Refrescar();
            if (_profesoresBusqueda.IsNullOrEmpty()) {
                this.ProfesorSeleccionado = null;
            }
        }

    
    }
}
