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
    }
}
