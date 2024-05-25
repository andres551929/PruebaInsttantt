using Prueba.Insttantt.Domain.Entities.Flujo;
using Prueba.Insttantt.Domain.Entities.Paso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Domain.Entities.DependenciaPaso
{
    public class DependenciaPasoEntity
    {
        public int DependenciaPasoId { get; set; }
        public int PasoId { get; set; }
        public int PasoIdDependiente { get; set; }
        public string Estado { get; set; }
        public PasoEntity Paso { get; set; }
        public PasoEntity PasoDependiente { get; set; }
    }
}
