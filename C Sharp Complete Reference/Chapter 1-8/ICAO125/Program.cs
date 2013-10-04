// Add a method that takes two arguments.
using System;

namespace ICAO125
{
    class ChkNum
    {
        // Return true if x is prime.
        public bool IsPrime(int x)
        {
            if (x <= 1) return false;

            for (int i = 2; i <= x / i; i++)
                if ((x % i) == 0) return false;

            return true;
        }

        // Return the last common factor.
        public int LeastCommonFactor(int a, int b)
        {
            int max;

            if (IsPrime(a) || IsPrime(b)) return 1;

            max = a < b ? a : b;

            for (int i = 2; i <= max / 2; i++)
                if (((a % i) == 0) && ((b % i) == 0)) return i;
            return 1;
        }
    }

    class Program
    {
        static void Main()
        {
            ChkNum ob = new ChkNum();
            int a, b;

            for(int i = 2; i < 10; i++)
                if (ob.IsPrime(i)) Console.WriteLine(i + " is prime.");
                else Console.WriteLine(i + " is not prime.");

            a = 7;
            b = 8;
            Console.WriteLine("Least common factor for " +
                              a + " and " + b + " is " +
                              ob.LeastCommonFactor(a, b));

            a = 100;
            b = 8;
            Console.WriteLine("Least common factor for " +
                              a + " and " + b + " is " +
                              ob.LeastCommonFactor(a, b));

            a = 100;
            b = 75;
            Console.WriteLine("Least common factor for " +
                              a + " and " + b + " is " +
                              ob.LeastCommonFactor(a, b));
        }
    }
}
