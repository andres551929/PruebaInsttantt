using Prueba.Insttantt.Application.DataBase.Test.Commands.CreateTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo
{
    public interface ICreateFlujoCommand
    {
        Task<CreateFlujoModel> Execute(CreateFlujoModel model);

    }
}
