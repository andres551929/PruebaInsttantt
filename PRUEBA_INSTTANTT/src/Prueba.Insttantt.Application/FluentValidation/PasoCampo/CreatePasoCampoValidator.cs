using FluentValidation;
using Prueba.Insttantt.Application.DataBase.PasoCampo.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.FluentValidation.PasoCampo
{
    public class CreatePasoCampoValidator : AbstractValidator<CreatePasoCampoModel>
    {
        public CreatePasoCampoValidator()
        {
            RuleFor(x => x.CampoId).NotNull().GreaterThan(0);
            RuleFor(x => x.PasoId).NotNull().GreaterThan(0);
            RuleFor(x => x.Tipo).NotNull().NotEmpty().MaximumLength(50);

        }
    }
}
