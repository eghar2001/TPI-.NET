using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rutas
    {

        public static string  RutaSolucion 
        {
            get
            {
                string current_path = AppDomain.CurrentDomain.BaseDirectory;
                string path_root = Path.GetPathRoot(current_path);
                while(!current_path.EndsWith("TPI-.NET")  && current_path != path_root)
                {
                    current_path = Directory.GetParent(current_path).ToString();
                }
                if (current_path == path_root)
                {
                    throw new DirectoryNotFoundException();
                }
                return current_path;
            }
        
        }
        public static string RutaImagenes
        {
            get
            {
                return RutaSolucion + "\\Imagenes";
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
