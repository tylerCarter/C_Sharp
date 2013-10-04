// An example of operator overloading 

using System;

namespace Chapter_9
{
// A three-dimensional coordinate class.
    class ThreeD
    {
        private int x, y, z;

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
            ThreeD result = new ThreeD();

            /* This adds together the coordinates of the two points
             * and returns the result. */
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;

            return result;
        }

        // Overload binary -.
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

        // Overload unary -.
        public static ThreeD operator -(ThreeD op1)
        {
            var result = new ThreeD() {x = -op1.x, y = -op1.y, z = -op1.z};
            return result;
        }

        // Overload unary ++.
        public static ThreeD operator ++(ThreeD op1)
        {
            var result = new ThreeD() {x = op1.x + 1, y = op1.y + 1, z = op1.z + 1};
            return result;
        }

        // Show x, y, z coordinates.
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ThreeD(1, 2, 3);
            var b = new ThreeD(10, 10, 10);
            ThreeD c;

            Console.Write("Here is a: ");
            a.Show();
            Console.WriteLine();
            Console.Write("Here is b: ");
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
