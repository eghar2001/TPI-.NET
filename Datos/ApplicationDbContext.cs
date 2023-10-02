using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Entidades.Configuraciones;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

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
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.ApplyConfiguration(new InscripcionTurnoConfig());
            //modelBuilder.ApplyConfiguration(new ReservaConfig());
            //modelBuilder.ApplyConfiguration(new TipoUsuarioConfig());
            //modelBuilder.ApplyConfiguration(new UsuarioConfig());
            //modelBuilder.ApplyConfiguration(new ValorActividadConfig());
            //modelBuilder.ApplyConfiguration(new ValorProductoConfig());
            //modelBuilder.ApplyConfiguration(new ValorReservaConfig());
            //modelBuilder.ApplyConfiguration(new VentaConfig());


    }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<String>().HaveMaxLength(150);
            configurationBuilder.Properties<decimal>().HaveColumnType("decimal(10,2)");
        }


    //Entidades no dependientes
        public DbSet<Profesor> Profesores => Set<Profesor>();
        public DbSet<Instalacion> Instalaciones => Set<Instalacion>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<TipoUsuario> TiposUsuario => Set<TipoUsuario>();
        public DbSet<Actividad> Actividades => Set<Actividad>();
        



    //Entidades dependientes
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Turno> Turnos => Set<Turno>();
        
        public DbSet<InscripcionTurno> InscripcionesTurno => Set<InscripcionTurno>();


        
        public DbSet<ValorActividad> ValoresActividad => Set<ValorActividad>();
        public DbSet<ValorProducto> ValoresProducto => Set<ValorProducto>();
        public DbSet<ValorReserva> ValoresReserva => Set<ValorReserva>();
        public DbSet<Venta> Ventas => Set<Venta>();

        public DbSet<Reserva> Reservas => Set<Reserva>();
        
        public DbSet<Horario> Horarios => Set<Horario>();

}
