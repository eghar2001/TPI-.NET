using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Configuraciones
{
    public class HorarioConfig : IEntityTypeConfiguration<Entidades.Horario>
    {
        public void Configure(EntityTypeBuilder<Entidades.Horario> builder)
        {
            builder.HasKey(h => new { h.TurnoId, h.DiaSemana });
        }
    }
}
