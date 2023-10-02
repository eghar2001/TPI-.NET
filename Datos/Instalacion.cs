using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Instalacion
    {
        

        public Entidades.Instalacion? get_by_Titulo(string titulo)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Instalaciones.FirstOrDefault(i => i.Titulo == titulo);
            }         
        }

        public Entidades.Instalacion? get_by_Id(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Instalaciones.FirstOrDefault(i => i.Id == id);
            }          
        }

        public List<Entidades.Instalacion> find_all()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Instalaciones.ToList();
            }           
        }

        public void agregar_instalacion(Entidades.Instalacion instalacion)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Add(instalacion);
                context.SaveChanges();
            }          
        }

       

        public void modificar_instalacion(Entidades.Instalacion instalacion_modificada)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Update(instalacion_modificada);
                context.SaveChanges();
            } 
        }



        public void remover_instalacion(Entidades.Instalacion instalacion)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Remove(instalacion);
                context.SaveChanges();  
            }
                
        }
        public List<Entidades.Horario> getHorariosInstalacion(Entidades.Instalacion instalacion)
        {
            using (var context = new ApplicationDbContext())
            {
               List<Entidades.Horario> horarios =  context.Horarios.Where(h => h.Turno.InstalacionId  == instalacion.Id).ToList();
                return horarios;
            }
        }
        public List<Entidades.Reserva> getReservasInstalacion(Entidades.Instalacion instalacion)
        {
            using (var context = new ApplicationDbContext())
            {
                List<Entidades.Reserva> reservas = context.Reservas.Where(r => r.InstalacionId == instalacion.Id).ToList();
                return reservas;
            }
        }


    }
}
