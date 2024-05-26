namespace Prueba.Insttantt.Application.DataBase.Campo.Queries.GetCampoById
{
    public interface IGetCampoByIdQuery
    {
        Task<List<GetCampoByIdModel>> Execute(int campoId);
    }
}
