using AutoMapper;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Prueba.Insttantt.Application.Configuration;
using Prueba.Insttantt.Application.DataBase.Campo.Commands;
using Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands;
using Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo;
using Prueba.Insttantt.Application.DataBase.Flujo.Queries.GetAllFlujos;
using Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso;
using Prueba.Insttantt.Application.DataBase.Paso.Queries;
using Prueba.Insttantt.Application.DataBase.PasoCampo.Commands;
using Prueba.Insttantt.Application.FluentValidation.Campo;
using Prueba.Insttantt.Application.FluentValidation.DependenciaPaso;
using Prueba.Insttantt.Application.FluentValidation.Flujo;
using Prueba.Insttantt.Application.FluentValidation.Paso;
using Prueba.Insttantt.Application.FluentValidation.PasoCampo;

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
            services.AddTransient<ICreateFlujoCommand, CreateFlujoCommand>();
            services.AddTransient<ICreatePasoCommand, CreatePasoCommand>();
            services.AddTransient<ICreateDependenciaPasoCommand, CreateDependenciaPasoCommand>();
            services.AddTransient<ICreateCampoCommand, CreateCampoCommand>();
            services.AddTransient<ICreatePasoCampoCommand, CreatePasoCampoCommand>();
            services.AddTransient<IGetAllFlujosQuery, GetAllFlujosQuery>();
            services.AddTransient<IGetAllPasosQuery, GetAllPasosQuery>();


            #region Validator
            services.AddScoped<IValidator<CreateFlujoModel>, CreateFlujoValidator>();
            services.AddScoped<IValidator<CreatePasoModel>, CreatePasoValidator>();
            services.AddScoped<IValidator<CreateDependenciaPasoModel>, CreateDependenciaPasoValidator>();
            services.AddScoped<IValidator<CreateCampoModel>, CreateCampoValidator>();
            services.AddScoped<IValidator<CreatePasoCampoModel>, CreatePasoCampoValidator>();
            #endregion
            return services;
        }

    }
}
