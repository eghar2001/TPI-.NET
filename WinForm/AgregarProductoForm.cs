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
    public partial class AgregarProductoForm : Form
    {
        Negocio.Producto negocio_producto = new Negocio.Producto();
        private Entidades.Producto? producto_a_modificar = null;
        public AgregarProductoForm()
        {
            InitializeComponent();
        }

        public AgregarProductoForm(Entidades.Producto producto_original)
        {
            InitializeComponent();

            this.txtNombreProducto.Text = producto_original.Nombre;
            this.txtDescripcion.Text = producto_original.Descripcion;
            this.txtStock.Text = Convert.ToString(producto_original.Stock);
            this.txtPrecio.Text = Convert.ToString(negocio_producto.get_ultimo_precio(producto_original.Id));

            this.producto_a_modificar = producto_original;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            bool agregar = this.producto_a_modificar == null;
            if (agregar)
            {
                Entidades.Producto producto1 = new Entidades.Producto()
                {
                    Nombre = txtNombreProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    Stock = Int32.Parse(txtStock.Text)
                };



                try
                {
                    negocio_producto.agregar_producto(producto1);

                }
                catch (Exception ex)
                {

                }

                decimal ult_precio = Convert.ToDecimal(txtPrecio.Text);

                if (ult_precio > 0)
                {
                    Entidades.ValorProducto vp = new Entidades.ValorProducto()
                    {
                        ProductoId = producto1.Id,
                        FechaDesde = DateTime.Now,
                        Precio = ult_precio,
                    };

                    try
                    {
                        negocio_producto.agregar_Valorproducto(vp);

                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
            else
            {
                Entidades.Producto producto1 = new Entidades.Producto()
                {
                    Id = producto_a_modificar.Id,
                    Nombre = txtNombreProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    Stock = Int32.Parse(txtStock.Text)
                };
                decimal ult_precio = Convert.ToDecimal(txtPrecio.Text);

                if (ult_precio >= 0)
                {
                    Entidades.ValorProducto vp = new Entidades.ValorProducto()
                    {
                        ProductoId = producto_a_modificar.Id,
                        FechaDesde = DateTime.Now,
                        Precio = ult_precio,
                    };

                    try
                    {
                        negocio_producto.modificar_producto(producto1);
                        negocio_producto.agregar_Valorproducto(vp);
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }
    }
}
