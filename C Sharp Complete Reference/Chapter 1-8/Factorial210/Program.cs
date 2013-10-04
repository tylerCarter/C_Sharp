// A simple example of recursion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial210
{
    class Factorial
    {
        // This is recursive method.
        public int FactR(int n)
        {
            int result;

            if (n == 1) return 1;
            result = FactR(n - 1)*n;
            return result;
        }

        // This is an iteratie equivalent.
        public int FactI(int n)
        {
            int t, result;

            result = 1;
            for (t = 1; t <= n; t++) result *= t;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Factorial f = new Factorial();

            Console.WriteLine("Factorial using recursive method.");
            Console.WriteLine("Factorial of 3 is " + f.FactR(3));
            Console.WriteLine("Factorial of 4 is " + f.FactR(4));
            Console.WriteLine("Factorial of 5 is " + f.FactR(5));
            Console.WriteLine();

            Console.WriteLine("Factorial using iterative method.");
            Console.WriteLine("Factorial of 3 is " + f.FactI(3));
            Console.WriteLine("Factorial of 4 is " + f.FactI(4));
            Console.WriteLine("Factorial of 5 is " + f.FactI(5));
        }
    }
}
