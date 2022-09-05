using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApi.Dto;
using WepApi.Model;
using WepApi.Utils;

namespace WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
          static  User _user = new User();
        private readonly IConfiguration configuration;
        //Registro
        [HttpPost("Register")]
        public ActionResult<User> Register(UserDto userDto)
        {
            _user.Created = DateTime.Now;
            _user.Id = 1;
            _user.Name = userDto.UserName;
            _user.Password = userDto.Password;
            return Created("api/Auth/Register", _user);
        }

        //Logon
        [HttpPost("Logon")]

        public ActionResult<string> Logon(UserDto userDto)
        {
            if(userDto.UserName == _user.Name && _user.Password == userDto.Password)
            {
            return Ok(new JwtTokenUser(this.configuration).CreateToken(_user));

            }
            return BadRequest("Usuário ou senha inválidos");
        }

    }
}
