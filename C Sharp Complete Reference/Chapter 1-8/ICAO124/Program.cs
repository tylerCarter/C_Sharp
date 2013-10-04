// A simple example that uses a parameter.

using System;


namespace ICAO124
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
    }

    class Program
    {
        static void Main()
        {
            ChkNum ob = new ChkNum();

            for(int i = 2; i < 10; i++)
                if (ob.IsPrime(i)) Console.WriteLine(i + " is prime.");
                else Console.WriteLine(i + " is not prime.");
        }
    }
}
