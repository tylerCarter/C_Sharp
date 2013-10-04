using System;

namespace ControlStatements102
{
    class Program
    {
        static void Main()
        {
            // Compute the order of magnitude of an integer
            int num;
            int mag;

            num = 435679;
            mag = 0;

            Console.WriteLine("Number " + num);

            while (num > 0)
            {
                mag++;
                num = num / 10;
            };

            Console.WriteLine("Magnitude: " + mag);

        }
    }
}
