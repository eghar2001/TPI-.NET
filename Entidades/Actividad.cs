using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Actividad
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [MaxLength(400)]
        public string Descripcion { get; set; }


        [Required]
        public decimal UltimoPrecio { get; set;  }

        public override string ToString()
        {
            return this.Nombre;
        }
        public override bool Equals(object obj)
        {
            if(obj is not Actividad)
            {
                return false;
            }
            Entidades.Actividad otra_actividad = (Entidades.Actividad)obj;
            return otra_actividad.Id == this.Id;
        }

    }
}
