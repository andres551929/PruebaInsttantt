using Microsoft.EntityFrameworkCore;
using Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.Campo.Queries.GetAllCampos
{
    public class GetAllCamposQuery : IGetAllCamposQuery
    {
        private readonly IDataBaseService _dataBaseService;

        public GetAllCamposQuery(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<List<GetAllCamposModel>> Execute()
        {
            var result = await (from campo in _dataBaseService.Campo

                                where campo.Estado == "A"
                                select new GetAllCamposModel
                                {
                                    Nombre = campo.Nombre
                                }).ToListAsync();

            return result;
        }

    }
}
