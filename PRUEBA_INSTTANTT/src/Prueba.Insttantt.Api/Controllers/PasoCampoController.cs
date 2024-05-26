using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Prueba.Insttantt.Application.DataBase.Flujo.Queries.GetAllFlujos;
using Prueba.Insttantt.Application.DataBase.PasoCampo.Commands;
using Prueba.Insttantt.Application.DataBase.PasoCampo.Queries.GetllPasoCampos;
using Prueba.Insttantt.Application.Exceptions;
using Prueba.Insttantt.Application.Features;

namespace Prueba.Insttantt.Api.Controllers
{
    [Route("api/v1/pasoCampo")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class PasoCampoController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreatePasoCampoModel model, [FromServices] ICreatePasoCampoCommand createPasoCampoCommand, [FromServices] IValidator<CreatePasoCampoModel> validator)
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            }
            var data = await createPasoCampoCommand.Execute(model);

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromServices] IGetAllPasoCamposQuery gettAllPasoCamposQuery)
        {

            var data = await gettAllPasoCamposQuery.Execute();

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
