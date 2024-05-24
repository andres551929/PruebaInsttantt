using Microsoft.EntityFrameworkCore;
using Prueba.Insttantt.Domain.Entities.Test;

namespace Prueba.Insttantt.Application.DataBase
{
    public interface IDataBaseService
    {
        //DbSet<PruebaEntity> Prueba { get; set; }
        DbSet<TestEntity> Test { get; set; }
        //DbSet<CustomerEntity> Customer { get; set; }
        //DbSet<BookingEntity> Booking { get; set; }

        Task<bool> SaveAsync();
    }
}
