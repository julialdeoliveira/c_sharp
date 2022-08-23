using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.TipoValor
{
    internal class TipoValor
    {
        public void Executar()
        {
            byte min = Byte.MinValue;
            byte max = Byte.MaxValue;
            System.Console.WriteLine("Min byte " + min + " Max byte " + max);
            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            System.Console.WriteLine("Min sbyte " + sbyteMin + " Max sbyte " + sbyteMax);
            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            System.Console.WriteLine("Min short " + shortMin + " Max short  " + shortMax);
            ushort ushortMin = ushort.MinValue;
            ushort ushortMax = ushort.MaxValue;
            System.Console.WriteLine("Min ushort " + ushortMin + " Max ushort " + ushortMax);
        }
    }
}
