using System;

namespace ControleStatements106
{
    class Program
    {
        static void Main()
        {
            // Using break with nested loops

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Outer loop count: " + i);
                Console.Write("    Inner loop count: ");

                int t = 0;
                while (t < 100)
                {
                    if (t == 10) break; // terminate loop if t is 10
                    Console.Write(t + " ");
                    t++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Loops complete.");
        }
    }
}
