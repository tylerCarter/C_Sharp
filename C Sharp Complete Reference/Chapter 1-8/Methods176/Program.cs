// Value types are passed by value.
using System;

namespace Methods176
{
    class Test
    {
        /* This method causes no change to the arguments
         * used in the call. */

        public void NoChange(int i, int j)
        {
            i = i + j;
            j = -j;
        }
    }
    class Program
    {
        static void Main()
        {
            Test ob = new Test();
            int a = 15, b = 20;

            Console.WriteLine("a and b before call: " + 
                               a + " " + b);

            ob.NoChange(a, b);

            Console.WriteLine("a and b after call: " + 
                               a + " " + b);
        }
    }
}
