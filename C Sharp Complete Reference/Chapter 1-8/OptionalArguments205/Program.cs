// Use an optional argument to simplify a call to a method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArguments205
{
    class Program
    {
        // Display part or all of string.
        static void Display(string str, int start = 0, int stop = -1)
        {
            if (stop < 0)
                stop = str.Length;

            // Check for out-of-range condition.
            if (stop > str.Length | start  > stop | stop < 0)
                return;

            for(int i = start; i < stop; i++)
                Console.Write(str[i]);

            Console.WriteLine();            
        }

        static void Main(string[] args)
        {
            Display("this is a test");
            Display("this is a test", 10);
            Display("this is a test", 5, 12);
        }
    }
}
