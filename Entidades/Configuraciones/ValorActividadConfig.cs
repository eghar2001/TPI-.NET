using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class ValorActividadConfig : IEntityTypeConfiguration<ValorActividad>
    {
        public void Configure(EntityTypeBuilder<ValorActividad> builder)
        {
            builder.HasIndex(va =>new { va.ActividadId, va.FechaDesde}).IsUnique();
            builder.Property(va => va.FechaDesde).HasDefaultValueSql("GETDATE()");

        }
    }
}
