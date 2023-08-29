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
        optionsBuilder.UseSqlServer("Server=DESKTOP-JBRO1Q5\\SQLEXPRESS;Database=TPISocios;Integrated Security=True;TrustServerCertificate=True");


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ///modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.ApplyConfiguration(new UsuarioConfig());
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
        configurationBuilder.Properties<String>().HaveMaxLength(150);
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
}
