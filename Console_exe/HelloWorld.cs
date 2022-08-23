using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe
{
    internal class HelloWorld
    {
        public static void Name()
        {
            Console.WriteLine("Hello Word :)"); //How to print something in the console
            String person = "Júlia"; //Declaring a String variable
            Console.WriteLine(person);
            Console.WriteLine("My name is " + person); //How to join a variable with a string
            Console.WriteLine($"My name is {person}");//In another way
            String mom = "Mariana";
            String dad = "Antônio";
            Console.WriteLine($"{mom} and {dad} had me");
            Console.WriteLine($"My mom's name has {mom.Length} letters");
        }
       
    }
}
