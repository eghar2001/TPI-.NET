using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class InscripcionTurno
    {
        public List<Entidades.InscripcionTurno> find_all(int idUsuario)
        {
            using (var context = new ApplicationDbContext())
            {
                var todas_las_inscripciones = context.InscripcionesTurno.ToList();

                var inscripciones_usuario = from iu in todas_las_inscripciones where iu.UsuarioId == idUsuario select iu;

                return inscripciones_usuario.ToList();
            }
        }

        public void agregarInscripcionTurno(Entidades.InscripcionTurno inscripcionTurno_nuevo)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Add(inscripcionTurno_nuevo);
                context.SaveChanges();
            }
        }

        public void borrarInscripcionTurno(Entidades.InscripcionTurno inscripcionTurno)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Remove(inscripcionTurno);
                context.SaveChanges();
            }
        }
    }
}
