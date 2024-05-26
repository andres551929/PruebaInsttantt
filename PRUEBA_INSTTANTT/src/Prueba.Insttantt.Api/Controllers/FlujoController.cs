using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Prueba.Insttantt.Application.DataBase.Flujo.Commands.CreateFlujo;
using Prueba.Insttantt.Application.DataBase.Flujo.Queries.GetAllFlujos;
using Prueba.Insttantt.Application.Exceptions;
using Prueba.Insttantt.Application.External.GetTokenJwt;
using Prueba.Insttantt.Application.Features;
using System.Dynamic;

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

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromServices] IGetAllFlujosQuery gettAllFlujosQuery)
        {



            var data = await gettAllFlujosQuery.Execute();

            if (data == null || data.Count == 0)
            {
                return StatusCode(StatusCodes.Status404NotFound, ResponseApiService.Response(StatusCodes.Status404NotFound, data));
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));

            }
        }

        [AllowAnonymous]
        [HttpGet("login")]
        public async Task<IActionResult> GetByUserNamePassword([FromServices] IGetTokenJwtService getTokenJwtService)
        {
            dynamic data = new ExpandoObject();
            data.Id = 1;
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
