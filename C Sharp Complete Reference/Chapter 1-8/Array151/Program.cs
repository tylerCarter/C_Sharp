// Reverse an array.
using System;

namespace Array151
{
    class Program
    {
        static void Main()
        {
            int i, j;
            int[] nums1 = new int[10];
            int[] nums2 = new int[10];

            for (i = 0; i < nums1.Length; i++) nums1[i] = i;

            Console.Write("Original contents: ");
            for (i = 0; i < nums1.Length; i++)
                Console.Write(nums1[i] + " ");

            Console.WriteLine();

            // Reverse copy nums1 to nums2.
            if (nums2.Length >= nums1.Length) // Make sure nums2 is long enough
                for (i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j--)
                    nums2[j] = nums1[i];

            Console.Write("Reverse contents: ");
            for (i = 0; i < nums2.Length; i++)
                Console.Write(nums2[i] + " ");

            Console.WriteLine();
        }
    }
}
