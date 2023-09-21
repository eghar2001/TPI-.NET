using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ValorReserva
    {
        private decimal precio;

        [Key]
        public int Id { get; set; }

        [ForeignKey("Instalacion")]
        [Required]
        public int InstalacionId { get; set; }

        
        
        public Instalacion Instalacion { get; set; } = null!;

        [Required]
        public DateTime FechaDesde { get; set; }

        [Required]
        public decimal Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(precio));
                }
                precio = value;
            }
        }
    }
}
