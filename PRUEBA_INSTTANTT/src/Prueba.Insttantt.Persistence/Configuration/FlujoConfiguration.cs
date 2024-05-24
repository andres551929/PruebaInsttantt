using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Insttantt.Domain.Entities.Flujo;

namespace Prueba.Insttantt.Persistence.Configuration
{
    public class FlujoConfiguration
    {
        public FlujoConfiguration(EntityTypeBuilder<FlujoEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.FlujoId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.Descripcion).IsRequired();
            entityBuilder.Property(x => x.FechaCreacion).IsRequired();
            entityBuilder.Property(x => x.FechaActualizacion).IsRequired();
        }
    }
}
