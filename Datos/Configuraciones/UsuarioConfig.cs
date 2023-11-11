using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class UsuarioConfig: IEntityTypeConfiguration<Entidades.Usuario>
    {
        public void Configure(EntityTypeBuilder<Entidades.Usuario> builder)
        {
            builder.HasIndex(u => u.NombreUsuario).IsUnique();
            builder.HasIndex(u => u.Dni).IsUnique();
            builder.Property(u => u.FotoNombre).HasDefaultValue("default.png");


        }
    }
}
