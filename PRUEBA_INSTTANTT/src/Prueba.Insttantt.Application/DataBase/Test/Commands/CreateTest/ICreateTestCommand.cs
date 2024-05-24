namespace Prueba.Insttantt.Application.DataBase.Test.Commands.CreateTest
{
    public interface ICreateTestCommand
    {
        Task<CreateTestModel> Execute(CreateTestModel model);

    }
}
