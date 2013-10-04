using System;


namespace ControlStatements99_1
{
    class Program
    {
        static void Main()
        {
            // Move more out of the for loop.
            int i;

            i = 0; // move initialization out of loop
            for (; i < 10;)
            {
                Console.WriteLine("Pass #" + i);
                i++; // increment loop control var
            }
        }
    }
}
