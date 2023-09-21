using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Instalacion")]
        public int InstalacionId { get; set; }
        public Instalacion Instalacion { get; set; }

        [Required]
        public DateTime FechaHoraReserva { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;

        [Required]
        public int DuracionEnHoras { get; set;  }

        [Required]
        public int CantidadAsitentes { get; set; }

        
        public DateTime FechaHoraUso { get; set; }




    }
}
