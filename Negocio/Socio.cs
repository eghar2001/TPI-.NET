using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{

    public class Socio
    {
        Datos.Socio datos_socio = new Datos.Socio();
        private const int MAX_SOCIOS = 10;

        public void agregar_socio(Entidades.Socio socio)
        {
            //A dividir en el futuro
           
            datos_socio.agregar_socio(socio);
            
        }
        public void modificar_socio(Entidades.Socio socio)
        {
            datos_socio.modificar_socio(socio);
        }
        public List<Entidades.Socio> find_all()
        {
            return datos_socio.find_all();
        }
        public void borrar_socio(Entidades.Socio socio)
        {
            
            datos_socio.remover_socio( socio );
        }
        public Entidades.Socio get_by_dni(int dni)
        {
            return datos_socio.get_by_dni(dni);
        }
        public Entidades.Socio get(int id)
        {
            return datos_socio.get(id);
        }
    }

}
