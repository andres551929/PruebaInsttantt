using Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands
{
    public interface ICreateDependenciaPasoCommand
    {
        Task<CreateDependenciaPasoModel> Execute(CreateDependenciaPasoModel model);

    }
}
