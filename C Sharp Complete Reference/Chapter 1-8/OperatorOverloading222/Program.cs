// An example of operator overloading.

using System;

namespace OperatorOverloading222
{
    // A three-dimensional coordinate class.
    class ThreeD
    {
        int x, y, z;

        public ThreeD()
        {
            x = y = z = 0;
        }

        public ThreeD(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        // Overload binary +.
        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            var result = new ThreeD();

            /* This adds together coordinates of the two points
             * and returns the result. */
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;

            return result;
        }

        // Overload binaty -.
        public static ThreeD operator -(ThreeD op1, ThreeD op2)
        {
            var result = new ThreeD();

            /* Notice the order of the operands. op1 is the left
             * operand and op2 is the right. */
            result.x = op1.x - op2.x;
            result.y = op1.y - op2.y;
            result.z = op1.z - op2.z;

            return result;
        }

        // Show X, Y, Z coordinates.
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c;

            Console.Write("Here is a: ");
            a.Show();
            Console.WriteLine();
            Console.Write("Here is a b: ");
            b.Show();
            Console.WriteLine();

            c = a + b; // add a and b together
            Console.Write("Result of a + b: ");
            c.Show();
            Console.WriteLine();

            c = a + b + c; // add a, b and c together
            Console.Write("Result of a + b + c: ");
            c.Show();
            Console.WriteLine();

            c = c - a; // substract a 
            Console.Write("Result of c - a: ");
            c.Show();
            Console.WriteLine();

            c = c - b; // substract b
            Console.Write("Result of c - b: ");
            c.Show();
            Console.WriteLine();
        }
    }
}
