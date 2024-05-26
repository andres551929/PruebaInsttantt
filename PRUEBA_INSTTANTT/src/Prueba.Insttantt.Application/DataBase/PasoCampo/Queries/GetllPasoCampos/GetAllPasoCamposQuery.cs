using Microsoft.EntityFrameworkCore;

namespace Prueba.Insttantt.Application.DataBase.PasoCampo.Queries.GetllPasoCampos
{
    public class GetAllPasoCamposQuery : IGetAllPasoCamposQuery
    {

        private readonly IDataBaseService _dataBaseService;

        public GetAllPasoCamposQuery(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<List<GetAllPasoCamposModel>> Execute()
        {
            var result = await (from pasoCampo in _dataBaseService.PasoCampo
                                join campo in _dataBaseService.Campo
                                 on pasoCampo.CampoId equals campo.CampoId
                                join paso in _dataBaseService.Paso
                               on pasoCampo.PasoId equals paso.PasoId
                                where pasoCampo.Estado == "A"
                                select new GetAllPasoCamposModel
                                {
                                    PasoCampoId = pasoCampo.PasoCampoId,
                                    PasoId = paso.PasoId,
                                    CampoId = campo.CampoId,
                                    Tipo = pasoCampo.Tipo,
                                    NombrePaso = paso.Nombre,
                                    NombreCampo = campo.Nombre

                                }).ToListAsync();

            return result;
        }
    }
}
