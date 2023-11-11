using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
namespace Datos
{
    public class Usuario
    {
        

        


        public Entidades.Usuario? get(int id)
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Usuarios.FirstOrDefault(u => u.Id == id);
            }
            
        }
            
            
        
        public Entidades.Usuario? get_by_dni(int dni)
        {
            using (var context = new ApplicationDbContext()) 
            {

                return context.Usuarios.FirstOrDefault(u => u.Dni == dni);
            }
        }

        public Entidades.Usuario? get_by_nombre_usuario(string nombreUsuario)
        {
            using (var context = new ApplicationDbContext()) 
            {

                return context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
            }
        }

        public List<Entidades.Usuario> find_all()
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Usuarios.ToList();
            }
        }
        public List<Entidades.Usuario> find_socios()
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Usuarios.Where(u => u.TipoUsuario.Descripcion == "Socio").OrderBy(u => u.NombreUsuario).ToList();
            }
        }

        public void agregar_usuario(Entidades.Usuario usuario)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Add(usuario);
                context.SaveChanges();
            }
            
        }

        public void remover_usuario(int id_usuario)
        {
            using (var context = new ApplicationDbContext()) 
            {

                context.Remove(id_usuario);
                context.SaveChanges();
            }
        }

        public void modificar_usuario(Entidades.Usuario usuario_modificado)
        {
            using (var context = new ApplicationDbContext()) 
            {

                context.Update(usuario_modificado);
                context.SaveChanges();
            } 
        }

        public int cantidad_usuarios()
        {
            using (var context = new ApplicationDbContext()) 
            {

                return context.Usuarios.Count();
            }    
        }

        public List<Entidades.Actividad> actividadesNoInscriptas(int usuario_id)
        //Dado un id de usuario, retorna todas las actividades a la cual ese usuario no esta inscripto
        {
            Datos.Actividad datos_actividad = new Datos.Actividad();
            List<Entidades.Actividad> actividades = datos_actividad.findAll();
            List<Entidades.Actividad> actividadesInscriptas = actividadesInscriptasDelSocio(usuario_id);
            foreach (Entidades.Actividad actividad in actividadesInscriptas)
            {
                actividades.Remove(actividad);
            }
            return actividades;


        }
        public List<Entidades.Actividad> actividadesInscriptasDelSocio(int id_socio)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                List<Entidades.Actividad> actividades_inscriptas = context.InscripcionesTurno.Include(i => i.Turno.Actividad).Where(i => i.UsuarioId == id_socio && i.FechaHoraBaja == DateTime.MinValue).Select(i => i.Turno.Actividad).Distinct().ToList();
                return actividades_inscriptas;
            }

        }

    }
}
