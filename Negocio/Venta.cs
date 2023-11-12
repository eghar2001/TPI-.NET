using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Venta
    {
        private readonly Datos.Venta datos_venta = new Datos.Venta();
        private readonly Datos.Producto datos_producto = new Datos.Producto();

        public List<Entidades.Venta> find_all(Entidades.Usuario usuario)
        {
            return datos_venta.find_all(usuario);
        }

        public void agregar_venta(Entidades.Venta venta)
        {

            if(venta.Cantidad > venta.Producto.Stock)
            {
                throw new StockInsuficienteException();
            }
            venta.Producto.Stock -= venta.Cantidad;

            datos_venta.agregar_venta(venta);

        }

        
    }

    public class StockInsuficienteException : Exception
    {
        public StockInsuficienteException() : base("La cantidad ingresada supera el stock disponible")
        {

        }
    } 
}
