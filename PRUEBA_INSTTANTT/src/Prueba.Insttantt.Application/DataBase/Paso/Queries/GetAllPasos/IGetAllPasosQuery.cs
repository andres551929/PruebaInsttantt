using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos
{
    public interface IGetAllPasosQuery
    {
        Task<List<GetAllPasosModel>> Execute();

    }
}
