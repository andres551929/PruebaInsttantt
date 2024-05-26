using Microsoft.EntityFrameworkCore;

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
                                    CampoId = campo.CampoId,
                                    Nombre = campo.Nombre
                                }).ToListAsync();
            return result;
        }

    }
}
