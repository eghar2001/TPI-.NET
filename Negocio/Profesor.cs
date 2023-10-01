using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
  

    public class Profesor
    {
        Datos.Profesor datos_profesor = new Datos.Profesor();


        public Entidades.Profesor get_one(int id)
        {
            return datos_profesor.get_one(id);
        }
        public List<Entidades.Profesor> find_all()
        {
            return datos_profesor.find_all();
        }

        public void agregar_profesor(Entidades.Profesor profesor)
        {

            if (profesor.Salario < 0)
            {
                throw new ArgumentOutOfRangeException();   
            }

            datos_profesor.agregar_profesor(profesor);
        }

        public void modificar_profesor(Entidades.Profesor profesor_a_editar)
        {
            Entidades.Profesor? profesor;
            profesor = datos_profesor.get_one(profesor_a_editar.Id);
            datos_profesor.modificar_profesor(profesor_a_editar);
            //FALTAN VALIDACIONES
        }

        public void borrar_profesor(int  id)
        {
            Entidades.Profesor profesor = datos_profesor.get_one(id);
            datos_profesor.borrar_profesor(profesor);
           
        }
    }
}
