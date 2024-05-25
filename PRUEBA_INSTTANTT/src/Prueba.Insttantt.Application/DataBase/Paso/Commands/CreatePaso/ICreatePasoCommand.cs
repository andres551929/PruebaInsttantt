namespace Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso
{
    public interface ICreatePasoCommand
    {
        Task<CreatePasoModel> Execute(CreatePasoModel model);

    }
}
