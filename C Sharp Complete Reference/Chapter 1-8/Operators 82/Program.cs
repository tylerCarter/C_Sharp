using System;

namespace Operators_82
{
    class Program
    {
        static void Main()
        {
            // Use the shift operators to multiply and divide by 2.
            int n;

            n = 10;

            Console.WriteLine("Value of n: " + n);

            // Multiply by 2
            n = n << 1;
            Console.WriteLine("Value of n after n = n * 2: " + n);

            // Multiply by 4
            n = n << 2;
            Console.WriteLine("Value of n after n = n * 4: " + n);

            // Divide by 2
            n = n >> 1;
            Console.WriteLine("Value of n after n = n / 2: " + n);

            // Divide by 4
            n = n >> 2;
            Console.WriteLine("Value of n after n = n / 4: " + n);

            // Reset n
            n = 10;
            Console.WriteLine("Value of n: " + n);

            // Multiply by 2, 30 times
            n = n << 30;
            Console.WriteLine("Value on n after left-shifting 30 places: " + n);
        }
    }
}
