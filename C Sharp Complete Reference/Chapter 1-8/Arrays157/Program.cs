// Search an array using foreach.
using System;

namespace Arrays157
{
    class Program
    {
        static void Main()
        {
            int[] nums = new int[10];
            int val;
            bool found = false;

            // Give nums some values.
            for (int i = 0; i < 10; i++)
                nums[i] = i;

            val = 5;

            //Use foreach to search nums for key.
            foreach (int x in nums)
            {
                if (x == val)
                {
                    found = true;
                    break;
                }
            }

            if(found)
                Console.WriteLine("Value found");
        }
    }
}
