using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class TipoUsuarioConfig : IEntityTypeConfiguration<TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {

            builder.Property(tu => tu.Descripcion).IsRequired();
            builder.HasIndex(tu => tu.Descripcion).IsUnique();



        }
    }
}
