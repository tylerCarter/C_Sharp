using System;

namespace ControlStatements101
{
    class Program
    {
        static void Main()
        {
            // Declare loop control variable inside the for.
            int sum = 0;
            int fact = 1;

            // Control the factorial of the number 1 throught 5.
            for (int i = 1; i <= 5; i++)
            {
                sum += i; // i is known throught the loop.
                fact *= i;
            }

            // But, i is not known here.

            Console.WriteLine("Sum is " + sum);
            Console.WriteLine("Factorial is " + fact);
        }
    }
}
