using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Profesor
    {
        private readonly Datos.Profesor datos_profesor = new Datos.Profesor();

        public List<Entidades.Profesor> find_all()
        {
            return datos_profesor.find_all();
        }
        public List<Entidades.Horario> getHorariosProfesor(Entidades.Profesor profesor)
        {
            return datos_profesor.getHorariosProfesor(profesor);
        }

        

    }
}
