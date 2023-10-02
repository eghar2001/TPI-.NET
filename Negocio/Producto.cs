using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProductoInexistenteException : Exception
    {

    }
    public class NombreProductoRepetidoException : Exception 
    {
        public NombreProductoRepetidoException() : base("El nombre del producto se encuentra repetido") 
        {

        }
    }
    public class Producto
    {
        private readonly Datos.Producto datos_producto;
        public Producto()
        {
            this.datos_producto = new Datos.Producto();
        }

        public List<Entidades.Producto> find_all()
        {
            return datos_producto.find_all();
        }
        public Entidades.Producto get_one(int id)
        {
            Entidades.Producto prod =  datos_producto.get_one(id);
            if (prod == null)
            {
                throw new ProductoInexistenteException();
            }
            return prod;
        }

        public decimal get_ultimo_precio(int productoId)
        {
            return datos_producto.get_ultimo_precio(productoId);
        }

        public void agregar_producto(Entidades.Producto producto)
        {
            if (datos_producto.get_one(producto.Id) != null)
            {
                throw new NombreProductoRepetidoException();
            }
            datos_producto.agregar_producto(producto);
        }

        public void borrar_producto(Entidades.Producto producto)
        {
            datos_producto.remover_producto(producto);
        }

        public void modificar_producto(Entidades.Producto producto_modificado)
        {
            datos_producto.modificar_producto(producto_modificado);
        
        }

        public void agregar_Valorproducto(Entidades.ValorProducto valor_producto)
        {

            decimal ultimo_precio = datos_producto.get_ultimo_precio(valor_producto.ProductoId);

            if(ultimo_precio != valor_producto.Precio )
            {
                datos_producto.agregar_valorProducto(valor_producto);
            }

        }



    }
}
