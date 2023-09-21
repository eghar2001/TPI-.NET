using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class InscripcionTurno
    {
        private DateTime fechaHoraBaja;

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime FechaHoraInscripcion { get; set; }

        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        [Required]
        [ForeignKey("Turno")]
        public int TurnoId { get; set;  }
        public Turno Turno { get; set; } = null!;

        
        public DateTime FechaHoraBaja
        { get 
            {
                return fechaHoraBaja;
            }
            set
            {
                if (value <= FechaHoraInscripcion)
                {
                    throw new ArgumentException("Fecha de baja inválida");
                }
                this.fechaHoraBaja = value;
            }
        }

    }
}
