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
    public partial class EleccionClienteCompraProducto : Form
    {
        private Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        public EleccionClienteCompraProducto()
        {
            InitializeComponent();
        }
        private void EleccionClienteCompraProducto_Load(object sender, EventArgs e)
        {
            this.Listar();

            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();

            seleccionar.Name = "Seleccionar";
            seleccionar.Text = "Seleccionar";
            seleccionar.UseColumnTextForButtonValue = true;

            dgvUsuarios.Columns.Add(seleccionar);
        }

        private void Listar()
        {

            dgvUsuarios.DataSource = negocio_usuario.find_all().Where(u => u.TipoUsuarioId == 1).Select(u => new { u.Id, u.Nombre, u.Apellido }).ToList();

            dgvUsuarios.Refresh();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            List<Entidades.Usuario> allUsuarios = negocio_usuario.find_all();

            var usuariosFiltrados = from u in allUsuarios where (u.TipoUsuarioId == 1) && (u.Nombre.ToLower().Contains(txtNombreUsuario.Text.ToLower()) || u.Apellido.ToLower().Contains(txtNombreUsuario.Text.ToLower())) select new { u.Id, u.Nombre, u.Apellido };

            dgvUsuarios.DataSource = usuariosFiltrados.ToList();

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if ("Seleccionar" == dgvUsuarios.Columns[e.ColumnIndex].HeaderText)
                {
                    DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                    int idUsuario = Int32.Parse(row.Cells["Id"].Value.ToString());

                    ComprarProducto comprarProducto = new ComprarProducto(idUsuario);
                    comprarProducto.ShowDialog();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
