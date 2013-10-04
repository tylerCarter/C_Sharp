using System;

namespace ControlStatements90
{
    class Program
    {
        static void Main()
        {
            int num;

            for (num = 2; num < 12; num++)
            {
                if((num % 2) == 0)
                    Console.WriteLine("Smallest factor of " + num + " is 2.");
                else if((num % 3) == 0)
                    Console.WriteLine("Smallest factor of " + num + " is 3.");
                else if((num % 5) == 0)
                    Console.WriteLine("Smallest factor of " + num + " is 5.");
                else if((num % 7) == 0)
                    Console.WriteLine("Smallest factor of " + num + " is 7.");
                else
                    Console.WriteLine(num + " is not divisible by 2, 3, 5, 7.");
            }
        }
    }
}
