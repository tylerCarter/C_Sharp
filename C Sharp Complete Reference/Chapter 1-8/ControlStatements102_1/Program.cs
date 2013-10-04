using System;

namespace ControlStatements102_1
{
    class Program
    {
        static void Main()
        {
            // Compute iteger powers of 2
            int e;
            int result;

            for (int i = 0; i < 10; i++)
            {
                result = 1;
                e = i;
                while (e > 0)
                {
                    result *= 2;
                    e--;
                }

                Console.WriteLine("2 to the " + i + " power is " + result);
            }
        }
    }
}
