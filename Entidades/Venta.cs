using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {

        private int cantidad;

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; } = null!;

        [Required]
        public DateTime FechaVenta { get; set; }

        [Required]
        [ForeignKey("Producto")]
        public int ProductoId { get; set; }
        public Producto Producto { get; set; } = null!;
        
        

        [Required]
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(cantidad));
                }
                cantidad = value;
            }
        }



        public decimal PrecioUnitario { get; set; } 

    }
}
