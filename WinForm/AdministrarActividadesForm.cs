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
    public partial class AdministrarActividadesForm : Form
    {
        private readonly Negocio.Actividad negocio_actividad = new Negocio.Actividad();
        public AdministrarActividadesForm()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            
            this.dgvActividades.DataSource = negocio_actividad.find_all();
            this.dgvActividades.Columns.Remove("Id");
            this.dgvActividades.Columns.Remove("InstalacionId");


        }

        private void AdministrarActividadesForm_Load(object sender, EventArgs e)
        {

            this.Listar();
            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.HeaderText = "Editar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue= true;
            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            colBorrar.HeaderText = "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;

            this.dgvActividades.Columns.Add(colEditar);
            this.dgvActividades.Columns.Add(colBorrar);
            


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
