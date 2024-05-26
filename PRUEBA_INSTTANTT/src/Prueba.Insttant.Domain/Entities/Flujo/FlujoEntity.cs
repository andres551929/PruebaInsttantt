using Prueba.Insttantt.Domain.Entities.Paso;

namespace Prueba.Insttantt.Domain.Entities.Flujo
{
    public class FlujoEntity
    {
        public int FlujoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Estado { get; set; }
        public ICollection<PasoEntity> Pasos { get; set; }

    }
}
