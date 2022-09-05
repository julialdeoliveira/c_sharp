using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WepApi.Model;

namespace WepApi.Utils
{
    public class JwtTokenUser
    {
        private readonly IConfiguration configuration;

        public JwtTokenUser(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public  string CreateToken(User user)
        {
            //Claimns
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Name),
           
            };
            //Key
            string appKey =  configuration.GetSection("AppSettings:TokenKey").Value;

            //necessario instalar dependência
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(appKey));

            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
  

            //Expiration
            var expires = DateTime.Now.AddDays(1);
            //Geração do token necessário
            var token = new JwtSecurityToken(
                claims: claims,
                expires: expires,
                signingCredentials: credential
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
    }
}
