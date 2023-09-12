using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class ValorProductoConfig : IEntityTypeConfiguration<ValorProducto>
    {
        public void Configure(EntityTypeBuilder<ValorProducto> builder)
        {
            builder.HasKey(vp => new { vp.ProductoId, vp.FechaDesde });
            

        }
    }
}
