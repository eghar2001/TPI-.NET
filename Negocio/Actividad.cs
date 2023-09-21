using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Actividad
    {
        private readonly Datos.Actividad datos_actividad = new Datos.Actividad();


        public List<Entidades.Actividad> find_all()
        {
            return datos_actividad.find_all();
        }
    }
}
