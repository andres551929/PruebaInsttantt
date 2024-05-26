namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Queries.GetAllDependenciaPasos
{
    public interface IGetAllDependenciaPasosQuery
    {
        Task<List<GetAllDependenciaPasosModel>> Execute();

    }
}
