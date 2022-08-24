using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe.TipoValor
{
    internal class Estruturas
    {
        public static void Executar()
        {
            //int idade = 10;
            //PessoaFisica pessoaFisica = new PessoaFisica();

            PessoaClasse p1 = new PessoaClasse();
            p1.Nome = "Chimbinha";
            PessoaStruct p2 = new PessoaStruct();
            p2.Nome = "Joelma";
            Console.WriteLine(p1.Nome);
            Console.WriteLine(p2.Nome);

            PessoaClasse p3 = new PessoaClasse();
            p3 = p1; //Apontando para a mesma área
            PessoaStruct p4 = new PessoaStruct();
            p4 = p2; //Tentanto apontar para a mesma área
            Console.WriteLine(p3.Nome);
            Console.WriteLine(p4.Nome);
            p1.Nome = "Chimbinha Melhor Guitarrista do Mundo";
            p2.Nome = "Joelma Melhor Dançarina do Mundo > Shakira"; //p2 será alterado mas a p4 não
            Console.WriteLine("Valores alterados: ");
            Console.WriteLine(p1.Nome);
            Console.WriteLine(p2.Nome);
            Console.WriteLine(p3.Nome);
            Console.WriteLine(p4.Nome); //O struct não deixa você trocar o valor



        }
    }
    struct PessoaStruct
    {
        public string Nome { get; set; }
        public String Sobrenome { get; set; }
        public byte Idade { get; set; }

    }
    class PessoaClasse
    {
        public int Id { get; set; } 
        //Faz o get e o set automaticamente, isso é uma propriedade
        //Para criar automaticamente digite prop e aperte tab 2x

        public  string Nome { get; set; }
        public String Sobrenome { get; set; }
        public byte Idade{ get; set; }


        //private string nome;
        //private string sobrenome;
        //private byte idade;

        //public string GetNome()
        //{
        //    return this.nome;
        //}

        //public void SetNome(string nome)
        //{
        //   this.nome = nome;
        //}
    }
}
