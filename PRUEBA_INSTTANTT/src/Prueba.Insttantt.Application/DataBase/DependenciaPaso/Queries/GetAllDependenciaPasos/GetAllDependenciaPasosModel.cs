﻿namespace Prueba.Insttantt.Application.DataBase.DependenciaPaso.Queries.GetAllDependenciaPasos
{
    public class GetAllDependenciaPasosModel
    {
        public int DependenciaPasoId { get; set; }
        public int PasoId { get; set; }
        public int PasoIdDependiente { get; set; }
        public string NombrePasoId { get; set; }
        public string NombrePasoIdDependiente { get; set; }
    }
}
