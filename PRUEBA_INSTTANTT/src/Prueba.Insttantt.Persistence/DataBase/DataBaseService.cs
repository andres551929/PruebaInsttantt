using Microsoft.EntityFrameworkCore;
using Prueba.Insttantt.Application.DataBase;
using Prueba.Insttantt.Domain.Entities.Campo;
using Prueba.Insttantt.Domain.Entities.DependenciaPaso;
using Prueba.Insttantt.Domain.Entities.Flujo;
using Prueba.Insttantt.Domain.Entities.Paso;
using Prueba.Insttantt.Domain.Entities.Test;
using Prueba.Insttantt.Persistence.Configuration;

namespace Prueba.Insttantt.Persistence.DataBase
{
    public class DataBaseService : DbContext, IDataBaseService
    {
        public DataBaseService(DbContextOptions options) : base(options)
        {

        }

        public DbSet<FlujoEntity> Flujo { get; set; }
        public DbSet<TestEntity> Test { get; set; }
        public DbSet<DependenciaPasoEntity> DependenciaPaso { get; set; }
        public DbSet<CampoEntity> Campo { get; set; }
        public DbSet<PasoEntity> Paso { get; set; }


        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private void EntityConfiguration(ModelBuilder modelBuilder)
        {
            new FlujoConfiguration(modelBuilder.Entity<FlujoEntity>());
            new CampoConfiguration(modelBuilder.Entity<CampoEntity>());
            new PasoConfiguration(modelBuilder.Entity<PasoEntity>());
            new DependenciaPasoConfiguration(modelBuilder.Entity<DependenciaPasoEntity>());
            new TestConfiguration(modelBuilder.Entity<TestEntity>());
        }
    }
}
