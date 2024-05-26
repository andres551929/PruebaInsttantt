namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands
{
    public interface ICreateDependenciaPasoCommand
    {
        Task<CreateDependenciaPasoModel> Execute(CreateDependenciaPasoModel model);

    }
}
