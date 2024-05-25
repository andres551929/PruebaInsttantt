using AutoMapper;
using Prueba.Insttantt.Domain.Entities.PasoCampo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.PasoCampo.Commands
{
    public class CreatePasoCampoCommand : ICreatePasoCampoCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public CreatePasoCampoCommand(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<CreatePasoCampoModel> Execute(CreatePasoCampoModel model)
        {
            var entity = _mapper.Map<PasoCampoEntity>(model);
            entity.FechaCreacion = DateTime.Now;
            entity.FechaActualizacion = DateTime.Now;
            entity.Estado ="A";
            await _dataBaseService.PasoCampo.AddAsync(entity);
            await _dataBaseService.SaveAsync();
            return model;

        }
    }
}
