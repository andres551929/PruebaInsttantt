using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.Flujo.Queries.GetAllFlujos
{
    public interface IGetAllFlujosQuery
    {
        Task<List<GetAllFlujosModel>> Execute();

    }
}
