// Implicit type conversions can affect overloaded method resolution.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods192
{
    class Overload2
    {
        public void MyMeth(byte x)
        {
            Console.WriteLine("Inside MyMeth(byte): " + x);
        } 

        public void MyMeth(int x)
        {
            Console.WriteLine("Inside MyMeth(int): " + x);
        } 

        public void MyMeth(double x)
        {
            Console.WriteLine("Inside MyMeth(double): " + x);
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Overload2 ob = new Overload2();
            int i = 10;
            double d = 10.1;

            byte b = 99;
            short s = 10;
            float f = 11.5F;

            ob.MyMeth(i); // calls ob.MyMeth(int)
            ob.MyMeth(d); // calls ob.MyMeth(double)

            ob.MyMeth(b); // calls ob.MyMeth(int) -- now, no type conversion
            ob.MyMeth(s); // calls ob.MyMeth(int) -- type conversion
            ob.MyMeth(f); // calls ob.MyMeth(double) -- type conversion
        }
    }
}
