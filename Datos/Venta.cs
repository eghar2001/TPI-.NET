using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Venta
    {
        public List<Entidades.Venta> find_all(Entidades.Usuario usuario)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
               

                return context.Ventas.Where(v => v.UsuarioId == usuario.Id).ToList();
            }
        }


        public void agregar_venta(Entidades.Venta venta)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Update(venta.Producto);
                context.Add(venta);
                context.SaveChanges();
            }
        }
    }
}
