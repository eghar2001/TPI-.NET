using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.Data.SqlClient;
namespace Datos
{
    public class Usuario
    {
        private readonly ApplicationDbContext context;

        public Usuario() 
        {
            context = new ApplicationDbContext();
        }


        public Entidades.Usuario get(int id)
        {
            return context.Usuarios.FirstOrDefault(u => u.Id == id);
        }
            
            
        
        public Entidades.Usuario? get_by_dni(int dni)
        {
            return context.Usuarios.FirstOrDefault(u => u.Dni == dni);
        }

        public Entidades.Usuario? get_by_nombre_usuario(string nombreUsuario)
        {
            return context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }

        public List<Entidades.Usuario> find_all()
        {
            return context.Usuarios.ToList();
        }

        public void agregar_usuario(Entidades.Usuario usuario)
        {
            context.Add(usuario);
            context.SaveChanges();
        }

        public void remover_usuario(Entidades.Usuario usuario_param)
        {
            context.Remove(usuario_param);
            context.SaveChanges();
        }

        public void modificar_usuario(Entidades.Usuario usuario_modificado)
        {
            
            context.Update(usuario_modificado);
            context.SaveChanges();          
        }

        public int cantidad_usuarios()
        {
            return context.Usuarios.Count();          
        }
      

    }
}
