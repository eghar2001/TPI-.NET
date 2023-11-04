using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Descripcion { get; set; }


        [Required]
        [ForeignKey("Actividad")]
        public int ActividadId { get; set; }

        public Actividad Actividad { get; set; } = null!;

        [Required]
        [ForeignKey("Profesor")]
        public int ProfesorId { get; set; }

        public Profesor Profesor { get; set; } = null!;



        [Required]
        [ForeignKey("Instalacion")]
        public int InstalacionId { get;set; }
        public Instalacion Instalacion { get; set; } = null!;

        public List<Horario> Horarios { get; set; }
    }
}
