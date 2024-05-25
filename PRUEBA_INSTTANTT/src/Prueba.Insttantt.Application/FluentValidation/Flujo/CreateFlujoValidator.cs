using FluentValidation;
using Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo;
using Prueba.Insttantt.Application.DataBase.Test.Commands.CreateTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
