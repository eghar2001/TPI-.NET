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
        [Required]
        private int stock;
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = null!;
        [Required]
        public string Descripcion {get; set; }

        
        public Producto(string nombreProducto, string descripcion, int stock) 
        { 
           Nombre = nombreProducto;
           Descripcion = descripcion;
           Stock = stock;
        }

        
        public Producto() 
        { 

        }
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
        //[Required]
      //  public decimal UltPrecio { get; set; }
        public List<ValorProducto> Valores { get; set; } = new List<ValorProducto>();
    }
}
