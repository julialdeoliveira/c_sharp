using api_pessoa.Controllers;
using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class PlantaController : GenericController<Planta, RepositoryPlanta>
    {
        public PlantaController() : base(new RepositoryPlanta())
        {

        } 


    }
}
