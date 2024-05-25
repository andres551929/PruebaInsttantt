namespace Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo
{
    public interface ICreateFlujoCommand
    {
        Task<CreateFlujoModel> Execute(CreateFlujoModel model);

    }
}
