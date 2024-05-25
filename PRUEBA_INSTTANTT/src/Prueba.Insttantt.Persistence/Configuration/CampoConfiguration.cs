using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Insttantt.Domain.Entities.Campo;
using Prueba.Insttantt.Domain.Entities.DependenciaPaso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Persistence.Configuration
{
    public class CampoConfiguration
    {
        public CampoConfiguration(EntityTypeBuilder<CampoEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.CampoId);
            entityBuilder.Property(x => x.Nombre).IsRequired();
            entityBuilder.Property(x => x.FechaCreacion).IsRequired();
            entityBuilder.Property(x => x.FechaActualizacion).IsRequired();
            entityBuilder.Property(x => x.Estado).IsRequired();

            entityBuilder.HasMany(x => x.PasosCampos)
 .WithOne(x => x.Campo)
 .HasForeignKey(x => x.CampoId);
        }
    }
}
