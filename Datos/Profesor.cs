using Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Profesor
    {

        public Entidades.Profesor get_one(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Profesores.FirstOrDefault(u => u.Id == id);
            }
        }

        public List<Entidades.Profesor> find_all()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Profesores.ToList();
            }
        }

        public void agregar_profesor(Entidades.Profesor profesor)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Add(profesor);
                context.SaveChanges();
            }
               
        }

        public void modificar_profesor(Entidades.Profesor profesor_modificado)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Update(profesor_modificado);
                context.SaveChanges();
            }
                
        }

        public void borrar_profesor(Entidades.Profesor profesor)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Remove(profesor);
                context.SaveChanges();
            }
               
        }
        public List<Horario> getHorariosProfesor(Entidades.Profesor profesor)
        {
            using (var context = new ApplicationDbContext())
            {
                List<Horario> horarios = context.Horarios.Where(h => h.Turno.ProfesorId == profesor.Id).ToList();
                return horarios;
            }
        }
        public bool horarioProfesorValido(Entidades.Profesor profesor, Entidades.Horario horario)
        {
            List<Entidades.Horario> horarios_profesor = getHorariosProfesor(profesor);
            if (horarios_profesor.IsNullOrEmpty())
            {
                return false;
            }
            Entidades.Horario? horario_prof_superpuesto = horarios_profesor.Find(h => h.seSuperponeCon(horario));
            return horario_prof_superpuesto != null;
        }
        public bool horariosProfesorValidos(Entidades.Profesor profesor, List<Entidades.Horario> horarios)
        {
            if (profesor == null)
            {
                throw new ArgumentNullException("Se ingresó un profesor nula");
            }
            if (horarios.IsNullOrEmpty())
            {
                throw new ArgumentNullException("No se ingresaro horarios");
            }
            using (SqlConnection conn = new SqlConnection(ApplicationDbContext.ConnectionString))
            {
                conn.Open();
                foreach (Entidades.Horario h in horarios)
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT COUNT(h.TurnoId) FROM Horarios h " +
                        "INNER JOIN Turnos t ON h.TurnoId = t.Id " +
                        "WHERE t.ProfesorId = @ProfesorId" +
                        " AND not (h.HoraFin < @HoraInicio OR h.HoraInicio > @HoraFin ) ";
                    cmd.Parameters.Add("@ProfesorId", System.Data.SqlDbType.Int).Value = profesor.Id;
                    cmd.Parameters.Add("@HoraInicio", System.Data.SqlDbType.NVarChar).Value = h.HoraInicio;
                    cmd.Parameters.Add("@HoraFin", System.Data.SqlDbType.NVarChar).Value = h.HoraFin;
                    int cantidad_superpuestos = (int)cmd.ExecuteScalar();
                    if (cantidad_superpuestos > 0)
                    {
                        conn.Close();
                        return true;
                    }
                }
                conn.Close();
            }

            return false;

        }
    }
}

