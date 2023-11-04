using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class ProductoConfig : IEntityTypeConfiguration<Entidades.Producto>
    {
        public void Configure(EntityTypeBuilder<Entidades.Producto> builder)
        {
            builder.Property(p => p.Descripcion).HasMaxLength(500);


        }
    }
}
