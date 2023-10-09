using Negocio.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Turno
    {
        private readonly Datos.Turno datos_turno = new Datos.Turno();
        private readonly Datos.Instalacion datos_instalacion = new Datos.Instalacion();
        private readonly Datos.Profesor datos_profesor = new Datos.Profesor();
        public static readonly Dictionary<string, DayOfWeek> diasSemana = new Dictionary<string, DayOfWeek>()
        {
            {"Lunes",DayOfWeek.Monday },
            {"Martes",DayOfWeek.Tuesday },
            {"Miercoles",DayOfWeek.Wednesday },
            {"Jueves",DayOfWeek.Thursday },
            {"Viernes",DayOfWeek.Friday },
            {"Sabado",DayOfWeek.Saturday },
            {"Domingo",DayOfWeek.Sunday },
        };
        

        public List<TurnoDTO> getTurnosDTOActividad(Entidades.Actividad actividad)
        {
            List<Entidades.Turno> turnos = datos_turno.getTurnosActividad(actividad);
            List<TurnoDTO> turnosDTO = new List<TurnoDTO>();  
            foreach (Entidades.Turno turno in turnos)
            {
                turnosDTO.Add(new TurnoDTO(turno));
            }
            return turnosDTO;
        }
        public TurnoDTO getTurno(int id)
        {
            Entidades.Turno? turno = datos_turno.getTurno(id);
           
            return new TurnoDTO(turno);  
            
        }
        public List<HorarioDTO> getHorariosTurno(int turno_id)
        {
            List<Entidades.Horario> horarios = datos_turno.getHorariosTurno(turno_id);
            List<HorarioDTO> horariosDTO = new List<HorarioDTO>();
            foreach(Entidades.Horario hor in horarios)
            {
                horariosDTO.Add(new HorarioDTO(hor));
            }
            return horariosDTO;
        }
        public void agregarHorarioTurno(Entidades.Horario horario)
        {
            if (horario == null)
            {
                throw new ArgumentNullException(nameof(horario));
            }
            if (horario.HoraFinTime<= horario.HoraInicioTime)
            {
                throw new HorarioNoValidoException("No se ha ingresado una hora de inicio y de fin valida");
            }
            Entidades.Turno turno = datos_turno.getTurno(horario.TurnoId);

            //Validaciones de instalacion
            List<Entidades.Horario> horarios_instalacion = datos_instalacion.getHorariosInstalacion(turno.Instalacion);
            Entidades.Horario? horario_inst_superpuesto = horarios_instalacion.Find(h => h.seSuperponeCon(horario));
            if (horario_inst_superpuesto != null)
            {
                throw new HorarioNoValidoException("La instalacion '"+turno.Instalacion.Titulo+"' está ocupada en ese horario");
            }

            


            //Validaciones del profesor
            List<Entidades.Horario> horarios_profesor = datos_profesor.getHorariosProfesor(turno.Profesor);
            Entidades.Horario? horario_prof_superpuesto = horarios_profesor.Find(h => h.seSuperponeCon(horario));
            if (horario_prof_superpuesto != null)
            {
                throw new HorarioNoValidoException("El profesor '"+turno.Profesor.getNombApell()+"' se encuentra ocupado en ese horario");
            }

            

            datos_turno.agregarHorarioTurno(horario);
        }
        public void borrarHorarioTurno(Entidades.Horario horario)
        {
            datos_turno.borrarHorarioTurno(horario);
        }

        public void agregarTurno(Entidades.Turno turno_nuevo)
        {
            datos_turno.agregarTurno(turno_nuevo);
        }
    }
    public class HorarioNoValidoException : Exception
    {
        public HorarioNoValidoException(string msg) : base(msg) 
        { 
        }
    }
}
