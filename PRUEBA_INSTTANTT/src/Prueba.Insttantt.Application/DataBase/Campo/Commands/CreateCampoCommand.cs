using AutoMapper;
using Prueba.Insttantt.Domain.Entities.Campo;

namespace Prueba.Insttantt.Application.DataBase.Campo.Commands
{
    public class CreateCampoCommand : ICreateCampoCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public CreateCampoCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }



        public async Task<CreateCampoModel> Execute(CreateCampoModel model)
        {
            var entity = _mapper.Map<CampoEntity>(model);
            entity.FechaCreacion = DateTime.Now;
            entity.FechaActualizacion = DateTime.Now;
            entity.Estado = "A";


            await _dataBaseService.Campo.AddAsync(entity);

            await _dataBaseService.SaveAsync();

            return model;
        }
    }
}
