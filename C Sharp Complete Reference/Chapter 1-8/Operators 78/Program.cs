﻿using System;


namespace Operators_78
{
    class Program
    {
        static void Main()
        {
            // Use bitwise OR to make a number odd
            ushort num;
            ushort i;

            for (i = 1; i <= 10; i++)
            {
                num = i;
                Console.WriteLine("num: " + num);

                num = (ushort)(num | 1);

                Console.WriteLine("num after turning on bit zero: " + num + "\n");
            }
        }
    }
}
