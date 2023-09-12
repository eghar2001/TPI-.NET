using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        private int cantidad;
        public int UsuarioId { get; set; }
        public int ProductoId { get; set; }
        public DateTime FechaVenta { get; set; }
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

        public decimal Precio { get; set; } 

    }
}
