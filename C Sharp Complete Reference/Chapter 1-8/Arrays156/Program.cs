// Use break with foreach.

using System;

namespace Arrays156
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int[] nums = new int[10];

            // Give nums some values.
            for (int i = 0; i < 10; i++)
                nums[i] = i;

            // Use foreach to display and sum the values.
            foreach (int x in nums)
            {
                Console.WriteLine("Values is: " + x);
                sum += x;
                if (x == 4) break; // stop the loop when 4 is obtained
            }
            Console.WriteLine("Summation of first 5 elements: " + sum);
        }
    }
}
