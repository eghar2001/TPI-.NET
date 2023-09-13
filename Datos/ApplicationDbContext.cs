using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Entidades.Configuraciones;


public class ApplicationDbContext : DbContext
{
  

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);


    }

    public static string ConnectionString
    {
        get { return "Server=DESKTOP-NOSG56K\\SQLEXPRESS;Database=TPISocios;Integrated Security=True;TrustServerCertificate=True"; }
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


}
