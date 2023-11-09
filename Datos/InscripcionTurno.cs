using Microsoft.EntityFrameworkCore;
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
                List<Entidades.InscripcionTurno> inscripciones_usuario = context.InscripcionesTurno.Where(i => i.UsuarioId == idUsuario && i.FechaHoraBaja == DateTime.MinValue)
                                                                        .Include(i => i.Turno).Include(i => i.Usuario).Include(i => i.Turno.Actividad)
                                                                        .ToList();

                return inscripciones_usuario;
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
        public void actualizarInscripcionTurno(Entidades.InscripcionTurno inscripcionTurno_nuevo)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Update(inscripcionTurno_nuevo);
                context.SaveChanges();
            }
        }
        public Entidades.InscripcionTurno? get_one(int id_inscripcion)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                Entidades.InscripcionTurno inscripcion = context.InscripcionesTurno.FirstOrDefault(i => i.Id == id_inscripcion);
                return inscripcion;

            }
        }
        public List<Entidades.Usuario> sociosInscriptosAActividad (int id_actividad)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                List<Entidades.Usuario> socios_inscriptos = context.InscripcionesTurno.Include(i => i.Turno).Where(i => i.Turno.ActividadId == id_actividad && i.FechaHoraBaja == DateTime.MinValue).Select(i => i.Usuario).Distinct().ToList();
                return socios_inscriptos;
            }
            
        }
        



    }
}
