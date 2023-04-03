using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using workshop.Application.Common.Interface;
using workshop.Application.DTOs;

namespace workshop.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IAuthentication _authenticationManger;

        private AuthenticateController(UserManager<IdentityUser> userManager, IAuthentication authenticationManager)
        {
            _userManager = userManager;
            _authenticationManger = authenticationManager;
        }

        [HttpPost]
        [Route("/api/authenticate/register")]
        public async Task<ResponseDTO> Register([FromBody] UserRegisterRequestDTO model)
        {
            var result = await _authenticationManger.Register(model);
            return result;
        }
    }
}
