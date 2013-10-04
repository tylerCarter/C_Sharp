// Swap two values.

using System;

namespace Methods179_1
{
    class ValueSwap
    {
        // This method now changes its arguments.
        public void Swap(ref int a, ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;
        }
    }
    class Program
    {
        static void Main()
        {
            ValueSwap ob = new ValueSwap();

            int x = 10, y = 20;

            Console.WriteLine("x and y before call: " + x + " " + y);

            ob.Swap(ref x, ref y);

            Console.WriteLine("x and y after call: " + x + " " + y);
        }
    }
}
