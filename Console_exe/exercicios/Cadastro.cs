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

        //byte idade = Byte.Parse(System.Console.ReadLine());


        public static void Cadastrar()
        {
            Console.WriteLine("Seja bem vindo");
            Console.WriteLine("Digite seu primeiro nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            byte idade = 0;

            while (idade == 0)
            {

                try
                {
                    Console.WriteLine("Digite uma idade válida: ");
                    idade = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine($"Até mais {nome} {sobrenome}, que tem {idade} anos");

                }
                catch
                {
                    Console.WriteLine("Você digitou uma idade errada");
                }

            }

        }
    }
}
