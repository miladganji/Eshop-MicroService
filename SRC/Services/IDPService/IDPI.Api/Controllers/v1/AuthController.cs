using Asp.Versioning;
using IDP.Application.Command.User;
using IDP.Application.Query.Auth;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IDPI.Api.Controllers.v1
{

    [ApiVersion(1)]
    [ApiVersion(2)]

    [Route("api/v{v:apiversion}/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Login([FromBody] AuthQuery authQuery) {

            var res = await _mediator.Send(authQuery);
            return Ok(res);

        }
    }
}
