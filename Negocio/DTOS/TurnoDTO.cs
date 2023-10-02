using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.DTOS
{
    public class TurnoDTO
    {
        
        public int Id { get; }

        public string Descripcion { get; }

        public decimal Precio { get;  }
        public string Actividad { get; } 

        public string Profesor { get;  } 

        public string Instalacion { get;}



        public TurnoDTO(Entidades.Turno turno)
        {
            Id = turno.Id;
            Descripcion = turno.Descripcion;
            Actividad = turno.Actividad.Nombre;
            Precio = turno.Actividad.UltimoPrecio;
            Profesor = turno.Profesor.getNombApell();
            Instalacion = turno.Instalacion.Titulo;
        }
    }
}
