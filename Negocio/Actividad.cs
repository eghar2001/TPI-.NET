using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Actividad

    {

        private readonly Datos.Actividad datos_actividad = new Datos.Actividad();


        public List<Entidades.Actividad> find_all()
        {
            return datos_actividad.find_all();
        }
        public Entidades.Actividad? get(int actividad_id) 
        {
            return datos_actividad.get(actividad_id);
        }
        public void agregar_actividad(Entidades.Actividad actividad_nueva)
        {
            bool nombre_existente =datos_actividad.find_by_nombre(actividad_nueva.Nombre) != null;
            if (nombre_existente)
            {
                throw new NombreActividadExistenteException(); 
            }
            datos_actividad.agregar_actividad(actividad_nueva);
        }
        public void modificar_actividad(Entidades.Actividad actividad_modificada)
        {
            Entidades.Actividad actividad = datos_actividad.find_by_nombre(actividad_modificada.Nombre);
            if (actividad != null && actividad.Id != actividad_modificada.Id   )
            {
                throw new NombreActividadExistenteException();
            }
            datos_actividad.modificar_actividad(actividad_modificada);
        }
        public void borrar_actividad(Entidades.Actividad actividad_a_borrar) 
        {
            bool existe_actividad = datos_actividad.get(actividad_a_borrar.Id) != null;
            if (existe_actividad) { 
                datos_actividad.borrar_actividad(actividad_a_borrar);
            }
           
        }
    }
    

    public class NombreActividadExistenteException : Exception
    {
        public NombreActividadExistenteException():base("El nombre de la actividad ya existe") { }
    }
}
