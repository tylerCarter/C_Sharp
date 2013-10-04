using System;

namespace C_Sharp_Complete_Reference
{
    class Program
    {
        static void Main()
        {
            int x, y;
            int i;

            x = 1;
            y = 0;
            Console.WriteLine("Series generated using y = y + x++;");
            for (i = 0; i < 10; i++)
            {
                y = y + x++; //postrix ++

                Console.WriteLine(y + " ");
            }
            Console.WriteLine();

            x = 1;
            y = 0;
            Console.WriteLine("Series generated usint y = y + ++x;");
            for (i = 0; i < 10; i++)
            {
                y = y + ++x; // prefix ++
                Console.WriteLine(y + " ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
