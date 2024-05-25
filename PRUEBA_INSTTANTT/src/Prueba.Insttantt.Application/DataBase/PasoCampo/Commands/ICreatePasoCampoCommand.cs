using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.PasoCampo.Commands
{
    public interface ICreatePasoCampoCommand
    {
        Task<CreatePasoCampoModel> Execute(CreatePasoCampoModel model);

    }
}
