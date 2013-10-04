using System;

namespace Operators_84
{
    class Program
    {
        static void Main()
        {
            int result;

            for (int i = -5; i < 6; i++)
            {
                result = i != 0 ? 100/i : 0;
                if (i != 0)
                    Console.WriteLine("100 / " + i + " is " + result);
            }  
        }
    }
}
