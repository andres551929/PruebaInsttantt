using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.PasoCampo.Queries.GetllPasoCampos
{
    public class GetAllPasoCamposModel
    {
        public int PasoCampoId { get; set; }
        public int PasoId { get; set; }
        public int CampoId { get; set; }
        public string Tipo { get; set; }
        public string NombrePaso { get; set; }
        public string NombreCampo { get; set; }
    }
}
