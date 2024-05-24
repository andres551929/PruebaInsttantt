﻿using Microsoft.EntityFrameworkCore;
using Prueba.Insttantt.Application.DataBase;
using Prueba.Insttantt.Domain.Entities.Test;
using Prueba.Insttantt.Persistence.Configuration;

namespace Prueba.Insttantt.Persistence.DataBase
{
    public class DataBaseService : DbContext, IDataBaseService
    {
        public DataBaseService(DbContextOptions options) : base(options)
        {

        }

        //public DbSet<PruebaEntity> Prueba { get; set; }
        public DbSet<TestEntity> Test { get; set; }


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
            //new PruebaConfiguration(modelBuilder.Entity<PruebaEntity>());
            new TestConfiguration(modelBuilder.Entity<TestEntity>());
        }
    }
}