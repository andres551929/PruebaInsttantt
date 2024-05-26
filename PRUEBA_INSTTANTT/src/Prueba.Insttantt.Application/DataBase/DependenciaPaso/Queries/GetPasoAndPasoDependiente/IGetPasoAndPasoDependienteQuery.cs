namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Queries.GetPasoAndPasoDependiente
{
    public interface IGetPasoAndPasoDependienteQuery
    {
        Task<List<GetPasoAndPasoDependienteModel>> Execute(int pasoId);

    }
}
