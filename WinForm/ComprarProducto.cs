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
    public partial class ComprarProducto : Form
    {
        private Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        private Negocio.Producto negocio_producto = new Negocio.Producto();
        private Negocio.Venta negocio_venta = new Negocio.Venta();
        private Entidades.Usuario usuario_seleccionado = null;
        private List<Entidades.Venta> carrito = new List<Entidades.Venta>();

        public ComprarProducto(int idUsuario)
        {
            InitializeComponent();

            this.usuario_seleccionado = negocio_usuario.get(idUsuario);
            lblTitulo.Text = "Comprar productos para: '" + usuario_seleccionado.NombreApellido + "'";

        }

        private void ComprarProducto_Load(object sender, EventArgs e)
        {
            this.Listar();

            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();

            eliminar.Text = "Eliminar";
            eliminar.Name = "Eliminar";
            eliminar.UseColumnTextForButtonValue = true;

            dgvProductosCliente.Columns.Add(eliminar);


            dgvProductosCliente.DataSource = carrito.Select(c => new { Id = c.ProductoId, c.Cantidad }).ToList();

            DataGridViewTextBoxColumn cantidad = new DataGridViewTextBoxColumn();

            cantidad.Name = "Cantidad";
            dgvProductos.Columns.Add(cantidad);

            DataGridViewButtonColumn seleccionar = new DataGridViewButtonColumn();

            seleccionar.Name = "Seleccionar";
            seleccionar.Text = "Seleccionar";
            seleccionar.UseColumnTextForButtonValue = true;

            dgvProductos.Columns.Add(seleccionar);
        }

        private void Listar()
        {
            dgvProductos.DataSource = negocio_producto.find_all();

            this.AgregarColumnaPrecio(this.dgvProductos);

            dgvProductos.Refresh();
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.DataSource = negocio_producto.find_all().Where(p => p.Nombre.ToLower().Contains(txtNombreProducto.Text.ToLower())).ToList();
            this.AgregarColumnaPrecio(this.dgvProductos);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if ("Seleccionar" == dgvProductos.Columns[e.ColumnIndex].HeaderText)
                {
                    DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                    int cantidad = row.Cells["Cantidad"].Value != null ? Int32.Parse(row.Cells["Cantidad"].Value.ToString()) : 0;
                    int stock = Int32.Parse(row.Cells["Stock"].Value.ToString());
                    if (stock > 0 && cantidad > 0 && stock >= cantidad)
                    {
                        Entidades.Venta venta = new Entidades.Venta
                        {
                            ProductoId = Int32.Parse(row.Cells["Id"].Value.ToString()),
                            Cantidad = Int32.Parse(row.Cells["Cantidad"].Value.ToString()),

                        };

                        bool band = true;
                        List<Entidades.Producto> productos = negocio_producto.find_all();
                        foreach (Entidades.Venta ca in carrito)
                        {
                            if (ca.ProductoId == venta.ProductoId)
                            {
                                band = false;
                                DataGridViewRow rowCliente = dgvProductosCliente.Rows.Cast<DataGridViewRow>().Where(r => Convert.ToInt32(r.Cells["Id"].Value) == ca.ProductoId).FirstOrDefault();
                                int cantidadAnterior = Int32.Parse(rowCliente.Cells["Cantidad"].Value.ToString());
                                if ((cantidadAnterior + Int32.Parse(row.Cells["Cantidad"].Value.ToString())) <= Int32.Parse(row.Cells["Stock"].Value.ToString()))
                                {

                                    ca.Cantidad = cantidadAnterior + Int32.Parse(row.Cells["Cantidad"].Value.ToString());

                                    var carritoCompleto = from carr in carrito join p in productos on carr.ProductoId equals p.Id select new { p.Id, p.Nombre, p.Descripcion, carr.Cantidad };

                                    dgvProductosCliente.DataSource = carritoCompleto.ToList();
                                    this.AgregarColumnaPrecio(this.dgvProductosCliente);
                                    dgvProductosCliente.Refresh();

                                }
                                else
                                {
                                    MessageBox.Show("La cantidad supera el stock");
                                }

                                break;
                            }
                        }


                        if (band)
                        {
                            carrito.Add(venta);

                            var carritoCompleto = from carr in carrito join p in productos on carr.ProductoId equals p.Id select new { p.Id, p.Nombre, p.Descripcion, carr.Cantidad };

                            dgvProductosCliente.DataSource = carritoCompleto.ToList();
                            this.AgregarColumnaPrecio(this.dgvProductosCliente);
                            dgvProductosCliente.Refresh();
                        }

                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mayor a 0 o el stock es insuficiente");
                    }


                }


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            foreach (Entidades.Venta c in carrito)
            {
                DataGridViewRow rowCliente = dgvProductosCliente.Rows.Cast<DataGridViewRow>().Where(r => Convert.ToInt32(r.Cells["Id"].Value) == c.ProductoId).FirstOrDefault();
                int cantidad = Int32.Parse(rowCliente.Cells["Cantidad"].Value.ToString());

                Entidades.Producto producto_a_modificar = negocio_producto.get_one(c.ProductoId);

                c.Producto = producto_a_modificar;

                producto_a_modificar.Stock -= cantidad;

                c.UsuarioId = usuario_seleccionado.Id;
                c.FechaVenta = DateTime.Now;
                c.PrecioUnitario = decimal.Parse(rowCliente.Cells["Precio"].Value.ToString());


                negocio_venta.agregar_venta(c);
                negocio_producto.modificar_producto(producto_a_modificar);



            }
            DialogResult = DialogResult.OK;
        }
        private void AgregarColumnaPrecio(DataGridView dgvProductos)
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

        private void dgvProductosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if ("Eliminar" == dgvProductosCliente.Columns[e.ColumnIndex].HeaderText)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Está seguro que quiere eliminar este producto?", "Advertencia", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataGridViewRow producto = dgvProductosCliente.Rows[e.RowIndex];

                        Entidades.Venta venta = null;

                        foreach (Entidades.Venta v in carrito)
                        {
                            if (v.ProductoId == Int32.Parse(producto.Cells["Id"].Value.ToString()))
                            {
                                venta = v; break;
                            }

                        }

                        carrito.Remove(venta);

                        List<Entidades.Producto> productos = negocio_producto.find_all();
                        var carritoCompleto = from carr in carrito join p in productos on carr.ProductoId equals p.Id select new { p.Id, p.Nombre, p.Descripcion, carr.Cantidad };

                        dgvProductosCliente.DataSource = null;
                        dgvProductosCliente.DataSource = carritoCompleto.ToList();
                        this.AgregarColumnaPrecio(this.dgvProductosCliente);
                        dgvProductosCliente.Refresh();

                    }
                }
            }


        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
