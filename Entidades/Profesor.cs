using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public decimal Salario { get; set; }

        public string getNombApell()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public override string ToString()
        {
            return this.getNombApell();
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) 
                return false;
            if (!(obj is Profesor)) 
                return false;
            Entidades.Profesor otro_profe = (Entidades.Profesor)obj;
            return otro_profe.Id == this.Id;
        }
    }
}
