using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class Instalacion
    {
        

        public Entidades.Instalacion? get_by_Titulo(string titulo)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Instalaciones.FirstOrDefault(i => i.Titulo == titulo);
            }         
        }

        public Entidades.Instalacion? get_one(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Instalaciones.FirstOrDefault(i => i.Id == id);
            }          
        }

        public List<Entidades.Instalacion> find_all()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return context.Instalaciones.ToList();
            }           
        }

        public void agregar_instalacion(Entidades.Instalacion instalacion)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Add(instalacion);
                context.SaveChanges();
            }          
        }

       

        public void modificar_instalacion(Entidades.Instalacion instalacion_modificada)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Update(instalacion_modificada);
                context.SaveChanges();
            } 
        }



        public void remover_instalacion(Entidades.Instalacion instalacion)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Remove(instalacion);
                context.SaveChanges();  
            }
                
        }
        
        public List<Entidades.Horario> getHorariosInstalacion(Entidades.Instalacion instalacion)
        {
            
            using (var context = new ApplicationDbContext())
            {
                List<Horario> horarios = context.Horarios.Where(h => h.Turno.InstalacionId == instalacion.Id).ToList();
                return horarios;
            }
        }
        public List<Entidades.Reserva> getReservasInstalacion(Entidades.Instalacion instalacion)
        {
            using (var context = new ApplicationDbContext())
            {
                List<Entidades.Reserva> reservas = context.Reservas.Where(r => r.InstalacionId == instalacion.Id).ToList();
                return reservas;
            }
        }

        public bool horarioInstalacionSuperpuesto(Entidades.Instalacion instalacion, Entidades.Horario horario)
        {
            List<Entidades.Horario> horarios_instalacion = getHorariosInstalacion(instalacion);
            if (horarios_instalacion.IsNullOrEmpty())
            {
                return false;
            }
            Entidades.Horario? horario_inst_superpuesto = horarios_instalacion.Find(h => h.seSuperponeCon(horario));
            
            return horario_inst_superpuesto != null;
        }
        public bool horariosInstalacionSuperpuesto(Entidades.Instalacion instalacion, List<Entidades.Horario> horarios)
        {
            if (instalacion == null)
            {
                throw new ArgumentNullException("Se ingresó una instlacion nula");
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
                        "WHERE t.InstalacionId = @InstalacionId" +
                        " AND not (h.HoraFin < @HoraInicio OR h.HoraInicio > @HoraFin ) ";
                    cmd.Parameters.Add("@InstalacionId", System.Data.SqlDbType.Int).Value = instalacion.Id;
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
