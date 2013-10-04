// Use the Length array property.

using System;


namespace Arrays150
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[10];

            Console.WriteLine("Length of nums is  " + nums.Length);

            // Use Length to initialize nums.
            for (int i = 0; i < nums.Length; i++)
                nums[i] = i * i;

            // Now use Length to display nums.
            Console.Write("Here is nums: ");
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");

            Console.WriteLine();
        }
    }
}
