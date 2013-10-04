// Demonstrate string arrays.
using System;

namespace Strings163
{
    class Program
    {
        static void Main()
        {
            string[] str = { "This", "is", "a", "test." };

            Console.WriteLine("Original array: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine("\n");

            // Change a string.
            str[1] = "was";
            str[3] = "test, too!";

            Console.WriteLine("Modified array: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
