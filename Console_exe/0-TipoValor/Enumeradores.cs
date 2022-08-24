using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe.TipoValor
{
    internal class Enumeradores
    {
        public static void Executa()
        {
            Console.WriteLine(DiasDaSemana.DOM);
            Console.WriteLine((byte)DiasDaSemana.DOM); //Ele vai chamar a posição do domingo em todos esses
            Console.WriteLine((int)DiasDaSemana.SEX);
            Console.WriteLine((int)DiasDaSemana.DOM);
            Console.WriteLine((float)DiasDaSemana.DOM);
            Console.WriteLine((double)DiasDaSemana.DOM);
            Console.WriteLine((decimal)DiasDaSemana.DOM);

            DiasDaSemana seg = DiasDaSemana.SEG;
            Console.WriteLine(seg);
            DiasDaSemana ter = (DiasDaSemana)2;
            System.Console.WriteLine(ter);



        }
    }

    enum DiasDaSemana //enum = coisas que são fixas, teremos valores númericos associados a estes enums
    {
        //O valor inicial será por padrão 0, mas se você instanciar um valor os outros seguem o padrão
        //ex DOM = 1;
        DOM,
        SEG,
        TER,
        QUA,
        QUI,
        SEX,
        SAB
    }
}
