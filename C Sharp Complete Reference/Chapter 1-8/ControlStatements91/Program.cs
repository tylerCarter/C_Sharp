using System;

namespace ControlStatements91
{
    class Program
    {
        static void Main()
        {
            // Demonstrate the switch.
            int i;

            for(i = 0; i < 10; i++)
                switch (i)
                {
                    case 0:
                        Console.WriteLine("i is zero");
                        break;
                    case 1:
                        Console.WriteLine("i is one");
                        break;
                    case 2:
                        Console.WriteLine("i is two");
                        break;
                    case 3:
                        Console.WriteLine("i is three");
                        break;
                    case 4:
                        Console.WriteLine("i is four");
                        break;
                    default:
                        Console.WriteLine("i is five or more");
                        break;
                }
        }
    }
}
