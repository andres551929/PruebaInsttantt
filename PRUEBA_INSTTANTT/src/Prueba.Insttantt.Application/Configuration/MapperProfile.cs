using AutoMapper;
using Prueba.Insttantt.Application.DataBase.Campo.Commands;
using Prueba.Insttantt.Application.DataBase.Campo.Queries.GetAllCampos;
using Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands;
using Prueba.Insttantt.Application.DataBase.DependenciaPaso.Queries.GetAllDependenciaPasos;
using Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo;
using Prueba.Insttantt.Application.DataBase.Flujo.Queries.GetAllFlujos;
using Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso;
using Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos;
using Prueba.Insttantt.Application.DataBase.PasoCampo.Commands;
using Prueba.Insttantt.Domain.Entities.Campo;
using Prueba.Insttantt.Domain.Entities.DependenciaPaso;
using Prueba.Insttantt.Domain.Entities.Flujo;
using Prueba.Insttantt.Domain.Entities.Paso;
using Prueba.Insttantt.Domain.Entities.PasoCampo;

namespace Prueba.Insttantt.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //#region user
            //CreateMap<PruebaEntity, CreatePruebaModel>().ReverseMap();
            CreateMap<FlujoEntity, CreateFlujoModel>().ReverseMap();
            CreateMap<PasoEntity, CreatePasoModel>().ReverseMap();
            CreateMap<CampoEntity, CreateCampoModel>().ReverseMap();
            CreateMap<DependenciaPasoEntity, CreateDependenciaPasoModel>().ReverseMap();
            CreateMap<PasoCampoEntity, CreatePasoCampoModel>().ReverseMap();
            CreateMap<FlujoEntity, GetAllFlujosModel>().ReverseMap();
            CreateMap<PasoEntity, GetAllPasosModel>().ReverseMap();
            CreateMap<DependenciaPasoEntity, GetAllDependenciaPasosModel>().ReverseMap();
            CreateMap<CampoEntity, GetAllCamposModel>().ReverseMap();

            //CreateMap<UserEntity, UpdateUserModel>().ReverseMap();
            //CreateMap<UserEntity, GetAllUserModel>().ReverseMap();
            //CreateMap<UserEntity, GetUserByIdModel>().ReverseMap();
            //CreateMap<UserEntity, GetUserByUserNameAndPasswordModel>().ReverseMap();
            //#endregion


            //#region customer
            //CreateMap<CustomerEntity, CreateCustomerModel>().ReverseMap();
            //CreateMap<CustomerEntity, UpdateCustomerModel>().ReverseMap();
            //CreateMap<CustomerEntity, GetAllCustomerModel>().ReverseMap();
            //CreateMap<CustomerEntity, GetCustomerByIdModel>().ReverseMap();
            //CreateMap<CustomerEntity, GetCustomerByDocumentNumberModel>().ReverseMap();

            //#endregion

            //#region Booking

            //CreateMap<BookingEntity, CreateBookingModel>().ReverseMap();

            //#endregion
        }
    }
}
