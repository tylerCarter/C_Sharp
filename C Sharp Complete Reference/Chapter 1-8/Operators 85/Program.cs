using System;

namespace Operators_85
{
    class Program
    {
        static void Main()
        {
            // Divide by only even, non-zero values.
            for (int i = -5; i < 6; i++)
            {
                if (i != 0 ? (i%2 == 0) : false) // as in book(sic!)
                    Console.WriteLine("100 / " + i + " is " + 100 / i);
                
            }
        }
    }
}
