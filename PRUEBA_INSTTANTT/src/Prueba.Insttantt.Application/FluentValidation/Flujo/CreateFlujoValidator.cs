using FluentValidation;
using Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo;

namespace Prueba.Insttantt.Application.FluentValidation.Flujo
{
    public class CreateFlujoValidator : AbstractValidator<CreateFlujoModel>
    {
        public CreateFlujoValidator()
        {
            RuleFor(x => x.Nombre).NotNull().WithMessage("El campo no puede ser nulo").NotEmpty().MaximumLength(50);

        }
    }
}
