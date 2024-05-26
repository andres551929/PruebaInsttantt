namespace Prueba.Insttantt.Application.DataBase.Campo.Queries.GetAllCampos
{
    public interface IGetAllCamposQuery
    {
        Task<List<GetAllCamposModel>> Execute();

    }
}
