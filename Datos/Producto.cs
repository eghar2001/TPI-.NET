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
            Microsoft.Data.SqlClient.SqlConnection conn = new SqlConnection(ApplicationDbContext.ConnectionString);
            

            /*SqlCommand buscar_ult_fecha = new SqlCommand();

            buscar_ult_fecha.Connection = conn;

            buscar_ult_fecha.CommandText = "SELECT MAX(vp.FechaDesde)  FROM ValoresProducto vp  WHERE vp.ProductoId = @ProductoId";

            buscar_ult_fecha.Parameters.Add("@ProductoId", System.Data.SqlDbType.Int).Value = productoId;*/



            SqlCommand buscar_precio = new SqlCommand();

            buscar_precio.Connection = conn;

            buscar_precio.CommandText = "SELECT vp.Precio  FROM ValoresProducto vp  WHERE vp.ProductoId = @ProductoId AND vp.FechaDesde = (SELECT MAX(vp1.FechaDesde)  FROM ValoresProducto vp1  WHERE vp1.ProductoId = @ProductoId)";

            buscar_precio.Parameters.Add("@ProductoId", System.Data.SqlDbType.Int).Value = productoId;
            conn.Open();

            var ult_fecha = buscar_precio.ExecuteScalar();
            decimal ult_precio = 0;
            if (ult_fecha is DBNull)
            {
                conn.Close();
                return ult_precio;
            }


            //buscar_precio.Parameters.Add("@UltFecha", System.Data.SqlDbType.DateTime).Value = ult_fecha;
            ult_precio = Convert.ToDecimal(buscar_precio.ExecuteScalar());

            conn.Close() ;
            return ult_precio;



            
        }

        

        public void modificar_producto(Entidades.Producto producto_modificado)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Update(producto_modificado);
                context.SaveChanges();
            }
        }

        public void agregar_producto(Entidades.Producto producto)
        {
            context.Add(producto);
            context.SaveChanges();
        }

        public void remover_producto(Entidades.Producto producto)
        {
            context.Remove(producto);
            context.SaveChanges();
        }

        public void agregar_valorProducto(Entidades.ValorProducto valor_producto)
        {
            context.Add(valor_producto);
            context.SaveChanges();
        }
    }
}
