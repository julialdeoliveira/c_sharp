using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe
{
    internal class BemVindo
    {
        public static void Salutar()
        {
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Olá {name}");
            Console.ReadLine();
        }
    }
}
