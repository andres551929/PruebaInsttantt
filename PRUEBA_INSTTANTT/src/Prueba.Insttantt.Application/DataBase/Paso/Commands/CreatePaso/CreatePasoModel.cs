using Prueba.Insttantt.Domain.Entities.Paso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso
{
    public class CreatePasoModel
    {
        public int FlujoId { get; set; }
        public string Nombre { get; set; }
        public string Acciones { get; set; }
        public int Orden { get; set; }
    }
}
