using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos
{
    public class GetAllPasosModel
    {
        public int PasoId { get; set; }
        public string Nombre { get; set; }
        public string Acciones { get; set; }
        public int Orden { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string NombreFlujo { get; set; }
        public int FlujoId { get; set; }
    }
}
