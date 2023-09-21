using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Actividad
    {
        private readonly ApplicationDbContext context = new ApplicationDbContext();

        public List<Entidades.Actividad> find_all()
        {
            return context.Actividades.ToList();
        }
    }
}
