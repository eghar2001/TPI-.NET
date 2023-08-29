using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
///using System.Reflection;


public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions options) : base(options)
    {
		
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=DESKTOP-JBRO1Q5\\SQLEXPRESS;Database=TPISocios;Integrated Security=True;TrustServerCertificate=True")
		
			
	}
}
