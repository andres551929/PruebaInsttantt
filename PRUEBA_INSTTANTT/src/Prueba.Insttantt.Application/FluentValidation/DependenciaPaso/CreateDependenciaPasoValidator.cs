using FluentValidation;
using Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands;
using Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
