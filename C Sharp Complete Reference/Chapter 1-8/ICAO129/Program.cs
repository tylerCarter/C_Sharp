// A simply constructor.
using System;

namespace ICAO129
{
    class MyClass
    {
        public int x;

        public MyClass()
        {
            x = 10;
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass t1 = new MyClass();
            MyClass t2 = new MyClass();

            Console.WriteLine(t1.x + " " + t2.x);
        }
    }
}
