﻿using System;

namespace ControlStatements97
{
    class Program
    {
        static void Main()
        {
            // Use comma in a for statement to find largest and
            // smallest factor of a number

            int i, j;
            int smallest, largest;
            int num;

            num = 100;

            smallest = largest = 1;

            for (i = 2, j = num/2; (i <= num/2) & (j >= 2); i++, j--)
            {
                if ((smallest == 1) & ((num%i) == 0))
                    smallest = i;
                if ((largest == 1) & ((num%j) == 0))
                    largest = j;
            }

            Console.WriteLine("Largest factor: " + largest);
            Console.WriteLine("Smallest factor: " + smallest);
        }
    }
}
