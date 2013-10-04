using System;

namespace ControlStatements99
{
    class Program
    {
        static void Main()
        {
            // Parts of the for can be empty

            int i;

            for (i = 0; i < 10;)
            {
                Console.WriteLine("Pass #" + i);
                i++; // increment loop control var
            }
        }
    }
}
