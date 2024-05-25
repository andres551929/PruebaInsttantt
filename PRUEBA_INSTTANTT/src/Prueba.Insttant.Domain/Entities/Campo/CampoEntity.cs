using Prueba.Insttantt.Domain.Entities.PasoCampo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Domain.Entities.Campo
{
    public class CampoEntity
    {
        public int CampoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Estado { get; set; }
        public ICollection<PasoCampoEntity> PasosCampos { get; set; }

    }
}
