using System;

namespace ControlStatements100
{
    class Program
    {
        static void Main()
        {
            // The body of a loop can be empty.
            int i;
            int sum = 0;

            // Sum the members throught 5
            for(i = 1; i <= 5; sum += i++);

            Console.WriteLine("Sum is " + sum);
        }
    }
}
