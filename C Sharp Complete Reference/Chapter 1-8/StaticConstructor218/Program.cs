// Use a static constructor

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor218
{
    class Cons
    {
        public static int alpha;
        public int beta;

        // A static constructor.
        static Cons()
        {
            alpha = 99;
            Console.WriteLine("Inside static constructor.");
        }

        // An instance constructor.
        public Cons()
        {
            beta = 100;
            Console.WriteLine("Inside instance constructor.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cons ob = new Cons();

            Console.WriteLine("Cons.alpha: " + Cons.alpha);
            Console.WriteLine("ob.beta: " + ob.beta);
        }
    }
}
