using Entidades;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
                context.Add(new ValorReserva()
                {
                    Precio = instalacion.UltimoPrecio,
                    Instalacion = instalacion
                });
                context.SaveChanges();
            }          
        }



        public void modificar_instalacion(Entidades.Instalacion instalacion_modificada)
        {
            Entidades.Instalacion instalacion_original = get_by_Id(instalacion_modificada.Id);
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Update(instalacion_modificada);
                if (instalacion_original.UltimoPrecio != instalacion_modificada.UltimoPrecio)
                {
                    context.Add(new ValorReserva()
                    {
                        InstalacionId = instalacion_modificada.Id,
                        Precio = instalacion_modificada.UltimoPrecio
                    });
                    context.SaveChanges();
                }
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

        public List<Entidades.Instalacion> BuscarInstalacionesDisponibles(DateTime fechaHoraReserva, int duracionEnHoras, int cant)
        {
            using (var context = new ApplicationDbContext()) 
            {
                List<Entidades.Instalacion> instalaciones = context.Instalaciones.ToList();
                List<Entidades.Instalacion> instalacionesReservadas = context.Reservas
                    .Where(r => r.Instalacion.Cupo < cant &&
                        !(r.FechaHoraReserva > fechaHoraReserva.AddHours(duracionEnHoras) ||
                        r.FechaHoraReserva.AddHours(r.DuracionEnHoras) < fechaHoraReserva)) .Select(r => r.Instalacion).Distinct()
                    .ToList();

                //return context.Instalaciones.Where(i => !instalacionesReservadas.Contains(i.Id) && i.Cupo >=cant).ToList();
                instalaciones.RemoveAll( i => instalacionesReservadas.Contains(i));
                return instalaciones;
                
            }
        }
    }
}
