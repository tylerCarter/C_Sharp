// Use named arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments206
{
    class Program
    {
        // Determine if one value is evently divisible by another.
        static bool IsFactor(int val, int divisor)
        {
            if ((val%divisor) == 0) return true;
            return false;
        }
        static void Main(string[] args)
        {
            // The following show various ways in which IsFactor() can be called.

            // Call the use of positional arguments.
            if(IsFactor(10, 2))
                Console.WriteLine("2 is factor of 10.");

            // Call the use of named arguments.
            if(IsFactor(val: 10, divisor: 2))
                Console.WriteLine("2 is factor of 10.");

            // Use both a positional argument and a named argument.
            if(IsFactor(10, divisor: 10))
                Console.WriteLine("2 is factor of 10.");
        }
    }
}
