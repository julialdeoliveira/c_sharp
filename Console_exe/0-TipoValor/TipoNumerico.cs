using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_exe.TipoValor
{
    internal class TipoNumerico

    {
        public void Executar()
        {
            //Esse são os tipos númericos no C#

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

            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            System.Console.WriteLine("Min int " + intMin + " Max int " + intMax);

            Int16 int16Min = Int16.MinValue;
            Int16 int16Max = Int16.MaxValue;
            System.Console.WriteLine("Min int16 " + int16Min + "Max int16" + int16Max);

            Int32 int32Min = Int32.MinValue;
            Int32 int32Max = Int32.MaxValue;
            System.Console.WriteLine("Min int32 " + int32Min + "Max int32" + int32Max);

            Int64 int64Min = Int64.MinValue;
            Int64 int64Max = Int64.MaxValue;
            System.Console.WriteLine("Min int64 " + int64Min + "Max int64" + int64Max);

            long longMin = long.MinValue;
            long longMax = long.MaxValue;
            System.Console.WriteLine("Min long " + longMin + "Max long" + longMax);




        }
    }
}
