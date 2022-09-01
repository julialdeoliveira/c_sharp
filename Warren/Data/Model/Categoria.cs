using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
    
  
{
   // [Table("TabelaCategoria")]
    public class Categoria : BaseModel
    {
        public string Nome { get; set; } = String.Empty;
        public string Descricao { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
