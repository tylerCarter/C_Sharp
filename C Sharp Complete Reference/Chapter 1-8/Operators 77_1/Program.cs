using System;

namespace Operators_77_1
{
    class Program
    {
        static void Main()
        {
            //Display the bits within a byte.

            int t;
            byte val;

            val = 10;
            for(t = 128; t > 0; t = t/2)
            {
                if((val & t) != 0) Console.Write("1 ");
                if((val & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
        }
    }
}
