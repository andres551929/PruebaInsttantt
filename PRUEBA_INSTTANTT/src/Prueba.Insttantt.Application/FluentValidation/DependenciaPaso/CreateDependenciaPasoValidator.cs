using FluentValidation;
using Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands;

namespace Prueba.Insttantt.Application.FluentValidation.DependenciaPaso
{
    public class CreateDependenciaPasoValidator : AbstractValidator<CreateDependenciaPasoModel>
    {
        public CreateDependenciaPasoValidator()
        {
            RuleFor(x => x.PasoId).NotNull().GreaterThan(0);
            RuleFor(x => x.PasoIdDependiente).NotNull().GreaterThan(0);

        }
    }
}
