using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ValorActividad
    {
        private decimal precio;

        [Key]
        public int Id { get; set; }

        [ForeignKey("Actividad")]
        [Required]       
        public int ActividadId { get; set; }


        public Actividad Actividad { get; set; } = null!;


        [Required]
        public DateTime FechaDesde { get; set; }

        [Required]
        public decimal Precio {
            get
            {
                return precio;
            }
            set
            {
                if (value < 0)
                {
                    throw  new ArgumentOutOfRangeException(nameof(precio));
                }
                precio = value;
            }
        }   
    }
}
