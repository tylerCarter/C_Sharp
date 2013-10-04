using System;

namespace ConditionalStatements98
{
    class Program
    {
        static void Main()
        {
            // Loop condition can be any bool expression
            int i, j;
            bool done = false;

            for (i = 0, j = 100; !done; i++, j--)
            {
                if (i*i >= j) done = true;

                Console.WriteLine("i, j: " + i + " " + j);
            }
        }
    }
}
