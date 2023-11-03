using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Reserva
    {
       Datos.Reserva datos_reserva = new Datos.Reserva();

        public List<Entidades.Reserva> find_all()
        {
            return datos_reserva.find_all();
        }

        public List <Entidades.Reserva> get_by_UsuarioId(int id)
        {
            return datos_reserva.get_by_UsuarioId(id);
        }
        public void agregar_reserva(Entidades.Reserva reserva)
        {
            datos_reserva.agregar_reserva(reserva);
        }

        public void remover_reserva(int id)
        {
            
            Entidades.Reserva reserva = datos_reserva.get_by_Id(id);
                
            datos_reserva.remover_reserva(reserva);
           
        }
    }
}
