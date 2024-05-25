using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Insttantt.Domain.Entities.Flujo;
using Prueba.Insttantt.Domain.Entities.Paso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

//            entityBuilder.HasMany(x => x.DependenciaPasos)
//  .WithOne(x => x.Paso)
//   .HasForeignKey(x => x.PasoId);

//            entityBuilder.HasMany(x => x.DependenciaPasosDependiente)
//.WithOne(x => x.PasoDependiente)
//.HasForeignKey(x => x.PasoIdDependiente);

        }

    }
}
