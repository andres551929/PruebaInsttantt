using Microsoft.EntityFrameworkCore;

namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Queries.GetPasoAndPasoDependiente
{
    public class GetPasoAndPasoDependienteQuery : IGetPasoAndPasoDependienteQuery
    {
        private readonly IDataBaseService _dataBaseService;

        public GetPasoAndPasoDependienteQuery(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<List<GetPasoAndPasoDependienteModel>> Execute(int pasoId)
        {
            var result = await (from dependenciaPaso in _dataBaseService.DependenciaPaso
                                join paso in _dataBaseService.Paso
                                on dependenciaPaso.PasoId equals paso.PasoId
                                join pasodependiente in _dataBaseService.Paso
                                on dependenciaPaso.PasoIdDependiente equals pasodependiente.PasoId
                                where dependenciaPaso.PasoId == pasoId && dependenciaPaso.Estado == "A"
                                orderby dependenciaPaso.PasoId ascending
                                select new GetPasoAndPasoDependienteModel
                                {
                                    DependenciaPasoId = dependenciaPaso.DependenciaPasoId,
                                    PasoId = dependenciaPaso.PasoId,
                                    PasoIdDependiente = dependenciaPaso.PasoIdDependiente,
                                    NombrePasoId = paso.Nombre,
                                    NombrePasoIdDependiente = pasodependiente.Nombre
                                }).ToListAsync();

            return result;
        }
    }
}
