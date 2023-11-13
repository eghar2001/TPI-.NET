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
    public partial class VerComprasSocio : Form
    {
        private Negocio.Producto negocio_producto = new Negocio.Producto();
        private Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        private Negocio.Venta negocio_venta = new Negocio.Venta();
        public VerComprasSocio()
        {
            InitializeComponent();

            lblNombreUsuario.Text = DatosLogin.UsuarioLogueado.Nombre + ' ' + DatosLogin.UsuarioLogueado.Apellido;
            lblTitulo.Text = "Mis Compras";
        }

        private void VerComprasSocio_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Listar()
        {
            List<Entidades.Venta> ventas = negocio_venta.find_all(DatosLogin.UsuarioLogueado);
            List<Entidades.Producto> productos = negocio_producto.find_all();

            var productosCompletos = from v in ventas join p in productos on v.ProductoId equals p.Id select new { p.Nombre, p.Descripcion, v.FechaVenta, v.Cantidad, v.PrecioUnitario, SubTotal = v.Cantidad*v.PrecioUnitario };

            dgvProductos.DataSource = productosCompletos.ToList() ;

            dgvProductos.Refresh();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
