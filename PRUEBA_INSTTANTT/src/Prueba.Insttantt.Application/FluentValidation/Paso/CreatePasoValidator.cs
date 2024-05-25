using FluentValidation;
using Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso;

namespace Prueba.Insttantt.Application.FluentValidation.Paso
{
    public class CreatePasoValidator : AbstractValidator<CreatePasoModel>
    {
        public CreatePasoValidator()
        {

            RuleFor(x => x.FlujoId).NotNull().GreaterThan(0);
            RuleFor(x => x.Nombre).NotNull().WithMessage("El campo no puede ser nulo").NotEmpty().MaximumLength(50);
            RuleFor(x => x.Acciones).NotNull().WithMessage("El campo no puede ser nulo").NotEmpty();
            RuleFor(x => x.Orden).NotNull().GreaterThan(0);

        }
    }
}
