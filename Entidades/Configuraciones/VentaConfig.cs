using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class VentaConfig : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.HasIndex(v => new { v.ProductoId,v.UsuarioId, v.FechaVenta }).IsUnique();
            builder.Property(v => v.FechaVenta).HasDefaultValueSql("GETDATE()");


        }
    }
}
