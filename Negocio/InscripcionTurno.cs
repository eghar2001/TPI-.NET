using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    
    public class InscripcionTurno
    {
        private Datos.InscripcionTurno datos_inscripcionTurno = new Datos.InscripcionTurno();

        public List<Entidades.InscripcionTurno> find_all(int idUsuario)
        {
            return datos_inscripcionTurno.find_all(idUsuario);
        }

        public void agregarInscripcionTurno(Entidades.InscripcionTurno inscripcionTurno_nuevo)
        {
            datos_inscripcionTurno.agregarInscripcionTurno(inscripcionTurno_nuevo);
        }

        public void borrarInscripcionTurno(Entidades.InscripcionTurno inscripcionTurno)
        {
            datos_inscripcionTurno.borrarInscripcionTurno(inscripcionTurno);
        }
    }
}
