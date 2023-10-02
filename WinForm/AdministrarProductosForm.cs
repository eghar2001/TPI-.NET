using Datos;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class AdministrarProductosForm : Form
    {
        private Negocio.Producto negocio_producto = new Negocio.Producto();
        public AdministrarProductosForm()
        {
            InitializeComponent();
        }
        public void Listar()
        {
            dgvProductos.DataSource = negocio_producto.find_all();

            this.AgregarColumnaPrecio();


            dgvProductos.Refresh();
        }

        private void AdministrarProductosForm_Load(object sender, EventArgs e)
        {
            Listar();

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();

            colEditar.Name = "Editar";
            colBorrar.Name = "Borrar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;

            this.dgvProductos.Columns.Add(colEditar);
            this.dgvProductos.Columns.Add(colBorrar);

           

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            AgregarProductoForm productoForm = new AgregarProductoForm();
            productoForm.ShowDialog();
            if (productoForm.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void DgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvProductos.Columns[e.ColumnIndex].Name;

                if ("Editar" == dgvProductos.Columns[e.ColumnIndex].HeaderText)
                {
                    MessageBox.Show("Botón 'Editar' clickeado en la fila " + e.RowIndex + " id del producto: " + dgvProductos.Rows[e.RowIndex].Cells[0].Value);
                    DataGridViewRow row = dgvProductos.Rows[e.RowIndex];
                    int idProducto = Int32.Parse(row.Cells["Id"].Value.ToString());

                    ModificarProducto(idProducto);
                    
                }
                else if (columnName == "Borrar")
                {
                    MessageBox.Show("Botón 'Borrar' clickeado en la fila " + e.RowIndex);
                    int idProducto = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Id"].Value);
                    BorrarProducto(idProducto);
                }
            }

            
        }

        private void ModificarProducto(int idProducto)
        {
            Entidades.Producto producto = negocio_producto.get_one(idProducto);
            AgregarProductoForm modificarProductoForm = new AgregarProductoForm(producto);

            modificarProductoForm.ShowDialog();

        }

        private void BorrarProducto(int idProducto)
        {
            Entidades.Producto producto = negocio_producto.get_one(idProducto);

            negocio_producto.borrar_producto(producto);

        }

        private void AgregarColumnaPrecio()
        {
            List<Entidades.Producto> listaProductos = new List<Entidades.Producto>();
            listaProductos = negocio_producto.find_all();
            try
            {
                bool columnaPrecioExiste = dgvProductos.Columns.Cast<DataGridViewColumn>().Any(column => column.Name == "Precio");

                if (!columnaPrecioExiste)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = "Precio";
                    dgvProductos.Columns.Add(column);
                }

                foreach (Entidades.Producto lp in listaProductos)
                {
                    decimal vp = negocio_producto.get_ultimo_precio(lp.Id);

                    foreach (DataGridViewRow row in dgvProductos.Rows)
                    {
                        if (row.Cells["Id"].Value != null && row.Cells["Id"].Value.ToString() == lp.Id.ToString())
                        {
                            row.Cells["Precio"].Value = vp.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el precio: " + ex.Message);
            }
        }
    }
}
