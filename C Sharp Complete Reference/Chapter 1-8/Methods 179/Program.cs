// Use ref to pass a value type by reference.

using System;


namespace Methods_179
{
    class RefTest
    {
        // This method changes its arguments. Notice the use of ref.
        public void Sqr(ref int i)
        {
            i = i * i;
        }
    }
    class Program
    {
        static void Main()
        {
            RefTest ob = new RefTest();

            int a = 10;

            Console.WriteLine("a before call: " + a);

            ob.Sqr(ref a); // notice the use of ref

            Console.WriteLine("a after call: " + a);
        }
    }
}
