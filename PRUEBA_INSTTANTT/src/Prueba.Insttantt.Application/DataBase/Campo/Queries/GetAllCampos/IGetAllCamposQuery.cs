using Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.Campo.Queries.GetAllCampos
{
    public interface IGetAllCamposQuery
    {
        Task<List<GetAllCamposModel>> Execute();

    }
}
