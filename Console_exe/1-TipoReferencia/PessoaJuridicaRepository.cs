using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe._1_TipoReferencia
{
    internal class PessoaJuridicaRepository
    {
        private List<PessoaJuridica> pessoasJuridicas;
        public PessoaJuridicaRepository()
        {
            this.pessoasJuridicas  = new List<PessoaJuridica>();
        }

        public string Create(PessoaJuridica pessoa)
        {
            this.pessoasJuridicas.Add(pessoa);
            return "Pessoa: " + pessoa.Nome + " Salva com sucesso";

        }

        public List<PessoaJuridica> Read()
        {
            return pessoasJuridicas;
        }

        public string Update(PessoaJuridica pessoa)
        {
            return "Pessoa: " + pessoa.Nome + " alterada com sucesso";
        }

        public string Delete(int id)
        {
            return "Pessoa de id: " + id + "deletada com sucesso";
        }
    }

    
}
