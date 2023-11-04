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
        public List<Entidades.Horario> getHorariosTurno(Entidades.Turno turno)
        {
            using (var context = new ApplicationDbContext())
            {
                List<Entidades.Horario> horarios = context.Horarios
                    .Where(h => h.TurnoId == turno.Id)                    
                    .ToList();


                return horarios;
            }
        }
        public bool turnoOcupaDiaSemana(Entidades.Turno turno, DayOfWeek diaSemana)
        {
            using (ApplicationDbContext context = new ApplicationDbContext()) 
            {
                int cantidadOcupados = context.Horarios.Where(h => (h.TurnoId == turno.Id && h.DiaSemana == diaSemana)).Count();
                return cantidadOcupados > 0;
            }
        }
        public void agregarTurno(Entidades.Turno turno_nuevo)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Add(turno_nuevo);
                context.SaveChanges();
            }
        }
        public void modificarTurno(Entidades.Turno turno)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Update(turno);
                context.SaveChanges();
            }
        }
        public void borrarTurno(Entidades.Turno turno)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Remove(turno);
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
