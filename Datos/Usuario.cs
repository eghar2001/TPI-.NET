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
        

        private static string ConnectionString
        {
            get { return "Data Source=EGHARMACHINE;Initial Catalog=Club;Integrated Security=True;Encrypt=False"; }
        }

        

        public Entidades.Usuario get(int id)
        {
            Entidades.Usuario usuario = null;

            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ConnectionString);


            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            comando.CommandText = "SELECT * FROM usuarios WHERE id = @id";

            comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;


            conn.Open();

            SqlDataReader dr = comando.ExecuteReader();


            if (dr.Read())
            {
                string nombre = dr["nombre"].ToString();
                string apellido = dr["apellido"].ToString();
                int dni = Int32.Parse(dr["dni"].ToString());
                string nombreUsuario = dr["nombreUsuario"].ToString();
                string contrasenia = dr["contrasenia"].ToString();

                usuario = new Entidades.Usuario(id, dni, nombre, apellido,nombreUsuario,contrasenia);
            }


            conn.Close();
            return usuario;
            
        }
        public Entidades.Usuario get_by_dni(int dni)
        {
            Entidades.Usuario usuario = null;

            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ConnectionString);


            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            comando.CommandText = "SELECT * FROM usuarios WHERE dni = @dni";

            comando.Parameters.Add("@dni", System.Data.SqlDbType.Int).Value = dni;


            conn.Open();

            SqlDataReader dr = comando.ExecuteReader();


            if (dr.Read())
            {
                int id = Int32.Parse(dr["id"].ToString());
                string nombre = dr["nombre"].ToString();
                string apellido = dr["apellido"].ToString();
                string nombreUsuario = dr["nombreUsuario"].ToString();
                string contrasenia = dr["contrasenia"].ToString();

                usuario = new Entidades.Usuario(id, dni, nombre, apellido, nombreUsuario, contrasenia);
            }


            conn.Close();
            return usuario;
        }

        public Entidades.Usuario get_by_nombre_usuario(string nombreUsuario)
        {
            Entidades.Usuario usuario = null;

            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ConnectionString);


            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            comando.CommandText = "SELECT * FROM usuarios WHERE nombreusuario = @nombreusuario";

            comando.Parameters.Add("@nombreusuario", System.Data.SqlDbType.VarChar).Value = nombreUsuario;


            conn.Open();

            SqlDataReader dr = comando.ExecuteReader();


            if (dr.Read())
            {
                int id = Int32.Parse(dr["id"].ToString().Trim());
                string nombre = dr["nombre"].ToString().Trim();
                string apellido = dr["apellido"].ToString().Trim();
                int dni = Int32.Parse(dr["dni"].ToString().Trim());
                string contrasenia = dr["contrasenia"].ToString().Trim();

                usuario = new Entidades.Usuario(id, dni, nombre, apellido, nombreUsuario, contrasenia);
            }


            conn.Close();
            return usuario;
        }

        public List<Entidades.Usuario> find_all()
        {
            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ConnectionString);
            

            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            comando.CommandText = "SELECT * FROM usuarios";

            List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();

            conn.Open();

            SqlDataReader dr = comando.ExecuteReader();          


            while (dr.Read())
            {
                int id = Int32.Parse(dr["id"].ToString());
                string nombre = dr["nombre"].ToString();
                string apellido = dr["apellido"].ToString();
                int dni = Int32.Parse(dr["dni"].ToString());
                string nombreUsuario = dr["nombreUsuario"].ToString();
                string contrasenia = dr["contrasenia"].ToString();
                usuarios.Add(new Entidades.Usuario(id, dni,nombre, apellido, nombreUsuario, contrasenia));
            }


            conn.Close();
            return usuarios;
        }
        public void agregar_usuario(Entidades.Usuario usuario)
        {
            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ConnectionString);
            

            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            comando.CommandText = "INSERT INTO [dbo].[usuarios] ([nombre] ,[apellido]  ,[dni] ,[nombreUsuario]  ,[contrasenia])   VALUES      (@nombre, @apellido   ,@dni  ,@nombreUsuario   ,@contrasenia)";

            comando.Parameters.Add("@nombre",System.Data.SqlDbType.VarChar).Value = usuario.Nombre;
            comando.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar).Value = usuario.Apellido;
            comando.Parameters.Add("@dni", System.Data.SqlDbType.Int).Value = usuario.Dni;
            comando.Parameters.Add("@nombreUsuario", System.Data.SqlDbType.VarChar).Value = usuario.NombreUsuario;
            comando.Parameters.Add("@contrasenia", System.Data.SqlDbType.VarChar).Value = usuario.Contrasenia;

            conn.Open();
            try {
                comando.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            

        }
        public void remover_usuario(Entidades.Usuario usuario_param)
        {
            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            comando.CommandText = "DELETE FROM usuarios WHERE id = @id";
            
            comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = usuario_param.Id;
            
            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }
        public void modificar_usuario(Entidades.Usuario usuario_modificado)
        {
            

            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            comando.CommandText = "UPDATE usuarios SET  nombre=@nombre, apellido=@apellido ,dni=@dni  , nombreusuario = @nombreUsuario   ,contrasenia= @contrasenia WHERE id = @id";
            
            comando.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = usuario_modificado.Id;
            comando.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = usuario_modificado.Nombre;
            comando.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar).Value = usuario_modificado.Apellido;
            comando.Parameters.Add("@dni", System.Data.SqlDbType.Int).Value = usuario_modificado.Dni;
            comando.Parameters.Add("@nombreUsuario", System.Data.SqlDbType.VarChar).Value = usuario_modificado.NombreUsuario;
            comando.Parameters.Add("@contrasenia", System.Data.SqlDbType.VarChar).Value = usuario_modificado.Contrasenia;

            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();


        }
        public int cantidad_usuarios()
        {
            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ConnectionString);


            SqlCommand comando = new SqlCommand();

            comando.Connection = conn;

            comando.CommandText = "SELECT count(id) FROM usuarios";

            List<Entidades.Usuario> usuarios = new List<Entidades.Usuario>();

            conn.Open();

            int cantidadusuarios = (int)comando.ExecuteScalar();

            conn.Close();
            return cantidadusuarios;
        }
      

    }
}
