using System;

namespace Operators_76
{
    class Program
    {
        static void Main()
        {
            ushort num;
            ushort i;

            for (i = 1; i <= 10; i++)
            {
                num = i;

                Console.WriteLine("num: " + num);

                num = (ushort)(num & 0xFFFE);

                Console.WriteLine("num after turning off bit zero: " + num + "\n");
            }
        }
    }
}
