using System;

namespace Operators_73
{
    class Program
    {
        static void Main()
        {
            // Side effects can be important.
            int i;
            bool someCondition = false;

            i = 0;

            // Here, i is still incremented even through the if statement fails.
            if (someCondition & (++i < 100))
                Console.WriteLine("this won't be displayed");
            Console.WriteLine("if statement executed: " + i); // displays 1

            // In this case, i is not incremented because the short-circuit
            // operator skips the increment.
            if (someCondition && (++i < 100))
                Console.WriteLine("this won't be displayed");
            Console.WriteLine("if statement executed: " + i); // still 1!!
        }
    }
}
