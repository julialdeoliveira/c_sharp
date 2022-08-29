using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_pessoa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>

    {
        private R repo;
       

        public GenericController(R  repo)
        {
            this.repo = repo;
        }

   

        [HttpGet]
        public List<T> GetAll()
        {

            return repo.GetAll();

        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {

            return repo.GetById(id);

        }

        [HttpPost]
        public string Post(T model)
        {

            return repo.Create(model);
        }
        [HttpDelete]
        public string Delete(int id)
        {

            return repo.Delete(id);

        }
        [HttpPut]
        public string Update(T model)
        {


            return repo.Update(model);

        }

    }
}
