namespace Prueba.Insttantt.Application.DataBase.Paso.Queries.GetPasoByFlujo
{
    public interface IGetPasoByFlujoQuery
    {
        Task<List<GetPasoByFlujoModel>> Execute(int flujoId);

    }
}
