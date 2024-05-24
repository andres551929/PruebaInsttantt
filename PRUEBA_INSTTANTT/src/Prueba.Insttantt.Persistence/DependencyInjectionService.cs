using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Prueba.Insttantt.Application.DataBase;
using Prueba.Insttantt.Persistence.DataBase;

namespace Prueba.Insttantt.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataBaseService>(options => options.UseSqlServer(configuration["SQLConnectionString"]));
            //services.AddDbContext<DataBaseService>(options => options.UseSqlServer(configuration["SQLConnectionString:ConnectionString"])); ////LINEA PARA SECRETOS DE USUARIO

            services.AddScoped<IDataBaseService, DataBaseService>();

            return services;
        }
    }
}
