// Use a class factory.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods188
{
    class MyClass
    {
        private int a, b; // private

        // Create a class factory fro MyClass.
        public MyClass Factory(int i, int j)
        {
            MyClass t = new MyClass();
            t.a = i;
            t.b = j;

            return t; // return and object
        }

        public void Show()
        {
            Console.WriteLine("a and b: " + a + " " + b);
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass ob = new MyClass();
            int i, j;

            // Generate objects using the factory.
            for (i = 0, j = 10; i < 10; i++, j--)
            {
                MyClass anotherOb = ob.Factory(i, j); // make an object
                anotherOb.Show();
            }

            Console.WriteLine();
        }
    }
}
