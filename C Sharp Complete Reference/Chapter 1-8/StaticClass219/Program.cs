// Demonstrate a static class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass219
{
    internal static class NumericFn
    {
        // Return the reciprocal of a value.
        public static double Reciprocal(double num)
        {
            return 1 / num;
        }

        // Return the fractional part of a value.
        public static double FracPart(double num)
        {
            return num - (int)num;
        }

        // Return true if num is even.
        static public bool IsEven(double num)
        {
            return (num % 2) == 0 ? true : false;
        }

        // Return true if num is odd.
        static public bool IsOdd(double num)
        {
            return !IsEven(num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reciprocal of 5 is " + NumericFn.Reciprocal(5.0));
            Console.WriteLine("Fractional part of 4.234 is " + NumericFn.FracPart(4.234));
            if(NumericFn.IsEven(10))
                Console.WriteLine("10 is even");
            if(NumericFn.IsOdd(5))
                Console.WriteLine("5 is odd");

            // The following attempt to create an instance of 
            // NumericFn will cause an error.
            // NumericFn ob = new NumericFn(); // Wrong!
        }
    }
}
