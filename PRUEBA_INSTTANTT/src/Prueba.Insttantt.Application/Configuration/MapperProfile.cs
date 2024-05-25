using AutoMapper;
using Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo;
using Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso;
using Prueba.Insttantt.Application.DataBase.Test.Commands.CreateTest;
using Prueba.Insttantt.Domain.Entities.Flujo;
using Prueba.Insttantt.Domain.Entities.Paso;
using Prueba.Insttantt.Domain.Entities.Test;

namespace Prueba.Insttantt.Application.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //#region user
            //CreateMap<PruebaEntity, CreatePruebaModel>().ReverseMap();
            CreateMap<TestEntity, CreateTestModel>().ReverseMap();
            CreateMap<FlujoEntity, CreateFlujoModel>().ReverseMap();
            CreateMap<PasoEntity, CreatePasoModel>().ReverseMap();
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
