﻿using System;


namespace ControlStatements95_1
{
    class Program
    {
        static void Main()
        {
            // Determine if a number is prime. If it is not, then
            // display its largest factor.

            int num;
            int i;
            int factor;
            bool isprime;

            for (num = 2; num < 20; num++)
            {
                isprime = true;
                factor = 0;

                // See if num is evently divisible.
                for (i = 2; i <= num/2; i++)
                {
                    if ((num%i) == 0)
                    {
                        // num is evently divisible. Thus, it is not prime.
                        isprime = false;
                        factor = i;
                    }
                }

                if(isprime)
                    Console.WriteLine(num + " is prime.");
                else
                    Console.WriteLine("Largest factor of " + num + " is " + factor);
            }

        }
    }
}
