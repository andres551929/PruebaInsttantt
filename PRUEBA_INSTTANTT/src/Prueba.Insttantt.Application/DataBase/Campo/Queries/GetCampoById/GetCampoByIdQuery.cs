using Microsoft.EntityFrameworkCore;
using Prueba.Insttantt.Application.DataBase.Campo.Queries.GetAllCampos;

namespace Prueba.Insttantt.Application.DataBase.Campo.Queries.GetCampoById
{
    public class GetCampoByIdQuery : IGetCampoByIdQuery
    {
        private readonly IDataBaseService _dataBaseService;

        public GetCampoByIdQuery(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<List<GetCampoByIdModel>> Execute(int campoId)
        {
            var result = await (from campo in _dataBaseService.Campo
                                where campo.CampoId == campoId && campo.Estado == "A"
                                select new GetCampoByIdModel
                                {
                                    CampoId = campo.CampoId,
                                    Nombre = campo.Nombre
                                }).ToListAsync();
            return result;
        }
    }
}
