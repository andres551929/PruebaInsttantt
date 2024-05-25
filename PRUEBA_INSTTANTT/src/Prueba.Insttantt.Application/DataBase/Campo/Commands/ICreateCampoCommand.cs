using Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.Campo.Commands
{
    public interface ICreateCampoCommand
    {
        Task<CreateCampoModel> Execute(CreateCampoModel model);

    }
}
