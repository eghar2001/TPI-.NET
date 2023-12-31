﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class ValorProductoConfig : IEntityTypeConfiguration<Entidades.ValorProducto>
    {
        public void Configure(EntityTypeBuilder<Entidades.ValorProducto> builder)
        {
            builder.HasIndex(vp => new { vp.ProductoId, vp.FechaDesde }).IsUnique();
            builder.Property(v => v.FechaDesde).HasDefaultValueSql("GETDATE()");

        }
    }
}
