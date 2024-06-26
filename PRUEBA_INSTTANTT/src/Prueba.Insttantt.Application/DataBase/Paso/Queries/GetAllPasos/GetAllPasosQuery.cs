﻿using Microsoft.EntityFrameworkCore;

namespace Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos
{
    public class GetAllPasosQuery : IGetAllPasosQuery
    {
        private readonly IDataBaseService _dataBaseService;

        public GetAllPasosQuery(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        public async Task<List<GetAllPasosModel>> Execute()
        {
            var result = await (from paso in _dataBaseService.Paso
                                join flujo in _dataBaseService.Flujo
                                on paso.FlujoId equals flujo.FlujoId
                                where paso.Estado == "A"
                                select new GetAllPasosModel
                                {
                                    PasoId = paso.PasoId,
                                    NombreFlujo = flujo.Nombre,
                                    Acciones = paso.Acciones,
                                    Orden = paso.Orden,
                                    FechaCreacion = paso.FechaCreacion,
                                    FlujoId = paso.FlujoId,
                                    Nombre = paso.Nombre
                                }).ToListAsync();

            return result;
        }
    }
}
