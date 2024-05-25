using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Prueba.Insttantt.Application.DataBase.Campo.Commands;
using Prueba.Insttantt.Application.DataBase.DependenciaPaso.Commands;
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
    }
}
