using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Prueba.Insttantt.Application.DataBase.Campo.Queries.GetAllCampos;
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
            var result = await (from flujo in _dataBaseService.Flujo

                                where flujo.Estado == "A"
                                select new GetAllFlujosModel
                                {
                                    FlujoId = flujo.FlujoId,
                                    Nombre = flujo.Nombre
                                }).ToListAsync();

            return result;
        }
    }
}
