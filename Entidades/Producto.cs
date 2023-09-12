using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int stock;
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion {get; set; }
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
