using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Prueba.Insttantt.Application.DataBase.Campo.Commands;
using Prueba.Insttantt.Application.DataBase.Campo.Queries.GetAllCampos;
using Prueba.Insttantt.Application.DataBase.Campo.Queries.GetCampoById;
using Prueba.Insttantt.Application.DataBase.Paso.Queries.GetPasoByFlujo;
using Prueba.Insttantt.Application.Exceptions;
using Prueba.Insttantt.Application.Features;

namespace Prueba.Insttantt.Api.Controllers
{
    [Route("api/v1/campo")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class CampoController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateCampoModel model, [FromServices] ICreateCampoCommand createCampoCommand, [FromServices] IValidator<CreateCampoModel> validator)
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            }
            var data = await createCampoCommand.Execute(model);

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromServices] IGetAllCamposQuery gettAllCamposQuery)
        {
            var data = await gettAllCamposQuery.Execute();

            if (data == null || data.Count == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, data));
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));

            }
        }

        [HttpGet("get-by-campoId")]

        public async Task<IActionResult> GetPasoByFlujoNumber([FromQuery] int campoId, [FromServices] IGetCampoByIdQuery getCampoByIdQuery)
        {
            if (campoId == 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));
            }
            var data = await getCampoByIdQuery.Execute(campoId);

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
