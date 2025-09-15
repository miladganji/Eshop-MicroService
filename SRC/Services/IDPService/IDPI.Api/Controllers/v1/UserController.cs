using Asp.Versioning;
using IDP.Application.Command.User;
using IDPI.Api.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IDPI.Api.Controllers.v1
{
    [ApiVersion(1)]
    [ApiVersion(2)]
   
    [Route("api/v{v:apiversion}/users")]
    [ApiController]
    public class UserController : IBaseController
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
                _mediator = mediator;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(UserCommand userCommand)
        {
            var res = await _mediator.Send(userCommand);
            return Ok(res);
        }
    }
}
