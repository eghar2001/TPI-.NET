using Datos;
using Negocio;
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
    public partial class ComprarProductoForm : Form
    {
        private readonly Negocio.Producto negocio_producto = new Negocio.Producto();
        private readonly Negocio.Venta negocio_venta = new Negocio.Venta();
        private decimal ult_precio = 0;
        private Entidades.Producto producto;
        public ComprarProductoForm(Entidades.Producto prod)
        {
            InitializeComponent();
            this.producto = prod;
        }

        private void ComprarProductoForm_Load(object sender, EventArgs e)
        {
            this.lblNombreProducto.Text = this.producto.Nombre;
            this.lblDescripcion.Text = this.producto.Descripcion;
            this.ult_precio = negocio_producto.get_ultimo_precio(producto.Id);
            this.lblPrecio.Text += " $" + ult_precio;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Entidades.Venta nuevaVenta = new Entidades.Venta()
            {
                UsuarioId = DatosLogin.UsuarioLogueado.Id,
                Producto = producto,
                ProductoId = producto.Id,
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioUnitario = this.ult_precio
            };
            try 
            {
                negocio_venta.agregar_venta(nuevaVenta);
                this.DialogResult = DialogResult.OK;
            }
            catch (StockInsuficienteException x) 
            {
                MessageBox.Show("El stock es insuficiente", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
