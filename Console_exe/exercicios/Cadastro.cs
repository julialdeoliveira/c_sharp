using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe.exercicios
{
    internal class Cadastro
    {
        //Crie um sistema de cadastro de pessos
        //1- O sistema deve exibir uma mensagem de boas vindas
        //2- Deve solicitar as seguintes informações:
        //Nome, Sobrenome e idade
        // 3- Ao fim deve exibir o nome completo e a idade junto com a mensagem de despedida

            public static void Cadastrar()
        {
            Console.WriteLine("Seja bem vindo");
            Console.WriteLine("Digite seu primeiro nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite sua idade");
            byte idade = Convert.ToByte(Console.ReadLine());
            while (idade == 0)
            {
                Console.WriteLine("Digite uma idade");
                idade = Convert.ToByte(Console.ReadLine());
            }
            Console.WriteLine($"Até mais {nome} {sobrenome}, que tem {idade} anos");


        }
    }
}
