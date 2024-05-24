using AutoMapper;
using Prueba.Insttantt.Domain.Entities.Flujo;

namespace Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo
{
    public class CreateFlujoCommand : ICreateFlujoCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public CreateFlujoCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }



        public async Task<CreateFlujoModel> Execute(CreateFlujoModel model)
        {
            var entity = _mapper.Map<FlujoEntity>(model);
            entity.FechaCreacion = DateTime.Now;
            entity.FechaActualizacion = DateTime.Now;
            entity.Estado = "A";


            await _dataBaseService.Flujo.AddAsync(entity);

            await _dataBaseService.SaveAsync();

            return model;
        }
    }
}
