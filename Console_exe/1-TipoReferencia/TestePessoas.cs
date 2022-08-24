using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe._1_TipoReferencia
{
    internal class TestePessoas
    {
        public static void Executa()
        {
            PessoaFisica pessoaFisica = new PessoaFisica("Júlia", "Luciani", "44444");
            PessoaFisica pessoaFisica2 = new PessoaFisica("j", "jjj", "55555");
            PessoaFisicaRepository repository = new PessoaFisicaRepository();
            repository.Create(pessoaFisica);
            repository.Create(pessoaFisica2);
            List<PessoaFisica> pessoas = repository.Read();

            foreach (PessoaFisica p in pessoas)
            {
                Console.WriteLine(p.Saudacao());
            }
            Console.Read();

            
        }

        public static void ExecutaJuridica()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica("Warren", "enterprise", "22222222");
            PessoaJuridica pessoaJuridica2 = new PessoaJuridica("Amazon", "online", "55555555");
            PessoaJuridicaRepository repository1 = new PessoaJuridicaRepository();
            repository1.Create(pessoaJuridica);
            repository1.Create(pessoaJuridica2);
            List<PessoaJuridica> pessoasJuridicas = repository1.Read();

            foreach (PessoaJuridica p in pessoasJuridicas)
            {
                Console.WriteLine(p.Saudacao());
                Console.Read();
            }
        }
        
    
    }
}
