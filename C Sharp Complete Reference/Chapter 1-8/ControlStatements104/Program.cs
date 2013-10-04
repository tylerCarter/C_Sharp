using System;


namespace ControlStatements104
{
    class Program
    {
        static void Main()
        {
            // Using break to exit a loop.

            for (int i = -10; i <= 10; i++)
            {
                if (i > 0) break; // Terminate loop when i is positive
                Console.Write(i + " ");
            }
            Console.WriteLine("Done");
        }
    }
}
