using System;

namespace ControlStatements105
{
    class Program
    {
        static void Main()
        {
            // Using break to exit a do-while loop

            int i;

            i = -10;
            do
            {
                if (i > 0) break;
                Console.Write(i + " ");
                i++;
            } while (i <= 10);

            Console.WriteLine("Done");
        }
    }
}
