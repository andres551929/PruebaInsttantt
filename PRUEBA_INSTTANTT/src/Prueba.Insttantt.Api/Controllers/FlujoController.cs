using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo;
using Prueba.Insttantt.Application.Exceptions;
using Prueba.Insttantt.Application.Features;

namespace Prueba.Insttantt.Api.Controllers
{
    [Route("api/v1/flujo")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class FlujoController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateFlujoModel model, [FromServices] ICreateFlujoCommand createFlujoCommand, [FromServices] IValidator<CreateFlujoModel> validator)
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            }
            var data = await createFlujoCommand.Execute(model);

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }
    }
}
