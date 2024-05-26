namespace Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos
{
    public interface IGetAllPasosQuery
    {
        Task<List<GetAllPasosModel>> Execute();

    }
}
