using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Venta
    {
        private readonly ApplicationDbContext context;

        public Venta()
        {
            context = new ApplicationDbContext();
        }

        public void agregar_venta(Entidades.Venta venta)
        {
            context.Update(venta.Producto);
            context.Add(venta);
            context.SaveChanges();
        }
    }
}
