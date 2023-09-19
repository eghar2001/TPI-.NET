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
    public partial class ListadoProductosForm : Form
    {
        private readonly Negocio.Producto negocio_producto = new Negocio.Producto();
        public ListadoProductosForm()
        {
            InitializeComponent();


        }
        private void Listar()
        {
            this.dgvProductos.DataSource = null;
            this.dgvProductos.DataSource = this.negocio_producto.find_all();

            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                dgvProductos.Rows[i].Cells["Comprar"].Value = "Comprar";
            }


            this.dgvProductos.Refresh();
        }

        private void ListadoProductosForm_Load(object sender, EventArgs e)
        {

            DataGridViewButtonColumn comprarCol = new DataGridViewButtonColumn();
            int indexComprarCol = dgvProductos.Columns.IndexOf(comprarCol);
            if (indexComprarCol == -1)
            {
                comprarCol.Name = "Comprar";
                dgvProductos.Columns.Add(comprarCol);
            }
            this.Listar();

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (this.dgvProductos.Columns[e.ColumnIndex].Name == "Comprar")
            {
                this.Comprar((int)dgvProductos.CurrentRow.Cells["id"].Value);
            }
        }

        private void Comprar(int idProducto)
        {
            Entidades.Producto prod = negocio_producto.get_one(idProducto);
            ComprarProductoForm comprarForm = new ComprarProductoForm(prod);
            comprarForm.ShowDialog();
            if (comprarForm.DialogResult == DialogResult.OK)
            {
                this.Listar();
            }
        }
    }
}
