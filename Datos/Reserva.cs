using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Reserva
    {
        public List <Entidades.Reserva> find_all()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Reservas.ToList();
            }
        }
        public Entidades.Reserva? get_by_Id(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Reservas.FirstOrDefault(r => r.Id== id);
            }
        }
        public List <Entidades.Reserva> get_by_UsuarioId(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Reservas.Where(r => r.UsuarioId == id).Include(r => r.Instalacion).Include(r => r.Usuario).ToList();
            }
        }

        public void agregar_reserva(Entidades.Reserva reserva)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Reservas.Add(reserva);
                context.SaveChanges();
            }
        }

       
       
        public void remover_reserva(Entidades.Reserva reserva)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                context.Reservas.Remove(reserva);
                context.SaveChanges();
            }
        }

    }
}
