using Microsoft.EntityFrameworkCore;
using Prueba.Insttantt.Domain.Entities.DependenciaPaso;
using Prueba.Insttantt.Domain.Entities.Flujo;
using Prueba.Insttantt.Domain.Entities.Paso;
using Prueba.Insttantt.Domain.Entities.Test;

namespace Prueba.Insttantt.Application.DataBase
{
    public interface IDataBaseService
    {
        DbSet<FlujoEntity> Flujo { get; set; }
        DbSet<PasoEntity> Paso { get; set; }
        DbSet<TestEntity> Test { get; set; }
        //DbSet<DependenciaPasoEntity> DependenciaPaso { get; set; }

        Task<bool> SaveAsync();
    }
}
