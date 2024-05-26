using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Insttantt.Domain.Entities.Paso;

namespace Prueba.Insttantt.Persistence.Configuration
{
    public class PasoConfiguration
    {
        public PasoConfiguration(EntityTypeBuilder<PasoEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.PasoId);
            entityBuilder.Property(x => x.FlujoId).IsRequired();
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.Acciones).IsRequired();
            entityBuilder.Property(x => x.Orden).IsRequired();
            entityBuilder.Property(x => x.FechaCreacion).IsRequired();
            entityBuilder.Property(x => x.FechaActualizacion).IsRequired();
            entityBuilder.Property(x => x.Estado).IsRequired();

            entityBuilder.HasOne(x => x.Flujo)
        .WithMany(x => x.Pasos)
           .HasForeignKey(x => x.FlujoId);

            entityBuilder.HasMany(x => x.DependenciaPasos)
  .WithOne(x => x.Paso)
   .HasForeignKey(x => x.PasoId);

            entityBuilder.HasMany(x => x.DependenciaPasosDependiente)
.WithOne(x => x.PasoDependiente)
.HasForeignKey(x => x.PasoIdDependiente);

            entityBuilder.HasMany(x => x.PasosCampos)
 .WithOne(x => x.Paso)
 .HasForeignKey(x => x.PasoId);

        }

    }
}
