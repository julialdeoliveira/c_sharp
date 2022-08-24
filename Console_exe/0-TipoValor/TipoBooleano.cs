using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe.TipoValor
{
    internal class TipoBooleano
    {
        public static void Executa()
        {
            bool gostaDeCalypso = true;
            bool naoGostaDeBaroes = false;

            bool ehmaior = 10 > 11;
            bool ehigual = 10 + 11 == 21;
            if (ehmaior)
            {
                Console.WriteLine("É maior");
            }
            else
            {
                Console.WriteLine("É menor");
            }

        }
    }
}
