using Prueba.Insttantt.Domain.Entities.Paso;

namespace Prueba.Insttantt.Domain.Entities.DependenciaPaso
{
    public class DependenciaPasoEntity
    {
        public int DependenciaPasoId { get; set; }
        public int PasoId { get; set; }
        public int PasoIdDependiente { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public PasoEntity Paso { get; set; }
        public PasoEntity PasoDependiente { get; set; }
    }
}
