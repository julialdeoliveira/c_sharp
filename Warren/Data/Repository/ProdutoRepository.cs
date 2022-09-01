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
    public class ProdutoRepository : BaseRepository<Produto>
    {
        public override List<Produto> GetAll()

        {
            List<Produto> list = new List<Produto>();

            using (WarrenContext context = new WarrenContext())
            {
                list = context.Produto.Include("Categoria").ToList();   
            }
            return list;
        }
    }
}
