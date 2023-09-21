using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Configuraciones
{
    public class ReservaConfig : IEntityTypeConfiguration<Entidades.Reserva>
    {
        public void Configure(EntityTypeBuilder<Entidades.Reserva> builder)
        {
            builder.HasIndex(r => new {r.InstalacionId, r.FechaHoraReserva}).IsUnique();


        }
    }
}
