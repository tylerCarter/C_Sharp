using System;

namespace ControleStatements107
{
    class Program
    {
        static void Main()
        {
            // Using goto to sum 1..n

            int x = 1;
            int sum = 0;
            loop1:
                sum += x++;
                if (x <= 100) goto loop1;

            Console.WriteLine(sum);

        }
    }
}
