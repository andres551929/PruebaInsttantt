namespace Prueba.Insttantt.Application.DataBase.Flujo.Queries.GetAllFlujos
{
    public interface IGetAllFlujosQuery
    {
        Task<List<GetAllFlujosModel>> Execute();

    }
}
