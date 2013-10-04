﻿// Demonstrate params.

using System;


namespace Methods184
{
    class Program
    {
        class Min
        {
            public int MinVal(params int[] nums)
            {
                int m;

                if (nums.Length == 0)
                {
                    Console.WriteLine("Error: no arguments.");
                    return 0;
                }

                m = nums[0];
                for (int i = 0; i < nums.Length; i++)
                    if (nums[i] < m) m = nums[i];

                return m;
            }
        }

        static void Main()
        {
            Min ob = new Min();
            int min;
            int a = 10, b = 20;

            // Call with 2 values.
            min = ob.MinVal(a, b);
            Console.WriteLine("Minimum is " + min);

            // Call with 3 values.
            min = ob.MinVal(a, b, -1);
            Console.WriteLine("Minimum is " + min);

            // Call with 5 values.
            min = ob.MinVal(18, 23, 3, 14, 25);
            Console.WriteLine("Minimum is " + min);

            // Can call with an int array, too.
            int[] args = {45, 67, 34, 9, 112, 8};
            min = ob.MinVal(args);
            Console.WriteLine("Minimum is " + min);
        }
    }
}
