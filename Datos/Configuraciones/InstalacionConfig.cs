using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class InstalacionConfig : IEntityTypeConfiguration<Entidades.Instalacion>
    {
        public void Configure(EntityTypeBuilder<Entidades.Instalacion> builder)
        {
            builder.Property(i => i.Descripcion).HasMaxLength(500);


        }
    }
}
