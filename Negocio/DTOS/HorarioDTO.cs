using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DTOS
{
    public class HorarioDTO
    {
        public string DiaSemana {
            get;
        }
        public TimeOnly HoraInicio
        {
            get;
        }
        public TimeOnly HoraFin
        {
            get;
        }
       


        public HorarioDTO(Entidades.Horario horario) 
        {
            this.HoraInicio = horario.HoraInicioTime;
            this.HoraFin = horario.HoraFinTime;
            this.DiaSemana = horario.DiaSemanaEsp;

        }
        
    }
}
