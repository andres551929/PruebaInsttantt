using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Insttantt.Domain.Entities.DependenciaPaso;
using Prueba.Insttantt.Domain.Entities.Paso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Persistence.Configuration
{
    public class DependenciaPasoConfiguration
    {

        public DependenciaPasoConfiguration(EntityTypeBuilder<DependenciaPasoEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.DependenciaPasoId);
            entityBuilder.Property(x => x.PasoId).IsRequired();
            entityBuilder.Property(x => x.PasoIdDependiente).IsRequired();
            entityBuilder.Property(x => x.Estado).IsRequired();


//            entityBuilder.HasOne(x => x.Paso)
//        .WithMany(x => x.DependenciaPasos)
//           .HasForeignKey(x => x.PasoId);

//            entityBuilder.HasOne(x => x.Paso)
//.WithMany(x => x.DependenciaPasosDependiente)
//.HasForeignKey(x => x.PasoIdDependiente);
     }



    }
}
