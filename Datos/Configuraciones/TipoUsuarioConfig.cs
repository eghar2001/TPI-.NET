using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class TipoUsuarioConfig : IEntityTypeConfiguration<Entidades.TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<Entidades.TipoUsuario> builder)
        {
            builder.HasIndex(tu => tu.Descripcion).IsUnique();
            


        }
    }
}
