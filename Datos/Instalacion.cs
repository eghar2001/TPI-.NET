using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Instalacion
    {
        private readonly ApplicationDbContext context;

        

        public Instalacion()
        {
            context = new ApplicationDbContext();
        }

        public Entidades.Instalacion? get_by_Titulo(string titulo)
        {
            return context.Instalaciones.FirstOrDefault(i => i.Titulo == titulo);
        }

        public Entidades.Instalacion? get_by_Id(int id)
        {
            return context.Instalaciones.FirstOrDefault(i => i.Id == id);
        }

        public List<Entidades.Instalacion> find_all()
        {
            return context.Instalaciones.ToList();
        }

        public void agregar_instalacion(Entidades.Instalacion instalacion)
        {
            context.Add(instalacion);
            context.SaveChanges();
        }

       

        public void modificar_instalacion(Entidades.Instalacion instalacion_modificada)
        {

            context.Update(instalacion_modificada);
            context.SaveChanges();
        }



        public void remover_instalacion(Entidades.Instalacion instalacion)
        {
                context.Remove(instalacion);
                context.SaveChanges();  
        }
    }
}
