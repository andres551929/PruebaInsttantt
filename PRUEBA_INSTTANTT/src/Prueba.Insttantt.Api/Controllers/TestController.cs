using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prueba.Insttantt.Application.DataBase.Test.Commands.CreateTest;
using Prueba.Insttantt.Application.Exceptions;
using Prueba.Insttantt.Application.External.GetTokenJwt;
using Prueba.Insttantt.Application.Features;
using System.Dynamic;

namespace Prueba.Insttantt.Api.Controllers
{
    [Authorize]
    [Route("api/v1/test")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class TestController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateTestModel model, [FromServices] ICreateTestCommand createUserCommand, [FromServices] IValidator<CreateTestModel> validator)
        {
            var validate = await validator.ValidateAsync(model);
            if (!validate.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest, validate.Errors));

            }
            var data = await createUserCommand.Execute(model);

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }

        [AllowAnonymous]
        [HttpGet("login")]
        public async Task<IActionResult> GetByUserNamePassword([FromServices] IGetTokenJwtService getTokenJwtService)
        {





            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Nombre = "Juan";
            data.Edad = 30;
            data.Token = "";


            if (data == null)
            {
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, data));

            }
            else
            {
                data.Token = getTokenJwtService.Execute(data.Id.ToString());
                return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
            }
        }
    }
}
