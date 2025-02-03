
using Application.UseCQ.Commands;
using Application.UseCQ.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace API.Controllers
{
    [Route("[controller]")]
        [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator; 
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("Create-User")]
        public async Task<ActionResult<UserInfoViewModel>> CreateUser(CreateUserCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
    
}
