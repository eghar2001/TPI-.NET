using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Horario
    {
        [NotMapped]
        public static readonly DayOfWeek[] diasSemana = new DayOfWeek[7] {DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday,
                                                    DayOfWeek.Saturday, DayOfWeek.Sunday};
        [NotMapped]
        public static readonly string[] diasSemanaEsp = new string[7] { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        [Required]
        [ForeignKey("Turno")]
        public int TurnoId { get; set; }

        public Turno Turno { get; set; }

        [Required]
        public DayOfWeek DiaSemana { get; set; }

        [Required]
        public string HoraInicio { get; set; }

        [Required]
        public string HoraFin { get; set; }


        [NotMapped]
        public TimeOnly HoraInicioTime 
        {
            get 
            {
                return TimeOnly.Parse(HoraInicio);            
            }
            
        }

        [NotMapped]
        public TimeOnly HoraFinTime 
        { 
            get 
            {
                return TimeOnly.Parse(HoraFin);
            }
        }

        [NotMapped]
        public string DiaSemanaEsp
        {
            get
            {
                switch (DiaSemana)
                {
                    case DayOfWeek.Monday:
                        return "Lunes";
                        break;
                    case DayOfWeek.Tuesday:
                        return "Martes";
                        break;
                    case DayOfWeek.Wednesday:
                        return "Miercoles";
                        break;
                    case DayOfWeek.Thursday:
                        return "Jueves";
                        break;
                    case DayOfWeek.Friday:
                        return "Viernes";
                        break;
                    case DayOfWeek.Saturday:
                        return "Sabado";
                        break;
                    case DayOfWeek.Sunday:
                        return "Sabado";
                        break;
                    default:
                        return "";
                        break;
                }
            }
        }

       

        public override string ToString()
        {
            return this.DiaSemanaEsp+ " " + this.HoraInicio+"-"+ this.HoraFin;
        }

        public bool seSuperponeCon(Entidades.Horario otro_horario)
        {
            if (this.DiaSemana != otro_horario.DiaSemana)
            {
                return false;
            }
            return !(otro_horario.HoraFinTime < this.HoraInicioTime || otro_horario.HoraInicioTime > this.HoraFinTime);
        }

        
    }
}
