using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Prueba.Insttantt.Application.DataBase.Paso.Commands.CreatePaso;
using Prueba.Insttantt.Application.DataBase.Paso.Queries.GetAllPasos;
using Prueba.Insttantt.Application.DataBase.Paso.Queries.GetPasoByFlujo;
using Prueba.Insttantt.Application.Exceptions;
using Prueba.Insttantt.Application.Features;

namespace Prueba.Insttantt.Api.Controllers
{
    [Route("api/v1/paso")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class PasoController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreatePasoModel model, [FromServices] ICreatePasoCommand createPasoCommand, [FromServices] IValidator<CreatePasoModel> validator)
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            }
            var data = await createPasoCommand.Execute(model);

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromServices] IGetAllPasosQuery gettAllPasosQuery)
        {
            var data = await gettAllPasosQuery.Execute();

            if (data == null || data.Count == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, data));
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));

            }
        }

        [HttpGet("get-by-paso")]

        public async Task<IActionResult> GetPasoByFlujoNumber([FromQuery] int flujoId, [FromServices] IGetPasoByFlujoQuery getPasoByFlujoQuery)
        {
            if (flujoId == 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));
            }
            var data = await getPasoByFlujoQuery.Execute(flujoId);

            if (data.Count == 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));

            }
        }
    }
}
