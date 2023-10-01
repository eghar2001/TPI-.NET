using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Profesor
    {

        public Entidades.Profesor get_one(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Profesores.FirstOrDefault(u => u.Id == id);
            }
        }

        public List<Entidades.Profesor> find_all()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Profesores.ToList();
            }
        }

        public void agregar_profesor(Entidades.Profesor profesor)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Add(profesor);
                context.SaveChanges();
            }
               
        }

        public void modificar_profesor(Entidades.Profesor profesor_modificado)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Update(profesor_modificado);
                context.SaveChanges();
            }
                
        }

        public void borrar_profesor(Entidades.Profesor profesor)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Remove(profesor);
                context.SaveChanges();
            }
               
        }


    }
}
