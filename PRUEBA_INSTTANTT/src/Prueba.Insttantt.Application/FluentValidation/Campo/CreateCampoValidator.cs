using FluentValidation;
using Prueba.Insttantt.Application.DataBase.Campo.Commands;
using Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
