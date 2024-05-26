using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Insttantt.Domain.Entities.PasoCampo;

namespace Prueba.Insttantt.Persistence.Configuration
{
    public class PasoCampoConfiguration
    {
        public PasoCampoConfiguration(EntityTypeBuilder<PasoCampoEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.PasoCampoId);
            entityBuilder.Property(x => x.PasoId).IsRequired();
            entityBuilder.Property(x => x.CampoId).IsRequired();
            entityBuilder.Property(x => x.Tipo).IsRequired();
            entityBuilder.Property(x => x.FechaCreacion).IsRequired();
            entityBuilder.Property(x => x.FechaActualizacion).IsRequired();
            entityBuilder.Property(x => x.Estado).IsRequired();

            entityBuilder.HasOne(x => x.Paso)
    .WithMany(x => x.PasosCampos)
    .HasForeignKey(x => x.PasoId);

            entityBuilder.HasOne(x => x.Campo)
                 .WithMany(x => x.PasosCampos)
                 .HasForeignKey(x => x.CampoId);

        }
    }
}
