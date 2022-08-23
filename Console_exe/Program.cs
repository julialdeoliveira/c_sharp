using Console_exe.TipoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TipoValor1 tipo1 = new TipoValor1();
            tipo1.Executar();
            BemVindo.Salutar();
        }
    }
}
