using FluentValidation;
using Prueba.Insttantt.Application.DataBase.Campo.Commands;

namespace Prueba.Insttantt.Application.FluentValidation.Campo
{
    public class CreateCampoValidator : AbstractValidator<CreateCampoModel>
    {
        public CreateCampoValidator()
        {
            RuleFor(x => x.Nombre).NotNull().WithMessage("El campo no puede ser nulo").NotEmpty().MaximumLength(50);

        }
    }
}
