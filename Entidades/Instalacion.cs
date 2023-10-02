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

        [MaxLength(400)]
        public string Descripcion { get; set; }

        [Required]
        public int Cupo { get; set; }

        public override string ToString()
        {
            return this.Titulo;
        }
    }
}
