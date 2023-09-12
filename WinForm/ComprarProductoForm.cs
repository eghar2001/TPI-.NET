using Datos;
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
        private Entidades.Producto producto;
        public ComprarProductoForm(Entidades.Producto prod)
        {
            InitializeComponent();
            this.producto = prod;
        }

        private void ComprarProductoForm_Load(object sender, EventArgs e)
        {
            this.lblNombreProducto.Text = this.producto.Nombre;
            decimal ult_precio = negocio_producto.get_ultimo_precio(producto.Id);
            this.lblPrecio.Text += " $" + ult_precio;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
