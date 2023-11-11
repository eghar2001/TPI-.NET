using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rutas
    {

        public static string  RutaProyecto 
        {
            get
            {
                return "D:\\Proyectos\\TPI-.NET";
            }
        
        }
        public static string RutaImagenes
        {
            get
            {
                return RutaProyecto + "\\Imagenes";
            }
        }
        public static string RutaImagenesPerfil
        {
            get
            {
                return RutaImagenes + "\\PerfilUsuario";
            }
        }
    }
}
