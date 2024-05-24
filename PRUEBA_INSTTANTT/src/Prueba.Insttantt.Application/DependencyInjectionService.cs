using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Prueba.Insttantt.Application.Configuration;
using Prueba.Insttantt.Application.DataBase.Test.Commands.CreateTest;
using Prueba.Insttantt.Application.FluentValidation.Test;

namespace Prueba.Insttantt.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddProfile(new MapperProfile());
            });

            services.AddSingleton(mapper.CreateMapper());
            //services.AddTransient<ICreatePruebaCommand, CreatePruebaCommand>();
            services.AddTransient<ICreateTestCommand, CreateTestCommand>();


            #region Validator
            //services.AddScoped<IValidator<CreatePruebaModel>, CreatePruebaValidator>();
            services.AddScoped<IValidator<CreateTestModel>, CreateTestValidator>();
            #endregion
            return services;
        }

    }
}
