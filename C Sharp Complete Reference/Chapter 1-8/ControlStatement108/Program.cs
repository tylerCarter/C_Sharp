using System;

namespace ControlStatement108
{
    class Program
    {
        static void Main()
        {
            // Use goto with a switch.

            for (int i = 1; i < 5; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("In case 1");
                        goto case 3;
                    case 2:
                        Console.WriteLine("In case 2");
                        goto case 1;
                    case 3:
                        Console.WriteLine("In case 3");
                        goto default;
                    default:
                        Console.WriteLine("In default");
                        break;
                }

                Console.WriteLine();
            }

            // goto case 1; // Error! Can't jump into a switch.
        }
    }
}
