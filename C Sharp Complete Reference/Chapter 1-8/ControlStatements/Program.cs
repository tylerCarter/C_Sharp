using System;

namespace ControlStatements
{
    class Program
    {
        static void Main()
        {
            // Determine if a value is positive or negative.
            int i;

            for (i = -5; i <= 5; i++)
            {
                Console.Write("Testing " + i + ": ");
                if(i < 0) Console.WriteLine("negative");
                else Console.WriteLine("positive");
            }
        }
    }
}
