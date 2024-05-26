using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands;
using Prueba.Insttantt.Application.DataBase.DependenciaPaso.Queries.GetAllDependenciaPasos;
using Prueba.Insttantt.Application.Exceptions;
using Prueba.Insttantt.Application.Features;

namespace Prueba.Insttantt.Api.Controllers
{
    [Route("api/v1/dependenciaPaso")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class DependenciaPasoController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateDependenciaPasoModel model, [FromServices] ICreateDependenciaPasoCommand createDependenciaPasoCommand, [FromServices] IValidator<CreateDependenciaPasoModel> validator)
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            }
            var data = await createDependenciaPasoCommand.Execute(model);

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromServices] IGetAllDependenciaPasosQuery gettAllDepedenciaPasosQuery)
        {
            var data = await gettAllDepedenciaPasosQuery.Execute();

            if (data == null || data.Count == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, data));
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));

            }
        }
    }
}
