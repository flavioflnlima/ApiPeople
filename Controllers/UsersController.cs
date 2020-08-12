using System.Threading.Tasks;
using WebApiPeople.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebApiPeople.Repositories;
using WebApiPeople.Services;

namespace WebApiPeople.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login([FromBody] UserViewModel userModel)
        {
            var user = UserRepository.Get(userModel.Email, userModel.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            user.Password = "";
            return new
            {
                user = user,
                token = token
            };
        }

    }
}
