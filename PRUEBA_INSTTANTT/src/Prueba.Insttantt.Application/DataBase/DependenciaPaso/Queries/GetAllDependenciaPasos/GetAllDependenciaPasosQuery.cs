using Microsoft.EntityFrameworkCore;
using Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos;

namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Queries.GetAllDependenciaPasos
{
    public class GetAllDependenciaPasosQuery : IGetAllDependenciaPasosQuery
    {
        private readonly IDataBaseService _dataBaseService;

        public GetAllDependenciaPasosQuery(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<List<GetAllDependenciaPasosModel>> Execute()
        {
            var result = await (from dependenciaPaso in _dataBaseService.DependenciaPaso
                                join paso in _dataBaseService.Paso
                                on dependenciaPaso.PasoId equals paso.PasoId
                                join pasodependiente in _dataBaseService.Paso
                                on dependenciaPaso.PasoIdDependiente equals pasodependiente.PasoId
                                select new GetAllDependenciaPasosModel
                                {
                                   DependenciaPasoId  = dependenciaPaso.DependenciaPasoId,
                                    PasoId = dependenciaPaso.PasoId,
                                    PasoIdDependiente = dependenciaPaso.PasoIdDependiente,
                                    NombrePasoId = paso.Nombre,
                                    NombrePasoIdDependiente = pasodependiente.Nombre
                                }).ToListAsync();

            return result;
        }
    }
}
