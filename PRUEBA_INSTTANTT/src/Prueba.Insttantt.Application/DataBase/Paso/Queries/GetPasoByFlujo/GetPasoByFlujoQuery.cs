using Microsoft.EntityFrameworkCore;

namespace Prueba.Insttantt.Application.DataBase.Paso.Queries.GetPasoByFlujo
{
    public class GetPasoByFlujoQuery : IGetPasoByFlujoQuery
    {
        private readonly IDataBaseService _dataBaseService;

        public GetPasoByFlujoQuery(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<List<GetPasoByFlujoModel>> Execute(int flujoId)
        {
            var result = await (from paso in _dataBaseService.Paso
                                join flujo in _dataBaseService.Flujo
                                on paso.FlujoId equals flujo.FlujoId
                                where flujo.FlujoId == flujoId && paso.Estado == "A"
                                select new GetPasoByFlujoModel
                                {
                                    PasoId = paso.PasoId,
                                    NombreFlujo = flujo.Nombre,
                                    Acciones = paso.Acciones,
                                    Orden = paso.Orden,
                                    FechaCreacion = paso.FechaCreacion,
                                    FlujoId = paso.FlujoId,
                                    Nombre = paso.Nombre
                                }).ToListAsync();

            return result;
        }

     
    }
}
