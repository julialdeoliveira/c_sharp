using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTO;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class AcessController : ControllerBase
    {

        [HttpPost("Logon")]
        public string Logon(UsuarioDto usuarioDto)
        {
            UsuarioRepository repository = new UsuarioRepository();
            string model = repository.Logon(usuarioDto.Email, usuarioDto.Password);
            return model;
        }

       
    }
}
