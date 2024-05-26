using Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Queries.GetAllDependenciaPasos
{
    public interface IGetAllDependenciaPasosQuery
    {
        Task<List<GetAllDependenciaPasosModel>> Execute();

    }
}
