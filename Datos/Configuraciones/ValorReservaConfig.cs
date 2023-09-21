using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class ValorReservaConfig : IEntityTypeConfiguration<Entidades.ValorReserva>
    {
        public void Configure(EntityTypeBuilder<Entidades.ValorReserva> builder)
        {
            builder.HasIndex(vr => new { vr.InstalacionId, vr.FechaDesde }).IsUnique();
            builder.Property(v => v.FechaDesde).HasDefaultValueSql("GETDATE()");

        }
    }
}
