using AutoMapper;
using Prueba.Insttantt.Domain.Entities.DependenciaPaso;

namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands
{
    public class CreateDependenciaPasoCommand : ICreateDependenciaPasoCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public CreateDependenciaPasoCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }



        public async Task<CreateDependenciaPasoModel> Execute(CreateDependenciaPasoModel model)
        {
            var entity = _mapper.Map<DependenciaPasoEntity>(model);
            entity.FechaCreacion = DateTime.Now;
            entity.FechaActualizacion = DateTime.Now;
            entity.Estado = "A";


            await _dataBaseService.DependenciaPaso.AddAsync(entity);

            await _dataBaseService.SaveAsync();

            return model;
        }
    }
}
