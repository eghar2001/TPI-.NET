using Datos.Migrations;
using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.SymbolStore;
using Microsoft.IdentityModel.Tokens;

namespace Negocio
{
    public class Turno
    {
        private readonly Datos.Turno datos_turno = new Datos.Turno();
        private readonly Datos.Instalacion datos_instalacion = new Datos.Instalacion();
        private readonly Datos.Profesor datos_profesor = new Datos.Profesor();

        public List<Entidades.Turno> find_all()
        {
            return datos_turno.find_all();
        }

        public List<Entidades.Turno> getTurnosDTOActividad(Entidades.Actividad actividad)
        {
            List<Entidades.Turno> turnos = datos_turno.getTurnosActividad(actividad);
            
            
            return turnos;
        }
        public Entidades.Turno getTurno(int id)
        {
            Entidades.Turno? turno = datos_turno.getTurno(id);
           
            return turno;  
            
        }
        public List<Entidades.Horario> getHorariosTurno(Entidades.Turno turno)
        {
            List<Entidades.Horario> horarios = datos_turno.getHorariosTurno(turno);
            
            return horarios;
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
            bool horario_ocupado = datos_turno.turnoOcupaDiaSemana(turno, horario.DiaSemana);
            bool horario_superpuesto_inst = datos_instalacion.horarioInstalacionSuperpuesto(turno.Instalacion,horario);




            
            //Validaciones del profesor
            bool horario_superpuesto_prof = datos_profesor.horarioProfesorValido(turno.Profesor, horario);
            if (horario_ocupado)
            {
                throw new DiaOcupadoException("El turno ya ocupa el dia puesto");
            }
            if (horario_superpuesto_inst && horario_superpuesto_prof)
            {
                throw new HorarioSuperpuestoException("La instalacion y el profesor estan ocupados en los horarios del turno. Por favor, modifique los horarios");
            }
            if (horario_superpuesto_prof)
            {
                throw new HorarioSuperpuestoException("El profesor esta ocupado en ese horario. Por favor, modifique los horarios");
            }
            if (horario_superpuesto_inst)
            {
                throw new HorarioSuperpuestoException("La instalacion esta ocupada en los horarios del turno. Por favor, modifique los horarios");
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
        public void modificarTurno(Entidades.Turno turno)
        {
            //Tenemos que validar que los horarios de las instalaciones no se superponga con alguno de los horarios de la instalacion
            Entidades.Turno turno_orig = datos_turno.getTurno(turno.Id);
            bool horario_superpuesto_inst = false;
            bool horario_superpuesto_prof = false;
            List<Entidades.Horario> horarios = datos_turno.getHorariosTurno(turno);
            if (turno_orig.InstalacionId != turno.InstalacionId)
            {
                Entidades.Instalacion instalacion = datos_instalacion.get_one(turno.InstalacionId);

                horario_superpuesto_inst = datos_instalacion.horariosInstalacionSuperpuesto(instalacion, horarios);
                
            }
              
            //Validaciones del profesor
            if (turno_orig.ProfesorId != turno.ProfesorId)
            {
                Entidades.Profesor profesor = datos_profesor.get_one(turno.InstalacionId);
                horario_superpuesto_prof = datos_profesor.horariosProfesorValidos(profesor, horarios);
                
            }
            if (horario_superpuesto_prof && horario_superpuesto_inst)
            {
                throw new HorarioSuperpuestoException("La instalacion y el profesor estan ocupados en los horarios del turno");
            }
            if (horario_superpuesto_inst)
            {
                throw new HorarioSuperpuestoException("La instalacion esta ocupada en los horarios del turno");
            }
            if (horario_superpuesto_inst)
            {
                throw new HorarioSuperpuestoException("El profesor esta ocupado en los horarios del turno");
            }



            datos_turno.modificarTurno(turno);
        }
        public void borrarTurno(Entidades.Turno turno)
        {
            datos_turno.borrarTurno(turno);
        }
    }
    public class HorarioNoValidoException : Exception
    {
        public HorarioNoValidoException(string msg) : base(msg) 
        { 
        }
    }
    public class HorarioSuperpuestoException : Exception
    {
        public HorarioSuperpuestoException(string msg) : base(msg)
        {
        }
    }
    public class DiaOcupadoException : Exception
    {
        public DiaOcupadoException(string msg) : base(msg)
        {
        }
    }
}
