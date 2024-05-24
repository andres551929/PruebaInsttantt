using AutoMapper;
using Prueba.Insttantt.Domain.Entities.Test;

namespace Prueba.Insttantt.Application.DataBase.Test.Commands.CreateTest
{
    public class CreateTestCommand : ICreateTestCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;
        public CreateTestCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }



        public async Task<CreateTestModel> Execute(CreateTestModel model)
        {
            var entity = _mapper.Map<TestEntity>(model);

            await _dataBaseService.Test.AddAsync(entity);

            await _dataBaseService.SaveAsync();

            return model;
        }
    }
}
