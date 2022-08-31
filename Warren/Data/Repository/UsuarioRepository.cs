using Data.Model;
using Data.NovaPasta;
using Data.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>
    {
        public override string Create(Usuario model)
        {
            model.Password = Criptografia.Criptografar( model.Password);
            return base.Create(model);
        }

        public override string Update(Usuario model)
        {
            model.Password = Criptografia.Criptografar(model.Password);
            return base.Update(model);

        }

        public string Logon(string email, string password)
        {
            password = Criptografia.Criptografar(password);
            Usuario usuario = new Usuario();    
            using (WarrenContext context = new WarrenContext())
            {

                usuario = context.Usuario.Where(u=>u.Email == email && u.Password == password).FirstOrDefault();

            }
            usuario.Password = null;
            JsonSerializerOptions jsonSerializerOptions = new() {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull

            };
            string userJson = JsonSerializer.Serialize(usuario, jsonSerializerOptions); 
            return userJson;
        }



    }
}
