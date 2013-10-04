// A parametrized constructor.
using System;

namespace ICAO130
{
    class MyClass
    {
        public int x;

        public MyClass(int i)
        {
            x = i;
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass t1 = new MyClass(10);
            MyClass t2 = new MyClass(20);

            Console.WriteLine(t1.x + " " + t2.x);
        }
    }
}
