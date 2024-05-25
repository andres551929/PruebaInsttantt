﻿using Prueba.Insttantt.Domain.Entities.Paso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
