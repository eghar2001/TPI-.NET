using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Datos
{
    
    public class Producto
    {
        private readonly ApplicationDbContext context;
        private  static string ADOConnectionString
        {
            get { return "Server=EGHARMACHINE;Database=TPISocios;Integrated Security=True;TrustServerCertificate=True"; }
        }
        public Producto()
        {
            this.context = new ApplicationDbContext();
        }

        public List<Entidades.Producto> find_all()
        {
            return this.context.Productos.ToList();
        }
        public Entidades.Producto? get_one(int id)
        {

            return  this.context.Productos.FirstOrDefault(p => p.Id == id);
           
        }
        public decimal get_ultimo_precio(int productoId)
        {
            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ADOConnectionString);


            SqlCommand buscar_ult_fecha = new SqlCommand();

            buscar_ult_fecha.Connection = conn;

            buscar_ult_fecha.CommandText = "SELECT MAX(vp.FechaDesde)  FROM ValoresProducto vp  WHERE vp.ProductoId = @ProductoId";

            buscar_ult_fecha.Parameters.Add("@ProductoId", System.Data.SqlDbType.Int).Value = productoId;



            SqlCommand buscar_precio = new SqlCommand();

            buscar_precio.Connection = conn;

            buscar_precio.CommandText = "SELECT vp.Precio  FROM ValoresProducto vp  WHERE vp.ProductoId = @ProductoId AND vp.FechaDesde = @UltFecha";

            buscar_precio.Parameters.Add("@ProductoId", System.Data.SqlDbType.Int).Value = productoId;
            conn.Open();

            var ult_fecha = buscar_ult_fecha.ExecuteScalar();
            decimal ult_precio = 0;
            if (ult_fecha is DBNull)
            {
                return ult_precio;
            }


            buscar_precio.Parameters.Add("@UltFecha", System.Data.SqlDbType.DateTime).Value = ult_fecha;
            ult_precio = (decimal)buscar_precio.ExecuteScalar();

            return ult_precio;



            
        }
    }
}
