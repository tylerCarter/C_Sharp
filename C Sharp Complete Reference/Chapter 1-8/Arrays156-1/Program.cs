// Use foreach on a two-dimensional array.
using System;

namespace Arrays156_1
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            int[,] nums = new int[3, 5];

            // Give nums some values.
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                    nums[i, j] = (i + 1) * (j + 1);

            // Use foreach to display and sum the values.
            foreach (int x in nums)
            {
                Console.WriteLine("Values is: " + x);
                sum += x;
            }
            Console.WriteLine("Summation: " + sum);
        }
    }
}
