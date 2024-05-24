using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Insttantt.Domain.Entities.Test;

namespace Prueba.Insttantt.Persistence.Configuration
{
    public class TestConfiguration
    {
        public TestConfiguration(EntityTypeBuilder<TestEntity> entityBuilder)
        {
            entityBuilder.HasKey(x => x.TestId);
            entityBuilder.Property(x => x.Field).IsRequired();

        }
    }
}
