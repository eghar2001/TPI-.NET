using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class InscripcionTurnoConfig : IEntityTypeConfiguration<InscripcionTurno>
    {
        public void Configure(EntityTypeBuilder<InscripcionTurno> builder)
        {
            builder.HasIndex(i => new { i.FechaHoraInscripcion, i.UsuarioId }).IsUnique();


        }
    }
}
