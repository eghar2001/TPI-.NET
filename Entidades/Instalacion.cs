using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Instalacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [StringLength(maximumLength:400)]
        public string Descripcion { get; set; }

        [Required]
        public int Cupo { get; set; }

        [Required]
        public decimal UltimoPrecio { get; set; }

        public override string ToString()
        {
            return this.Titulo;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Entidades.Instalacion))
                return false;
            Entidades.Instalacion otra_inst = (Entidades.Instalacion)obj;
            return otra_inst.Id == this.Id;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
