namespace Prueba.Insttantt.Application.DataBase.PasoCampo.Queries.GetllPasoCampos
{
    public interface IGetAllPasoCamposQuery
    {
        Task<List<GetAllPasoCamposModel>> Execute();

    }
}
