using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Instalacion
    {
        private readonly Datos.Instalacion datos_instalacion = new Datos.Instalacion();

        public List<Entidades.Instalacion> find_all()
        {
            return datos_instalacion.find_all();
        }
        public List<Entidades.Horario> GetHorariosInstalacion(Entidades.Instalacion instalacion)
        {
            return datos_instalacion.getHorariosInstalacion(instalacion);
        }
        
    }
}
