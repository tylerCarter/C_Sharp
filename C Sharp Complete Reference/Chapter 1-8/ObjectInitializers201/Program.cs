// A simple demonstration that uses object initializers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers201
{
    class MyClass
    {
        public int Count;
        public string Str;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Construct a MyClass object by using object initializers.
            var obj = new MyClass {Count = 100, Str = "Testing"};

            Console.WriteLine(obj.Count + " " + obj.Str);
        }
    }
}
