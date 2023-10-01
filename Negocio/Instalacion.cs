using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TituloInstalacionRepetidoException : Exception
    {
        public TituloInstalacionRepetidoException() : base("Ya se encuentra cargado ese titulo")
        {

        }
    }

    public class InstalacionInexistenteException : Exception { }

    public class ProfesorInexistenteException : Exception
    {
        public ProfesorInexistenteException() : base("Ya se encuentra cargado ese titulo")
        {

        }
    }
    public class Instalacion
    {
        Datos.Instalacion datos_instalacion = new Datos.Instalacion();

        public Entidades.Instalacion? get_by_Id(int id)
        {
            return datos_instalacion.get_by_Id(id);
        }

        public List<Entidades.Instalacion> find_all()
        {
            return datos_instalacion.find_all();
        }



        private bool EsNumero(string texto)
        {

            if (int.TryParse(texto, out int resultado))
            {

                return true;
            }
            else
            {
                return false;
            }
        }


        public void agregar_instalacion(Entidades.Instalacion instalacion)
        {

            if (datos_instalacion.get_by_Titulo(instalacion.Titulo) != null)
            {
                throw new TituloInstalacionRepetidoException();
            }
            else if (instalacion.Cupo <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            datos_instalacion.agregar_instalacion(instalacion);
        }

        public void modificar_Instalacion(Entidades.Instalacion instalacion_a_editar)
        {
            Entidades.Instalacion? instalacion;
            instalacion = datos_instalacion.get_by_Titulo(instalacion_a_editar.Titulo); 
            if(instalacion != null && instalacion.Id != instalacion_a_editar.Id)
            {
                throw new TituloInstalacionRepetidoException();
            }
            datos_instalacion.modificar_instalacion(instalacion_a_editar);
            
        }

        public void remover_Instalacion(int id)
        {
    
            if (datos_instalacion.get_by_Id(id) != null)
            {
                Entidades.Instalacion instalacion = datos_instalacion.get_by_Id(id);
                datos_instalacion.remover_instalacion(instalacion);
            }
            else 
            {
                throw new InstalacionInexistenteException();
            }
        }
    }
}
