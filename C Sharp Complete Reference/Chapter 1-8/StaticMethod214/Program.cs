// Use static

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod214
{
    class StaticDemo
    {
        // A static variable
        public static int Val = 100;

        // A static method
        public static int ValDiv2()
        {
            return Val/2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initial value of StaticDemo.Val is " + StaticDemo.Val);

            StaticDemo.Val = 8;
            Console.WriteLine("StaticDemo.Val is " + StaticDemo.Val);
            Console.WriteLine("StaticDemo.ValDemo2(): " + 
                               StaticDemo.ValDiv2());
        } 
    }
}
