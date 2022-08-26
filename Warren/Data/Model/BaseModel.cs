using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public abstract class BaseModel //O abstract faz ela só poder ser herdade e não instanciada
    {
        public int Id { get; set; } 
            
    }
}
