// Compute the average of a set of values.

using System;

namespace Arrays142
{
    class Program
    {
        static void Main()
        {
            int[] nums = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

            // OR
            // nums = new int[10] { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };

            int avg = 0;

            for (int i = 0; i < 10; i++)
                avg = avg + nums[i];

            avg = avg / 10;

            Console.WriteLine("Average: " + avg);
        }
    }
}
