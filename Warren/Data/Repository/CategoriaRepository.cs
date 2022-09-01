using Data.Model;
using Data.NovaPasta;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CategoriaRepository : BaseRepository<Categoria>
    {
        public override List<Categoria> GetAll()
        {
            List<Categoria> list = new List<Categoria>();
            using (WarrenContext context = new WarrenContext())
            {
                list = context.Categoria.Include("Produtos").ToList();
;            }
            return list;
        }
    }
}
