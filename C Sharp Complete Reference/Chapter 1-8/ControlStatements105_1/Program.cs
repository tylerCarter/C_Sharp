using System;


namespace ControlStatements105_1
{
    class Program
    {
        static void Main()
        {
            // Find the smallest factor of a value.

            int factor = 1;
            int num = 15;

            for (int i = 2; i <= num / i; i++)
            {
                if ((num % i) == 0)
                {
                    factor = i;
                    break; // stop loop when factor is found
                }
            }
            Console.WriteLine("Smallest factor is " + factor);
        }
    }
}
