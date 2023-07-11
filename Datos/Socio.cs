using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Socio
    {

        private static List<Entidades.Socio> socios = new List<Entidades.Socio>() {
                new Entidades.Socio( 11111111,"Pedro","Camiliozzi", "pedro123","123"),
                new Entidades.Socio( 43840925,"Nahue","Coronel", "nahurc10","123"),
                new Entidades.Socio( 22222222,"Ale","Marincioni", "alemar89","123"),


        };

        public Entidades.Socio get(int id)
        {
            Entidades.Socio socio = socios.Find(socio => socio.Id == id);
            if (socio == null)
            {
                return null;
            }
            return socio;
        }
        public Entidades.Socio get_by_dni(int dni)
        {
            Entidades.Socio socio = socios.Find(socio => socio.Dni == dni);
            return socio;
        }

        public bool dni_existente(Entidades.Socio socio_a_buscar)
        {
            var dni_existente = (from s in Socio.socios where s.Dni == socio_a_buscar.Dni select s.Dni).FirstOrDefault();
            Console.Write(dni_existente);
            if (dni_existente == null )
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public List<Entidades.Socio> find_all()
        {
            return socios;
        }
        public void agregar_socio(Entidades.Socio socio)
        {
            socios.Add(socio);
        }
        public bool remover_socio(Entidades.Socio socio_param)
        {
            Entidades.Socio socio_a_remover = socios.Find(socio => socio.Id == socio_param.Id);
            if (socio_a_remover != null)
            {
                socios.Remove(socio_a_remover);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool modificar_socio(Entidades.Socio socio_modificado)
        {
            Entidades.Socio socio_viejo = socios.Find(socio => socio.Id == socio_modificado.Id);
            if (socio_viejo != null)
            {
                socio_viejo.Dni = socio_modificado.Dni;
                socio_viejo.Nombre = socio_modificado.Nombre;
                socio_viejo.Apellido = socio_modificado.Apellido;
                socio_viejo.NombreUsuario = socio_modificado.NombreUsuario;
                socio_viejo.Contrasenia = socio_modificado.Contrasenia;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int cantidad_socios()
        {
            return socios.Count();
        }
      

    }
}
