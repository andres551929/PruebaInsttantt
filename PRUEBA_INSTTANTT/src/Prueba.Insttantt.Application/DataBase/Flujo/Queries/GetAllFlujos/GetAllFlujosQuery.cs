using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.Flujo.Queries.GetAllFlujos
{
    public class GetAllFlujosQuery : IGetAllFlujosQuery
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public GetAllFlujosQuery(IDataBaseService dataBaseService, IMapper mapper)
        {
            _dataBaseService = dataBaseService;
            _mapper = mapper;
        }

        public async Task<List<GetAllFlujosModel>> Execute()
        {
            var listEntity = await _dataBaseService.Flujo.ToListAsync();
            return _mapper.Map<List<GetAllFlujosModel>>(listEntity);
        }
    }
}
