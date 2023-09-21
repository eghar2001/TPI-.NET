using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int stock;

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = null!;

        [MaxLength(400)]
        public string Descripcion {get; set; }

        [Required]
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(stock));
                }
                this.stock = value;
            }
        } 
        public List<ValorProducto> Valores { get; set; } = new List<ValorProducto>();
    }
}
