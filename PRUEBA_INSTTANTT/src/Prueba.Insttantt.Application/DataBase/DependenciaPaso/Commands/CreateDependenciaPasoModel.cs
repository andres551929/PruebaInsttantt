using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands
{
    public class CreateDependenciaPasoModel
    {
        public int PasoId { get; set; }
        public int PasoIdDependiente { get; set; }
    }
}
