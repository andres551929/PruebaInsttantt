using Prueba.Insttantt.Domain.Entities.Campo;
using Prueba.Insttantt.Domain.Entities.Paso;

namespace Prueba.Insttantt.Domain.Entities.PasoCampo
{
    public class PasoCampoEntity
    {
        public int PasoCampoId { get; set; }
        public int PasoId { get; set; }
        public int CampoId { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Estado { get; set; }

        public PasoEntity Paso { get; set; }
        public CampoEntity Campo { get; set; }
    }
}
