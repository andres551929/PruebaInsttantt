using FluentValidation;
using Prueba.Insttantt.Application.DataBase.Test.Commands.CreateTest;

namespace Prueba.Insttantt.Application.FluentValidation.Test
{
    public class CreateTestValidator : AbstractValidator<CreateTestModel>
    {
        public CreateTestValidator()
        {
            RuleFor(x => x.Field).NotNull().WithMessage("El campo no puede ser nulo").NotEmpty().MaximumLength(50);

        }
    }
}
