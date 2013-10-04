// Objects are passed by reference.

using System;

namespace Methods177
{
    class Test
    {
        public int a, b;

        public Test(int i, int j)
        {
            a = i;
            b = j;
        }

        /* Pass an object. Now, ob.a and ob.b in object
         * used in the call will be changed. */
        public void Change(Test ob)
        {
            ob.a = ob.a + ob.a;
            ob.b = -ob.b;
        }

    }
    class Program
    {
        static void Main()
        {
            Test ob = new Test(15, 20);

            Console.WriteLine("ob.a and ob.b before call: " +
                              ob.a + " " + ob.b);

            ob.Change(ob);

            Console.WriteLine("ob.a and ob.b after call: " +
                              ob.a + " " + ob.b);
        }
    }
}
