using AutoMapper;
using Prueba.Insttantt.Domain.Entities.Paso;

namespace Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso
{
    public class CreatePasoCommand : ICreatePasoCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public CreatePasoCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }



        public async Task<CreatePasoModel> Execute(CreatePasoModel model)
        {
            var entity = _mapper.Map<PasoEntity>(model);
            entity.FechaCreacion = DateTime.Now;
            entity.FechaActualizacion = DateTime.Now;
            entity.Estado = "A";


            await _dataBaseService.Paso.AddAsync(entity);

            await _dataBaseService.SaveAsync();

            return model;
        }
    }
}
