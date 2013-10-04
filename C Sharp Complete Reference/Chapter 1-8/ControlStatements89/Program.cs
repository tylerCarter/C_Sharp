using System;

namespace ControlStatements89
{
    class Program
    {
        static void Main()
        {
            int i;

            for (i = -5; i <= 5; i++)
            {
                Console.Write("Testing " + i + ": ");

                if(i < 0) Console.WriteLine("negative");
                else if(i == 0) Console.WriteLine("no sign");
                    else Console.WriteLine("positive");
            }
        }
    }
}
