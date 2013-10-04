// A string can control a switch statement.
using System;

namespace Strings166
{
    class Program
    {
        static void Main()
        {
            string[] strs = { "one", "two", "three", "two", "one" };

            foreach (string s in strs)
            {
                switch (s)
                {
                    case "one":
                        Console.Write(1);
                        break;
                    case "two":
                        Console.Write(2);
                        break;
                    case "three":
                        Console.Write(3);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
