using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tipo flutuante é aquele que tem casa decimal

namespace Console_exe.TipoValor
{
    internal class TipoNumerico3
    {
        public static void Executa()
        {
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;
            Console.WriteLine("Float min: " + floatMin);
            Console.WriteLine("Float max: " + floatMax);

            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;
            Console.WriteLine("Double min: " + doubleMin);
            Console.WriteLine("Double max: " + doubleMax);

            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;
            Console.WriteLine("Decimal min: " + decimalMin);
            Console.WriteLine("Decimal max: " + decimalMax);

            double n1 = 10.10;
            double n2 = 20.20;
            double result = 30.3;

            Console.WriteLine($"{n1 + n2} -  {result}");
            Console.WriteLine((n1 + n2) == result);

            decimal n1d = 10.10m;
            decimal n2d = 20.20m;
            decimal resultd = 30.3m;

            Console.WriteLine($"{n1d + n2d} -  {resultd}");
            Console.WriteLine((n1d + n2d) == resultd);
        }
    }
}
