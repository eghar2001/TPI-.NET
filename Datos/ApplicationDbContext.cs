using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Entidades.Configuraciones;


    public class ConnectionStringNotFoundException: Exception 
    {
        public ConnectionStringNotFoundException():base("No se encontró la connection string")
        {
        }
    }


    public class ApplicationDbContext : DbContext
    {

        public static string ConnectionString
        {
            get 
            {
                var conn_string = Environment.GetEnvironmentVariable("TPI_NET_DB");
                if (conn_string == null)
                {
                    throw new ConnectionStringNotFoundException();

                }
                return conn_string;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);


        }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            ///modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
            modelBuilder.ApplyConfiguration(new ProductoConfig());
            modelBuilder.ApplyConfiguration(new ValorProductoConfig());
            modelBuilder.ApplyConfiguration(new ProductoConfig());
            modelBuilder.ApplyConfiguration(new VentaConfig());
            modelBuilder.ApplyConfiguration(new TipoUsuarioConfig());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<String>().HaveMaxLength(150);
            configurationBuilder.Properties<decimal>().HaveColumnType("decimal(10,2)");
        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<ValorProducto> ValoresProducto => Set<ValorProducto>();
        public DbSet<Venta> Ventas => Set<Venta>();
        public DbSet<TipoUsuario> TiposUsuario => Set<TipoUsuario>();

    
    }
