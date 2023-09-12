using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ValorProducto
    {
        private decimal precio;
        public int ProductoId { get; set; }

        public DateTime FechaDesde { get; set; }

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
