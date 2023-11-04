using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuraciones
{
    public class ActividadesConfig : IEntityTypeConfiguration<Entidades.Actividad>
    {
        public void Configure(EntityTypeBuilder<Entidades.Actividad> builder)
        {
            builder.Property(a => a.Descripcion).HasMaxLength(500);
        }
    }
}
