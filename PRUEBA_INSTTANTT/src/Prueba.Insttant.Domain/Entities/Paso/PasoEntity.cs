using Prueba.Insttantt.Domain.Entities.DependenciaPaso;
using Prueba.Insttantt.Domain.Entities.Flujo;

namespace Prueba.Insttantt.Domain.Entities.Paso
{
    public class PasoEntity
    {
        public int PasoId { get; set; }
        public int FlujoId { get; set; }
        public string Nombre { get; set; }
        public string Acciones { get; set; }
        public int Orden { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public string Estado { get; set; }
        public FlujoEntity Flujo { get; set; }
        //public ICollection<DependenciaPasoEntity> DependenciaPasos { get; set; }

        //public ICollection<DependenciaPasoEntity> DependenciaPasosDependiente { get; set; }


    }


}
