using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Turno
    {
        public List<Entidades.Turno> getTurnosActividad(Entidades.Actividad actividad)
        {
            using (var context = new ApplicationDbContext())
            {
                List<Entidades.Turno> turnos = context.Turnos
                    .Where(t => t.ActividadId == actividad.Id)
                    .Include(t => t.Actividad)
                    .Include(t => t.Instalacion)
                    .Include(t => t.Profesor)
                    .ToList();


                return turnos;
            }
        }
        public Entidades.Turno? getTurno(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                Entidades.Turno turno = context.Turnos
                    .Include(t => t.Actividad)
                    .Include(t => t.Instalacion)
                    .Include(t => t.Profesor)
                    .Include(t => t.Horarios)
                    .FirstOrDefault(t => t.Id == id);
                    


                return turno;
            }
        }
        public List<Entidades.Horario> getHorariosTurno(int turno_id)
        {
            using (var context = new ApplicationDbContext())
            {
                List<Entidades.Horario> horarios = context.Horarios
                    .Where(h => h.TurnoId == turno_id)                    
                    .ToList();


                return horarios;
            }
        }
        public void agregarTurno(Turno turno_nuevo)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Add(turno_nuevo);
                context.SaveChanges();
            }
        }
        public void agregarHorarioTurno(Horario horario_nuevo)
        {
            using(var context = new ApplicationDbContext())
            {
                context.Add(horario_nuevo);
                context.SaveChanges();
            }
        }
        public void borrarHorarioTurno(Horario horario)
        {
            using(var context = new ApplicationDbContext())
            {
                context.Remove(horario);
                context.SaveChanges();
            }
        }
    }
}
