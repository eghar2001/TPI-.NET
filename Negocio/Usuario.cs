using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using NETCore;

namespace Negocio
{
    public class DniRepetidoException : Exception
    {
        public DniRepetidoException(): base("El dni se encuentra repetido")
        {
            
        }
    }

    public class NombreUsuarioRepetidoException : Exception
    {
        public NombreUsuarioRepetidoException() : base("El nombre de usuario se encuentra repetido")
        {

        }
    }
    public class UsuarioInexistenteException:Exception
    {
        public UsuarioInexistenteException() : base("El nombre de usuario es invalido")
        {

        }
    }
    public class ContraseniaIncorrectaException : Exception
    {
        public ContraseniaIncorrectaException() : base("La contraseña es incorrecta")
        {

        }
    }

    public class Usuario
    {
        Datos.Usuario datos_usuario = new Datos.Usuario();
        private const int MAX_USUARIOS = 10;


        public Entidades.Usuario login(string username, string password)
        {
            Entidades.Usuario? usuario = datos_usuario.get_by_nombre_usuario(username);
            if (usuario == null)
            {
                throw new UsuarioInexistenteException();
            }
            if (password != usuario.Contrasenia)
            {
                throw new ContraseniaIncorrectaException();  
                
            }
            return usuario;


        }
        public void agregar_socio(Entidades.Usuario usuario)
        {
            if(datos_usuario.get_by_dni(usuario.Dni) != null)
            {
                throw new DniRepetidoException();
            }
            if (datos_usuario.get_by_nombre_usuario(usuario.NombreUsuario) != null)
            {
                throw new NombreUsuarioRepetidoException();
            }
            usuario.TipoUsuarioId = 1;
            datos_usuario.agregar_usuario(usuario);
            
        }
        public void modificar_socio(Entidades.Usuario usuario_modificado)
        {
            Entidades.Usuario? user_original = datos_usuario.get(usuario_modificado.Id);
            if (user_original == null)
            {
                throw new ArgumentException("El usuario ingresado no se encuentra");
            }
            if (usuario_modificado.Dni != user_original.Dni && datos_usuario.get_by_dni(usuario_modificado.Dni) != null )
            {
                throw new DniRepetidoException();
            }
            if (usuario_modificado.NombreUsuario != user_original.NombreUsuario && datos_usuario.get_by_nombre_usuario(usuario_modificado.NombreUsuario) != null)
            {
                throw new NombreUsuarioRepetidoException();
            }
            usuario_modificado.TipoUsuarioId = 1;
            datos_usuario.modificar_usuario(usuario_modificado);
        }
        public List<Entidades.Usuario> find_all()
        {
            return datos_usuario.find_all();
        }
        public List<Entidades.Usuario> find_socios()
        {
            return datos_usuario.find_socios();
        }
        public void borrar_usuario(int id_usuario)
        {
            
            datos_usuario.remover_usuario(id_usuario);
        }
        public Entidades.Usuario get_by_dni(int dni)
        {
            return datos_usuario.get_by_dni(dni);
        }
        public Entidades.Usuario get(int id)
        {
            return datos_usuario.get(id);
        }
        public List<Entidades.Actividad> actividadesNoInscriptas(int usuario_id)
        {
            return datos_usuario.actividadesNoInscriptas(usuario_id);
        }
    }

}
