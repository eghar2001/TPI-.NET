using Entidades;
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
    }
}
